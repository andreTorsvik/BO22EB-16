using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComKategorier_Bilde
    {
        public static List<Kategorier_Bilde> ListAllKategorier_BildeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Kategorier_Bilde>("[dbo].[PROCEDUREListAllKategorier_BildeFromDb]").ToList();
                return output;
            }
        }

        public static void InsertKategorier_BildeToDb(string kategorinavn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                Kategorier_Bilde kategorier_BildeKategoriToAdd = new Kategorier_Bilde
                {
                    Kategorinavn = kategorinavn
                    //Bilde = NULL, ordnes av Procedure
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoKategorier_Bilde] @Kategorinavn", kategorier_BildeKategoriToAdd);
            }
        }

        public static void InsertBildeToChosenKategorier_BildeToDb(string kategorinavn, byte[] imageData)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                Kategorier_Bilde kategorier_BildeBildeToAdd = new Kategorier_Bilde
                {
                    Kategorinavn = kategorinavn,
                    Bilde = imageData
                };

                connection.Execute("[dbo].[PROCEDUREinsertBildeIntoKategorier_Bilde] @Kategorinavn, @Bilde", (kategorier_BildeBildeToAdd));
            }
        }

        public static List<Kategorier_Bilde> GetBildeForKategoriFromDbKategorier_Bilde(string kategorinavn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Kategorier_Bilde>($"SELECT Kategorinavn, Bilde FROM [dbo].[Kategorier_Bilde] WHERE Kategorinavn = '{ kategorinavn }'").ToList();

                return output;
            }
        }

        public static void DeleteKategorier_Bilde(string kategorinavn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Ressurs>($"delete FROM [dbo].[Kategorier_Bilde] WHERE (Kategorinavn = '{ kategorinavn }')");

            }
        }
    }
}
