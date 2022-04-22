using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using GMap.NET;
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

        public static List<Bruker> CheckLoginAgainstDb(string Username, string Password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Bruker>($"SELECT* FROM [dbo].[Bruker] WHERE ( (Epost = '{Username}') AND (Passord = '{Password}') )").ToList();
                return output;
            }
        }

        public static List<Bruker> ListAllBrukerFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Bruker>("[dbo].[PROCEDUREListAllBrukerFromDb]").ToList();
                return output;
            }
        }
        public static List<Kategorier_Bilde> ListAllKategorier_BildeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Kategorier_Bilde>("[dbo].[PROCEDUREListAllKategorier_BildeFromDb]").ToList();
                return output;
            }
        }
        public static List<Måling> ListAllMålingFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Måling>("[dbo].[PROCEDUREListAllMålingFromDb]").ToList();
                return output;
            }
        }
        public static List<Område> ListAllOmrådeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Område>("[dbo].[PROCEDUREListAllOmrådeFromDb]").ToList();
                return output;
            }
        }
        public static List<Tag_Område> ListAllTag_OmrådeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Tag_Område>("[dbo].[PROCEDUREListAllTag_OmrådeFromDb]").ToList();
                return output;
            }
        }
        public static List<Tag_Ressurs> ListAllTag_RessursFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Tag_Ressurs>("[dbo].[PROCEDUREListAllTag_RessursFromDb]").ToList();
                return output;
            }
        }
        public static List<Punkter_område> ListAllPunkter_områdeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Punkter_område>("[dbo].[PROCEDUREListAllPunkter_områdeFromDb]").ToList();
                return output;
            }
        }
        public static List<Ressurs> ListAllRessursFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Ressurs>("[dbo].[PROCEDUREListAllRessursFromDb]").ToList();
                return output;
            }
        }

        public static List<Ressurs> ListRessursFromDb(int løpenummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Ressurs>($"SELECT * FROM[dbo].[Ressurs] WHERE(Løpenummer_ressurs = '{løpenummer}')").ToList();
                return output;
            }
        }
        public static List<Område> ListOmrådeFromDb(int løpenummer)
        {
            //ListOmrådeFromDb
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Område>($"SELECT * FROM[dbo].[Område] WHERE(Løpenummer_område = '{løpenummer}')").ToList();
                return output;
            }
        }

        public static List<Punkter_område> GetPunkter_området(int løpenummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Punkter_område>($"select* FROM [dbo].[Punkter_område] WHERE(Løpenummer_til_område = '{løpenummer}')").ToList();
                return output;
            }
        }



        public static List<Bruker> ListBrukerInfoFromDb(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Bruker>($"SELECT * FROM [dbo].[Bruker] WHERE (Epost = '{username}')").ToList();
                return output;
            }
        }

        public static void DeleteBruker(string username)
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

        public static void DeleteRessurs(int løpeNummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Ressurs DeleteRessurs = new Ressurs
                {
                    Løpenummer_ressurs = løpeNummer
                };

                connection.Execute("[dbo].[PROCEDURERemoveRessurs] @Løpenummer_ressurs", (DeleteRessurs));
            }
        }
        public static void DeletePunkter_området(int løpenummer)
        {
            //delete FROM [dbo].[Punkter_område]
            //WHERE Løpenummer_til_område = 38
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                connection.Query<Ressurs>($"delete FROM [dbo].[Punkter_område] WHERE(Løpenummer_til_område = '{løpenummer}')");
            }
        }
        public static void DeleteOmråde(int løpeNummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Område DeleteOmråde = new Område
                {
                    Løpenummer_område = løpeNummer
                };

                connection.Execute("[dbo].[PROCEDURERemoveOmråde] @Løpenummer_område", (DeleteOmråde));
            }
        }

        public static void InsertRessursToDb(int Løpenummer_ressurs,string navn, string kategori, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Ressurs ressursToAdd = new Ressurs {
                    Løpenummer_ressurs = Løpenummer_ressurs,
                    Navn = navn,
                    Kategori = kategori,
                    //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                    Opprettet_av_bruker = opprettet_av_bruker,
                    Sikkerhetsklarering = sikkerhetsklarering,
                    Kommentar = kommentar,
                    Lat = lat,
                    Lang = lang
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoRessurs] @Løpenummer_ressurs, @Navn, @Kategori, @Opprettet_av_bruker, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang", ressursToAdd);
            }
        }

        public static void InsertOmrådeToDb(int løpenummer,string navn, string kategori, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, string farge)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
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

        public static void InsertPunkter_områdetToDb(int løpenummer, float lat, float lang, int rekkefølge)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Punkter_område punktToAdd = new Punkter_område
                {
                    Løpenummer_til_område = løpenummer,
                    Rekkefølge_punkter = rekkefølge,
                    Lat = lat,
                    Lang = lang
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoPunkter_område] @Løpenummer_til_område, @Rekkefølge_punkter, @Lat, @Lang", punktToAdd);
            }
        }
        public static List<int> GetLøpenummer_område()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<int>($"select (NEXT VALUE FOR [dbo].[SEQUENCEOmrådeId]) as int").ToList();
                return output;
            }
        }

        public static List<int> GetLøpenummer_Ressurs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<int>($"select (NEXT VALUE FOR [dbo].[SEQUENCERessursId]) as int").ToList();
                return output;
            }
        }

        public static void LogFeil(string klasse,string Metode, string feilmelding)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                log_feil ErrorToLog = new log_feil
                {
                    klasse = klasse,
                    Metode = Metode,
                    Feilmelding = feilmelding,
                    //Dato = "CURRENT_TIMESTAMP", ordnes av Procedure
                };

                connection.Execute("[dbo].[PROCEDURELoggFeil] @klasse,@Metode, @feilmelding", ErrorToLog);
            }
        }

        //public static void InsertOmrådeToDb(string navn, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, string farge, List<PointLatLng> punkter)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
        //    {
        //        DataTable dt_Punkter_område = new DataTable();
        //        dt_Punkter_område.Columns.Add(nameof(Punkter_område.Løpenummer_til_område), typeof(int));
        //        dt_Punkter_område.Columns.Add(nameof(Punkter_område.Rekkefølge_punkter), typeof(int));
        //        dt_Punkter_område.Columns.Add(nameof(Punkter_område.Lat), typeof(float));
        //        dt_Punkter_område.Columns.Add(nameof(Punkter_område.Lang), typeof(float));

        //        int i = 0;
        //        foreach (var item in punkter)
        //        {
        //            var row = dt_Punkter_område.NewRow();
        //            // row[nameof(Punkter_område.Løpenummer_til_område)] = "Håndteres av procedure+sequence";
        //            row[nameof(Punkter_område.Rekkefølge_punkter)] = i;
        //            i++;
        //            row[nameof(Punkter_område.Lat)] = item.Lat;
        //            row[nameof(Punkter_område.Lang)] = item.Lng;
        //            dt_Punkter_område.Rows.Add(row);
        //        }

        //        områdeToAdd områdeToAdd = new områdeToAdd
        //        {
        //            Navn = navn,
        //            Opprettet_av_bruker = opprettet_av_bruker,
        //            Kommentar = kommentar,
        //            Sikkerhetsklarering = sikkerhetsklarering,
        //            Farge = farge,
        //            TVP_Punkter_område = dt_Punkter_område
        //        };
        //        //connection.Execute("[dbo].[PROCEDUREinsertIntoOmråde] @Navn, @Opprettet_av_bruker, @Sikkerhetsklarering, @Kommentar, @Farge", områdeToAdd);
        //        connection.Execute("[dbo].[PROCEDUREinsertIntoOmrådeANDPunkter_område]", områdeToAdd);



        //        //List<PointLatLng> pointsLatLngToAdd = new List<PointLatLng>(punkter);
        //        //for (int i = 0; i < punkter.Count; i++)
        //        //{
        //        //    Lat = punkter[i].Lat;
        //        //    Lang = punkter[i].Lang;
        //        //}
        //        //connection.Execute("[dbo].[PROCEDUREinsertIntoPunkter_område] @Rekkefølge_punkter, @Lat, @Lang", områdeToAdd);
        //    }
        //}

        public static void InsertBrukerToDb(string fornavn, string etternavn, int telefonnummer, string epost, string passord, int tallkode)
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

        public static void InsertKategorier_BildeToDb(string kategorinavn)
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

        public static void InsertTag_RessursToDb(string Tag, int løpenummer_Til_ressurs)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
            {
                Tag_Ressurs Tag_RessursKategoriToAdd = new Tag_Ressurs
                {
                    Tag = Tag
                    //Bilde = NULL, ordnes av Procedure
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoKategorier_Bilde] @Kategorinavn", Tag_RessursKategoriToAdd);
            }
        }

        public static void InsertBildeToChosenKategorier_BildeToDb(string kategorinavn, byte[] imageData)
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
        public static void UpdateBruker_Godkjent(string epost, bool godkjent)
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
        public static void UpdateBruker_Verifisert(string epost, bool godkjent)
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
        public static void UpdateBruker_Sikkerhetsklarering(string epost, int klarering)
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

        public static void UpdateRessurs(int Løpenummer, string navn, string kategori, int sikkerhetsklarering, string kommentar, float lat, float lang)
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
        public static void UpdateOmråde(int løpenummer, string navn, int sikkerhetsklarering, string kommentar, string farge)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
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

        public static List<Kategorier_Bilde> GetBildeForKategoriFromDbKategorier_Bilde(string kategorinavn)
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
