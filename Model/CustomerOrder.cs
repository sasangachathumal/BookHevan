using BookHevan.database;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace BookHevan.Model
{
    internal class CustomerOrder
    {
        // Database connection
        private static MySqlConnection connection = DatabaseConnection.Instance.GetConnection();
        public int id { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string date { get; set; }
        public decimal amount { get; set; }
        public int discount { get; set; }
        public int noOfItems { get; set; }
        public string type { get; set; }

        public CustomerOrder(int id, int customerId, int userId, string date, decimal amount, string type, int noOfItems, int discount)
        {
            this.id = id;
            this.customerId = customerId;
            this.userId = userId;
            this.date = date;
            this.amount = amount;
            this.type = type;
            this.noOfItems = noOfItems;
            this.discount = discount;
        }

        public CustomerOrder(int customerId, int userId, string date, decimal amount, string type, int noOfItems, int discount)
        {
            this.customerId = customerId;
            this.userId = userId;
            this.date = date;
            this.amount = amount;
            this.type = type;
            this.discount = discount;
            this.noOfItems = noOfItems;
        }

        public CustomerOrder(int id)
        {
            this.id = id;
        }

        public CustomerOrder() { }


        /*
         * This method will save a new customer order data in the database and return a boolean based of result.
         * @return
         *  - true: if order succesfuly saved in DB.
         *  - false: if save process had any issues or order data not provided.
        */
        public CustomerOrder create()
        {
            CustomerOrder customerOrder = new CustomerOrder();
            if (!int.IsPositive(customerId) || !int.IsPositive(userId) || !decimal.IsPositive(amount) || string.IsNullOrEmpty(date)
                || string.IsNullOrEmpty(type) || !int.IsPositive(noOfItems))
            {
                return customerOrder;
            }
            try
            {
                connection.Open();
                string query = "INSERT INTO customerOrder (customerId, userId, date, amount, discount, noOfItems, type)" +
                    " VALUES (@customerId, @userId, @date, @amount, @discount, @noOfItems, @type); " +
                    "SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@noOfItems", noOfItems);

                    long orderId = Convert.ToInt64(cmd.ExecuteScalar());
                    if (orderId > 0)
                    {
                        string selectQuery = "SELECT id, customerId, userId, date, amount, discount, noOfItems, type " +
                                 "FROM customerOrder WHERE id = @orderId";

                        using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection))
                        {
                            selectCmd.Parameters.AddWithValue("@orderId", orderId);

                            using (MySqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    customerOrder.id = reader.GetInt32(0);
                                    customerOrder.customerId = reader.GetInt32(1);
                                    customerOrder.userId = reader.GetInt32(2);
                                    customerOrder.date = reader.GetDateTime(3).ToShortDateString();
                                    customerOrder.amount = reader.GetDecimal(4);
                                    customerOrder.discount = reader.GetInt32(5);
                                    customerOrder.noOfItems = reader.GetInt32(6);
                                    customerOrder.type = reader.GetString(7);

                                    connection.Close();
                                    return customerOrder;
                                }
                            }
                        }
                    }
                    return customerOrder;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return customerOrder;
            }
        }

        /*
         * This method will update the customer order data in the database and return a boolean based of result.
         * @return
         *  - true: if customer order succesfuly updated in DB.
         *  - false: if update process had any issues or customer order data not provided.
        */
        public bool update()
        {
            if (!int.IsPositive(id) || !int.IsPositive(noOfItems) || !decimal.IsPositive(amount))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "UPDATE customerOrder SET noOfItems = @noOfItems, amount = @amount " +
                    "WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@noOfItems", noOfItems);
                    cmd.Parameters.AddWithValue("@amount", amount);
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
         * This method will delete the customer order data in the database and return a boolean based of result.
         * @return
         *  - true: if customer order succesfuly deleted in DB.
         *  - false: if delete process had any issues or customer order id not provided.
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
                string query = "DELETE FROM customerOrder WHERE id=@id";

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
         * This method will search customer order by the id in the database.
         * @return
         *  - customer order object with data: if customer order succesfuly found in DB.
         *  - customer order object without data: if customer order succesfuly not found in DB.
        */
        public static CustomerOrder searchById(int customerOrderID)
        {
            CustomerOrder customerOrder = new CustomerOrder();

            if (customerOrderID <= 0) { return customerOrder; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM customerOrder WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", customerOrderID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            customerOrder.id = reader.GetInt32(0);
                            customerOrder.customerId = reader.GetInt32(1);
                            customerOrder.userId = reader.GetInt32(2);
                            customerOrder.date = reader.GetDateTime(3).ToShortDateString();
                            customerOrder.amount = reader.GetDecimal(4);
                            customerOrder.discount = reader.GetInt32(5);
                            customerOrder.noOfItems = reader.GetInt32(6);
                            customerOrder.type = reader.GetString(7);

                            connection.Close();
                            return customerOrder;
                        }
                        else
                        {
                            connection.Close();
                            return customerOrder;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return customerOrder;
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
         * This method return a data table object with suppliers based on provided title.
         * @return
         *  - data table object with data: if suppliers succesfuly found in DB.
         *  - data table object without data: if had any issues or suppliers not available.
        */
        public static DataTable getOrdersByCustomerForDataTable(int customerId)
        {
            DataTable dataTable = new DataTable();

            if (customerId <= 0) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT co.id as 'Order Id', co.date, co.amount, co.discount, co.noOfItems, "+
                    "co.type, u.username as 'Placed By'" +
                    "FROM customerOrder co "+
                    "JOIN customer c ON co.customerId = c.id "+
                    "JOIN users u ON co.userId = u.id "+
                    "WHERE co.customerId = @customerId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);

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
