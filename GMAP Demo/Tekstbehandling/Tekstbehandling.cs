using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public class Tekstbehandling
    {
        static public string AltUtfylt_Registerings(string Fornavn, string Etternavn, string Telefon, string Epost, string Passord, string BePassord)
        {
            string utFyllingsmangler = string.Empty;
            List<string> Lfeil = new List<string>();

            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(Fornavn)) Lfeil.Add("Fornavn");
            if (string.IsNullOrWhiteSpace(Etternavn)) Lfeil.Add(" Etternavn");
            if (string.IsNullOrWhiteSpace(Telefon)) Lfeil.Add(" Telefonnummer");
            if (string.IsNullOrWhiteSpace(Epost)) Lfeil.Add(" Epost");
            if (string.IsNullOrWhiteSpace(Passord)) Lfeil.Add(" Passord");
            if (string.IsNullOrWhiteSpace(BePassord)) Lfeil.Add(" Bekrefte passord");

            utFyllingsmangler = SammenslåTekst("Du mangler: ", Lfeil);

            return utFyllingsmangler;
        }

        static public string SjekkGyldigDataRegistering(string Epost, string passord, string Bepassord)
        {
            string svar = string.Empty;
            List<string> Lfeil = new List<string>();
            int antalltegnPassord = 4;

            //sjekk passord
            if (!(passord == Bepassord))
                Lfeil.Add("Passord samsvarer ikke");
            else if (passord.Length < antalltegnPassord)
                Lfeil.Add(String.Format("passord er for kort, må minst være: {0}", antalltegnPassord)); 

            //Sjekk epost 
            if (!ErEmailGodkjent(Epost))
            {
                Lfeil.Add("Ikke oppgitt en mail adresse");
            }
            else
            {
                //om Eposten er i systemet allerede 
                Epost = Epost.ToLower();
                var SjekkEpost = DBComBruker.ListBrukerInfoFromDb(Epost.Trim());

                if (SjekkEpost.Count != 0)
                    Lfeil.Add("Mailen eksitere allerede i systemet");
            }

            svar = SammenslåTekst("Feil: ", Lfeil);

            return svar;
        }
      
        static public string AltUtfylt_Objekt(string navn, string kategori, string sikkerhetsklarering, string kommentar, string lat, string lang, int ListeAntall,string TekstLatLong)
        {
            string utFyllingsmangler = string.Empty;
            List<string> Lfeil = new List<string>();

            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(navn)) Lfeil.Add("Navn");
            if (string.IsNullOrWhiteSpace(kategori)) Lfeil.Add("Kategori");
            if (string.IsNullOrWhiteSpace(sikkerhetsklarering)) Lfeil.Add("Sikkerhetsklarering");
            if (string.IsNullOrWhiteSpace(kommentar)) Lfeil.Add("Kommentar");
            if (string.IsNullOrWhiteSpace(lat) || lat == TekstLatLong) Lfeil.Add("Lat");
            if (string.IsNullOrWhiteSpace(lang) || lang == TekstLatLong) Lfeil.Add("Long");
            if (ListeAntall <= 0) Lfeil.Add("Tag");

            utFyllingsmangler = SammenslåTekst("Du mangler: ", Lfeil);

            return utFyllingsmangler;
        }

        public static string SjekkEndringer_Objekt(List<Ressurs> rList, string navn, string kategori, string sikkerhetsklarering, string kommentar, string lat, string lang, List<string> GammleTags, List<string> NyTags)
        {
            string Endringer = string.Empty;
            string newLine = Environment.NewLine;

            if (rList[0].Navn != navn)
                Endringer += string.Format("Navn: {0} -> {1}" + newLine, rList[0].Navn, navn);
            try
            {
                if (rList[0].Sikkerhetsklarering != Convert.ToInt16(sikkerhetsklarering))
                {
                    Endringer += string.Format("Sikkerhetsklarering: {0} -> {1}" + newLine, rList[0].Sikkerhetsklarering, sikkerhetsklarering);
                }
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(Tekstbehandling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            if (rList[0].Kategori != kategori)
                Endringer += string.Format("Kategori: {0} -> {1}" + newLine, rList[0].Kategori, kategori);
            if (rList[0].Kommentar != kommentar)
                Endringer += string.Format("Kommentar: {0} -> {1}" + newLine, rList[0].Kommentar, kommentar);
            try
            {
                if (Math.Round(rList[0].Lat, 5) != Math.Round(Convert.ToDouble(lat), 5))
                    Endringer += string.Format("Lat: {0} -> {1}" + newLine, rList[0].Lat, lat);
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(Tekstbehandling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }

            try
            {
                if (Math.Round(rList[0].Lang, 5) != Math.Round(Convert.ToDouble(lang), 5))
                    Endringer += string.Format("Long: {0} -> {1}" + newLine, rList[0].Lang, lang);
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(Tekstbehandling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }

            //tags
            List<string> SjekkOmNye1 = NyTags.Except(GammleTags).ToList();
            List<string> SjekkOmNye2 = GammleTags.Except(NyTags).ToList();

            if (SjekkOmNye1.Count != 0 || SjekkOmNye2.Count != 0)
            {
                Endringer += newLine + "Gjeldene Tags: " + newLine;
                for (int i = 0; i < NyTags.Count; i++)
                {
                    Endringer += string.Format("{0}", NyTags[i]);
                    if (i < NyTags.Count - 1) Endringer += newLine;
                }
            }
            return Endringer;
        }

        static public string sjekkGyldigTallData_objekt(string sikkerhetsKlarering, string lat, string lang)
        {
            string feil = string.Empty;
            List<string> Lfeil = new List<string>();
            string SjekkSikkerhetsklarering = sjekkSikkerhetsKlarering(sikkerhetsKlarering);
            string SjekkLat = sjekkLat(lat);
            string SjekkLang = sjekkLong(lang);

            if (SjekkSikkerhetsklarering != string.Empty) Lfeil.Add(SjekkSikkerhetsklarering);
            if (SjekkLat != string.Empty) Lfeil.Add(SjekkLat);
            if (SjekkLang != string.Empty) Lfeil.Add(SjekkLang);

            feil = SammenslåTekst("Feil: ", Lfeil);

            return feil;
        }

        public static string AltUtfylt_Område(string navn, string sikkerhetsklarering, string kommentar, string farge, int AntallPunkter, int AntallTags)
        {
            string utFyllingsmangler = string.Empty;
            List<string> Lfeil = new List<string>();

            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(navn)) Lfeil.Add("Navn");
            if (string.IsNullOrWhiteSpace(sikkerhetsklarering)) Lfeil.Add("Sikkerhetsklarering");
            if (string.IsNullOrWhiteSpace(kommentar)) Lfeil.Add("Kommentar");
            if (string.IsNullOrWhiteSpace(farge)) Lfeil.Add("Farge");
            if (AntallPunkter < 3) Lfeil.Add("Må minst ha 3 punkter");
            if (AntallTags <= 0) Lfeil.Add("Tag");

            utFyllingsmangler = SammenslåTekst("Du mangler: ", Lfeil);

            return utFyllingsmangler;
        }

        public static string SjekkEndringer_Område(List<Område> oList, string navn, string sikkerhetsklarering, string kommentar, string farge, List<PointLatLng> pList, List<string> GammleTags, List<string> NyTags)
        {
            string Endringer = string.Empty;
            string newLine = Environment.NewLine;

            if (oList[0].Navn != navn)
                Endringer += string.Format("Navn: {0} -> {1}" + newLine, oList[0].Navn, navn);
            try
            {
                if (oList[0].Sikkerhetsklarering != Convert.ToInt16(sikkerhetsklarering))
                {
                    Endringer += string.Format("Sikkerhetsklarering: {0} -> {1}" + newLine, oList[0].Sikkerhetsklarering, sikkerhetsklarering);
                }
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(Tekstbehandling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            if (oList[0].Kommentar != kommentar)
                Endringer += string.Format("Kommentar: {0} -> {1}" + newLine, oList[0].Kommentar, kommentar);
            if (oList[0].Farge != farge)
                Endringer += string.Format("Farge: {0} -> {1}" + newLine, oList[0].Farge, farge);

            Endringer += sammenlignPunkter(oList, pList);

            //tags
            List<string> SjekkOmNye1 = NyTags.Except(GammleTags).ToList();
            List<string> SjekkOmNye2 = GammleTags.Except(NyTags).ToList();

            if (SjekkOmNye1.Count != 0 || SjekkOmNye2.Count != 0)
            {
                Endringer += newLine + "Gjeldene Tags: " + newLine;
                for (int i = 0; i < NyTags.Count; i++)
                {
                    Endringer += string.Format("{0}", NyTags[i]);
                    if (i < NyTags.Count - 1) Endringer += newLine;
                }
            }

            return Endringer;
        }

        public static string AdresseTekstfelt(string land, string ByKommune, string adresse)
        {
            string svar = string.Empty;
            List<string> LSammenSlåing = new List<string>();

            if (!string.IsNullOrWhiteSpace(land)) LSammenSlåing.Add(land.Trim());
            if (!string.IsNullOrWhiteSpace(ByKommune)) LSammenSlåing.Add(ByKommune.Trim());
            if (!string.IsNullOrWhiteSpace(adresse)) LSammenSlåing.Add(adresse.Trim());

            svar = SammenslåTekst(null, LSammenSlåing);

            return svar;
        }

        public static string SammenslåTekst(string startTekst, List<string> liste)
        {
            string svar = string.Empty;

            svar = startTekst + String.Join(", ", liste);

            return svar;
        }

        public static string sammenlignPunkter(List<Område> oList, List<PointLatLng> pList)
        {
            string Endringer = string.Empty;
            string newLine = Environment.NewLine;
            //sjekk punkter 
            List<PointLatLng> Orginalepunkter = oList[0].HentPunkter();

            if (Orginalepunkter.Count == pList.Count)
            {
                for (int i = 0; i < pList.Count; i++) // må sjekke om punktene er de samme som før 
                {
                    if (Math.Round(Orginalepunkter[i].Lat, 6) != Math.Round(pList[i].Lat, 6))
                    {
                        Endringer += string.Format("Ny punkter" + newLine);
                        break;
                    }
                    else if (Math.Round(Orginalepunkter[i].Lng, 6) != Math.Round(pList[i].Lng, 6))
                    {
                        Endringer += string.Format("Ny punkter" + newLine);
                        break;
                    }

                }
            }
            else
            {
                if (Orginalepunkter.Count > pList.Count)
                    Endringer += string.Format("færre punkter enn før" + newLine);
                else if (Orginalepunkter.Count < pList.Count)
                    Endringer += string.Format("flere punkter enn før" + newLine);
            }

            return Endringer;
        }

        public static bool ErEmailGodkjent(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public static string sjekkSikkerhetsKlarering(string sikkerhetsKlarering)
        {
            string svar = string.Empty;

            try
            {
                int sjekk = Convert.ToInt32(sikkerhetsKlarering);
                if (sjekk > Globalekonstanter.MaxSikkerhetsklarering)
                {
                    svar = "Sikkerhetsklarering er for høy";
                }
                else if (sjekk < 1)
                {
                    svar = "Sikkerhetsklarering kan ikke være lavere enn 1 ";
                }

                if (sjekk > InnloggetBruker.Sikkerhetsklarering)
                {
                    svar = "Sikkerhetsklaering kan ikke være høyre enn din egen";
                }
            }
            catch (Exception)
            {
                svar = "Feil inntasting med Sikkerhetsklarering";
            }

            return svar;
        }

        public static string sjekkLat(string lat)
        {
            string svar = string.Empty;

            try
            {
                float sjekk = Convert.ToSingle(lat);
            }
            catch (Exception)
            {
                svar = "inntasting med Lat";
            }

            return svar;
        }

        public static string sjekkLong(string lang)
        {
            string svar = string.Empty;

            try
            {
                float sjekk = Convert.ToSingle(lang);
            }
            catch (Exception)
            {
                svar = "inntasting med Long";
            }

            return svar;
        }

        public static double HentLat(string text)
        {
            double lat = 0;

            try
            {
                int startIndex = text.IndexOf(" ");
                string sjekk = text.Substring(startIndex);
                lat = Convert.ToDouble(sjekk);
            }
            catch (Exception)
            {


            }

            return lat;
        }

        public static double hentLong(string text)
        {
            double lang = 0;

            try
            {
                int startIndex = text.IndexOf(" ");
                string sjekk = text.Substring(startIndex);
                lang = Convert.ToDouble(sjekk);
            }
            catch (Exception)
            {


            }


            return lang;
        }
    }
}
