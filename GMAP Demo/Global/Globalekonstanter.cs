using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    public class Globalekonstanter
    {
        public static int MaxSikkerhetsklarering = 3;
        public static Color knapp_trykket = Color.FromArgb(46, 51, 73);
        public static Color StandarFargeKnapp = Color.FromArgb(24, 30, 54);


        // Tilpassing av størrelse på viste ikoner på kart:
        public const double MaxWidth = 40.0; // Max bredde i pixler
        public const double MaxHeight = 70.0; // Max Høyde i pixler
    }
}
