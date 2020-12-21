using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Linq;

namespace POE_APP
{
    //THEME CLASS
    class Utils
    {
        //FIELDS
        private static readonly PaletteHelper paletteHelper = new PaletteHelper();

        //TOGGLEBASECOLOUR METHOD (LIGHT/DARK THEME)
        public static void ToggleBaseColour(bool isDark)
        {
            //GET THE THEME
            ITheme theme = paletteHelper.GetTheme();

            //CREATE A BASE THEME BASED ON THE ISDARK PROPERTY
            IBaseTheme baseTheme = isDark ? new MaterialDesignDarkTheme() :
                (IBaseTheme)new MaterialDesignLightTheme();

            //SET THE BASE THEME (LIGHT/DARK)
            theme.SetBaseTheme(baseTheme);

            //UPDATE THE THEME (REALTIME)
            paletteHelper.SetTheme(theme);
        }

        //TOGGLEPRIMARYCOLOUR METHOD (PRIMARY COLOUR: RED, GREEN ETC)
        public static void TogglePrimaryColour(string color)
        {
            //UPDATE THE COLOR STRING TO LOWERCASE
            color = color.ToLower();

            //GET THE THEME
            ITheme theme = paletteHelper.GetTheme();

            //GET THE SWATCHES PROVIDER (FOR COLOURS)
            SwatchesProvider swatchesProvider = new SwatchesProvider();

            //CREATE A SWATCH WHERE THE SELECTED COLOR MATCHES THE COLOR IN THE LIST
            Swatch swatch = swatchesProvider.Swatches.Where(_ => _.Name.Equals(color)).First();

            //IF THE SWATCH LIST CONTAINS THE SELECTED SWATCH
            if (swatchesProvider.Swatches.Contains(swatch))
            {
                //SET THE PRIMARY COLOUR OF THE THEME
                theme.SetPrimaryColor(swatch.ExemplarHue.Color);
            }

            //UPDATE THE THEME (REALTIME)
            paletteHelper.SetTheme(theme);
        }
        /*
        * CODE ATTRIBUTION: https://stackoverflow.com/questions/273313/randomize-a-listt
        */
        public static void Shuffle(List<string> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Generation.random.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
