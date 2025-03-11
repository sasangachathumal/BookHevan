using BookHevan.database;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.Model
{
    internal class Supplier
    {
        // Database connection
        private static MySqlConnection connection = DatabaseConnection.Instance.GetConnection();
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNo { get; set; }
        public string address { get; set; }

        public Supplier(int id, string name, string email, string phoneNo, string address)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phoneNo = phoneNo;
            this.address = address;
        }
        public Supplier(string name, string email, string phoneNo, string address)
        {
            this.name = name;
            this.email = email;
            this.phoneNo = phoneNo;
            this.address = address;
        }
        public Supplier(int id)
        {
            this.id = id;
        }
        public Supplier() { }

        /*
         * This method will save the supplier data in the database and return a boolean based of result.
         * @return
         *  - true: if supplier succesfuly saved in DB.
         *  - false: if save process had any issues or supplier data not provided.
        */
        public bool create()
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNo) ||
                string.IsNullOrEmpty(address))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "INSERT INTO supplier (name, email, phoneNo, address)" +
                    " VALUES (@name, @email, @phoneNo, @address)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
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
         * This method will update the supplier data in the database and return a boolean based of result.
         * @return
         *  - true: if supplier succesfuly updated in DB.
         *  - false: if update process had any issues or supplier data not provided.
        */
        public bool update()
        {
            if (!int.IsPositive(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNo) ||
                string.IsNullOrEmpty(address))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "UPDATE supplier SET name = @name, " +
                    "email = @email, phoneNo = @phoneNo, address = @address " +
                    "WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
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
         * This method will delete the supplier data in the database and return a boolean based of result.
         * @return
         *  - true: if supplier succesfuly deleted in DB.
         *  - false: if delete process had any issues or supplier id not provided.
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
                string query = "DELETE FROM supplier WHERE id=@id";

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
         * This method will search supplier by the id in the database and return a supplier object with data if supplier found.
         * @return
         *  - supplier object with data: if supplier succesfuly found in DB.
         *  - supplier object without data: if update search had any issues or supplier id not provided.
        */
        public static Supplier searchById(int supplierId)
        {
            Supplier supplier = new Supplier();

            if (supplierId <= 0) { return supplier; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM supplier WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", supplierId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            supplier.id = reader.GetInt32(0);
                            supplier.name = reader.GetString(1);
                            supplier.email = reader.GetString(2);
                            supplier.phoneNo = reader.GetString(3);
                            supplier.address = reader.GetString(4);
                            connection.Close();
                            return supplier;
                        }
                        else
                        {
                            connection.Close();
                            return supplier;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return supplier;
            }
        }

        /*
         * This method will search supplier by the name in the database and return a supplier object with data if supplier found.
         * @return
         *  - supplier object with data: if supplier succesfuly found in DB.
         *  - supplier object without data: if update search had any issues or supplier name not provided.
        */
        public static Supplier searchByName(string supplierName)
        {
            Supplier supplier = new Supplier();

            if (string.IsNullOrEmpty(supplierName)) { return supplier; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM supplier WHERE name=@name";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", supplierName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            supplier.id = reader.GetInt32(0);
                            supplier.name = reader.GetString(1);
                            supplier.email = reader.GetString(2);
                            supplier.phoneNo = reader.GetString(3);
                            supplier.address = reader.GetString(4);
                            connection.Close();
                            return supplier;
                        }
                        else
                        {
                            connection.Close();
                            return supplier;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return supplier;
            }
        }

        /*
         * This method return a data table object with suppliers.
         * @return
         *  - data table object with data: if user succesfuly found in DB.
         *  - data table object without data: if had any issues or suppliers not available.
        */
        public static DataTable getSupplierForDataTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                string query = "SELECT id as 'Supplier ID', name, email, phoneNo, address FROM supplier";

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
         * This method return a data table object with suppliers based on provided name.
         * search will be based on like query on name.
         * @return
         *  - data table object with data: if suppliers succesfuly found in DB.
         *  - data table object without data: if had any issues or suppliers not available.
        */
        public static DataTable searchByNameForDataTable(string name)
        {
            DataTable dataTable = new DataTable();

            if (name == null) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT id as 'Supplier ID', name, email, phoneNo, address FROM supplier" +
                    " WHERE name LIKE @name";

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
