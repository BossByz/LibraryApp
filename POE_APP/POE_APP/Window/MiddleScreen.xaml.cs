using System;
using System.Windows;
using System.Windows.Input;
namespace POE_APP
{
    /// <summary>
    /// Interaction logic for AreaIdentification.xaml
    /// </summary>
    public partial class MiddleScreen : Window
    {
        private readonly TutorialLinkedList tutorialLinkedList = new TutorialLinkedList();
        private readonly AchievementKind kind;
        public MiddleScreen(AchievementKind kind)
        {
            InitializeComponent();

            this.kind = kind;

            //SEND THE BINDING VARIABLES TO THE USER INSTANCE
            DataContext = User.GetInstance();

            if (kind == AchievementKind.AreaIdentification)
            {
                //ADD THE FOLLOWING TO THE TUTORIAL LINKEDLIST
                tutorialLinkedList.Add("Welcome to IDENTIFYING AREAS!");
                tutorialLinkedList.Add("In this task, you will have to match the coloumns!");
                tutorialLinkedList.Add("You will either need to match CALL NUMBERS to DESCRIPTION\nor DESCRIPTION to CALL NUMBERS");

                string node = "The following is all CALL NUMBERS and their matching DESCRIPTIONS.\nLearn them well.\n\n";

                foreach (var item in AreaIdentificationTest.dictionary)
                {
                    node += item.Key + " => " + item.Value + "\n";
                }

                tutorialLinkedList.Add(node);
                tutorialLinkedList.Add("Simply select the correct corresponding answer from each dropdown");
                tutorialLinkedList.Add("There are achievements you can earn by doing well in tests");
                tutorialLinkedList.Add("Good luck!");
            }
            else if (kind == AchievementKind.BookReplace)
            {
                //ADD THE FOLLOWING TO THE TUTORIAL LINKEDLIST
                tutorialLinkedList.Add("Welcome to REPLACING BOOKS!");
                tutorialLinkedList.Add("In this task, you will have to reorder books in a list\nby CALL NUMBER");
                tutorialLinkedList.Add("CALL NUMBERS are ordered firstly by number, then by letter");
                tutorialLinkedList.Add("Ordering CALL NUMBERS in this way is called the\nDewey Decimal Classification system");
                tutorialLinkedList.Add("Simply drag and drop the items in the list to reorder them");
                tutorialLinkedList.Add("There are achievements you can earn by doing well in tests");
                tutorialLinkedList.Add("Good luck!");
            }
            else
            {
                //ADD THE FOLLOWING TO THE TUTORIAL LINKEDLIST
                tutorialLinkedList.Add("Welcome to FINDING CALL NUMBERS!");
                tutorialLinkedList.Add("In this task, you will have to choose the right answer");
                tutorialLinkedList.Add("A third level CALL NUMBER will be displayed, along with 4 possible level one answers");
                tutorialLinkedList.Add("You must pick the correct level that the question belongs to");
                tutorialLinkedList.Add("This will be repeated until you have to pick the CALL NUMBER for the question itself");
                tutorialLinkedList.Add("Getting a wrong answer anywhere along the way will automatically end the test");
                tutorialLinkedList.Add("There are achievements you can earn by doing well in tests");
                tutorialLinkedList.Add("Good luck!");
            }

            //IF THE USER HAS SHOW TUTORIALS CHECKED
            if (User.ShowTutorials)
            {
                //SHOW THE TUTORIAL DIALOG
                tutorialLinkedList.Current = tutorialLinkedList.Head;
                TutorialDialog.IsOpen = true;
                TxtTutorial.Text = tutorialLinkedList.Current.Data;
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

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            //RESET THE TUTORIAL AND OPEN THE DIALOG
            tutorialLinkedList.Current = tutorialLinkedList.Head;
            BtnNext.Content = "NEXT";
            BtnPrevious.IsEnabled = false;
            TutorialDialog.IsOpen = true;
            TxtTutorial.Text = tutorialLinkedList.Head.Data;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            //SHOW THE MAIN MENU
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.Top = Top;
            mainWindow.Left = Left;
            Close();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            //SHOW THE CONFIRM START TEST DIALOG
            StartTestDialog.IsOpen = true;
        }

        private void BtnAchievements_Click(object sender, RoutedEventArgs e)
        {
            //SHOW THE ACHIEVENENTS PAGE
            Achievements achievements = new Achievements(kind);
            achievements.Show();
            achievements.Top = Top;
            achievements.Left = Left;
            Hide();
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            //GO TO THE PREVIOUS NODE
            TutorialNavigation.Previous(tutorialLinkedList, BtnPrevious,
                BtnNext, TxtTutorial);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            //GO TO THE NEXT NODE
            TutorialNavigation.Next(tutorialLinkedList, BtnPrevious,
                BtnNext, TxtTutorial, TutorialDialog);
        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {
            //START A NEW AREA IDENTIFICATION TEST
            if (kind == AchievementKind.BookReplace)
            {
                BookReplaceTest bookReplaceTest =
                    new BookReplaceTest();
                bookReplaceTest.Show();
            }
            else if (kind == AchievementKind.AreaIdentification)
            {
                AreaIdentificationTest areaIdentificationTest =
                    new AreaIdentificationTest();
                areaIdentificationTest.Show();
                areaIdentificationTest.Top = Top;
                areaIdentificationTest.Top = Top;
            }
            else
            {
                FindCallNumbersTest findCallNumbersTest =
                    new FindCallNumbersTest();
                findCallNumbersTest.Show();
                findCallNumbersTest.Top = Top;
                findCallNumbersTest.Left = Left;
            }
            Close();
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {
            //CLOSE THE DIALOG
            StartTestDialog.IsOpen = false;
        }
    }
}
