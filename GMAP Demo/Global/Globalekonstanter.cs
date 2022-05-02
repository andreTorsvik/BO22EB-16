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
        // Sikkerhetsklarering (1-3)
        public const int MaxSikkerhetsklarering = 3;

        // Default textbox text for input Lat+Long
        public const string tekstLatLong_område = "Dobbelklikk på kartet + \"legg til\"";
        public const string tekstLatLong_objekt = "Dobbelklikk på kartet";

        // Tilpassing av størrelse på viste ikoner på kart:
        public const double MaxWidth = 40.0; // Max bredde i pixler
        public const double MaxHeight = 70.0; // Max Høyde i pixler

        // Design/Theme
        public static Color knapp_trykket = ThemeDesign.colorSecondaryGroupedBackground; // Farge når knapp er trykket 
        public static Color StandarFargeKnapp = ThemeDesign.colorSecondaryBackground; // Farge på knapp normalt sett

        //navn på Overlays 
        public const  string NavnHjelpeOmråde = "HjelpeOmråde"; // området som blir tegnet underveis når man skal legge til eller redigere 
        public const string NavnRute = "routes"; // navn på rute mellom to plasser //x
        public const string NavnObjekter = "Objekter"; // navn på objekter //x
        public const string NavnHjelpeMarkør = "HjelpeMarkør"; //x
        public const string NavnOmråde = "Polygons"; //navn område x
        public const string NavnMarkørForOmråde = "MarkørForOmråde"; //x

        //grensen hvor område(polygon) og objekter blir borte fra kartet 
        public const int  ZoomLevel = 16;
    }
}
