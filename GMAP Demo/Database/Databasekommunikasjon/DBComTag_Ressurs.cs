using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComTag_Ressurs
    {
        
        public static List<Tag_Ressurs> ListAllTag_RessursFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Tag_Ressurs>("[dbo].[PROCEDUREListAllTag_RessursFromDb]").ToList();
                return output;
            }
        }

        public static void InsertTag_RessursToDb(string Tag, int løpenummer_Til_ressurs)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                Tag_Ressurs Tag_RessursToAdd = new Tag_Ressurs
                {
                    Tag = Tag,
                    Løpenummer_til_ressurs = løpenummer_Til_ressurs
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoTag_Ressurs] @Løpenummer_til_ressurs,@Tag", Tag_RessursToAdd);
            }
        }

        public static List<Tag_Ressurs> ListTag_ressursFromDb(int løpenummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Tag_Ressurs>($"SELECT * FROM[dbo].[Tag_ressurs] WHERE(Løpenummer_til_ressurs = '{løpenummer}')").ToList();
                return output;
            }
        }

        public static void DeleteTags_Ressurs(int løpenummer)
        {
            //delete FROM [dbo].[Punkter_område]
            //WHERE Løpenummer_til_område = 38
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                connection.Query<Ressurs>($"delete FROM [dbo].[Tag_ressurs] WHERE(Løpenummer_til_ressurs = '{løpenummer}')");
            }
        }
    }
}
