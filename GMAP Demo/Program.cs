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
            try
            {
                // En vilkårlig metode som tester om vi har kontakt med databasen.
                List<Bruker> brukerList = new List<Bruker>();
                brukerList = DBComBruker.ListAllBrukerFromDb();
            }
            catch (Exception e)
            {
                // Dersom vi ikke har kontakt med databasen vises en feilmelding,
                MessageBox.Show(e.ToString());
                // Og programmet avsluttes.
                System.Environment.Exit(1);
            }

            // Simulerer målinger ved å oppdatere Målingstabellen regelmessig
            MålingSim målingSim = new MålingSim();
            målingSim.InitTimer();

            Application.Run(new frmInnlogging());
        }
    }
}