using Newtonsoft.Json;
using POE_APP.Util;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace POE_APP
{
    /// <summary>
    /// Interaction logic for AreaIdentificationTest.xaml
    /// </summary>
    public partial class FindCallNumbersTest : Window
    {
        //GLOBAL VARIABLES
        public readonly List<TreeNode<string>> correctAnswers = new List<TreeNode<string>>();
        public readonly List<Button> buttonList = new List<Button>();
        public readonly Tree<string> root = new Tree<string>();
        public List<string> possibleAnswers = new List<string>();
        public readonly Brush color = null;
        public int mark = 0;
        public int level = 0;

        public FindCallNumbersTest()
        {
            InitializeComponent();

            //GET JSON FILE PATH
            string path = Directory.GetParent(
                Directory.GetCurrentDirectory()).Parent.Parent.FullName
                + @"\POE_APP\Resources\CallNumbers.json";

            //VARIABLES FOR THE TREE LEVELS
            TreeNode<string> lastLevelOne = new TreeNode<string>() { Value = "" };
            TreeNode<string> lastLevelTwo = new TreeNode<string>() { Value = "" };

            //ADD THE OPTIONS BUTTONS TO A LIST
            buttonList.AddRange(new Button[] { BtnOptionA, BtnOptionB, BtnOptionC, BtnOptionD });

            //STORE THE CURRENT THEME PRIMARY COLOR
            color = buttonList[0].Background;

            /*
             * CODE ATTRIBUTION https://www.newtonsoft.com/json/help/html/ReadingWritingJSON.htm
             */

            //IF THE FILE EXISTS, READ FROM IT
            if (File.Exists(path))
            {
                JsonTextReader reader = new JsonTextReader(new StringReader(File.ReadAllText(path)));

                while (reader.Read())
                {
                    if (reader.Value != null)
                    {
                        //PROPERTYNAME = LEVEL 1 OR LEVEL 2 (IN JSON)
                        if (reader.TokenType == JsonToken.PropertyName)
                        {
                            //IF LEVEL 1
                            if (reader.Value.ToString().Substring(1, 2).Equals("00"))
                            {
                                if (reader.Value.ToString().Equals(lastLevelOne.Value.ToString()))
                                {
                                    lastLevelTwo = lastLevelOne.AddNode(lastLevelOne, reader.Value.ToString());
                                }
                                else
                                {
                                    lastLevelOne = root.AddNode(reader.Value.ToString());
                                }
                            }
                            //ELSE LEVEL 2
                            else if (reader.Value.ToString().Substring(2, 1).Equals("0"))
                            {
                                lastLevelTwo = lastLevelOne.AddNode(lastLevelOne, reader.Value.ToString());
                            }
                        }
                        //ELSE LEVEL 3
                        else if (reader.TokenType == JsonToken.String)
                        {
                            lastLevelTwo.AddNode(lastLevelTwo, reader.Value.ToString());
                        }
                    }
                }
            }
            else
            {
                //FILE NOT FOUND, RETURN TO MIDDLE-SCREEN
                MiddleScreen middleScreen = new MiddleScreen(AchievementKind.FindingCallNumbers);
                middleScreen.Show();
                Close();
            }

            //RANDOM VARIABLES TO GENERATE A QUESTION
            int randomLevelOne = Generation.random.Next(0, root.Nodes.Count);
            int randomLevelTwo = Generation.random.Next(0, root.Nodes[randomLevelOne].Children.Count);
            int randomLevelThree = Generation.random.Next(0, root.Nodes[randomLevelOne].Children[randomLevelTwo].Children.Count);

            //GENERATE THE QUESTION OFF A RANDOM SELECTION
            TreeNode<string> question = root.Nodes[randomLevelOne].Children[randomLevelTwo].Children[randomLevelThree];

            //ADD THE CORRECT ANSWERS BASED OFF THE SELECTION
            correctAnswers.AddRange(new TreeNode<string>[] { question.Parent.Parent, question.Parent, question });

            //SET THE QUESTION TEXT
            TxtQuestion.Text = question.Value.Substring(4);

            //POPULATE THE POSSIBLE ANSWERS
            MCQTestManager.NextQuestion(this);
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

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            //GO BACK TO PREVIOUS WINDOW
            MiddleScreen middleScreen = new MiddleScreen(AchievementKind.FindingCallNumbers);
            middleScreen.Show();
            Close();
        }

        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            //GO BACK TO PREVIOUS WINDOW
            ResultDialog.IsOpen = false;
            MiddleScreen middleScreen = new MiddleScreen(AchievementKind.FindingCallNumbers);
            middleScreen.Show();
            Close();
        }

        private void BtnAchievements_Click(object sender, RoutedEventArgs e)
        {
            //GO TO THE ACHIEVEMENTS PAGE
            Achievements achievements = new Achievements(AchievementKind.FindingCallNumbers);
            achievements.Show();
            Close();
        }

        private void BtnOptions_Click(object sender, RoutedEventArgs e)
        {
            //GET THE CLICKED BUTTON (SHARED BUTTON CLICK EVENT)
            Button option = sender as Button;

            //IF IT IS THE LAST LEVEL
            if (level == 2)
            {
                //SET THE OPTIONS TO ONLY THE CALL NUMBERS
                if (option.Content.Equals(correctAnswers[level].Value.Substring(0, 3)))
                {
                    option.Background = Brushes.Green;
                    mark++;
                }
                else
                {
                    option.Background = Brushes.Red;
                }

                //FINISH THE TEST
                MCQTestManager.FinishTest(this);
            }
            else
            {
                //IF THE ANSWER IS CORRECT
                if (option.Content.Equals(correctAnswers[level].Value))
                {
                    option.Background = Brushes.Green;
                    mark++;
                    level++;

                    //DISABLE THE BUTTONS CLICK EVENT
                    buttonList.ForEach(_ => _.IsHitTestVisible = false);

                    //WAIT 1 SECOND THEN DISPLAY THE NEXT QUESTION
                    Task.Delay(1000).ContinueWith(_ => { Dispatcher.Invoke(() => MCQTestManager.NextQuestion(this)); });
                }
                else
                {
                    option.Background = Brushes.Red;
                    MCQTestManager.FinishTest(this);
                }
            }
        }

        private void BtnStartNew_Click(object sender, RoutedEventArgs e)
        {
            //CREATE A NEW FINDING CALL NUMBERS TEST
            ResultDialog.IsOpen = false;
            FindCallNumbersTest findCallNumbersTest = new FindCallNumbersTest();
            findCallNumbersTest.Show();
            Close();
        }
    }
}
