﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO22EB16
{
    public class Bruker
    {
        public string Fornavn { get; set; }
        public string Etternavn { get; set; }
        public int Telefonnummer { get; set; }
        public string Epost { get; set; }
        public int Sikkerhetsklarering { get; set; }
        public string Passord { get; set; }
        public int Tallkode { get; set; }
        public bool Godkjent { get; set; }
        public bool Verifisert { get; set; }


        public string BrukerDataTilAdmin
        {
            get
            {
                return $"{Epost} - {Fornavn} - {Etternavn} - {Sikkerhetsklarering}";
            }
        }

        public string BrukerDataIkkeVertifisert
        {
            get
            {
                return $"{Epost} - {Tallkode}";
            }
        }

    }
}