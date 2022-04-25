using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComTag_Område
    {

        public static List<Tag_Område> ListAllTag_OmrådeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Tag_Område>("[dbo].[PROCEDUREListAllTag_OmrådeFromDb]").ToList();
                return output;
            }
        }


        //ListTag_områdeFromDb

        public static List<Tag_Område> ListTag_områdeFromDb(int løpenummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Tag_Område>($"SELECT * FROM[dbo].[Tag_område] WHERE(Løpenummer_til_område = '{løpenummer}')").ToList();
                return output;
            }
        }


        public static void DeleteTags_Område(int løpenummer)
        {
            //delete FROM [dbo].[Punkter_område]
            //WHERE Løpenummer_til_område = 38
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                connection.Query<Ressurs>($"delete FROM [dbo].[Tag_område] WHERE(Løpenummer_til_område = '{løpenummer}')");
            }
        }

        public static void InsertTag_OmrådeToDb(string Tag, int løpenummer_Til_område)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                Tag_Område Tag_områdeToAdd = new Tag_Område
                {
                    Tag = Tag,
                    Løpenummer_til_område = løpenummer_Til_område
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoTag_område] @Løpenummer_til_område,@Tag", Tag_områdeToAdd);
            }
        }
    }
}
