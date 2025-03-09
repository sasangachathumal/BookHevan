using BookHevan.database;
using BookHevan.Helper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookHevan.Model
{
    internal class Customer
    {
        // Database connection
        private static MySqlConnection connection = DatabaseConnection.Instance.GetConnection();
        public int id { get; set; }
        public string ?email { get; set; }
        public string name { get; set; }
        public string phoneNo { get; set; }
        public string ?address { get; set; }

        public Customer(int id, string name, string phoneNo, string ?address, string? email)
        {
            this.id = id;
            this.email = email;
            this.name = name;
            this.phoneNo = phoneNo;
            this.address = address;
        }
        public Customer(string name, string phoneNo, string? address, string? email)
        {
            this.email = email;
            this.name = name;
            this.phoneNo = phoneNo;
            this.address = address;
        }

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer() { }

        /*
         * This method will save the customer data in the database and return a boolean based of result.
         * @return
         *  - true: if customer succesfuly saved in DB.
         *  - false: if save process had any issues or customer data not provided.
        */
        public bool create()
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNo))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "INSERT INTO customer (email, name, phoneNo, address)" +
                    " VALUES (@email, @name, @phoneNo, @address)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@address", address);

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
         * This method will update the customer data in the database and return a boolean based of result.
         * @return
         *  - true: if customer succesfuly updated in DB.
         *  - false: if update process had any issues or customer data not provided.
        */
        public bool update()
        {
            if ((id == 0) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNo))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "UPDATE customer SET email = @email, " +
                    "name = @name, phoneNo = @phoneNo, address = @address " +
                    "WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@address", address);
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
         * This method will delete the customer data in the database and return a boolean based of result.
         * @return
         *  - true: if customer succesfuly deleted in DB.
         *  - false: if delete process had any issues or customer id not provided.
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
                string query = "DELETE FROM customer WHERE id=@id";

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
         * This method will search customer by the id in the database and return a customer object with data if customer found.
         * @return
         *  - customer object with data: if customer succesfuly found in DB.
         *  - customer object without data: if update search had any issues or customer id not provided.
        */
        public static Customer searchById(int userId)
        {
            Customer customer = new Customer();

            if (userId <= 0) { return customer; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM customer WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            customer.id = reader.GetInt32(0);
                            customer.email = reader.GetString(1);
                            customer.name = reader.GetString(2);
                            customer.phoneNo = reader.GetString(3);
                            customer.address = reader.GetString(4);
                            connection.Close();
                            return customer;
                        }
                        else
                        {
                            connection.Close();
                            return customer;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return customer;
            }
        }

        public static Customer searchByName(string name)
        {
            Customer customer = new Customer();

            if (name == null) { return customer; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM customer WHERE name=@name";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            customer.id = reader.GetInt32(0);
                            customer.email = reader.GetString(1);
                            customer.name = reader.GetString(2);
                            customer.phoneNo = reader.GetString(3);
                            customer.address = reader.GetString(4);
                            connection.Close();
                            return customer;
                        }
                        else
                        {
                            connection.Close();
                            return customer;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return customer;
            }
        }

        /*
         * This method return a data table object with customer.
         * @return
         *  - data table object with data: if user succesfuly found in DB.
         *  - data table object without data: if had any issues or customers not available.
        */
        public static DataTable getCustomersForDataTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                string query = "SELECT id as 'Customer ID', email, name, phoneNo, address FROM customer";

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
         * This method return a data table object with customers based on provided name.
         * @return
         *  - data table object with data: if customers succesfuly found in DB.
         *  - data table object without data: if had any issues or customers not available.
        */
        public static DataTable searchByCustomerNameForDataTable(string name)
        {
            DataTable dataTable = new DataTable();

            if (name == null) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT id as 'Customer ID', email, name, phoneNo, address FROM customer WHERE name LIKE @name";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");

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
