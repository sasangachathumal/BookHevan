using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.database
{
    // Singleton class for database connection
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private MySqlConnection _connection;
        private string connectionString;

        // Constructor
        private DatabaseConnection()
        {
            string server = "localhost";
            string port = "3307";
            string database = "bookhaven";
            string username = "root";
            string password = "";

            connectionString = $"Server={server};Port ={port};Database={database};User ID={username};Password={password};SslMode=none;";
            _connection = new MySqlConnection(connectionString);
        }

        // Singleton instance
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

        /**
         * Return connection to database
         */
        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
