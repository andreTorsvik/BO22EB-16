using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO22EB16
{
    internal class Punkter_område
    {
        public int IdOmråde { get; set; } // IdOmråde som skriver til databasen må bruke DEFAULT pga constraintSequence
        public int Rekkefølge_punkter { get; set; } 
        public float Lat { get; set; }
        public float Lang { get; set; }

    }
}