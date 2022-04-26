using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComRessurs
    {
        public static List<Ressurs> ListAllRessursFromDb(int SikkerhetsklareringBruker)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                //Ressurs Sikkerhetsklarering = new Ressurs
                //{
                //    Sikkerhetsklarering = SikkerhetsklareringBruker
                //};

                //var output = connection.Query<Ressurs>("[dbo].[PROCEDUREListAllRessursFromDb] @BrukersSikkerhetsklarering", Sikkerhetsklarering).ToList();
                var output = connection.Query<Ressurs>($"SELECT * FROM[dbo].[Ressurs] WHERE (Sikkerhetsklarering <= '{SikkerhetsklareringBruker}')").ToList();
               
                return output;
            }
        }
        //Where Sikkerhetsklarering <= '{InnloggetBruker.Sikkerhetsklarering}'
        public static List<Ressurs> ListRessursFromDb(int løpenummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Ressurs>($"SELECT * FROM[dbo].[Ressurs] WHERE(Løpenummer_ressurs = '{løpenummer}' AND Sikkerhetsklarering <= '{InnloggetBruker.Sikkerhetsklarering}')").ToList();
                return output;
            }
        }

        public static List<Ressurs> ListRessursBasedonKategori(string Kategori)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Ressurs>($"SELECT * FROM[dbo].[Ressurs] WHERE(Kategori = '{Kategori}' AND Sikkerhetsklarering <= '{InnloggetBruker.Sikkerhetsklarering}')").ToList();
                return output;
            }
        }

        public static void DeleteRessurs(int løpeNummer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                Ressurs DeleteRessurs = new Ressurs
                {
                    Løpenummer_ressurs = løpeNummer
                };

                connection.Execute("[dbo].[PROCEDURERemoveRessurs] @Løpenummer_ressurs", (DeleteRessurs));
            }
        }

        public static void InsertRessursToDb(int Løpenummer_ressurs, string navn, string kategori, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                Ressurs ressursToAdd = new Ressurs
                {
                    Løpenummer_ressurs = Løpenummer_ressurs,
                    Navn = navn,
                    Kategori = kategori,
                    //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                    Opprettet_av_bruker = opprettet_av_bruker,
                    Sikkerhetsklarering = sikkerhetsklarering,
                    Kommentar = kommentar,
                    Lat = lat,
                    Lang = lang,
                };

                connection.Execute("[dbo].[PROCEDUREinsertIntoRessurs] @Løpenummer_ressurs, @Navn, @Kategori, @Opprettet_av_bruker, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang", (ressursToAdd));
            }
        }

        public static List<int> GetLøpenummer_Ressurs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<int>($"select (NEXT VALUE FOR [dbo].[SEQUENCERessursId]) as int").ToList();
                return output;
            }
        }

        public static void UpdateRessurs(int Løpenummer, string navn, string kategori, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
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
                int brukersSikkerhetsklarering = InnloggetBruker.Sikkerhetsklarering;

                connection.Execute("[dbo].[PROCEDUREUpdateRessurs] @Løpenummer_ressurs, @Navn, @Kategori, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang, @BrukersSikkerhetsklarering", (UpdateRessurs, brukersSikkerhetsklarering));

            }
        }
    }
}
