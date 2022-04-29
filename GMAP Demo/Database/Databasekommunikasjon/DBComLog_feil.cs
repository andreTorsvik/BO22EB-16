using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComLog_feil
    {
        public static void LogFeil(string klasse, string Metode, string feilmelding)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
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
            catch (Exception exeption)
            {
                DatabaseCommunication.FeilmeldingFikkIkkeKontaktMedDatabasen(exeption);
            }
        }

    }
}
