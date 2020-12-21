using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace POE_APP
{
    internal class AchievementItem
    {
        //FIELDS
        public string title;
        public string description;
        public PackIconKind icon;
        public double progress;
        public int difficulty;
        public AchievementKind kind;

        public AchievementItem()
        {
            //ADD THE NEWLY CREATED ACHIEVEMENT TO THE ACHIEVEMENTS LIST
            AchievementList.achievementItems.Add(this);
        }

        public static ListBoxItem GenerateAchievementItem(AchievementItem item)
        {
            //CREATE THE NEEDED CONTROLS DYNAMICALLY AND ADD TO THE UI
            Grid grid = new Grid();

            ColumnDefinition columnIcon = new ColumnDefinition();
            columnIcon.Width = new GridLength(100, GridUnitType.Pixel);
            ColumnDefinition columnContent = new ColumnDefinition();
            columnContent.Width = new GridLength(450, GridUnitType.Pixel);
            ColumnDefinition columnTest = new ColumnDefinition();
            columnTest.Width = new GridLength(200, GridUnitType.Pixel);

            RowDefinition row1 = new RowDefinition();
            row1.Height = new GridLength(40, GridUnitType.Pixel);
            RowDefinition row2 = new RowDefinition();
            row2.Height = new GridLength(60, GridUnitType.Pixel);
            RowDefinition row3 = new RowDefinition();
            row3.Height = new GridLength(40, GridUnitType.Pixel);
            grid.ColumnDefinitions.Add(columnIcon);
            grid.ColumnDefinitions.Add(columnContent);
            grid.ColumnDefinitions.Add(columnTest);
            grid.RowDefinitions.Add(row1);
            grid.RowDefinitions.Add(row2);
            grid.RowDefinitions.Add(row3);

            //grid.ShowGridLines = true;

            ProgressBar progress = new ProgressBar();
            progress.SetValue(Grid.ColumnProperty, 1);
            progress.SetValue(Grid.RowProperty, 2);
            progress.SetValue(Grid.ColumnSpanProperty, 2);
            progress.Value = item.progress;
            progress.Margin = new Thickness(8);
            grid.Children.Add(progress);

            Button button = new Button();
            PackIcon packIcon = new PackIcon();
            button.Content = packIcon;
            packIcon.Kind = item.progress >= 100 ? PackIconKind.Tick : item.icon;
            button.Width = 96;
            button.Height = 96;
            packIcon.Width = 48;
            packIcon.Height = 48;
            packIcon.SetValue(Grid.RowProperty, 0);
            packIcon.SetValue(Grid.ColumnProperty, 0);
            packIcon.SetValue(Grid.RowSpanProperty, 3);
            button.SetValue(Grid.RowSpanProperty, 3);
            grid.Children.Add(button);

            TextBlock title = new TextBlock();
            title.SetValue(Grid.ColumnProperty, 1);
            title.HorizontalAlignment = HorizontalAlignment.Center;
            title.VerticalAlignment = VerticalAlignment.Center;
            title.FontSize = 20;
            title.FontStyle = FontStyles.Italic;
            title.FontWeight = FontWeights.Bold;
            title.Text = item.title;
            grid.Children.Add(title);

            TextBlock description = new TextBlock();
            description.SetValue(Grid.ColumnProperty, 1);
            description.SetValue(Grid.RowProperty, 1);
            description.HorizontalAlignment = HorizontalAlignment.Center;
            description.VerticalAlignment = VerticalAlignment.Center;
            description.Text = item.description;
            description.TextAlignment = TextAlignment.Center;
            grid.Children.Add(description);

            TextBlock difficulty = new TextBlock();
            difficulty.SetValue(Grid.ColumnProperty, 2);
            difficulty.Text = "Difficulty";
            difficulty.FontWeight = FontWeights.Bold;
            difficulty.HorizontalAlignment = HorizontalAlignment.Center;
            difficulty.VerticalAlignment = VerticalAlignment.Center;
            difficulty.FontStyle = FontStyles.Italic;
            grid.Children.Add(difficulty);

            RatingBar rating = new RatingBar();
            rating.SetValue(Grid.ColumnProperty, 2);
            rating.SetValue(Grid.RowProperty, 1);
            rating.Value = item.difficulty;
            rating.HorizontalAlignment = HorizontalAlignment.Center;
            rating.IsEnabled = false;
            rating.Opacity = 1;
            grid.Children.Add(rating);

            ListBoxItem listBoxItem = new ListBoxItem();
            listBoxItem.Content = grid;

            return listBoxItem;
        }
    }
}
