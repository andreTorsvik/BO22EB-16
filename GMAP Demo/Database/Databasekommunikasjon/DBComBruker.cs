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
            catch (Exception)
            {
                //melding
                List<Bruker> list = new List<Bruker>();
                return list;
            }
        }

        public static List<Bruker> ListAllBrukerFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Bruker>("[dbo].[PROCEDUREListAllBrukerFromDb]").ToList();
                return output;
            }
        }

        public static List<Bruker> ListBrukerInfoFromDb(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Bruker>($"SELECT * FROM [dbo].[Bruker] WHERE (Epost = '{username}')").ToList();
                return output;
            }
        }

        public static void InsertBrukerToDb(string fornavn, string etternavn, int telefonnummer, string epost, string passord, int tallkode)
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

        public static void UpdateBruker_Godkjent(string epost, bool godkjent)
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
        public static void UpdateBruker_Verifisert(string epost, bool godkjent)
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
        public static void UpdateBruker_Sikkerhetsklarering(string epost, int klarering)
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


        public static void DeleteBruker(string username)
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
    }
}
