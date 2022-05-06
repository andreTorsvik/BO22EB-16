using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    internal class Tag_Område
    {
        public int IdOmråde { get; set; } // IdOmråde som skriver til databasen må bruke DEFAULT pga constraintSequence
        public string Tag { get; set; }

        public string tag_OmrådeDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({IdOmråde} - {Tag})";
            }
        }
    }
}