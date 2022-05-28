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
        public static List<Punkter_område> GetPunkter_området(int idOmråde)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Punkter_område>($"select* FROM [dbo].[Punkter_område] WHERE(IdOmråde = '{idOmråde}')").ToList();
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

        public static void DeletePunkter_området(int idOmråde)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    connection.Query<Objekt>($"delete FROM [dbo].[Punkter_område] WHERE(IdOmråde = '{idOmråde}')");
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void InsertPunkter_områdetToDb(int idOmråde, float lat, float lang, int rekkefølge)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Punkter_område punktToAdd = new Punkter_område
                    {
                        IdOmråde = idOmråde,
                        Rekkefølge_punkter = rekkefølge,
                        Lat = lat,
                        Lang = lang
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoPunkter_område] @IdOmråde, @Rekkefølge_punkter, @Lat, @Lang", punktToAdd);
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
