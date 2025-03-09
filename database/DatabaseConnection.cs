using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.database
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private MySqlConnection _connection;
        private string connectionString;

        private DatabaseConnection()
        {
            string server = "localhost";
            string database = "bookhaven";
            string username = "root";
            string password = "";

            connectionString = $"Server={server};Database={database};User ID={username};Password={password};SslMode=none;";
            _connection = new MySqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
