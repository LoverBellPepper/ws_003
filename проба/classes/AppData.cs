using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проба.classes
{
    internal class AppData
    {
        SqlConnection connection = new SqlConnection(@"Data Source = WIN-SK9CJGKLOID; Initial Catalog = Trade; Integrated Security = True");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
