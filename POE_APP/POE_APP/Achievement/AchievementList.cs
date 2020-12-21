using MaterialDesignThemes.Wpf;
using System.Collections.Generic;

namespace POE_APP
{
    internal class AchievementList
    {
        //ACHIEVEMENT LIST
        public static List<AchievementItem> achievementItems = new List<AchievementItem>();

        public static List<AchievementItem> GetAchievementsList()
        {
            //CLEAR THE ACHIEVEMENT LIST
            achievementItems.Clear();

            //REPLACING BOOKS ACHIEVEMENTS

            new AchievementItem()
            {
                title = "Snail's Pace",
                description = "Achieve a low time of 30 seconds or less",
                difficulty = 1,
                icon = PackIconKind.Bug,
                progress = double.IsInfinity(30 / User.LowestTime) == true
                    ? 0 : ((30 / User.LowestTime) * 100),
                kind = AchievementKind.BookReplace
            };

            new AchievementItem()
            {
                title = "Casual Reader",
                description = "Achieve a high score of at least 3 correct answers",
                difficulty = 1,
                icon = PackIconKind.Book,
                progress = double.IsInfinity(User.HighestScore / 3.0) == true
                    ? 0 : ((User.HighestScore / 3.0) * 100),
                kind = AchievementKind.BookReplace
            };

            new AchievementItem()
            {
                title = "Tortoise",
                description = "Achieve a low time of 20 seconds or less",
                difficulty = 2,
                icon = PackIconKind.Tortoise,
                progress = double.IsInfinity(20 / User.LowestTime) == true
                    ? 0 : ((20 / User.LowestTime) * 100),
                kind = AchievementKind.BookReplace
            };

            new AchievementItem()
            {
                title = "Book Worm",
                description = "Achieve a total of 15 correct answers or more",
                difficulty = 2,
                icon = PackIconKind.Insect,
                progress = double.IsInfinity(User.ReplaceBooksCorrectCount / 15.0) == true
                    ? 0 : ((User.ReplaceBooksCorrectCount / 15.0) * 100),
                kind = AchievementKind.BookReplace
            };

            new AchievementItem()
            {
                title = "Page Turner",
                description = "Achieve a high score of at least 6 correct answers",
                difficulty = 3,
                icon = PackIconKind.BookOpen,
                progress = double.IsInfinity(User.HighestScore / 6.0) == true
                    ? 0 : ((User.HighestScore / 6.0) * 100),
                kind = AchievementKind.BookReplace
            };

            new AchievementItem()
            {
                title = "Speed Reader",
                description = "Achieve a low time of 12 seconds or less",
                difficulty = 3,
                icon = PackIconKind.Speedometer,
                progress = double.IsInfinity(12 / User.LowestTime) == true
                    ? 0 : ((12 / User.LowestTime) * 100),
                kind = AchievementKind.BookReplace
            };

            new AchievementItem()
            {
                title = "Scholar",
                description = "Achieve a total of 45 correct answers or more",
                difficulty = 4,
                icon = PackIconKind.Lecture,
                progress = double.IsInfinity(User.ReplaceBooksCorrectCount / 45.0) == true
                    ? 0 : ((User.ReplaceBooksCorrectCount / 45.0) * 100),
                kind = AchievementKind.BookReplace
            };

            new AchievementItem()
            {
                title = "Literature King",
                description = "Achieve a low time of 10 seconds or less\n" +
                                "Achieve a total of 60 correct answers or more\n" +
                                "Achieve a high score of at least 10 correct answers",
                difficulty = 5,
                icon = PackIconKind.Crown,
                progress = (((double.IsInfinity(User.HighestScore / 10.0) == true ? 0
                    : (User.HighestScore / 10.0 * 100)) / 4.0) > 25 ? 25
                    : ((double.IsInfinity(User.HighestScore / 10.0) == true ? 0
                    : (User.HighestScore / 10.0 * 100)) / 4.0))
                    + (((double.IsInfinity(7 / User.LowestTime) == true ? 0
                    : (7 / User.LowestTime * 100)) / 4.0) > 25 ? 25
                    : ((double.IsInfinity(7 / User.LowestTime) == true ? 0
                    : (7 / User.LowestTime * 100)) / 4.0))
                    + (((double.IsInfinity(User.ReplaceBooksCorrectCount / 60.0) == true ? 0
                    : (User.ReplaceBooksCorrectCount / 60.0 * 100)) / 2.0) > 50 ? 50
                    : ((double.IsInfinity(User.ReplaceBooksCorrectCount / 60.0) == true ? 0
                    : (User.ReplaceBooksCorrectCount / 60.0 * 100)) / 2.0)),
                kind = AchievementKind.BookReplace
            };

            //IDENTIFYING AREAS ACHIEVEMENTS

            new AchievementItem()
            {
                title = "Beginner",
                description = "Achieve a total of 20 correct answers or more",
                difficulty = 1,
                icon = PackIconKind.HumanChild,
                progress = double.IsInfinity(User.IdentifyingAreasCorrectCount / 20.0) == true
                    ? 0 : ((User.IdentifyingAreasCorrectCount / 20.0) * 100),
                kind = AchievementKind.AreaIdentification
            };

            new AchievementItem()
            {
                title = "Intermediate",
                description = "Achieve a total of 40 correct answers or more",
                difficulty = 2,
                icon = PackIconKind.MathCompass,
                progress = double.IsInfinity(User.IdentifyingAreasCorrectCount / 40.0) == true
                    ? 0 : ((User.IdentifyingAreasCorrectCount / 40.0) * 100),
                kind = AchievementKind.AreaIdentification
            };

            new AchievementItem()
            {
                title = "Professional",
                description = "Achieve a total of 60 correct answers or more",
                difficulty = 3,
                icon = PackIconKind.Lecture,
                progress = double.IsInfinity(User.IdentifyingAreasCorrectCount / 60.0) == true
                    ? 0 : ((User.IdentifyingAreasCorrectCount / 60.0) * 100),
                kind = AchievementKind.AreaIdentification
            };

            new AchievementItem()
            {
                title = "Expert",
                description = "Achieve a total of 100 correct answers or more",
                difficulty = 5,
                icon = PackIconKind.Star,
                progress = double.IsInfinity(User.IdentifyingAreasCorrectCount / 100.0) == true
                    ? 0 : ((User.IdentifyingAreasCorrectCount / 100.0) * 100),
                kind = AchievementKind.AreaIdentification
            };

            //FINDINGCALLNUMBERS ACHIEVEMENTS

            new AchievementItem()
            {
                title = "Beginner",
                description = "Achieve a total of 8 correct answers or more",
                difficulty = 1,
                icon = PackIconKind.HumanChild,
                progress = double.IsInfinity(User.FindingCallNumbersCorrectCount / 8.0) == true
                    ? 0 : ((User.FindingCallNumbersCorrectCount / 8.0) * 100),
                kind = AchievementKind.FindingCallNumbers
            };

            new AchievementItem()
            {
                title = "Intermediate",
                description = "Achieve a total of 3 perfect scores or more",
                difficulty = 2,
                icon = PackIconKind.MathCompass,
                progress = double.IsInfinity(User.FindingCallNumbersPerfectScoreCount / 3.0) == true
                    ? 0 : ((User.FindingCallNumbersPerfectScoreCount / 3.0) * 100),
                kind = AchievementKind.FindingCallNumbers
            };

            new AchievementItem()
            {
                title = "Professional",
                description = "Achieve a total of 16 correct answers or more",
                difficulty = 3,
                icon = PackIconKind.Lecture,
                progress = double.IsInfinity(User.FindingCallNumbersCorrectCount / 16.0) == true
                    ? 0 : ((User.FindingCallNumbersCorrectCount / 16.0) * 100),
                kind = AchievementKind.FindingCallNumbers
            };

            new AchievementItem()
            {
                title = "Expert",
                description = "Achieve a total of 8 perfect scores or more",
                difficulty = 4,
                icon = PackIconKind.Star,
                progress = double.IsInfinity(User.FindingCallNumbersPerfectScoreCount / 8.0) == true
                    ? 0 : ((User.FindingCallNumbersPerfectScoreCount / 8.0) * 100),
                kind = AchievementKind.FindingCallNumbers
            };

            new AchievementItem()
            {
                title = "Master",
                description = "Achieve a total of 15 perfect scores or more",
                difficulty = 5,
                icon = PackIconKind.Crown,
                progress = double.IsInfinity(User.FindingCallNumbersPerfectScoreCount / 15.0) == true
                    ? 0 : ((User.FindingCallNumbersPerfectScoreCount / 15.0) * 100),
                kind = AchievementKind.FindingCallNumbers
            };

            return achievementItems;
        }
    }
}
