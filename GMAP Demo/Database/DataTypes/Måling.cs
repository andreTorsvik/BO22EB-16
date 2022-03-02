using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo.Database.DataTypes
{
    internal class Måling
    {
        // Løpenummer_til_ressurs som skriver til databasen må bruke DEFAULT pga constraintSequence
        private string defa = "DEFAULT";
        // Dato som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
        private string cuti = "CURRENT_TIMESTAMP";

        public string Navn_på_sensor { get; set; }
        public float Verdi { get; set; }
        public int Løpenummer_til_ressurs { get; set; }
        public int Måling_id { get; set; }
        public string Dato { get; set; }
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