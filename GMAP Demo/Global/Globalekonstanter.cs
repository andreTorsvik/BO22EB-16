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
        public const int AntalltegnPassord = 4;

        // Antall siffer som kommer i talkoden som blir generet når man oppretter en bruker 
        public const int AntallSiffer  = 7;

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
        public const string NavnHjelpeOmråde = "HjelpeOmråde"; // Området som blir tegnet underveis, når man skal legge til eller redigere område 
        public const string NavnRute = "routes"; // Navn på rute mellom to plasser 
        public const string NavnObjekter = "Objekter"; // Navn på objekter 
        public const string NavnHjelpeMarkør = "HjelpeMarkør"; // Navn på markør (gul) som kommer når man dobbelttrykker på kart 
        public const string NavnOmråde = "Polygons"; // Navn område 
        public const string NavnMarkørForOmråde = "MarkørForOmråde"; // Markør (blå) for hjørnen i et område som er lagt til  

        // Grensen hvor objekter blir borte fra kartet 
        public const int  ZoomGrense = 16;

        // Filnavn
        public const string filStartPosisjon = "StartPosisjon.txt";
        public const string filTheme = "Theme.txt";

        

    }
}
