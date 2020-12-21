using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace POE_APP
{
    /// <summary>
    /// Interaction logic for AreaIdentificationTest.xaml
    /// </summary>
    public partial class AreaIdentificationTest : Window
    {
        //GLOBAL VARIABLES
        private static readonly Random random = new Random();
        private readonly List<string> possibleAnswers = new List<string>();
        private readonly bool switched;

        //DICTIONARY CONTAINING NEEDED DATA
        public static Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "000", "General Knowledge" },
            { "100", "Philosophy & Psychology" },
            { "200", "Religion" },
            { "300", "Social Sciences" },
            { "400", "Languages" },
            { "500", "Science" },
            { "600", "Technology" },
            { "700", "Arts & Recreation" },
            { "800", "Literature" },
            { "900", "History & Geography" }
        };

        public AreaIdentificationTest()
        {
            InitializeComponent();

            MatchItem.MatchItems.Clear();

            int rng = random.Next(1, 3);

            //RANDOMIZE THE ORDER OF THE COLOUMNS
            switched = rng != 1;

            //ADD 4 UNIQUE ITEMS TO THE LEFT COLOUMN
            while (LstColumnLeft.Items.Count != 4)
            {
                int rand = random.Next(0, 10);

                string item = switched ?
                    dictionary.ElementAt(rand).Value :
                    dictionary.ElementAt(rand).Key;

                var listBoxItem = MatchItem.GenerateMatchItem(item);

                if (!MatchItem.MatchItems.Contains(item))
                {
                    LstColumnLeft.Items.Add(listBoxItem);
                    MatchItem.MatchItems.Add(item);
                }
            }

            //ADD THE CORRECT ANSWERS TO THE RANDOMLY ADDED QUESTIONS
            foreach (var item in MatchItem.MatchItems)
            {
                string correctAnswer = switched ?
                    dictionary.Where(_ => _.Value.Equals(item)).First().Key :
                    dictionary.Where(_ => _.Key.Equals(item)).First().Value;

                possibleAnswers.Add(correctAnswer);
            }

            //ADD 3 RANDOM WRONG ANSWERS
            while (possibleAnswers.Count != 7)
            {
                int rand = random.Next(0, 10);

                string item = switched ?
                dictionary.ElementAt(rand).Key :
                dictionary.ElementAt(rand).Value;

                if (!possibleAnswers.Contains(item))
                    possibleAnswers.Add(item);
            }

            //SHUFFLE THE ORDER OF THE POSSIBLE ANSWERS
            Utils.Shuffle(possibleAnswers);

            //ADD THE SHUFFLED POSSIBLE ANSWERS TO THE LISTBOX
            for (int i = 0; i < possibleAnswers.Count; i++)
            {
                LstColumnRight.Items.Add(MatchItem.letters[i] + ". " + possibleAnswers[i]);
            }
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
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
            //MINIMIZE THE APPLICATION
            WindowState = WindowState.Minimized;
        }

        private void BtnHandIn_Click(object sender, RoutedEventArgs e)
        {
            int mark = 0;
            ResultDialog.IsOpen = true;
            txtResultDialogUser.Inlines.Add("Questions\n\n");
            txtResultCorrect.Inlines.Add("Correct Answers\n\n");

            //CHECK EACH SUBMITTED ANSWER AND ADD A MARK IF IT IS CORRECT
            foreach (var item in LstColumnLeft.Items)
            {
                Grid grid = (item as ListBoxItem).Content as Grid;
                ComboBox selectedAnswer = grid.Children[0] as ComboBox;
                string question = (grid.Children[1] as TextBlock).Text;
                string userAnswer = LstColumnRight.Items[selectedAnswer.SelectedIndex].ToString().Split('.')[1].Trim();
                string correctAnswer = switched ? dictionary.Where(_ => _.Value.Equals(question)).First().Key :
                    dictionary.Where(_ => _.Key.Equals(question)).First().Value;

                txtResultDialogUser.Inlines.Add(new Run(question + "\n"));

                if (userAnswer.Equals(correctAnswer))
                {
                    mark++;
                    txtResultCorrect.Inlines.Add(new Run(correctAnswer + "\n") { Foreground = Brushes.Green });
                }
                else
                {
                    txtResultCorrect.Inlines.Add(new Run(correctAnswer + "\n") { Foreground = Brushes.Red });
                }
            }

            //SAVE THE USERS CORRECT ANSWER COUNT
            User.IdentifyingAreasCorrectCount += mark;
            txtResultScore.Inlines.Add("You have scored " + mark + " out of 4");
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            //GO BACK TO PREVIOUS WINDOW
            MiddleScreen areaIdentification = new MiddleScreen(AchievementKind.AreaIdentification);
            areaIdentification.Show();
            Close();
        }

        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            ResultDialog.IsOpen = false;
            MiddleScreen areaIdentification = new MiddleScreen(AchievementKind.AreaIdentification);
            areaIdentification.Show();
            Close();
        }

        private void BtnAchievements_Click(object sender, RoutedEventArgs e)
        {
            Achievements achievements = new Achievements(AchievementKind.AreaIdentification);
            achievements.Show();
            Close();
        }
    }
}
