using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace GMAP_Demo
{
    public class Ressurs
    {
        public int Løpenummer_ressurs { get; set; } // Løpenummer_ressurs som skriver til databasen må bruke DEFAULT pga constraintSequence
        public string Navn { get; set; }
        public string Kategori { get; set; }
        public string Dato_opprettet { get; set; } // Dato_opprettet som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
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

        public List<string> hentTags()
        {
            List<string> tags = new List<string>();

            var TagListe = DatabaseCommunication.ListTag_ressursFromDb(Løpenummer_ressurs);

            foreach (var item in TagListe)
            {
                tags.Add(item.Tag);
            }

            return tags;
        }
        public override string ToString()
        {
            return $"({Løpenummer_ressurs} - {Navn} - {Kategori} - {Dato_opprettet} - {Opprettet_av_bruker} - {Sikkerhetsklarering} - {Kommentar} - {Lat} - {Lang})";
        }
    }
}