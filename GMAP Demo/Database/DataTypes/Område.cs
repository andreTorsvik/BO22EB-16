using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo.Database.DataTypes
{
    internal class Område
    {
        // Løpenummer_område som skriver til databasen må bruke DEFAULT pga constraintSequence
        private string defa = "DEFAULT";
        // Dato som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
        private string cuti = "CURRENT_TIMESTAMP";

        public int Løpenummer_område { get; set; }
        public string Navn { get; set; }
        public string Dato_opprettet { get; set; }
        public string Opprettet_av_bruker { get; set; }
        public string Kommentar { get; set; }
        public int Sikkerhetsklarering { get; set; }
        public string Farge { get; set; }



        public string områdeDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Løpenummer_område} - {Navn} - {Dato_opprettet} - {Opprettet_av_bruker} - {Kommentar} - {Sikkerhetsklarering} - {Farge})";
            }
        }


    }
}
