using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace POE_APP
{
    internal class MatchItem
    {
        //GLOBAL VARIABLES
        public static string[] letters = { "A", "B", "C", "D", "E", "F", "G" };
        public static List<string> MatchItems = new List<string>();

        //GENERATE A MATCHING COLOUMN ITEM
        public static ListBoxItem GenerateMatchItem(string text)
        {
            ListBoxItem listBoxItem = new ListBoxItem();
            Grid grid = new Grid();
            ColumnDefinition columnAnswer = new ColumnDefinition();
            columnAnswer.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition columnQuestion = new ColumnDefinition();
            columnQuestion.Width = new GridLength(1, GridUnitType.Star);
            grid.ColumnDefinitions.Add(columnAnswer);
            grid.ColumnDefinitions.Add(columnQuestion);

            TextBlock question = new TextBlock();

            ComboBox possibleAnswers = new ComboBox();
            possibleAnswers.Margin = new Thickness(8);
            question.Margin = new Thickness(8);

            foreach (var item in letters)
            {
                possibleAnswers.Items.Add(item);
            }
            possibleAnswers.SelectedIndex = 0;

            question.HorizontalAlignment = HorizontalAlignment.Left;
            possibleAnswers.HorizontalAlignment = HorizontalAlignment.Center;
            question.VerticalAlignment = VerticalAlignment.Center;

            possibleAnswers.SetValue(Grid.ColumnProperty, 0);
            question.SetValue(Grid.ColumnProperty, 1);

            question.Text = text;
            grid.Children.Add(possibleAnswers);
            grid.Children.Add(question);
            grid.ShowGridLines = false;

            listBoxItem.Content = grid;
            return listBoxItem;
        }
    }
}
