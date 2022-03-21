namespace GMAP_Demo
{
    internal class InnloggetBruker
    {
        // InnloggetBruker lagres ved innlogging og bruker gjennom resten av programmet
        // Brukernavn er epost. F.eks: 'ola.nordman@stud.hvl.no'
        private static string brukernavnInnlogget = "";
        private static bool godkjent = false;
        public static string BrukernavnInnlogget
        {
            get { return brukernavnInnlogget; }
            set { brukernavnInnlogget = value; }
        }

        public static bool Godkjent
        {
            get { return godkjent; }
            set { godkjent = value; }

        }
    }
}
