using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GMAP_Demo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool sjekk = DatabaseCommunication.IsServerConnected();
            //List<Bruker> brukerList = new List<Bruker>(DBComBruker.StartupConnectionTest()); // Dersom programmet ikke får kontakt med databasen ved oppstart, avsluttes programmet etter vist feilmelding.
            if(sjekk)
                Application.Run(new frmInnlogging());

        }
    }
}