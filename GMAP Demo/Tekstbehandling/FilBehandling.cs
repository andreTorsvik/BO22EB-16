using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace GMAP_Demo
{
    public class FilBehandling
    {
        public static bool LeggTilStartPosisjon(string FilNavn,string lat, string lang)
        {
            bool svar = false;
            if (File.Exists(FilNavn)) File.Delete(FilNavn);

            StreamWriter sw = File.CreateText(FilNavn); ;

            // Sjekk at man kan 
            try
            {
                sw.WriteLine("Lat: {0}", lat);
                sw.WriteLine("Long: {0}", lang);
                svar = true;
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(FilBehandling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            finally
            {
                sw.Close();
                
            }
            return svar;
        }
                
        public static PointLatLng HentStartPosisjon(string FilNavn)
        {
            PointLatLng svar = new PointLatLng(60.36893643470203, 5.350878781967968); // Over høyskolen, hvis filen ikke klare å hente noe kordinater

            if (File.Exists(FilNavn))
            {
                StreamReader sr = File.OpenText(FilNavn); ;
                try
                {
                    bool ferdig = sr.EndOfStream;
                    string text;

                    while (!ferdig)
                    {
                        text = sr.ReadLine();

                        if (text.Contains("Lat"))
                        {
                            svar.Lat =Tekstbehandling.HentLat(text);
                        }
                        else if (text.Contains("Long"))
                        {
                            svar.Lng = Tekstbehandling.hentLong(text);
                        }

                        ferdig = sr.EndOfStream;
                    }
                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(typeof(FilBehandling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }
                finally
                {
                    sr.Close();
                }         
            }
            return svar;
        }

        public static void LagreTheme(string FilNavn, string theme)
        {
            if (File.Exists(FilNavn)) File.Delete(FilNavn);

            StreamWriter sw = File.CreateText(FilNavn);

            // Sjekk at man kan 
            try
            {
                sw.WriteLine("Theme: " + theme );
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(FilBehandling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            finally
            {
                sw.Close();
            }
        }

        public static void HentTheme(string FilNavn)
        {
            string ThemeFraFil = "";

            // Finnne theme 
            if (File.Exists(FilNavn))
            {
                StreamReader sr = File.OpenText(FilNavn); ;
                try
                {
                    bool ferdig = sr.EndOfStream;
                    string text;

                    while (!ferdig)
                    {
                        text = sr.ReadLine();

                        if (text.Contains("Theme"))
                        {
                            ThemeFraFil = Tekstbehandling.hentTheme(text);
                        }
                        ferdig = sr.EndOfStream;
                    }
                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(typeof(FilBehandling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }
                finally
                {
                    sr.Close();
                }

            }

            // Utfører theme vis man kan 
            // Hvis ikke bruker den default 
            foreach (MethodInfo item in typeof(ThemeDesign).GetMethods())
            {
               if(item.Name == ThemeFraFil)
               {
                    // utfører metoden med samme navn som er hentet fra filen 
                    item.Invoke(null,null);
                    break;
               }
            }

            
        }
    }
}
