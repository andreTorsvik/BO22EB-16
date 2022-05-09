using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    public class GlobaleVariabler
    {
        // Hvis man trykker på logg ut, blir denne true
        public static bool LoggUt = false;

        // Hvis kartet er utenfor zoom grense 
        public static  bool UtenforZoomGrense = false;

        // bool variabel visser hvis kartet holder på å oppdatere 
        public static bool KartOppdatere = false;

        // Boolske variabeler for hvilket filter som skal bli brukt
        public static bool filterOR;
        public static bool filterAND;
    }
}
