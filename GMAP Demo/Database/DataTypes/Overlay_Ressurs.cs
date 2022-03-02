using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo.Database.DataTypes
{
    internal class Overlay_Ressurs
    {
        // Løpenummer_til_ressurs som skriver til databasen må bruke DEFAULT pga constraintSequence
        private string defa = "DEFAULT";

        public int Løpenummer_til_ressurs { get; set; }
        public string Kategori { get; set; }




        public string overlay_RessursDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Løpenummer_til_ressurs} - {Kategori})";
            }
        }


    }
}