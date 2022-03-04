﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo.Database.DataTypes
{
    internal class Bruker
    {
        public string Fornavn { get; set; }
        public string Etternavn { get; set; }
        public int Telefonnummer { get; set; }
        public string Epost { get; set; }
        public int Sikkerhetsklarering { get; set; }
        public string Passord { get; set; }




        public string brukerDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Fornavn} - {Etternavn} - {Telefonnummer} - {Epost} - {Sikkerhetsklarering} - {Passord})";
            }
        }



    }
}