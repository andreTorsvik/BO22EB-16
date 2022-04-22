using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    internal class Tag_Område
    {
        public int Løpenummer_til_område { get; set; } // Løpenummer_til_område som skriver til databasen må bruke DEFAULT pga constraintSequence
        public string Tag { get; set; }

        public string overlay_OmrådeDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Løpenummer_til_område} - {Tag})";
            }
        }
    }
}