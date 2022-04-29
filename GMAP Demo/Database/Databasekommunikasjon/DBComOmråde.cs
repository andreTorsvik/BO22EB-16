using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComOmråde
    {
        public static List<Område> ListAllOmrådeFromDb()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    //var output = connection.Query<Område>("[dbo].[PROCEDUREListAllOmrådeFromDb]").ToList();
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
        public static List<Område> ListOmrådeFromDb(int løpenummer)
        {
            //ListOmrådeFromDb
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Område>($"SELECT * FROM[dbo].[Område] WHERE(Løpenummer_område = '{løpenummer}')").ToList();
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

        public static void DeleteOmråde(int løpeNummer)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Område DeleteOmråde = new Område
                    {
                        Løpenummer_område = løpeNummer
                    };

                    connection.Execute("[dbo].[PROCEDURERemoveOmråde] @Løpenummer_område", (DeleteOmråde));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void InsertOmrådeToDb(int løpenummer, string navn, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, string farge)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Område OmrådeToAdd = new Område
                    {
                        Løpenummer_område = løpenummer,
                        Navn = navn,
                        //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                        Opprettet_av_bruker = opprettet_av_bruker,
                        Sikkerhetsklarering = sikkerhetsklarering,
                        Kommentar = kommentar,
                        Farge = farge
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoOmråde] @Løpenummer_område, @Navn, @Opprettet_av_bruker,  @Kommentar, @Sikkerhetsklarering, @Farge", OmrådeToAdd);
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static List<int> GetLøpenummer_område()
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

        public static void UpdateOmråde(int løpenummer, string navn, int sikkerhetsklarering, string kommentar, string farge)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Område UpdateOmråde = new Område
                    {
                        Løpenummer_område = løpenummer,
                        Navn = navn,
                        //Kategori = kategori,
                        //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                        //Opprettet_av_bruker = opprettet_av_bruker,
                        Sikkerhetsklarering = sikkerhetsklarering,
                        Kommentar = kommentar,
                        Farge = farge
                    };

                    connection.Execute("[dbo].[PROCEDUREUpdateOmråde] @Løpenummer_område, @Navn, @kommentar, @Sikkerhetsklarering, @farge", UpdateOmråde);

                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
