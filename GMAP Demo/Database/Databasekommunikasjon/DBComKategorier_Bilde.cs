using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace BO22EB16
{
    internal class DBComKategorier_Bilde
    {

        public static List<Kategorier_Bilde> ListAllKategorier_BildeFromDb()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Kategorier_Bilde>("[dbo].[PROCEDUREListAllKategorier_BildeFromDb]").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Kategorier_Bilde> list = new List<Kategorier_Bilde>();
                return list;
            }
        }

        public static void InsertKategorier_BildeToDb(string kategorinavn)
        {
            try
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
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void InsertBildeToChosenKategorier_BildeToDb(string kategorinavn, byte[] imageData)
        {
            try
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
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void DeleteBildeFromKategorier_Bilde(string kategorinavn)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Objekt>($"UPDATE [dbo].[Kategorier_Bilde] SET Bilde = null WHERE (Kategorinavn = '{ kategorinavn }')");
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static List<Kategorier_Bilde> GetBildeForKategoriFromDbKategorier_Bilde(string kategorinavn)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Kategorier_Bilde>($"SELECT Kategorinavn, Bilde FROM [dbo].[Kategorier_Bilde] WHERE Kategorinavn = '{ kategorinavn }'").ToList();

                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Kategorier_Bilde> list = new List<Kategorier_Bilde>();
                return list;
            }
        }

        public static void DeleteKategorier_Bilde(string kategorinavn)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Objekt>($"delete FROM [dbo].[Kategorier_Bilde] WHERE (Kategorinavn = '{ kategorinavn }')");

                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
