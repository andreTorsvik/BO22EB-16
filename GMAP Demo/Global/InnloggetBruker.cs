namespace BO22EB16
{
    internal class InnloggetBruker
    {
        // InnloggetBruker lagres ved innlogging og bruker gjennom resten av programmet
        // Brukernavn er epost. F.eks: 'ola.nordman@stud.hvl.no'
        private static string brukernavnInnlogget = "";
        private static int sikkerhetsklarering = 1;

        public static string BrukernavnInnlogget
        {
            get { return brukernavnInnlogget; }
            set { brukernavnInnlogget = value; }
        }

        public static int Sikkerhetsklarering { get => sikkerhetsklarering; set => sikkerhetsklarering = value; }
    }
}
