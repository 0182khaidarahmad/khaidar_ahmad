using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Database
    {
        private static string connectionString = @"Data Source=LAPTOP-K7S62OP5;Initial Catalog=DB_Tanaman;TrustServerCertificate=True;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
