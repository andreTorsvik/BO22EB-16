using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComMåling
    {
        public static List<Måling> ListAllMålingFromDb()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Måling>("[dbo].[PROCEDUREListAllMålingFromDb]").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Måling> list = new List<Måling>();
                return list;
            }
        }

        public static List<Måling> GetLatestValueMålingFromSelectedRessurs(int idObjekt)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Måling>($"SELECT TOP(1) Verdi, Dato, Enhet FROM dbo.Måling WHERE IdObjekt = {idObjekt} ORDER BY Dato DESC;").ToList();

                    if (output.Count == 0)  // Metoden viser "Ingen måling" for de ressurser som ikke har målinger.
                    {
                        Måling tomMåling = new Måling()
                        {
                            Navn_på_sensor = "",
                            Verdi = 0,
                            IdObjekt = 0,
                            Måling_id = 0,
                            Dato = "Ingen måling",
                            Enhet = ""

                        };
                        //tomMåling.Navn_på_sensor = "";
                        //tomMåling.Verdi = 0;
                        //tomMåling.IdObjekt = 0;
                        //tomMåling.Måling_id = 0;
                        //tomMåling.Dato = "Ingen måling";
                        //tomMåling.Enhet = "";
                        output.Add(tomMåling);
                    }
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Måling> list = new List<Måling>();
                return list;
            }
        }

        public static void UpdateMåling(string navn_på_sensor, float verdi, int idObjekt, string enhet)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Måling UpdateMåling = new Måling
                    {
                        Navn_på_sensor = navn_på_sensor,
                        Verdi = verdi,
                        IdObjekt = idObjekt,
                        Enhet = enhet
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoMåling] @Navn_på_sensor, @Verdi, @IdObjekt, @Enhet", (UpdateMåling));

                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

    }
}
