using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    public class Tekstbehandling
    {
        static public string sjekkTallData(string sikkerhetsKlarering, string lat, string lang)
        {
            string svar = string.Empty;

            try
            {
                int sjekk = Convert.ToInt16(sikkerhetsKlarering);
                if (sjekk > Form1.instance.MaxSikkerhetsklarering)
                {
                    svar = "Sikkerhetsklarering er for høy";
                }
                else if (sjekk < 1)
                {
                    svar = "Sikkerhetsklarering kan ikke være lavere enn 1 ";
                }
            }
            catch (Exception)
            {
                if (svar != string.Empty) svar += ", ";
                svar += "Feil inntasting med Sikkerhetsklarering";
            }
            try
            {
                float sjekk = Convert.ToSingle(lat);

            }
            catch (Exception)
            {
                if (svar != string.Empty) svar += ", ";
                svar += "Feil inntasting med Lat";
            }
            try
            {
                float sjekk = Convert.ToSingle(lang);
            }
            catch (Exception)
            {
                if (svar != string.Empty) svar += ", ";
                svar += " Feil inntasting med Long";
            }

            return svar;
        }

        static public string SjekkInntastetDataObjekt(string navn,string kategori, string sikkerhetsklarering, string kommentar,string lat, string lang, int ListeAntall)
        {
            string utFyllingsmangler = string.Empty;
            List<string> Lfeil = new List<string>();

            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(navn)) Lfeil.Add("Navn");
            if (string.IsNullOrWhiteSpace(kategori)) Lfeil.Add("Kategori");
            if (string.IsNullOrWhiteSpace(sikkerhetsklarering)) Lfeil.Add("Sikkerhetsklarering");
            if (string.IsNullOrWhiteSpace(kommentar)) Lfeil.Add("Kommentar");
            if (string.IsNullOrWhiteSpace(lat)) Lfeil.Add("Lat");
            if (string.IsNullOrWhiteSpace(lang)) Lfeil.Add("Long");
            if (ListeAntall <= 0) Lfeil.Add("Overlay");

            if (Lfeil.Count > 0)
            {
                utFyllingsmangler = "Du mangler: ";
                for (int i = 0; i < Lfeil.Count; i++)
                {
                    utFyllingsmangler += Lfeil[i];
                    if (i < Lfeil.Count - 1 ) utFyllingsmangler += ", ";
                }
            }
            return utFyllingsmangler;
        }
    }
}
