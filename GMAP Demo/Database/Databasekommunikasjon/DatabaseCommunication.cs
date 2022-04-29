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

        public static void FeilmeldingFikkIkkeKontaktMedDatabasen(Exception exception)
        {
            System.Windows.Forms.DialogResult messageBoxResult = System.Windows.Forms.MessageBox.Show("Det oppstod et problem og programmet fikk ikke kontakt med databasen. Vennligst sjekk tilkoblingen og prøv på nytt. \nSom følge av feilen kan programmet krasje, dersom det skjer, vennligst start programmet på nytt og prøv igjen. \nDersom du ønsker mer teknisk informasjon om feilen, trykk \"OK\"", "Fikk ikke kontakt med databasen.", System.Windows.Forms.MessageBoxButtons.OKCancel);
            if (messageBoxResult == System.Windows.Forms.DialogResult.OK)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }
        }

    }
}
