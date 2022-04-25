using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                List<Ressurs> ressursList = new List<Ressurs>();
                ressursList = DBComRessurs.ListAllRessursFromDb();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                System.Environment.Exit(1);
            }
            Application.Run(new frmInnlogging());
        }
    }
}