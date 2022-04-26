using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GMAP_Demo
{
    internal class MålingSim
    {
        internal static Random random = new Random();
        public static void InitTimer()
        {
            Timer timer = new Timer(TimerProc);
            timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        public static void TimerProc(object state)
        {
            // perform the operation
            float måling = (Convert.ToSingle(random.Next(30)) + Convert.ToSingle(random.NextDouble()));
            måling = (float)Math.Round(måling, 2);
            DBComMåling.UpdateMåling("Termomåler 9001", (måling), 0, "C");
            
            måling = (Convert.ToSingle(random.Next(400)) + Convert.ToSingle(random.NextDouble()));
            måling = (float)Math.Round(måling, 2);
            DBComMåling.UpdateMåling("Voltron 777", (måling), 1, "V");
        }
    }
}
