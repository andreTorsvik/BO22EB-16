using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    internal class InnloggetBruker
    {
        // InnloggetBruker lagres ved innlogging og bruker gjennom resten av programmet
        // Brukernavn er epost. F.eks: 'ola.nordman@stud.hvl.no'
        private static string brukernavnInnlogget = "";
            public static string BrukernavnInnlogget
            {
                get { return brukernavnInnlogget; }
                set { brukernavnInnlogget = value; }
            }
    }
}
