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
            string utFyllingsmangler = "Du mangler:";
                //"Du mangler:";
            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(navn))
            {

                utFyllingsmangler += " Navn";
            }
            if (string.IsNullOrWhiteSpace(kategori))
            {

                utFyllingsmangler += " Kategori";
            }
            if (string.IsNullOrWhiteSpace(sikkerhetsklarering))
            {

                utFyllingsmangler += " Sikkerhetsklarering";
            }
            if (string.IsNullOrWhiteSpace(kommentar))
            {
                utFyllingsmangler += " Kommentar";
            }
            if (string.IsNullOrWhiteSpace(lat))
            {
                utFyllingsmangler += " lat";
            }
            if (string.IsNullOrWhiteSpace(lang))
            {
                utFyllingsmangler += " long";
            }
            if (ListeAntall <= 0)
            {
                utFyllingsmangler += " Overlay";
            }

            return utFyllingsmangler;
        }
    }
}
