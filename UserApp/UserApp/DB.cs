using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp
{
    internal class DB
    {
        public static string connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";
        SqlConnection connection = new SqlConnection(connectionString);

        public SqlConnection getConnection
        {
            get
            {
                return connection;
            }
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }
    }
}

