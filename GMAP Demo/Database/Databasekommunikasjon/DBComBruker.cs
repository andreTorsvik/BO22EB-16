using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComBruker
    {
        public static List<Bruker> CheckLoginAgainstDb(string Username, string Password)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Bruker>($"SELECT* FROM [dbo].[Bruker] WHERE ( (Epost = '{Username}') AND (Passord = '{Password}') )").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Bruker> list = new List<Bruker>();
                return list;
            }
        }

        public static List<Bruker> ListAllBrukerFromDb()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Bruker>("[dbo].[PROCEDUREListAllBrukerFromDb]").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Bruker> list = new List<Bruker>();
                return list;
            }

        }

        public static List<Bruker> ListAllBrukerFromDbWithMaksSikkerhetsklarering(int Sikkerhetsklarering)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Bruker>($"SELECT * FROM [dbo].[Bruker] WHERE (Sikkerhetsklarering = '{Sikkerhetsklarering}')").ToList();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                List<Bruker> list = new List<Bruker>();
                return list;
            }

        }

        public static Bruker ListBrukerInfoFromDb(string username)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    var output = connection.Query<Bruker>($"SELECT * FROM [dbo].[Bruker] WHERE (Epost = '{username}')").FirstOrDefault();
                    return output;
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
                Bruker bruker = new Bruker();
                return bruker;
            }
        }

        public static void InsertBrukerToDb(string fornavn, string etternavn, int telefonnummer, string epost, string passord, int tallkode)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
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
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void UpdateBruker_Godkjent(string epost, bool godkjent)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Bruker UpdateGodkjent = new Bruker
                    {
                        Epost = epost,
                        Godkjent = godkjent
                    };

                    connection.Execute("[dbo].[PROCEDUREUpdateBruker_godkjent] @Epost, @Godkjent", (UpdateGodkjent));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void UpdateBruker_Verifisert(string epost, bool godkjent)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Bruker UpdateVerifisert = new Bruker
                    {
                        Epost = epost,
                        Verifisert = godkjent
                    };

                    connection.Execute("[dbo].[PROCEDUREUpdateBruker_Verifisert] @Epost, @Verifisert", (UpdateVerifisert));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void UpdateBruker_Sikkerhetsklarering(string epost, int klarering)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Bruker UpdateSikkerhetsklarering = new Bruker
                    {
                        Epost = epost,
                        Sikkerhetsklarering = klarering
                    };

                    connection.Execute("[dbo].[PROCEDUREUpgradeBruker_Sikkerhetsklarering] @Epost, @Sikkerhetsklarering", (UpdateSikkerhetsklarering));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

        public static void DeleteBruker(string username)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
                {
                    Bruker DeleteUser = new Bruker
                    {
                        Epost = username
                    };

                    connection.Execute("[dbo].[PROCEDURERemoveBruker] @Epost", (DeleteUser));
                }
            }
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }
    }
}
