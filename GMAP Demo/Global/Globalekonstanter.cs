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
        // Forms med meny og kart (for å få plass til alle elementer)
        public static Size frmWithMenuMinimumSize = new Size(1000, 750);

        // Sikkerhetsklarering (1-3)
        public const int MaxSikkerhetsklarering = 3;

        // Antall tegn man må ha i passordet, når man registerer seg 
        public const int antalltegnPassord = 4;

        // Default textbox text for input Lat+Long
        public const string tekstLatLong_område = "Dobbelklikk på kartet + \"legg til\"";
        public const string tekstLatLong_objekt = "Dobbelklikk på kartet";

        // Tilpassing av størrelse på viste ikoner på kart:
        public const double MaxWidth = 30.0; // Max bredde i pixler
        public const double MaxHeight = 30.0; // Max Høyde i pixler

        // Design/Theme
        public static Color knapp_trykket = ThemeDesign.colorSecondaryGroupedBackground; // Farge når knapp er trykket 
        public static Color StandardFargeKnapp = ThemeDesign.colorSecondaryBackground; // Farge på knapp normalt sett

        // Navn på Overlays 
        public const  string NavnHjelpeOmråde = "HjelpeOmråde"; // området som blir tegnet underveis, når man skal legge til eller redigere område 
        public const string NavnRute = "routes"; // navn på rute mellom to plasser 
        public const string NavnObjekter = "Objekter"; // navn på objekter 
        public const string NavnHjelpeMarkør = "HjelpeMarkør"; // navn på markør som kommer når man dobbelttrykker på kart, (gul) 
        public const string NavnOmråde = "Polygons"; //navn område 
        public const string NavnMarkørForOmråde = "MarkørForOmråde"; //markør for hjørnen i et område som er lagt til 

        // Grensen hvor område(polygon) og objekter blir borte fra kartet 
        public const int  ZoomLevel = 16;

        //filnaven
        public const string filStartPosisjon = "StartPosisjon.txt";
        public const string filTheme = "Theme.txt";

    }
}
