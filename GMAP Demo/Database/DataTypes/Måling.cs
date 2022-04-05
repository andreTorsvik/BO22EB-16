using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    internal class Måling
    {
        public string Navn_på_sensor { get; set; }
        public float Verdi { get; set; }
        public int Løpenummer_til_ressurs { get; set; } // Løpenummer_til_ressurs som skriver til databasen må bruke DEFAULT pga constraintSequence
        public int Måling_id { get; set; }
        public string Dato { get; set; } // Dato som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
        public string Enhet { get; set; }




        public string målingDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Navn_på_sensor} - {Verdi} - {Løpenummer_til_ressurs} - {Måling_id} - {Dato} - {Enhet})";
            }
        }



    }
}