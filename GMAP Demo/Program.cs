using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

// Det er vårt ønske at alt av koden og tilhørende rapport, som ikke omfattes av allerede eksisterende lisenser, skal være fritt tilgjengelig under «Creative Commons Attribution 4.0 International Public License».
// https://creativecommons.org/licenses/by/4.0/legalcode

namespace BO22EB16
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

            FilBehandling.HentTheme(Globalekonstanter.filTheme);

            bool sjekk = DatabaseCommunication.IsServerConnected();
            if(sjekk)
                Application.Run(new FrmInnlogging());

        }
    }
}