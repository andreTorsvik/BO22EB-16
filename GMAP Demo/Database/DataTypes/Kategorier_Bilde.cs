using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    public class Kategorier_Bilde
    {
        public string Kategorinavn { get; set; }
        public byte[] Bilde { get; set; }



        public string kategorier_BildeDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Kategorinavn})";
            }
        }



    }
}