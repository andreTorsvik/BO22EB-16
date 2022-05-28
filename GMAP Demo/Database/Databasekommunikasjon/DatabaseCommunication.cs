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
        public static string bo22eb16DatabasePathUrlLocation = "GMAP_Demo.Properties.Settings.bo22eb16ConnectionString";

        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static void FeilmeldingFikkIkkeKontaktMedDatabasen(Exception exception)
        {
            System.Windows.Forms.DialogResult messageBoxResult = System.Windows.Forms.MessageBox.Show("Det oppstod et problem og programmet fikk ikke kontakt med databasen. Vennligst sjekk tilkoblingen. \nProgrammet avsluttes da det ikke kan brukes uten tilkobling til databasen. \n\nØnsker du å se den tekniske feilmeldingen til programmet?", "Fikk ikke kontakt med databasen.", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (messageBoxResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }
            System.Environment.Exit(1); // Dersom programmet ikke får kontakt med databasen avsluttes programmet etter vist feilmelding.
        }

        public static bool IsServerConnected()
        {
                using (IDbConnection connection = new SqlConnection(CnnVal(bo22eb16DatabasePathUrlLocation)))
                {
                    try
                    {
                        connection.Open();
                        return true;
                    }
                    catch (SqlException e)
                    {
                        FeilmeldingFikkIkkeKontaktMedDatabasen(e);
                        return false;
                    }
                }        
        }
    }
}
