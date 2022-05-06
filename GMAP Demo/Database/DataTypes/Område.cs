﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace GMAP_Demo
{
    public class Område
    {
        public int IdOmråde { get; set; } // IdOmråde som skriver til databasen må bruke DEFAULT pga constraintSequence
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
                return $"({IdOmråde} - {Navn} - {Dato_opprettet} - {Opprettet_av_bruker} - {Kommentar} - {Sikkerhetsklarering} - {Farge})";
            }
        }

        public List<string> hentTags()
        {
            List<string> tags = new List<string>();

            var TagListe = DBComTag_Område.ListTag_områdeFromDb(IdOmråde);

            foreach (var item in TagListe)
            {
                tags.Add(item.Tag);
            }

            return tags;
        }

        public override string ToString()
        {
            return $"({IdOmråde} - {Navn} - {Dato_opprettet} - {Opprettet_av_bruker} - {Kommentar} - {Sikkerhetsklarering} - {Farge})";
        }
        public List<PointLatLng> HentPunkter()
        {
            //List<PointLatLng> Lsvar = new List<PointLatLng>();
            //var punktListe = DatabaseCommunication.ListAllPunkter_områdeFromDb();

            //// https://stackoverflow.com/questions/289010/c-sharp-list-sort-by-x-then-y
            //punktListe = punktListe.OrderBy(x => x.IdOmråde).ThenBy(x => x.Rekkefølge_punkter).ToList();

            //foreach (var item in punktListe)
            //{      
            //    if(item.IdOmråde == IdOmråde)
            //    {
            //        PointLatLng punkt = new PointLatLng(Convert.ToDouble(item.Lat), Convert.ToDouble(item.Lang));
            //        Lsvar.Add(punkt);
            //    }
            //}

            List<PointLatLng> Lsvar = new List<PointLatLng>();
            var PunktListe = DBComPunkter_område.GetPunkter_området(IdOmråde);
            PunktListe = PunktListe.OrderBy(x => x.Rekkefølge_punkter).ToList();
            foreach (var item in PunktListe)
            {        
                    PointLatLng punkt = new PointLatLng(Convert.ToDouble(item.Lat), Convert.ToDouble(item.Lang));
                    Lsvar.Add(punkt);
            }

            return Lsvar;
        }
    }
}
