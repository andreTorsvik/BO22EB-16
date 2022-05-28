using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComTag_Objekt
    {
        
        public static List<Tag_Objekt> ListAllTag_ObjektFromDb()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Tag_Objekt>("[dbo].[PROCEDUREListAllTag_ObjektFromDb]").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Tag_Objekt> list = new List<Tag_Objekt>();
                return list;
            }
        }

        public static void InsertTag_ObjektToDb(string Tag, int idObjekt)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Tag_Objekt tag_ObjektToAdd = new Tag_Objekt
                    {
                        Tag = Tag,
                        IdObjekt = idObjekt
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoTag_Objekt] @IdObjekt,@Tag", tag_ObjektToAdd);
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static List<Tag_Objekt> ListTag_ObjektFromDb(int idObjekt)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Tag_Objekt>($"SELECT * FROM[dbo].[Tag_Objekt] WHERE(IdObjekt = '{idObjekt}')").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Tag_Objekt> list = new List<Tag_Objekt>();
                return list;
            }
        }

        public static void DeleteTags_Objekt(int idObjekt)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    connection.Query<Objekt>($"delete FROM [dbo].[Tag_Objekt] WHERE(IdObjekt = '{idObjekt}')");
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
