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
            
            List<Bruker> brukerList = new List<Bruker>();
            brukerList = DBComBruker.StartupConnectionTest(); // Dersom programmet ikke får kontakt med databasen ved oppstart, avsluttes programmet etter vist feilmelding.

            // Simulerer målinger ved å oppdatere Målingstabellen regelmessig
            //MålingSim.InitTimer();


            Application.Run(new frmInnlogging());
        }
    }
}