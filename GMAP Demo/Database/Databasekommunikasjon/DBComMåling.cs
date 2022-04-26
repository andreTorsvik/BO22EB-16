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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Måling>("[dbo].[PROCEDUREListAllMålingFromDb]").ToList();
                return output;
            }
        }

        public static List<String> GetLatestValueMålingFromSelectedRessurs(int løpenummer_til_ressurs)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<String>($"SELECT TOP(1) Verdi FROM dbo.Måling WHERE Løpenummer_til_ressurs = {løpenummer_til_ressurs} ORDER BY Dato DESC;").ToList();
                if (output == null)
                {
                    return output;
                }
                else
                {
                    output.Add("Ingen måling");
                    return output;
                }
                
            }
        }

        public static void UpdateMåling(string navn_på_sensor, float verdi, int løpenummer_til_ressurs, string enhet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                Måling UpdateMåling = new Måling
                {
                Navn_på_sensor = navn_på_sensor,
                Verdi = verdi,
                Løpenummer_til_ressurs = løpenummer_til_ressurs,
                Enhet = enhet
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoMåling] @Navn_på_sensor, @Verdi, @Løpenummer_til_ressurs, @Enhet", (UpdateMåling));

            }
        }

    }
}
