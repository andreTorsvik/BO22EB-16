using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace GMAP_Demo
{
    public class Område
    {
        public int Løpenummer_område { get; set; } // Løpenummer_område som skriver til databasen må bruke DEFAULT pga constraintSequence
        public string Navn { get; set; }
        public string Dato_opprettet { get; set; } // Dato som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
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

        public List<PointLatLng> HentPunkter()
        {
            List<PointLatLng> Lsvar = new List<PointLatLng>();
            var punktListe = DatabaseCommunication.ListAllPunkter_områdeFromDb();

            // https://stackoverflow.com/questions/289010/c-sharp-list-sort-by-x-then-y
            punktListe = punktListe.OrderBy(x => x.Løpenummer_til_område).ThenBy(x => x.Rekkefølge_punkter).ToList();

            foreach (var item in punktListe)
            {      
                if(item.Løpenummer_til_område == Løpenummer_område)
                {
                    PointLatLng punkt = new PointLatLng(Convert.ToDouble(item.Lat), Convert.ToDouble(item.Lang));
                    Lsvar.Add(punkt);
                }
            }
            return Lsvar;
        }

    }
}
