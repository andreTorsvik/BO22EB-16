using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BO22EB16
{
    internal class MålingSim
    {
        internal static Random random = new Random();

        public static void TimerProc(object state)
        {
            // perform the operation
            // Simulerer kun målinger for 2 objekter, 
            // disse er hardkodet inn, har tagen "SimMåling"

            float måling = (Convert.ToSingle(random.Next(30)) + Convert.ToSingle(random.NextDouble()));
            måling = (float)Math.Round(måling, 2);
            DBComMåling.UpdateMåling("Termomåler 9001", (måling), 0, "C");
            
            måling = (Convert.ToSingle(random.Next(400)) + Convert.ToSingle(random.NextDouble()));
            måling = (float)Math.Round(måling, 2);
            DBComMåling.UpdateMåling("Voltron 777", (måling), 1, "V");
        }
    }
}
