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
    public class FilBehandeling
    {
        public static bool LeggTilStartPosisjon(string FilNavn,string lat, string lang)
        {
            bool svar = false;
            if (File.Exists(FilNavn)) File.Delete(FilNavn);

            StreamWriter sw = File.CreateText(FilNavn); ;
            //sjekk at man kan 
            try
            {
                sw.WriteLine("Lat: {0}", lat);
                sw.WriteLine("Long: {0}", lang);
                svar = true;
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(FilBehandeling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            finally
            {
                sw.Close();
                
            }
            return svar;
        }
                
        public static PointLatLng HentStartPosisjon(string FilNavn)
        {
            PointLatLng svar = new PointLatLng(60.36893643470203, 5.350878781967968); // Over høyskolen, hvis filen klare å hente noe 

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
                catch (Exception)
                {

                }
                finally
                {
                    sr.Close();
                }
                
            }
            return svar;
        }

        public static bool LagreTheme(string FilNavn, string theme)
        {
            bool svar = false;
            if (File.Exists(FilNavn)) File.Delete(FilNavn);

            StreamWriter sw = File.CreateText(FilNavn); ;
            //sjekk at man kan 
            try
            {
                sw.WriteLine("Theme: " + theme );
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(typeof(FilBehandeling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            finally
            {
                sw.Close();

            }
            return svar;

        }

        public static void HentTheme(string FilNavn)
        {
            string midlertidig = "";

            //finnne theme 
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
                            midlertidig = Tekstbehandling.hentTheme(text);
                        }
                        ferdig = sr.EndOfStream;
                    }
                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(typeof(FilBehandeling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }
                finally
                {
                    sr.Close();
                }

            }

            
            foreach (MethodInfo item in typeof(ThemeDesign).GetMethods())
            {
               if(item.Name == midlertidig)
               {
                    object p = item.Invoke(null,null);
                    break;
               }
            }

            //return design;
        }
    }
}
