using GongSolutions.Wpf.DragDrop;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;

namespace POE_APP
{
    /// <summary>
    /// Interaction logic for BookReplaceTest.xaml
    /// </summary>
    public partial class BookReplaceTest : Window
    {
        //FIELDS
        public static List<string> books = new List<string>();
        readonly DispatcherTimer timer = new DispatcherTimer();
        readonly Stopwatch stopWatch = new Stopwatch();
        public static BookReplaceTest instance;

        //CONSTRUCTOR
        public BookReplaceTest()
        {
            InitializeComponent();

            books.Clear();
            instance = this;
            //GENERATE A RANDOM INDEX TO INSERT THE TRICK CALL NUMBER
            //(SAME NUMBER BUT DIFFERENT LETTERS)
            int generatedRandom = Generation.random.Next(1, 9);
            string item = null;

            //CALL THE GENERATEBOOKS METHOD 10 TIMES
            for (int i = 0; i < 10; i++)
            {
                //COPY THE PREVIOUS INDEX OF THE RANDOM INDEX
                if (i == generatedRandom - 1)
                {
                    item = Generation.GenerateBooks(null);
                }else if (i == generatedRandom)
                {
                    //COPY THE NUMBERS OF THE COPIED INDEX
                    string trickEntry = item.Split(' ')[0];
                    //GENERATE 3 RANDOM CHARACTERS TO ADD ONTO THE COPIED INDEX
                    trickEntry += " " + Generation.RandomString();
                    //INSERT THE TRICK ENTRY
                    Generation.GenerateBooks(trickEntry);
                }
                else
                {
                    Generation.GenerateBooks(null);
                }
            }

            //SORT THE BOOKS INTO THE CORRECT ORDER 
            //(BY NUMBER THEN BY LETTER) (IT WORKS, EVEN IF THE NUMBERS ARE THE SAME! :D)
            books.Sort();

            //START THE STOPWATCH TO TIME THE USER
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
            stopWatch.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //VARIABLE OF THE CURRENT ELAPSED TIME
            TimeSpan timeSpan = stopWatch.Elapsed;

            //REFRESH THE TIME TEXT
            TxtTime.Inlines.Clear();
            TxtTime.Inlines.Add(new Run(timeSpan.Seconds + "s ") { FontSize = 24,
                Foreground = FindResource("PrimaryHueMidBrush") as Brush});
            TxtTime.Inlines.Add(new Run(timeSpan.Milliseconds + "ms") { FontSize = 18 });
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //ALLOWS THE USER TO DRAG THE WINDOW AROUND
            //IF STATEMENT PREVENTS A CRASH
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            //CLOSE THE APPLICATION
            Application.Current.Shutdown();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            //MINIMIZES THE APPLICATION
            WindowState = WindowState.Minimized;
        }

        private void BtnHandIn_Click(object sender, RoutedEventArgs e)
        {
            //STOP THE STOPWATCH
            stopWatch.Stop();
            int index = 0;
            List<string> userOrder = new List<string>();

            //GET ALL THE VALUES FROM THE USERS SUBMITTED ORDER AND STORE THEM IN THE LIST ABOVE
            foreach (var item in LstBooks.Items)
            {
                Grid grid = LstBooks.Items[index] as Grid;
                index++;

                foreach (var listBoxItem in grid.Children)
                {
                    if (listBoxItem is ListBoxItem)
                    {
                        ListBoxItem currentListBoxItem = listBoxItem as ListBoxItem;
                        userOrder.Add(currentListBoxItem.Content.ToString());
                    }
                }
            }

            int mark = 0;
            txtResultDialogUser.Text = "";

            txtResultDialogUser.Inlines.Add("Submitted Order\n\n");
            txtResultCorrect.Inlines.Add("Correct Order\n\n");

            //CALCULATE HOW MANY MARKS THE USER SCORED
            for (int i = 0; i < books.Count; i++)
            {
                //ADD THE CORRECT ANSWER
                txtResultCorrect.Inlines.Add(new Run(books[i] + "\n")
                { Foreground = new SolidColorBrush(Colors.Green) });

                //CHECK IF THE USER'S ORDER EQUALS THE CORRECT ORDER
                if (userOrder[i].Equals(books[i]))
                {
                    //DISPLAY THE ANSWER IN GREEN
                    txtResultDialogUser.Inlines.Add(new Run(userOrder[i] + "\n")
                    { Foreground = new SolidColorBrush(Colors.Green) });
                    mark++;
                }else
                {
                    //DISPLAY THE ANSWER IN RED
                    txtResultDialogUser.Inlines.Add(new Run(userOrder[i] + "\n")
                    { Foreground = new SolidColorBrush(Colors.Red) });
                }
            }

            //CONVERT TIME
            double time = stopWatch.ElapsedMilliseconds / 1000.0;

            txtResultScore.Inlines.Add("You have scored " + mark + " out of 10\n" +
                "Your final time was " + stopWatch.Elapsed.Seconds + "s " 
                + stopWatch.Elapsed.Milliseconds + "ms");

            //IF THE USER SCORED 3 OR MORE ANSWERS CORRECT, 
            //TAKE THE TIME INTO CONSIDERATION (TO PREVENT ABUSE)
            if (mark >= 3)
            {
                User.LowestTime = time;
            }
            else
            {
                txtResultScore.Inlines.Add(new Run("\n*Time will not be counted as " +
                    "you scored less than 3/10") { Foreground = Brushes.Red });
            }

            //SET THE HIGHEST SCORE TO THE MARK 
            //(WILL ONLY BE SET IF THE SCORE IS GREATER AS DEFINED THE USER CLASS LOGIC)
            if (mark > 0)
            {
                User.HighestScore = mark;
            }

            //UPDATE THE TOTAL CORRECT ANSWERS
            User.ReplaceBooksCorrectCount += mark;

            //OPEN THE RESULT DIALOG
            ResultDialog.IsOpen = true;
        }

        private void BtnAchievements_Click(object sender, RoutedEventArgs e)
        {
            //SHOW THE ACHIEVEMENTS WINDOW
            Achievements achievements = new Achievements(AchievementKind.BookReplace);
            achievements.Show();
            Close();
        }

        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            //SHOW THE BOOKREPLACE WINDOW
            MiddleScreen middleScreen = new MiddleScreen(AchievementKind.BookReplace);
            middleScreen.Show();
            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            //SHOW THE BOOKREPLACE WINDOW
            MiddleScreen middleScreen = new MiddleScreen(AchievementKind.BookReplace);
            middleScreen.Show();
            Close();
        }
    }
}
