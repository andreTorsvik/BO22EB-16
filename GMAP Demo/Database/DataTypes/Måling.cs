using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO22EB16
{
    internal class Måling
    {
        public string Navn_på_sensor { get; set; }
        public float Verdi { get; set; }
        public int IdObjekt { get; set; } // IdObjekt som skriver til databasen må bruke DEFAULT pga constraintSequence
        public int Måling_id { get; set; }
        public string Dato { get; set; } // Dato som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
        public string Enhet { get; set; }

    }
}