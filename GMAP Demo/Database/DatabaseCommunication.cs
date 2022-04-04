using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using GMAP_Demo.Database.DataTypes;
using System.IO;

namespace GMAP_Demo
{
    internal class DatabaseCommunication
    {
        // SQLdatabase connection settings
        //string name = "SQLtest.Properties.Settings.bo22eb16ConnectionString";
        //string connectionString = "Server=tcp:bo22eb16.database.windows.net,1433;Initial Catalog=bo22eb16;Persist Security Info=False;User ID=CloudSAbf2a2105;Password=Pass1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //string providerName = "System.Data.SqlClient";


        // Alternative SQLdatabase connection settings - Uses data from App.config <connectionString>

        public static string bo22eb16DatabasePathUrlLocation = "GMAP_Demo.Properties.Settings.bo22eb16ConnectionString";

        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        //

        public List<Bruker> CheckLoginAgainstDb(string Username, string Password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Bruker>($"SELECT* FROM [dbo].[Bruker] WHERE ( (Epost = '{Username}') AND (Passord = '{Password}') )").ToList();
                return output;
            }
        }

        public List<Bruker> ListAllBrukerFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Bruker>("[dbo].[PROCEDUREListAllBrukerFromDb]").ToList();
                return output;
            }
        }
        public List<Kategorier_Bilde> ListAllKategorier_BildeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Kategorier_Bilde>("[dbo].[PROCEDUREListAllKategorier_BildeFromDb]").ToList();
                return output;
            }
        }
        public List<Måling> ListAllMålingFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Måling>("[dbo].[PROCEDUREListAllMålingFromDb]").ToList();
                return output;
            }
        }
        public List<Område> ListAllOmrådeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Område>("[dbo].[PROCEDUREListAllOmrådeFromDb]").ToList();
                return output;
            }
        }
        public List<Overlay_Område> ListAllOverlay_OmrådeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Overlay_Område>("[dbo].[PROCEDUREListAllOverlay_OmrådeFromDb]").ToList();
                return output;
            }
        }
        public List<Overlay_Ressurs> ListAllOverlay_RessursFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Overlay_Ressurs>("[dbo].[PROCEDUREListAllOverlay_RessursFromDb]").ToList();
                return output;
            }
        }
        public List<Punkter_område> ListAllPunkter_områdeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Punkter_område>("[dbo].[PROCEDUREListAllPunkter_områdeFromDb]").ToList();
                return output;
            }
        }
        public List<Ressurs> ListAllRessursFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Ressurs>("[dbo].[PROCEDUREListAllRessursFromDb]").ToList();
                return output;
            }
        }

        public List<Ressurs> ListRessursFromDb(int løpenummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Ressurs>($"SELECT * FROM[dbo].[Ressurs] WHERE(Løpenummer_ressurs = '{løpenummer}')").ToList();
                return output;
            }
        }

        public List<Bruker> ListBrukerInfoFromDb(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Bruker>($"SELECT * FROM [dbo].[Bruker] WHERE (Epost = '{username}')").ToList();
                return output;
            }
        }

        public void DeleteUser(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Bruker DeleteUser = new Bruker
                {
                    Epost = username
                };

                connection.Execute("[dbo].[PROCEDURERemoveBruker] @Epost", (DeleteUser));
            }
        }

        public void InsertRessursToDb(string navn, string kategori, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Ressurs ressursToAdd = new Ressurs {
                    //Løpenummer_ressurs = "DEFAULT", ordnes av Procedure
                    Navn = navn,
                    Kategori = kategori,
                    //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                    Opprettet_av_bruker = opprettet_av_bruker,
                    Sikkerhetsklarering = sikkerhetsklarering,
                    Kommentar = kommentar,
                    Lat = lat,
                    Lang = lang
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoRessurs] @Navn, @Kategori, @Opprettet_av_bruker, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang", ressursToAdd);
            }
        }

        public void InsertBrukerToDb(string fornavn, string etternavn, int telefonnummer, string epost, string passord, int tallkode)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Bruker brukerToAdd = new Bruker
                {
                    Fornavn = fornavn,
                    Etternavn = etternavn,
                    Telefonnummer = telefonnummer,
                    Epost = epost,
                    Sikkerhetsklarering = 1,
                    Passord = passord,
                    Tallkode = tallkode,
                    Godkjent = false,
                    Verifisert = false
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoBruker] @Fornavn, @Etternavn, @Telefonnummer, @Epost,@Sikkerhetsklarering ,@Passord, @Tallkode, @Godkjent, @Verifisert ", brukerToAdd);
            }
        }

        public void InsertKategorier_BildeToDb(string kategorinavn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Kategorier_Bilde kategorier_BildeKategoriToAdd = new Kategorier_Bilde
                {
                    Kategorinavn = kategorinavn
                    //Bilde = NULL, ordnes av Procedure
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoKategorier_Bilde] @Kategorinavn", kategorier_BildeKategoriToAdd);
            }
        }

        public void InsertBildeToChosenKategorier_BildeToDb(string kategorinavn, byte[] imageData)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Kategorier_Bilde kategorier_BildeBildeToAdd = new Kategorier_Bilde
                {
                    Kategorinavn = kategorinavn,
                    Bilde = imageData
                };

                connection.Execute("[dbo].[PROCEDUREinsertBildeIntoKategorier_Bilde] @Kategorinavn, @Bilde", (kategorier_BildeBildeToAdd));
            }
        }
        public void UpdateBruker_Godkjent(string epost, bool godkjent)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Bruker UpdateGodkjent = new Bruker
                {
                    Epost = epost,
                    Godkjent = godkjent
                };

                connection.Execute("[dbo].[PROCEDUREUpdateBruker_godkjent] @Epost, @Godkjent", (UpdateGodkjent));
            }
        }
        public void UpdateBruker_Verifisert(string epost, bool godkjent)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Bruker UpdateVerifisert = new Bruker
                {
                    Epost = epost,
                    Verifisert = godkjent
                };

                connection.Execute("[dbo].[PROCEDUREUpdateBruker_Verifisert] @Epost, @Verifisert", (UpdateVerifisert));
            }
        }
        public void UpdateBruker_Sikkerhetsklarering(string epost, int klarering)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Bruker UpdateSikkerhetsklarering = new Bruker
                {
                    Epost = epost,
                    Sikkerhetsklarering = klarering
                };

                connection.Execute("[dbo].[PROCEDUREUpgradeBruker_Sikkerhetsklarering] @Epost, @Sikkerhetsklarering", (UpdateSikkerhetsklarering));
            }
        }

        public void UpdateRessurs(int Løpenummer, string navn, string kategori, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Ressurs UpdateRessurs = new Ressurs
                {
                    Løpenummer_ressurs = Løpenummer,
                    Navn = navn,
                    Kategori = kategori,
                    //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                    //Opprettet_av_bruker = opprettet_av_bruker,
                    Sikkerhetsklarering = sikkerhetsklarering,
                    Kommentar = kommentar,
                    Lat = lat,
                    Lang = lang
                };

                connection.Execute("[dbo].[PROCEDUREUpdateRessurs] @Løpenummer_ressurs, @Navn, @Kategori, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang", UpdateRessurs);

            }
        }

        public List<Kategorier_Bilde> GetBildeForKategoriFromDbKategorier_Bilde(string kategorinavn)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Kategorier_Bilde>($"SELECT Kategorinavn, Bilde FROM [dbo].[Kategorier_Bilde] WHERE Kategorinavn = '{ kategorinavn }'").ToList();
                
                
                
                // Stored procedure virker ikke helt enda. Får en syntax error. 
                //kategorinavn = $"'{kategorinavn}'";
                //var output = connection.Query<Kategorier_Bilde>("[dbo].[Zz], @Kategorinavn", kategorinavn).ToList();
                return output;
            }
        }


    }
}
