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
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Tag_Område>("[dbo].[PROCEDUREListAllTag_OmrådeFromDb]").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Tag_Område> list = new List<Tag_Område>();
                return list;
            }
        }


        //ListTag_områdeFromDb

        public static List<Tag_Område> ListTag_områdeFromDb(int løpenummer)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Tag_Område>($"SELECT * FROM[dbo].[Tag_område] WHERE(Løpenummer_til_område = '{løpenummer}')").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Tag_Område> list = new List<Tag_Område>();
                return list;
            }
        }


        public static void DeleteTags_Område(int løpenummer)
        {
            //delete FROM [dbo].[Punkter_område]
            //WHERE Løpenummer_til_område = 38
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    connection.Query<Objekt>($"delete FROM [dbo].[Tag_område] WHERE(Løpenummer_til_område = '{løpenummer}')");
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void InsertTag_OmrådeToDb(string Tag, int løpenummer_Til_område)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Tag_Område Tag_områdeToAdd = new Tag_Område
                    {
                        Tag = Tag,
                        IdOmråde = løpenummer_Til_område
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoTag_område] @Løpenummer_til_område,@Tag", Tag_områdeToAdd);
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
