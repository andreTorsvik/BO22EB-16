using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo.Database.DataTypes
{
    internal class Punkter_område
    {
        public int Løpenummer_til_område { get; set; } // Løpenummer_til_område som skriver til databasen må bruke DEFAULT pga constraintSequence
        public int Rekkefølge_punkter { get; set; } 
        public float Lat { get; set; }
        public float Lang { get; set; }




        public string punkter_områdeDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Løpenummer_til_område} - {Rekkefølge_punkter} - {Lat} - {Lang})";
            }
        }



    }
}