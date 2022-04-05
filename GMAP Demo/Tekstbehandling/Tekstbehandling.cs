﻿using System;
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
                if (sjekk > FrmVisning.instance.MaxSikkerhetsklarering)
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
        public static string SjekkEndringerObjekt(List<Ressurs> rList,string navn, string kategori, string sikkerhetsklarering, string kommentar, string lat, string lang, int ListeAntall)
        {
            string Endringer = string.Empty;
            string newLine = Environment.NewLine;

            if (rList[0].Navn != navn) Endringer += string.Format("Navn: {0} -> {1}" + newLine, rList[0].Navn, navn);
            try
            {
                if (rList[0].Sikkerhetsklarering != Convert.ToInt16(sikkerhetsklarering))
                {
                    Endringer += string.Format("Sikkerhetsklarering: {0} -> {1}" + newLine, rList[0].Sikkerhetsklarering, sikkerhetsklarering);
                }
            }
            catch (Exception) { }
            if (rList[0].Kategori != kategori) Endringer += string.Format("Kategori: {0} -> {1}" + newLine, rList[0].Kategori, kategori);
            if (rList[0].Kommentar != kommentar) Endringer += string.Format("Kommentar: {0} -> {1}" + newLine, rList[0].Kommentar, kommentar);
            try
            {
                if (Math.Round(rList[0].Lat, 5) != Math.Round(Convert.ToDouble(lat), 5))
                    Endringer += string.Format("Lat: {0} -> {1}" + newLine, rList[0].Lat, lat);
            }
            catch (Exception) { }

            try
            {
                if (Math.Round(rList[0].Lang, 5) != Math.Round(Convert.ToDouble(lang), 5))
                    Endringer += string.Format("Long: {0} -> {1}" + newLine, rList[0].Lang, lang);
            }
            catch (Exception) { }

            //må sjekke om hver overlay er likt 

            return Endringer;
        }
    }
}
