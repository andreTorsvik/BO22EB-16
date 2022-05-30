using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace BO22EB16
{
    internal class DBComObjekt
    {

        public static List<Objekt> ListAllObjektFromDb(int SikkerhetsklareringBruker)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Objekt>($"SELECT * FROM[dbo].[Objekt] WHERE (Sikkerhetsklarering <= '{SikkerhetsklareringBruker}')").ToList();
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

        public static Objekt ObjektFromDb(int idObjekt)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Objekt>($"SELECT * FROM[dbo].[Objekt] WHERE(idObjekt = '{idObjekt}' AND Sikkerhetsklarering <= '{InnloggetBruker.Sikkerhetsklarering}')").FirstOrDefault();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                Objekt Objekt = new Objekt();
                return Objekt;
            }
        }

        public static List<Objekt> ListObjektBasedOnKategori(string Kategori)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Objekt>($"SELECT * FROM[dbo].[Objekt] WHERE(Kategori = '{Kategori}')").ToList();
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

        public static void DeleteObjekt(int idObjekt)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Objekt deleteObjekt = new Objekt
                    {
                        IdObjekt = idObjekt
                    };

                    connection.Execute("[dbo].[PROCEDURERemoveObjekt] @IdObjekt", (deleteObjekt));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void InsertObjektToDb(int idObjekt, string navn, string kategori, string opprettet_av_bruker, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Objekt objektToAdd = new Objekt
                    {
                        IdObjekt = idObjekt,
                        Navn = navn,
                        Kategori = kategori,
                        //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                        Opprettet_av_bruker = opprettet_av_bruker,
                        Sikkerhetsklarering = sikkerhetsklarering,
                        Kommentar = kommentar,
                        Lat = lat,
                        Lang = lang
                    };

                    connection.Execute("[dbo].[PROCEDUREinsertIntoObjekt] @IdObjekt, @Navn, @Kategori, @Opprettet_av_bruker, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang", (objektToAdd));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static List<int> GetIdObjekt()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<int>($"select (NEXT VALUE FOR [dbo].[SEQUENCEObjektId]) as int").ToList();
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

        public static void UpdateObjekt(int idObjekt, string navn, string kategori, int sikkerhetsklarering, string kommentar, float lat, float lang)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Objekt updateObjekt = new Objekt
                    {
                        IdObjekt = idObjekt,
                        Navn = navn,
                        Kategori = kategori,
                        //Dato_opprettet = "CURRENT_TIMESTAMP", ordnes av Procedure
                        //Opprettet_av_bruker = opprettet_av_bruker,
                        Sikkerhetsklarering = sikkerhetsklarering,
                        Kommentar = kommentar,
                        Lat = lat,
                        Lang = lang
                    };

                    connection.Execute("[dbo].[PROCEDUREUpdateObjekt] @IdObjekt, @Navn, @Kategori, @Sikkerhetsklarering, @Kommentar, @Lat, @Lang", (updateObjekt));

                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
