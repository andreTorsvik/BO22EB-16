using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace BO22EB16
{
    public class Objekt
    {
        public int IdObjekt { get; set; } // IdObjekt som skriver til databasen må bruke DEFAULT pga constraintSequence
        public string Navn { get; set; }
        public string Kategori { get; set; }
        public string Dato_opprettet { get; set; } // Dato_opprettet som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
        public string Opprettet_av_bruker { get; set; }
        public int Sikkerhetsklarering { get; set; }
        public string Kommentar { get; set; }
        public float Lat { get; set; }
        public float Lang { get; set; }


        public PointLatLng GiPunktet()
        {
            PointLatLng point = new PointLatLng(Lat, Lang);
            return point;
        }

        public List<string> hentTags()
        {
            List<string> tags = new List<string>();

            var TagListe = DBComTag_Objekt.ListTag_ObjektFromDb(IdObjekt);

            foreach (var item in TagListe)
            {
                tags.Add(item.Tag);
            }

            return tags;
        }

        public override string ToString()
        {
            return $"({IdObjekt} - {Navn} - {Kategori} - {Dato_opprettet} - {Opprettet_av_bruker} - {Sikkerhetsklarering} - {Kommentar} - {Lat} - {Lang})";
        }
    }
}