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
    internal class Book
    {
        // Database connection
        private static MySqlConnection connection = DatabaseConnection.Instance.GetConnection();
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public string isbn { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }

        public Book(int id, string title, string author, string genre, string isbn, decimal price, int quantity)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isbn = isbn;
            this.price = price;
            this.quantity = quantity;
        }

        public Book(string title, string author, string genre, string isbn, decimal price, int quantity)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isbn = isbn;
            this.price = price;
            this.quantity = quantity;
        }

        public Book(int id)
        {
            this.id = id;
        }

        public Book() { }

        /*
         * This method will save the book data in the database and return a boolean based of result.
         * @return
         *  - true: if book succesfuly saved in DB.
         *  - false: if save process had any issues or book data not provided.
        */
        public bool create()
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) ||
                string.IsNullOrEmpty(genre) || !decimal.IsPositive(price) || !int.IsPositive(quantity))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "INSERT INTO book (title, author, genre, isbn, price, quantity)" +
                    " VALUES (@title, @author, @genre, @isbn, @price, @quantity)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@price", price);
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
         * This method will update the book data in the database and return a boolean based of result.
         * @return
         *  - true: if book succesfuly updated in DB.
         *  - false: if update process had any issues or book data not provided.
        */
        public bool update()
        {
            if (!int.IsPositive(id) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) ||
                string.IsNullOrEmpty(genre) || !decimal.IsPositive(price) || !int.IsPositive(quantity))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "UPDATE book SET title = @title, " +
                    "author = @author, genre = @genre, isbn = @isbn, price = @price, quantity = @quantity " +
                    "WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
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
         * This method will delete the book data in the database and return a boolean based of result.
         * @return
         *  - true: if book succesfuly deleted in DB.
         *  - false: if delete process had any issues or book id not provided.
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
                string query = "DELETE FROM book WHERE id=@id";

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
         * This method will search book by the id in the database and return a book object with data if book found.
         * @return
         *  - book object with data: if book succesfuly found in DB.
         *  - book object without data: if update search had any issues or book id not provided.
        */
        public static Book searchById(int bookId)
        {
            Book book = new Book();

            if (bookId <= 0) { return book; }

            try
            {
                connection.Open();
                string query = "SELECT * FROM book WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", bookId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            book.id = reader.GetInt32(0);
                            book.title = reader.GetString(1);
                            book.author = reader.GetString(2);
                            book.genre = reader.GetString(3);
                            book.isbn = reader.GetString(4);
                            book.price = reader.GetDecimal(5);
                            book.quantity = reader.GetInt32(6);
                            connection.Close();
                            return book;
                        }
                        else
                        {
                            connection.Close();
                            return book;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
                return book;
            }
        }

        /*
         * This method return a data table object with books.
         * @return
         *  - data table object with data: if user succesfuly found in DB.
         *  - data table object without data: if had any issues or books not available.
        */
        public static DataTable getBooksForDataTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                string query = "SELECT id as 'Book ID', title, author, genre, isbn, price, quantity FROM book";

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
         * This method return a data table object with books based on provided title.
        */
        public static DataTable searchByTitleForDataTable(string title)
        {
            DataTable dataTable = new DataTable();

            if (title == null) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT id as 'Book ID', title, author, genre, isbn, price, quantity FROM book"+
                    " WHERE title LIKE @title";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@title", "%" + title + "%");

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

        public static DataTable filterByTitle(string title)
        {
            DataTable dataTable = new DataTable();

            if (title == null) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT id as 'Book ID', title, author, genre, isbn, price, quantity FROM book" +
                    " WHERE title = @title";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@title", title);

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

        public static DataTable filterByAuthor(string author)
        {
            DataTable dataTable = new DataTable();

            if (author == null) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT id as 'Book ID', title, author, genre, isbn, price, quantity FROM book" +
                    " WHERE author = @author";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@author", author);

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

        public static DataTable filterByGenre(string genre)
        {
            DataTable dataTable = new DataTable();

            if (genre == null) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT id as 'Book ID', title, author, genre, isbn, price, quantity FROM book" +
                    " WHERE genre = @genre";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@genre", genre);

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

        public static bool updateQuantity(int id, int quantity)
        {
            if (!int.IsPositive(id) || !int.IsPositive(quantity))
            {
                return false;
            }
            try
            {
                connection.Open();
                string query = "UPDATE book SET quantity = @quantity " +
                    "WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@quantity", quantity);
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

        public static DataTable searchByKeywordForDataTable(string searchWord)
        {
            DataTable dataTable = new DataTable();

            if (searchWord == null) { return dataTable; }

            try
            {
                connection.Open();
                string query = "SELECT id as 'Book ID', title, author, genre, isbn, price, quantity FROM book" +
                    " WHERE title LIKE @title OR isbn LIKE @isbn";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@title", "%" + searchWord + "%");
                    cmd.Parameters.AddWithValue("@isbn", "%" + searchWord + "%");

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
