using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace GMAP_Demo
{
    internal class DBComMåling
    {
        public static List<Måling> ListAllMålingFromDb()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseCommunication.CnnVal(DatabaseCommunication.bo22eb16DatabasePathUrlLocation)))
            {
                var output = connection.Query<Måling>("[dbo].[PROCEDUREListAllMålingFromDb]").ToList();
                return output;
            }
        }



    }
}
