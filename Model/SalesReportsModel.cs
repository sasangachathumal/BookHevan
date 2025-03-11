using BookHevan.database;
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
    internal class SalesReportsModel
    {
        // Database connection
        private static MySqlConnection connection = DatabaseConnection.Instance.GetConnection();

        public SalesReportsModel()
        {
        }

        /**
         * Get the sales report of the daily sales
         */
        public static DataTable getDailySalesReport(string date)
        {
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(date)) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT co.id AS order_id, co.date AS order_date, c.name AS customer_name,"+
                    " co.noOfItems AS order_quantity, co.amount AS total_price, co.discount AS order_discount, co.type AS order_type" +
                    " FROM CustomerOrder co"+
                    " JOIN Customer c ON co.customerId = c.id"+
                    " WHERE co.date = @date"+
                    " ORDER BY co.date DESC;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@date", date);

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

        /**
         * Get the sales counts of the daily sales
         */
        public static string getSalesCountsByDate(string date)
        {
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(date)) { return ""; }

            try
            {
                connection.Open();
                string query = "SELECT SUM(amount) AS total_sales, COUNT(id) AS total_orders" +
                    " FROM CustomerOrder" +
                    " WHERE date = @date" +
                    " GROUP BY DATE(date);";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@date", date);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string result = $"{reader.GetDecimal(0)}, {reader.GetInt32(1)}";
                            connection.Close();
                            return result;
                        }
                        else
                        {
                            connection.Close();
                            return "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return "";
            }
        }

        /**
         * Get the sales report between a date range
         */
        public static DataTable getSalesReportByDateRange(string fromDate, string toDate)
        {
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(fromDate) || string.IsNullOrEmpty(toDate)) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT co.id AS order_id, co.date AS order_date, c.name AS customer_name," +
                    " co.noOfItems AS order_quantity, co.amount AS total_price, co.discount AS order_discount, co.type AS order_type" +
                    " FROM CustomerOrder co"+
                    " JOIN Customer c ON co.customerId = c.id"+
                    " WHERE co.date BETWEEN @StartDate AND @EndDate" +
                    " ORDER BY co.date DESC;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", fromDate);
                    cmd.Parameters.AddWithValue("@EndDate", toDate);

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

        /**
         * Get the sales counts of the date range
         */
        public static string getSalesCountsByDateRange(string fromDate, string toDate)
        {
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(fromDate) || string.IsNullOrEmpty(toDate)) { return ""; }

            try
            {
                connection.Open();
                string query = "SELECT SUM(amount) AS total_sales, COUNT(id) AS total_orders" +
                    " FROM CustomerOrder" +
                    " WHERE date BETWEEN @StartDate AND @EndDate" +
                    " GROUP BY DATE(date);";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", fromDate);
                    cmd.Parameters.AddWithValue("@EndDate", toDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string result = $"{reader.GetDecimal(0)}, {reader.GetInt32(1)}";
                            connection.Close();
                            return result;
                        }
                        else
                        {
                            connection.Close();
                            return "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return "";
            }
        }

        /**
         * Get the sales report of the best selling books
         */
        public static DataTable getSalesReportBestSellingBooks()
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                string query = "SELECT b.title AS book_title, b.author AS book_author, b.genre AS book_genre, b.isbn AS book_ISBN,"+
                    " SUM(cod.quantity) AS total_sold" +
                    " FROM CustOrderDetails cod"+
                    " JOIN Book b ON cod.bookId = b.id"+
                    " GROUP BY cod.bookId"+
                    " ORDER BY total_sold DESC"+
                    " LIMIT 10";

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

        /**
         * Get the sales report of books that are out of stock
         */
        public static DataTable getSalesReportInventoryStatus()
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                string query = "SELECT b.title AS book_title, b.author AS book_author, b.isbn AS book_ISBN, b.price," +
                    " b.quantity AS stock_available" +
                    " FROM book b" +
                    " ORDER BY b.quantity ASC;";

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
    }
}
