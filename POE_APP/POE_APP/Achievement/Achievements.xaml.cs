using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace POE_APP
{
    /// <summary>
    /// Interaction logic for Achievements.xaml
    /// </summary>
    public partial class Achievements : Window
    {
        private readonly AchievementKind kind;
        //CONSTRUCTOR
        public Achievements(AchievementKind kind)
        {
            InitializeComponent();

            this.kind = kind;

            LstBooks.Items.Clear();
            int completedCount = 0;

            //POPULATE THE ACHIEVEMENTS LIST BOX
            foreach (var item in AchievementList.GetAchievementsList())
            {
                //IF THE KIND MATCHES THE CONTEXT, ADD IT TO THE LISTBOX
                if (kind.Equals(item.kind))
                {
                    LstBooks.Items.Add(AchievementItem.GenerateAchievementItem(item));
                    if (item.progress >= 100) completedCount++;
                }
            }

            //SMALL TEXT AT THE BOTTOM OF THE ACHIEVEMENTS SCREEN
            //INDICATES HOW MANY ACHIEVEMENTS HAVE BEEN COMPLETED
            TxtCompletedCount.Inlines.Add("You have completed ");
            TxtCompletedCount.Inlines.Add(new Run(completedCount.ToString())
            { FontSize = 24, Foreground = FindResource("PrimaryHueMidBrush") as Brush });
            TxtCompletedCount.Inlines.Add(" out of ");
            TxtCompletedCount.Inlines.Add(new Run(LstBooks.Items.Count.ToString())
            { FontSize = 24, Foreground = FindResource("PrimaryHueMidBrush") as Brush });
            TxtCompletedCount.Inlines.Add(" achievements");
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
            //CLOSES THE APPLICATION
            Application.Current.Shutdown();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            //MINIMIZES THE APPLICATION
            WindowState = WindowState.Minimized;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            //SHOW THE PREVIOUS WINDOW
            MiddleScreen middleScreen = new MiddleScreen(kind);
            middleScreen.Show();
            middleScreen.Left = Left;
            middleScreen.Top = Top;
            Close();
        }

        private void BtnStats_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void BtnAchievements_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }
    }
}
