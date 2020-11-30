using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operose.ServicesLib
{
    public class DatabaseService
    {
        public static SqlConnection DbConnection(string connString)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            return con;
        }
    }
}
