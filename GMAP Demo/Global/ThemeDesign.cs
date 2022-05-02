using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{// https://developer.apple.com/design/human-interface-guidelines/macos/visual-design/color/
    
    internal class ThemeDesign
    {
        // UI Elements
        //public static Color DEformBackground = colorBackground;
        //public static Color DEpanelLayer2Background = colorSecondaryBackground;
        //public static Color DEpanelLayer3Background = colorTertiaryBackground;
        //public static Color DEgroupboxForeground = colorLabel;
        //public static Color DEgroupboxBackground = colorGroupedBackground;
        //public static Color DEgroupboxLayer2Background = colorSecondaryGroupedBackground;
        //public static Color DEgroupboxLayer3Background = colorTertiaryGroupedBackground;
        //public static Color DElabelForeground = colorLabel;
        //public static Color DEtextboxForeground = colorLabel;
        //public static Color DEtextboxBackground = colorGray;
        //public static Color DEtextboxDisabledForeground = colorBackground;
        //public static Color DEtextBoxDisabledBackground = colorGray6;
        //public static Color DElistboxForeground = colorLabel;
        //public static Color DElistboxBackground = colorGray;
        //public static Color DElistboxDisabledForeground = colorBackground;
        //public static Color DElistboxDisabledBackground = colorGray6;
        //public static Color DEbuttonForeground = colorLabel;
        //public static Color DEbuttonBackground = colorGray;
        //public static Color DEcheckboxForeground = colorLabel;
        
        // Default colors
        public static Color colorRed = Color.FromArgb(255, 59, 48);
        public static Color colorOrange = Color.FromArgb(255, 149, 0);
        public static Color colorYellow = Color.FromArgb(255, 204, 0);
        public static Color colorGreen = Color.FromArgb(40, 205, 65);
        public static Color colorMint = Color.FromArgb(0, 199, 190);
        public static Color colorTeal = Color.FromArgb(89, 173, 196);
        public static Color colorCyan = Color.FromArgb(85, 190, 240);
        public static Color colorBlue = Color.FromArgb(0, 122, 255);
        public static Color colorIndigo = Color.FromArgb(88, 86, 214);
        public static Color colorPurple = Color.FromArgb(175, 82, 222);
        public static Color colorPink = Color.FromArgb(255, 45, 85);
        public static Color colorBrown = Color.FromArgb(162, 132, 94);

        // Default Grayscale
        public static Color colorGray = Color.FromArgb(242, 242, 247);
        public static Color colorGray2 = Color.FromArgb(229, 229, 234);
        public static Color colorGray3 = Color.FromArgb(209, 209, 214);
        public static Color colorGray4 = Color.FromArgb(199, 199, 204);
        public static Color colorGray5 = Color.FromArgb(174, 174, 178);
        public static Color colorGray6 = Color.FromArgb(142, 142, 147);

        // Default Backgrounds
        public static Color colorBackground = Color.FromArgb(255, 255, 255);
        public static Color colorSecondaryBackground = Color.FromArgb(242, 242, 247);
        public static Color colorTertiaryBackground = Color.FromArgb(255, 255, 255);
        public static Color colorGroupedBackground = Color.FromArgb(242, 242, 247);
        public static Color colorSecondaryGroupedBackground = Color.FromArgb(255, 255, 255);
        public static Color colorTertiaryGroupedBackground = Color.FromArgb(242, 242, 247);

        // Default Labels
        public static Color colorLabel = Color.FromArgb(0, 0, 0);
        public static Color colorSecondaryLabel = Color.FromArgb(153, 60, 60, 67);
        public static Color colorTertiaryLabel = Color.FromArgb(77, 60, 60, 67);
        public static Color colorQuaternaryLabel = Color.FromArgb(46, 60, 60, 67);

        
        public static void LightTheme()
        {
            colorRed = Color.FromArgb(255, 59, 48);
            colorOrange = Color.FromArgb(255, 149, 0);
            colorYellow = Color.FromArgb(255, 204, 0);
            colorGreen = Color.FromArgb(40, 205, 65);
            colorMint = Color.FromArgb(0, 199, 190);
            colorTeal = Color.FromArgb(89, 173, 196);
            colorCyan = Color.FromArgb(85, 190, 240);
            colorBlue = Color.FromArgb(0, 122, 255);
            colorIndigo = Color.FromArgb(88, 86, 214);
            colorPurple = Color.FromArgb(175, 82, 222);
            colorPink = Color.FromArgb(255, 45, 85);
            colorBrown = Color.FromArgb(162, 132, 94);

            colorGray = Color.FromArgb(242, 242, 247);
            colorGray2 = Color.FromArgb(229, 229, 234);
            colorGray3 = Color.FromArgb(209, 209, 214);
            colorGray4 = Color.FromArgb(199, 199, 204);
            colorGray5 = Color.FromArgb(174, 174, 178);
            colorGray6 = Color.FromArgb(142, 142, 147);
            
            
            
            
            


            colorBackground = Color.FromArgb(255, 255, 255);
            colorSecondaryBackground = Color.FromArgb(242, 242, 247);
            colorTertiaryBackground = Color.FromArgb(255, 255, 255);
            colorGroupedBackground = Color.FromArgb(242, 242, 247);
            colorSecondaryGroupedBackground = Color.FromArgb(255, 255, 255);
            colorTertiaryGroupedBackground = Color.FromArgb(242, 242, 247);

            colorLabel = Color.FromArgb(0, 0, 0);
            colorSecondaryLabel = Color.FromArgb(153, 60, 60, 67);
            colorTertiaryLabel = Color.FromArgb(77, 60, 60, 67);
            colorQuaternaryLabel = Color.FromArgb(46, 60, 60, 67);
        }

        public static void DarkTheme()
        {
            colorRed = Color.FromArgb(255, 69, 58);
            colorOrange = Color.FromArgb(255, 159, 10);
            colorYellow = Color.FromArgb(255, 214, 10);
            colorGreen = Color.FromArgb(50, 215, 75);
            colorMint = Color.FromArgb(102, 212, 207);
            colorTeal = Color.FromArgb(106, 196, 220);
            colorCyan = Color.FromArgb(90, 200, 245);
            colorBlue = Color.FromArgb(10, 132, 255);
            colorIndigo = Color.FromArgb(94, 92, 230);
            colorPurple = Color.FromArgb(191, 90, 242);
            colorPink = Color.FromArgb(255, 55, 95);
            colorBrown = Color.FromArgb(172, 142, 104);

            colorGray = Color.FromArgb(142, 142, 147);
            colorGray2 = Color.FromArgb(99, 99, 102);
            colorGray3 = Color.FromArgb(72, 72, 74);
            colorGray4 = Color.FromArgb(58, 58, 60);
            colorGray5 = Color.FromArgb(44, 44, 46);
            colorGray6 = Color.FromArgb(28, 28, 30);

            colorBackground = Color.FromArgb(0, 0, 0);
            colorSecondaryBackground = Color.FromArgb(28, 28, 30);
            colorTertiaryBackground = Color.FromArgb(44, 44, 46);
            colorGroupedBackground = Color.FromArgb(28, 28, 30);
            colorSecondaryGroupedBackground = Color.FromArgb(44, 44, 46);
            colorTertiaryGroupedBackground = Color.FromArgb(60, 60, 62);

            colorLabel = Color.FromArgb(255, 255, 255, 255);
            colorSecondaryLabel = Color.FromArgb(153, 235, 235, 245);
            colorTertiaryLabel = Color.FromArgb(77, 235, 235, 245);
            colorQuaternaryLabel = Color.FromArgb(49, 235, 235, 245);
        }


        public static void OldTheme()
        {
            colorRed = Color.FromArgb(255, 69, 58);
            colorOrange = Color.FromArgb(255, 159, 10);
            colorYellow = Color.FromArgb(255, 214, 10);
            colorGreen = Color.FromArgb(50, 215, 75);
            colorMint = Color.FromArgb(102, 212, 207);
            colorTeal = Color.FromArgb(106, 196, 220);
            colorCyan = Color.FromArgb(90, 200, 245);
            colorBlue = Color.FromArgb(10, 132, 255);
            colorIndigo = Color.FromArgb(94, 92, 230);
            colorPurple = Color.FromArgb(191, 90, 242);
            colorPink = Color.FromArgb(255, 55, 95);
            colorBrown = Color.FromArgb(172, 142, 104);

            colorGray = Color.FromArgb(142, 142, 147);
            colorGray2 = Color.FromArgb(99, 99, 102);
            colorGray3 = Color.FromArgb(72, 72, 74);
            colorGray4 = Color.FromArgb(58, 58, 60);
            colorGray5 = Color.FromArgb(44, 44, 46);
            colorGray6 = Color.FromArgb(28, 28, 30);

            colorBackground = Color.FromArgb(24, 30, 54);
            colorSecondaryBackground = Color.FromArgb(46, 51, 73);
            colorTertiaryBackground = Color.FromArgb(24, 30, 54);
            colorGroupedBackground = Color.FromArgb(46, 51, 73);
            colorSecondaryGroupedBackground = Color.FromArgb(24, 30, 54);
            colorTertiaryGroupedBackground = Color.FromArgb(46, 51, 73);

            colorLabel = Color.FromArgb(255, 255, 255);
            colorSecondaryLabel = Color.FromArgb(153, 235, 235, 245);
            colorTertiaryLabel = Color.FromArgb(77, 235, 235, 245);
            colorQuaternaryLabel = Color.FromArgb(49, 235, 235, 245);

        }
    }
}
