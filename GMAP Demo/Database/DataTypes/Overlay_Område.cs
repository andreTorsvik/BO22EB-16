using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo.Database.DataTypes
{
    internal class Overlay_Område
    {
        // Løpenummer_til_område som skriver til databasen må bruke DEFAULT pga constraintSequence
        private string defa = "DEFAULT";

        public int Løpenummer_til_område { get; set; }
        public string Kategori { get; set; }




        public string overlay_OmrådeDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Løpenummer_til_område} - {Kategori})";
            }
        }



    }
}