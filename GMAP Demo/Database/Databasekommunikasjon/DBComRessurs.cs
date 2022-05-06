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
        public static List<Objekt> ListAllRessursFromDb(int SikkerhetsklareringBruker)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    //Ressurs Sikkerhetsklarering = new Ressurs
                    //{
                    //    Sikkerhetsklarering = SikkerhetsklareringBruker
                    //};

                    //var output = connection.Query<Ressurs>("[dbo].[PROCEDUREListAllRessursFromDb] @BrukersSikkerhetsklarering", Sikkerhetsklarering).ToList();
                    var output = connection.Query<Objekt>($"SELECT * FROM[dbo].[Ressurs] WHERE (Sikkerhetsklarering <= '{SikkerhetsklareringBruker}')").ToList();

                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Objekt> list = new List<Objekt>();
                return list;
            }
        }
        //Where Sikkerhetsklarering <= '{InnloggetBruker.Sikkerhetsklarering}'
        public static Objekt RessursFromDb(int løpenummer)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Objekt>($"SELECT * FROM[dbo].[Ressurs] WHERE(Løpenummer_ressurs = '{løpenummer}' AND Sikkerhetsklarering <= '{InnloggetBruker.Sikkerhetsklarering}')").FirstOrDefault();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                Objekt ressurs = new Objekt();
                return ressurs;
            }
        }

        public static List<Objekt> ListRessursBasedonKategori(string Kategori)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Objekt>($"SELECT * FROM[dbo].[Ressurs] WHERE(Kategori = '{Kategori}')").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Objekt> list = new List<Objekt>();
                return list;
            }
        }

        public static void DeleteRessurs(int løpeNummer)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Objekt DeleteRessurs = new Objekt
                    {
                        Id_ressurs = løpeNummer
                    };

                    connection.Execute("[dbo].[PROCEDURERemoveRessurs] @Løpenummer_ressurs", (DeleteRessurs));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void InsertRessursToDb(int Løpenummer_ressurs, string navn, string kategori, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Objekt ressursToAdd = new Objekt
                    {
                        Id_ressurs = Løpenummer_ressurs,
                        Navn = navn,
                        Kategori = kategori,
                        //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                        Opprettet_av_bruker = opprettet_av_bruker,
                        Sikkerhetsklarering = sikkerhetsklarering,
                        Kommentar = kommentar,
                        Lat = lat,
                        Lang = lang
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoRessurs] @Løpenummer_ressurs, @Navn, @Kategori, @Opprettet_av_bruker, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang", (ressursToAdd));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static List<int> GetLøpenummer_Ressurs()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<int>($"select (NEXT VALUE FOR [dbo].[SEQUENCERessursId]) as int").ToList();
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

        public static void UpdateRessurs(int Løpenummer, string navn, string kategori, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Objekt UpdateRessurs = new Objekt
                    {
                        Id_ressurs = Løpenummer,
                        Navn = navn,
                        Kategori = kategori,
                        //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                        //Opprettet_av_bruker = opprettet_av_bruker,
                        Sikkerhetsklarering = sikkerhetsklarering,
                        Kommentar = kommentar,
                        Lat = lat,
                        Lang = lang
                    };

                    connection.Execute("[dbo].[PROCEDUREUpdateRessurs] @Løpenummer_ressurs, @Navn, @Kategori, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang", (UpdateRessurs));

                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
