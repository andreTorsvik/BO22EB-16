using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace BO22EB16
{
    internal class DBComOmråde
    {

        public static List<Område> ListAllOmrådeFromDb()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Område>($"SELECT * FROM[dbo].[Område] WHERE (Sikkerhetsklarering <= '{InnloggetBruker.Sikkerhetsklarering}')").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Område> list = new List<Område>();
                return list;
            }
        }

        public static Område ListOmrådeFromDb(int idOmråde)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Område>($"SELECT * FROM[dbo].[Område] WHERE(IdOmråde = '{idOmråde}')").FirstOrDefault();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                Område område = new Område();
                return område;
            }
        }

        public static void DeleteOmråde(int idOmråde)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Område DeleteOmråde = new Område
                    {
                        IdOmråde = idOmråde
                    };

                    connection.Execute("[dbo].[PROCEDURERemoveOmråde] @IdOmråde", (DeleteOmråde));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void InsertOmrådeToDb(int idOmråde, string navn, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, string farge)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Område OmrådeToAdd = new Område
                    {
                        IdOmråde = idOmråde,
                        Navn = navn,
                        //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                        Opprettet_av_bruker = opprettet_av_bruker,
                        Sikkerhetsklarering = sikkerhetsklarering,
                        Kommentar = kommentar,
                        Farge = farge
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoOmråde] @IdOmråde, @Navn, @Opprettet_av_bruker,  @Kommentar, @Sikkerhetsklarering, @Farge", OmrådeToAdd);
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static List<int> GetIdOmråde()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<int>($"select (NEXT VALUE FOR [dbo].[SEQUENCEOmrådeId]) as int").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<int> list = new List<int>();
                return list;
            }
        }

        public static void UpdateOmråde(int idOmråde, string navn, int sikkerhetsklarering, string kommentar, string farge)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Område UpdateOmråde = new Område
                    {
                        IdOmråde = idOmråde,
                        Navn = navn,
                        //Kategori = kategori,
                        //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                        //Opprettet_av_bruker = opprettet_av_bruker,
                        Sikkerhetsklarering = sikkerhetsklarering,
                        Kommentar = kommentar,
                        Farge = farge
                    };

                    connection.Execute("[dbo].[PROCEDUREUpdateOmråde] @IdOmråde, @Navn, @kommentar, @Sikkerhetsklarering, @farge", UpdateOmråde);

                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
