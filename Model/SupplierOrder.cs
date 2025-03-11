using BookHevan.database;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.Model
{
    internal class SupplierOrder
    {
        // Database connection
        private static MySqlConnection connection = DatabaseConnection.Instance.GetConnection();
        public int id { get; set; }
        public int supplierId { get; set; }
        public int userId { get; set; }
        public int bookId { get; set; }
        public string date { get; set; }
        public int quantity { get; set; }

        public SupplierOrder(int id, int supplierId, int userId, int bookId, string date, int quantity)
        {
            this.id = id;
            this.supplierId = supplierId;
            this.userId = userId;
            this.date = date;
            this.quantity = quantity;
            this.bookId = bookId;
        }
        public SupplierOrder() { }

        /*
         * This method will save a new supplier order data in the database and return a boolean based of result.
         * @return
         *  - true: if order succesfuly saved in DB.
         *  - false: if save process had any issues or order data not provided.
        */
        public SupplierOrder create()
        {
            SupplierOrder supplierOrder = new SupplierOrder();
            if (!int.IsPositive(supplierId) || !int.IsPositive(userId) || !int.IsPositive(quantity) || string.IsNullOrEmpty(date)
                || !int.IsPositive(bookId))
            {
                return supplierOrder;
            }
            try
            {
                connection.Open();
                string query = "INSERT INTO supplierorder (supplierId, userId, bookId, date, quantity)" +
                    " VALUES (@supplierId, @userId, @bookId, @date, @quantity); " +
                    "SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@quantity", quantity);

                    long orderId = Convert.ToInt64(cmd.ExecuteScalar());
                    if (orderId > 0)
                    {
                        string selectQuery = "SELECT id, supplierId, userId, bookId, date, quantity " +
                                 "FROM supplierorder WHERE id = @orderId";

                        using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection))
                        {
                            selectCmd.Parameters.AddWithValue("@orderId", orderId);

                            using (MySqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    supplierOrder.id = reader.GetInt32(0);
                                    supplierOrder.supplierId = reader.GetInt32(1);
                                    supplierOrder.userId = reader.GetInt32(2);
                                    supplierOrder.date = reader.GetDateTime(4).ToShortDateString();
                                    supplierOrder.bookId = reader.GetInt32(3);
                                    supplierOrder.quantity = reader.GetInt32(5);

                                    connection.Close();
                                    return supplierOrder;
                                }
                            }
                        }
                    }
                    return supplierOrder;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return supplierOrder;
            }
        }

        /*
         * This method will delete the supplier order data in the database and return a boolean based of result.
         * @return
         *  - true: if supplier order succesfuly deleted in DB.
         *  - false: if delete process had any issues or supplier order id not provided.
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
                string query = "DELETE FROM supplierorder WHERE id=@id";

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
         * This method will search supplier order by the id in the database by supplier order id.
         * @return
         *  - supplier order object with data: if supplier order succesfuly found in DB.
         *  - supplier order object without data: if supplier order succesfuly not found in DB.
        */
        public static SupplierOrder searchById(int orderID)
        {
            SupplierOrder supplierOrder = new SupplierOrder();

            if (orderID <= 0) { return supplierOrder; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM supplierorder WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", orderID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            supplierOrder.id = reader.GetInt32(0);
                            supplierOrder.supplierId = reader.GetInt32(1);
                            supplierOrder.userId = reader.GetInt32(2);
                            supplierOrder.date = reader.GetDateTime(4).ToShortDateString();
                            supplierOrder.bookId = reader.GetInt32(3);
                            supplierOrder.quantity = reader.GetInt32(5);

                            connection.Close();
                            return supplierOrder;
                        }
                        else
                        {
                            connection.Close();
                            return supplierOrder;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return supplierOrder;
            }
        }

        /*
         * This method return a data table object with supplier orders.
         * @return
         *  - data table object with data: if user succesfuly found in DB.
         *  - data table object without data: if had any issues or supplier order not available.
        */
        public static DataTable getForDataTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                string query = "SELECT id, supplierId, userId, bookId, date, quantity FROM supplierorder";

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
         * This method return a data table object with suppliers based on provided supplier id.
         * @return
         *  - data table object with data: if suppliers succesfuly found in DB.
         *  - data table object without data: if had any issues or suppliers not available.
        */
        public static DataTable getOrdersBySupplierForDataTable(int supplierId)
        {
            DataTable dataTable = new DataTable();

            if (supplierId <= 0) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT so.id as 'Order Id', so.date, so.quantity, b.title, " +
                    "u.username as 'Placed By'" +
                    "FROM supplierorder so " +
                    "JOIN supplier s ON so.supplierId = s.id " +
                    "JOIN users u ON so.userId = u.id " +
                    "JOIN book b ON so.bookId = b.id " +
                    "WHERE so.supplierId = @supplierId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@supplierId", supplierId);

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
