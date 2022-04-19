using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                DatabaseCommunication.LogFeil(typeof(FilBehandeling).Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            finally
            {
                sw.Close();
                
            }
            return svar;
        }
        
           
        public static PointLatLng GiStartPosisjon(string FilNavn)
        {
            PointLatLng svar = new PointLatLng(60.36893643470203, 5.350878781967968); // Over høyskolen vis

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

    }
}
