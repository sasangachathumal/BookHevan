using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BookHevan.database;
using MySqlConnector;
using System.Xml.Linq;
using BookHevan.Helper;
using System.Data;

namespace BookHevan.Model
{
    internal class User
    {
        // Database connection
        private static MySqlConnection connection = DatabaseConnection.Instance.GetConnection();
        // User properties
        public int id { get; set; }
        public string fullName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phoneNo { get; set; }
        public string type { get; set; }

        public User(int id, string fullName, string username, string password, string phoneNo, string type)
        {
            this.id = id;
            this.fullName = fullName;
            this.username = username;
            this.password = password;
            this.phoneNo = phoneNo;
            this.type = type;
        }
        public User(string fullName, string username, string password, string phoneNo, string type)
        {
            this.fullName = fullName;
            this.username = username;
            this.password = password;
            this.phoneNo = phoneNo;
            this.type = type;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User(int id)
        {
            this.id = id;
        }
        public User(string username)
        {
            this.username = username;
        }
        public User() { }

        /*
         * This method will save the user data in the database and return a boolean based of result.
         * @return
         *  - true: if user succesfuly saved in DB.
         *  - false: if save process had any issues or user data not provided.
        */
        public bool create()
        {
            if ((fullName == null) || (username == null) || (password == null) || (phoneNo == null) || (type == null))
            {
                return false;
            }
            try 
            {
                connection.Open();
                string query = "INSERT INTO users (fullName, username, password, phoneNo, type)" + 
                    " VALUES (@fullName, @username, @password, @phoneNo, @type)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    string hashedPassword = PasswordSecurity.HashPassword(password);

                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@type", type);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return false;
            }
        }

        /*
         * This method will update the user data in the database and return a boolean based of result.
         * @return
         *  - true: if user succesfuly updated in DB.
         *  - false: if update process had any issues or user data not provided.
        */
        public bool update()
        {
            if ((id == 0) || (fullName == null) || (username == null) || (phoneNo == null) || (type == null))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "UPDATE users SET fullName = @fullName, " +
                    "username = @username, phoneNo = @phoneNo, type = @type " + 
                    "WHERE id = @id";
                string hashedPassword = "";

                if (!string.IsNullOrEmpty(password))
                {
                    query = "UPDATE users SET fullName = @fullName, " +
                    "username = @username, password = @password, phoneNo = @phoneNo, type = @type " +
                    "WHERE id = @id";
                    hashedPassword = PasswordSecurity.HashPassword(password);
                }

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@username", username);

                    if (!string.IsNullOrEmpty(hashedPassword))
                    {
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                    }

                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return false;
            }
        }

        /*
         * This method will delete the user data in the database and return a boolean based of result.
         * @return
         *  - true: if user succesfuly deleted in DB.
         *  - false: if delete process had any issues or user id not provided.
        */
        public bool delete()
        {
            if (id == 0)
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "DELETE FROM users WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return false;
            }
        }

        /*
         * This method will search user by the id in the database and return a user object with data if user found.
         * @return
         *  - user object with data: if user succesfuly found in DB.
         *  - user object without data: if update search had any issues or user id not provided.
        */
        public static User searchById(int userId) 
        {
            User user = new User();

            if (userId <= 0) { return user; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM users WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            user.id = reader.GetInt32(0);
                            user.fullName = reader.GetString(1);
                            user.username = reader.GetString(2);
                            user.password = reader.GetString(3);
                            user.phoneNo = reader.GetString(4);
                            user.type = reader.GetString(5);
                            connection.Close();
                            return user;
                        }
                        else
                        {
                            connection.Close();
                            return user;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return user;
            }
        }

        /*
         * This method will search user by the username in the database and return a user object with data if user found.
         * @return
         *  - user object with data: if user succesfuly found in DB.
         *  - user object without data: if update search had any issues or username not provided.
        */
        public static User searchByUsername(string username)
        {
            User user = new User();

            if (username == null) { return user; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM users WHERE username LIKE @username";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", "%"+username+"%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            user.id = reader.GetInt32(0);
                            user.fullName = reader.GetString(1);
                            user.username = reader.GetString(2);
                            user.password = reader.GetString(3);
                            user.phoneNo = reader.GetString(4);
                            user.type = reader.GetString(5);
                            connection.Close();
                            return user;
                        }
                        else
                        {
                            connection.Close();
                            return user;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return user;
            }
        }

        /*
         * This method return a data table object with users.
         * @return
         *  - data table object with data: if user succesfuly found in DB.
         *  - data table object without data: if had any issues or users not available.
        */
        public static DataTable getUsersForDataTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                string query = "SELECT id as 'User ID', fullName, username, phoneNo, type FROM users";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                        connection.Close();
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return dataTable;
            }
        }

        /*
         * This method return a data table object with users based on provided username.
         * search will be based on LIKE operator on username.
         * @return
         *  - data table object with data: if users succesfuly found in DB.
         *  - data table object without data: if had any issues or users not available.
        */
        public static DataTable searchByUsernameForDataTable(string username)
        {
            DataTable dataTable = new DataTable();

            if (username == null) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT id as 'User ID', fullName, username, phoneNo, type FROM users WHERE username LIKE @username";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", "%" + username + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                        connection.Close();
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return dataTable;
            }
        }
    }
}
