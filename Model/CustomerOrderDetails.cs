using BookHevan.database;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookHevan.Model
{
    internal class CustomerOrderDetails
    {
        private static MySqlConnection connection = DatabaseConnection.Instance.GetConnection();
        public int custOrderId { get; set; }
        public int bookId { get; set; }
        public int quantity { get; set; }

        public CustomerOrderDetails(int custOrderId, int bookId, int quantity)
        {
            this.custOrderId = custOrderId;
            this.bookId = bookId;
            this.quantity = quantity;
        }
        public CustomerOrderDetails() { }

        /*
         * This method will save a customer order detail data in the database and return a boolean based of result.
        */
        public bool create()
        {
            if (!int.IsPositive(custOrderId) || !int.IsPositive(bookId) || !int.IsPositive(quantity))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "INSERT INTO custorderdetails (custOrderId, bookId, quantity)" +
                    " VALUES (@custOrderId, @bookId, @quantity)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@custOrderId", custOrderId);
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
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
         * This method will update the customer order detail data in the database and return a boolean based of result.
        */
        public bool update()
        {
            if (!int.IsPositive(custOrderId) || !int.IsPositive(bookId) || !int.IsPositive(quantity))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "UPDATE custorderdetails SET quantity = @quantity " +
                    "WHERE custOrderId = @custOrderId AND bookId = @bookId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@custOrderId", custOrderId);
                    cmd.Parameters.AddWithValue("@bookId", bookId);

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
         * This method will delete the customer order details data in the database and return a boolean based of result.
        */
        public bool delete()
        {
            if (!int.IsPositive(custOrderId) || !int.IsPositive(bookId))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "DELETE FROM custorderdetails WHERE custOrderId = @custOrderId AND bookId = @bookId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@custOrderId", custOrderId);
                    cmd.Parameters.AddWithValue("@bookId", bookId);

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
         * This method return a data table object with customer order details based on provided title.
        */
        public static DataTable getOrdersDetailsByOrderForDataTable(int customerOrderId)
        {
            DataTable dataTable = new DataTable();

            if (customerOrderId <= 0) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT cod.custOrderId as 'Order Id', b.id as 'Book Id', "+
                    "b.title, b.author, b.genre, b.isbn, b.price, cod.quantity "+
                    "FROM custorderdetails cod "+
                    "JOIN book b ON cod.bookId = b.id "+
                    "WHERE cod.custOrderId = @custOrderId;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@custOrderId", customerOrderId);

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
