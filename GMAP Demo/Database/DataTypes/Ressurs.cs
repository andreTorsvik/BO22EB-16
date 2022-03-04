using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace GMAP_Demo.Database.DataTypes
{
    public class Ressurs
    {
        // Løpenummer_ressurs som skriver til databasen må bruke DEFAULT pga constraintSequence
        private string defa = "DEFAULT";
        // Dato_opprettet som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
        private string cuti = "CURRENT_TIMESTAMP";

        public int Løpenummer_ressurs { get; set; } 
        public string Navn { get; set; }
        public string Kategori { get; set; }
        public string Dato_opprettet { get; set; } 
        public string Opprettet_av_bruker { get; set; }
        public int Sikkerhetsklarering { get; set; }
        public string Kommentar { get; set; }
        public float Lat { get; set; }
        public float Lang { get; set; }

        public string ressursDataTypeToString // Her kan vi definere en versjon av string som viser datatypen i listbox
        {
            get
            {
                return $"({Løpenummer_ressurs} - {Navn} - {Kategori} - {Dato_opprettet} - {Opprettet_av_bruker} - {Sikkerhetsklarering} - {Kommentar} - {Lat} - {Lang})";
            }
        }

        public PointLatLng GiPunktet()
        {
            PointLatLng point = new PointLatLng(Lat, Lang);
            return point;
        }





    }
}