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

        



        public List<Bruker> ListAllBrukerFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("GMAP_Demo.Properties.Settings.bo22eb16ConnectionString")))
            {
                var output = connection.Query<Bruker>("[dbo].[PROCEDUREListAllBrukerFromDb]").ToList();
                return output;
            }
        }
        public List<Kategorier_Bilde> ListAllKategorier_BildeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("GMAP_Demo.Properties.Settings.bo22eb16ConnectionString")))
            {
                var output = connection.Query<Kategorier_Bilde>("[dbo].[PROCEDUREListAllKategorier_BildeFromDb]").ToList();
                return output;
            }
        }
        public List<Måling> ListAllMålingFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("GMAP_Demo.Properties.Settings.bo22eb16ConnectionString")))
            {
                var output = connection.Query<Måling>("[dbo].[PROCEDUREListAllMålingFromDb]").ToList();
                return output;
            }
        }
        public List<Område> ListAllOmrådeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("GMAP_Demo.Properties.Settings.bo22eb16ConnectionString")))
            {
                var output = connection.Query<Område>("[dbo].[PROCEDUREListAllOmrådeFromDb]").ToList();
                return output;
            }
        }
        public List<Overlay_Område> ListAllOverlay_OmrådeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("GMAP_Demo.Properties.Settings.bo22eb16ConnectionString")))
            {
                var output = connection.Query<Overlay_Område>("[dbo].[PROCEDUREListAllOverlay_OmrådeFromDb]").ToList();
                return output;
            }
        }
        public List<Overlay_Ressurs> ListAllOverlay_RessursFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("GMAP_Demo.Properties.Settings.bo22eb16ConnectionString")))
            {
                var output = connection.Query<Overlay_Ressurs>("[dbo].[PROCEDUREListAllOverlay_RessursFromDb]").ToList();
                return output;
            }
        }
        public List<Punkter_område> ListAllPunkter_områdeFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("GMAP_Demo.Properties.Settings.bo22eb16ConnectionString")))
            {
                var output = connection.Query<Punkter_område>("[dbo].[PROCEDUREListAllPunkter_områdeFromDb]").ToList();
                return output;
            }
        }
        public List<Ressurs> ListAllRessursFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("GMAP_Demo.Properties.Settings.bo22eb16ConnectionString")))
            {
                var output = connection.Query<Ressurs>("[dbo].[PROCEDUREListAllRessursFromDb]").ToList();
                return output;
            }
        }





    }
}
