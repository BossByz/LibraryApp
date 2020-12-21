using MaterialDesignThemes.Wpf;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace POE_APP
{

    /*
     * CODE ATTRIBUTION: https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
     * FOR RANDOMSTRING AND RANDOMNUMBER METHODS
     */

    //RANDOM CLASS
    internal class Generation
    {
        //FIELDS
        public static readonly Random random = new Random();

        //RANDOMSTRING METHOD (TO GENERATE 3 CHAR RANDOM STRING)
        public static string RandomString()
        {
            //STRING OF ALL CHARS THAT CAN BE USED
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            //RETURN A RANDOM 3 CHAR STRING
            return new string(Enumerable.Repeat(chars, 3)
              .Select(_ => _[random.Next(_.Length)]).ToArray());
        }

        //RANDOMNUMBER METHOD (TO GENERATE A 3 DIGIT RANDOM NUMBER)
        public static string RandomNumber()
        {
            //STRING OF ALL NUMBERS THAT CAN BE USED
            const string numbers = "0123456789";

            //RETURN A RANDOM 3 DIGIT NUMBER (STRING)
            return new string(Enumerable.Repeat(numbers, 3)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //GENERATEBOOKS METHOD (POPULATES THE LIST WITH RANDOM CALL NUMBERS)
        public static string GenerateBooks(string trickEntry)
        {
            //CREATE NEEDED COMPONENTS
            ListBoxItem listBoxItem = new ListBoxItem();
            Grid grid = new Grid();
            ColumnDefinition columnIcon = new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            };
            ColumnDefinition columnContent = new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            };
            grid.ColumnDefinitions.Add(columnIcon);
            grid.ColumnDefinitions.Add(columnContent);
            PackIcon packIcon = new PackIcon
            {
                Kind = PackIconKind.Book
            };
            listBoxItem.FontSize = 16;
            packIcon.Width = 32;
            packIcon.Height = 32;
            listBoxItem.SetValue(Grid.ColumnProperty, 1);

            //GENERATE A RANDOM CALL NUMBER USING THE RANDOMGEN CLASS
            string callNumber = RandomNumber() + "." +
                RandomNumber() + " " + RandomString();

            if (trickEntry == null)
            {
                //ADD THE CALL NUMBER TO THE LIST
                BookReplaceTest.books.Add(callNumber);
                listBoxItem.Content = callNumber;
            }
            else
            {
                BookReplaceTest.books.Add(trickEntry);
                listBoxItem.Content = trickEntry;
            }

            listBoxItem.IsEnabled = false;
            grid.Children.Add(packIcon);
            grid.Children.Add(listBoxItem);
            BookReplaceTest bookReplaceTest = BookReplaceTest.instance;
            bookReplaceTest.LstBooks.Items.Add(grid);
            return listBoxItem.Content.ToString();
        }
    }
}
