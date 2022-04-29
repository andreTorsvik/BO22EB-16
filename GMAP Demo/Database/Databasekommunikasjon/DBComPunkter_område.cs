using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComPunkter_område
    {
        public static List<Punkter_område> ListAllPunkter_områdeFromDb()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Punkter_område>("[dbo].[PROCEDUREListAllPunkter_områdeFromDb]").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Punkter_område> list = new List<Punkter_område>();
                return list;
            }
        }

        public static List<Punkter_område> GetPunkter_området(int løpenummer)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Punkter_område>($"select* FROM [dbo].[Punkter_område] WHERE(Løpenummer_til_område = '{løpenummer}')").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Punkter_område> list = new List<Punkter_område>();
                return list;
            }
        }

        public static void DeletePunkter_området(int løpenummer)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    connection.Query<Ressurs>($"delete FROM [dbo].[Punkter_område] WHERE(Løpenummer_til_område = '{løpenummer}')");
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void InsertPunkter_områdetToDb(int løpenummer, float lat, float lang, int rekkefølge)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Punkter_område punktToAdd = new Punkter_område
                    {
                        Løpenummer_til_område = løpenummer,
                        Rekkefølge_punkter = rekkefølge,
                        Lat = lat,
                        Lang = lang
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoPunkter_område] @Løpenummer_til_område, @Rekkefølge_punkter, @Lat, @Lang", punktToAdd);
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
