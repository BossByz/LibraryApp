namespace POE_APP
{
    internal class User
    {
        //FIELDS
        public static User Instance;
        private static double _lowestTime;
        private static int _highestScore;
        private static bool _isDark;
        private static bool _showTutorials;
        private static string _color;
        private static int _replaceBooksCorrectCount;
        private static int _identifyingAreasCorrectCount;
        private static int _findingCallNumbersPerfectScoreCount;
        private static int _findingCallNumbersCorrectCount;

        //SINGLETON
        public static User GetInstance()
        {
            if (Instance == null)
            {
                //IF THE INSTANCE DOES NOT EXIST, CREATE ONE
                Instance = new User();

                //SET THE PROPERTIES FROM THE STORED SETTINGS
                IsDark = Properties.Settings.Default.isDark;
                ShowTutorials = Properties.Settings.Default.showTutorial;
                LowestTime = Properties.Settings.Default.lowestTime;
                HighestScore = Properties.Settings.Default.highestScore;
                Color = Properties.Settings.Default.color;
                ReplaceBooksCorrectCount = Properties.Settings.Default.replaceBooksCorrectCount;
                IdentifyingAreasCorrectCount = Properties.Settings.Default.identifyingAreasCorrectCount;
                FindingCallNumbersCorrectCount = Properties.Settings.Default.findingCallNumbersCorrectCount;
                FindingCallNumbersPerfectScoreCount = Properties.Settings.Default.findingCallNumbersPerfectScoreCount;
            }
            return Instance;
        }

        //PROPERTIES

        //PERFECT SCORE COUNT PROPERTY (FOR FINDING CALL NUMBERS SECTION)
        public static int FindingCallNumbersPerfectScoreCount
        {
            get => _findingCallNumbersPerfectScoreCount;

            set
            {
                _findingCallNumbersPerfectScoreCount = value;
                Properties.Settings.Default.findingCallNumbersPerfectScoreCount = value;
                Properties.Settings.Default.Save();
            }
        }

        //CORRECT COUNT PROPERTY (FOR FINDING CALL NUMBERS SECTION)
        public static int FindingCallNumbersCorrectCount
        {
            get => _findingCallNumbersCorrectCount;

            set
            {
                _findingCallNumbersCorrectCount = value;
                Properties.Settings.Default.findingCallNumbersCorrectCount = value;
                Properties.Settings.Default.Save();
            }
        }

        //TOTAL CORRECT ANSWERS PROPERTY (FOR IDENTIFYING AREAS SECTION)
        public static int IdentifyingAreasCorrectCount
        {
            //GET THE TOTAL CORRECT ANSWERS VALUE
            get => _identifyingAreasCorrectCount;

            //SET THE TOTAL CORRECT ANSWERS VALUE
            set
            {
                _identifyingAreasCorrectCount = value;
                Properties.Settings.Default.identifyingAreasCorrectCount = value;
                Properties.Settings.Default.Save();
            }
        }

        //TOTAL CORRECT ANSWERS PROPERTY (FOR REPLACING BOOKS SECTION)
        public static int ReplaceBooksCorrectCount
        {
            //GET THE TOTAL CORRECT ANSWERS VALUE
            get => _replaceBooksCorrectCount;

            //SET THE TOTAL CORRECT ANSWERS VALUE
            set
            {
                _replaceBooksCorrectCount = value;
                Properties.Settings.Default.replaceBooksCorrectCount = value;
                Properties.Settings.Default.Save();
            }
        }

        //COLOR PROPERTY (PRIMARY COLOUR)
        public static string Color
        {
            //GET THE COLOR PROPERTY VALUE
            get => _color;

            //SET THE COLOR PROPERTY VALUE
            set
            {
                _color = value;
                //TOGGLE THE THEME
                Utils.TogglePrimaryColour(value);
                //SAVE THE SETTING
                Properties.Settings.Default.color = value;
                Properties.Settings.Default.Save();
            }
        }

        //ISDARK PROPERTY (LIGHT/DARK THEME)
        public static bool IsDark
        {
            get => _isDark;

            set
            {
                _isDark = value;
                Utils.ToggleBaseColour(_isDark);
                Properties.Settings.Default.isDark = value;
                Properties.Settings.Default.Save();
            }
        }

        //SHOWTUTORIALS PROPERTIES (TOGGLE VISIBILITY OF TUTORIALS)
        public static bool ShowTutorials
        {
            get => _showTutorials;

            set
            {
                _showTutorials = value;
                Properties.Settings.Default.showTutorial = value;
                Properties.Settings.Default.Save();
            }
        }

        //LOWESTTIME PROPERTY (STORES THE LOWEST TIME ACHIEVED IN ALL TESTS)
        public static double LowestTime
        {
            get => _lowestTime;

            set
            {
                //IF VALUS IS DEFAULT
                if (_lowestTime == 0)
                {
                    //SET THE LOW TIME TO THE FIRST TIME ACHIEVED
                    _lowestTime = value;
                    Properties.Settings.Default.lowestTime = value;
                    Properties.Settings.Default.Save();
                }
                //ELSE IF TIME IS LESS THAN THE CURRENT LOWEST TIME, SET THE VALUE
                else if (value < _lowestTime)
                {
                    _lowestTime = value;
                    Properties.Settings.Default.lowestTime = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        //HIGHESTSCORE PROPERTY (STORES THE HIGHEST SCORE ACHIEVED IN ALL TESTS)
        public static int HighestScore
        {
            get => _highestScore;

            set
            {
                //IF THE VALUE IS DEFAULT, SET THE SCORE
                if (value == 0)
                {
                    _highestScore = value;
                    Properties.Settings.Default.highestScore = value;
                    Properties.Settings.Default.Save();
                    //ELSE IF THE SCORE IS HIGHER THAN THE CURRENT HIGHEST SCORE, SET THE VALUE
                }
                else if (value > _highestScore)
                {
                    _highestScore = value;
                    Properties.Settings.Default.highestScore = value;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
