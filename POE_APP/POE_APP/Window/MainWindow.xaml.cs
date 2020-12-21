using MaterialDesignColors;
using POE_APP.Properties;
using System;
using System.Windows;
using System.Windows.Input;

namespace POE_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //CONSTRUCTOR
        public MainWindow()
        {
            InitializeComponent();
            //BIND THE VARIABLES TO THE USER INSTANCE
            DataContext = User.GetInstance();

            //GET A LIST OF THE SWATCHES
            var swatchList = new SwatchesProvider().Swatches;

            //ADD EACH SWATCH TO THE COLOUR COMBOBOX
            foreach (var item in swatchList)
            {
                CmbColour.Items.Add(item.Name.ToUpper());
            }

            //SHOW THE STARTUP DIALOG IF THE APP HAS BEEN LAUNCHED FOR THE FIRST TIME
            //OR SETTINGS HAVE BEEN RESET
            if (Settings.Default.startUpDialog)
            {
                StartUpDialog.IsOpen = true;
                Settings.Default.startUpDialog = false;
                Settings.Default.Save();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            //CLOSE THE APPLICATION
            Application.Current.Shutdown();
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

        public void ShowMiddleScreen(AchievementKind kind)
        {
            //SHOW THE MIDDLE SCREEN AND ALIGN IT
            MiddleScreen middleScreen = new MiddleScreen(kind);
            middleScreen.Show();
            middleScreen.Top = Top;
            middleScreen.Left = Left;
            Close();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            //MINIMIZES THE WINDOW
            WindowState = WindowState.Minimized;
        }
        private void BtnBookReplace_Click(object sender, RoutedEventArgs e)
        {
            //CALL THE MIDDLE SCREEN METHOD
            ShowMiddleScreen(AchievementKind.BookReplace);
        }

        private void BtnResetAchievements_Click(object sender, RoutedEventArgs e)
        {
            //REMOVE THE CURRENT INSTANCE
            User.Instance = null;

            //SET THE HIGHESTSCORE AND LOWEST TIME TO 0 AND SAVE
            Settings.Default.highestScore = 0;
            Settings.Default.lowestTime = 0;
            Settings.Default.replaceBooksCorrectCount = 0;
            Settings.Default.identifyingAreasCorrectCount = 0;
            Settings.Default.findingCallNumbersPerfectScoreCount = 0;
            Settings.Default.findingCallNumbersCorrectCount = 0;
            Settings.Default.Save();

            //REFETCH THE INSTANCE FOR VARIABLE BINDING
            DataContext = User.GetInstance();
        }

        private void BtnResetAll_Click(object sender, RoutedEventArgs e)
        {
            //REMOVE THE CURRENT INSTANCE
            User.Instance = null;

            //RESET AND SAVE THE SETTINGS
            Settings.Default.Reset();
            Settings.Default.Save();

            //REFETCH THE INSTANCE FOR VARIABLE BINDING
            DataContext = User.GetInstance();
        }

        private void BtnIdentifyingAreas_Click(object sender, RoutedEventArgs e)
        {
            //CALL THE MIDDLE SCREEN METHOD
            ShowMiddleScreen(AchievementKind.AreaIdentification);
        }

        private void BtnCallNumbers_Click(object sender, RoutedEventArgs e)
        {
            //CALL THE MIDDLE SCREEN METHOD
            ShowMiddleScreen(AchievementKind.FindingCallNumbers);
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            //CLOSE THE COMING SOON DIALOG
            ComingSoonDialog.IsOpen = false;
        }

        private void BtnOkStartup_Click(object sender, RoutedEventArgs e)
        {
            //CLOSE THE STARTUP DIALOG
            StartUpDialog.IsOpen = false;
        }
    }
}
