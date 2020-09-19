using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace DevExtremeAspNetCoreApp2.db {
    public class DB
    {
        private static DB instance;
        private string connectionString;
        SqlConnection connection;

        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            private set
            {
                connectionString = value;
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return connection;
            }
            private set
            {
                connection = value;
            }
        }

        private DB()
        {
            ConnectionString = @"Data Source=IVAN-PC\SQLEXPRESS; Initial Catalog=turnir2020; User=sa; Password=zakanje123";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }
    }
}
