using BookHevan.Helper;
using BookHevan.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHevan.View
{
    public partial class BookInventoryManagement : Form
    {
        private Book selectedBook = new Book();
        private bool isUpdating = false;
        private Supplier selectedSupplier = new Supplier();
        public BookInventoryManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * This method is used to reset the view to the initial state
         * */
        private void viewRest()
        {
            // Clear all the text fields
            txtAuthor.Clear();
            txtGenre.Clear();
            txtTitle.Clear();
            txtPrice.Clear();
            txtISBN.Clear();
            txtStockQuantity.Clear();
            txtSearchWord.Clear();
            // Load the data grid view with the books
            dgvBooks.DataSource = Book.getBooksForDataTable();
            dgvBooks.ClearSelection();
            // Set the button text to Save
            btnSave.Text = "Save";
            // Set the isUpdating flag to false
            isUpdating = false;
            // Create a new book object
            selectedBook = new Book();
            // Set focus to the title text field
            txtTitle.Focus();
            // Disable the order quantity text field and the supplier order button
            txtOrderQuantity.Enabled = false;
            btnSupplierOrder.Enabled = false;
            // Ensure order quantity text field and the supplier order button only visible to Admin
            if (UserSession.type != "Admin")
            {
                txtOrderQuantity.Visible = false;
                btnSupplierOrder.Visible = false;
            }
            // Load the supplier combo box
            loadComboBox();
        }

        /**
         * This method is used to load the supplier combo box
         * */
        private void loadComboBox()
        {
            DataTable supplierDT = Supplier.getSupplierForDataTable();
            comSupplier.Items.Clear();
            comSupplier.Items.Add("--SELECT--");
            foreach (DataRow Dr in supplierDT.Rows)
            {
                comSupplier.Items.Add(Dr["name"]);
            }
            comSupplier.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the values from the text fields
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string genre = txtGenre.Text;
            string isbn = txtISBN.Text;
            decimal price;
            int quantity;
            bool isSuccess = false;

            // Check if all the fields are filled
            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author) &&
                !string.IsNullOrEmpty(genre) && !string.IsNullOrEmpty(isbn) &&
                decimal.TryParse(txtPrice.Text, out price) && int.TryParse(txtStockQuantity.Text, out quantity) &&
                selectedSupplier.id > 0)
            {
                // Create a new book object
                Book book = new Book();
                // Set the values to the book object
                book.author = author;
                book.genre = genre;
                book.isbn = isbn;
                book.price = price;
                book.quantity = quantity;
                book.title = title;

                // Check if the operation is an update
                if (isUpdating)
                {
                    // Set the book id
                    book.id = selectedBook.id;
                    // Update the book
                    isSuccess = book.update();
                    if (isSuccess)
                    {
                        MessageBox.Show("Book update is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewRest();
                    }
                    else
                    {
                        MessageBox.Show("Book update fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Set the supplier name
                    book.supplier = selectedSupplier.name;
                    // Create the book
                    isSuccess = book.create();
                    if (isSuccess)
                    {
                        MessageBox.Show("Book creating is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewRest();
                    }
                    else
                    {
                        MessageBox.Show("Book creation fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide all the information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BookInventoryManagement_Load(object sender, EventArgs e)
        {
            viewRest();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                // Get data from specific columns
                selectedBook.id = int.Parse(row.Cells[0].Value.ToString());
                selectedBook.title = row.Cells[1].Value.ToString();
                selectedBook.author = row.Cells[2].Value.ToString();
                selectedBook.genre = row.Cells[3].Value.ToString();
                selectedBook.isbn = row.Cells[4].Value.ToString();
                selectedBook.price = decimal.Parse(row.Cells[5].Value.ToString());
                selectedBook.quantity = int.Parse(row.Cells[6].Value.ToString());
                selectedBook.supplier = row.Cells[7].Value.ToString();

                // Set the values to the text fields
                txtTitle.Text = selectedBook.title;
                txtAuthor.Text = selectedBook.author;
                txtGenre.Text = selectedBook.genre;
                txtISBN.Text = selectedBook.isbn;
                txtPrice.Text = selectedBook.price.ToString();
                txtStockQuantity.Text = selectedBook.quantity.ToString();
                comSupplier.SelectedItem = selectedBook.supplier;

                btnSave.Text = "Update";
                isUpdating = true;

                // Ensure order quantity text field and the supplier order button only visible to Admin
                if (UserSession.type != "Admin")
                {
                    txtOrderQuantity.Visible = false;
                    btnSupplierOrder.Visible = false;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the user is updating a book
            if (!isUpdating)
            {
                MessageBox.Show("Please select a book to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Confirm the delete operation
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Book " +
                selectedBook.title + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check if the user confirmed the delete operation
            if (diaRes == DialogResult.Yes)
            {
                // Delete the book
                bool isSuccess = selectedBook.delete();
                if (isSuccess)
                {
                    MessageBox.Show("Book successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book delete fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                viewRest();
            }
        }

        /**
         * This method is used to search books by title
         * */
        private void searchBooks()
        {
            // Get the search word
            string searchWord = txtSearchWord.Text;
            // Check if the search word is empty
            if (string.IsNullOrEmpty(searchWord))
            {
                // Load all the books if no search word is provided
                dgvBooks.DataSource = Book.getBooksForDataTable();
                dgvBooks.ClearSelection();
                return;
            }
            // Search the books by title and load the data grid view
            dgvBooks.DataSource = Book.searchByTitleForDataTable(searchWord);
            dgvBooks.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchBooks();
        }

        private void txtSearchWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only English letters (both upper and lower case) and control characters (like backspace)
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                searchBooks();
            }
        }

        private void txtSearchWord_KeyDown(object sender, KeyEventArgs e){}

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
        }

        private void comSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected supplier
            if (comSupplier.SelectedIndex > 0)
            {
                // Get the selected supplier name
                string selectedSupplierName = comSupplier.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selectedSupplierName))
                {
                    // Search the supplier by name
                    Supplier searched = Supplier.searchByName(selectedSupplierName);
                    if (searched?.id != null)
                    {
                        // Set the selected supplier
                        selectedSupplier = searched;
                    }
                }
            }
        }

        private void btnSupplierOrder_Click(object sender, EventArgs e)
        {
            // Check if the user is updating a book
            if (!isUpdating)
            {
                MessageBox.Show("Please select a book to place order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the supplier is selected
            if (comSupplier.SelectedIndex > 0)
            {
                string selectedSupplierName = comSupplier.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedSupplierName))
                {
                    // Search the supplier by name
                    Supplier searched = Supplier.searchByName(selectedSupplierName);
                    if (searched?.id > 0)
                    {
                        // Create a new supplier order object
                        SupplierOrder newSupplierOrder = new SupplierOrder();
                        // Set the values to the supplier order object
                        newSupplierOrder.supplierId = searched.id;
                        newSupplierOrder.bookId = selectedBook.id;
                        newSupplierOrder.quantity = int.Parse(txtOrderQuantity.Text);
                        newSupplierOrder.userId = UserSession.id;
                        newSupplierOrder.date = DateTime.Now.ToString("yyyy-MM-dd");

                        // Create the supplier order
                        SupplierOrder savedOrder = newSupplierOrder.create();
                        if (savedOrder?.id > 0)
                        {
                            // Update the book quantity
                            selectedBook.quantity += newSupplierOrder.quantity;
                            // Update the book
                            bool isSuccess = selectedBook.update();
                            if (isSuccess)
                            {

                                MessageBox.Show("Order placed successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                viewRest();
                            }
                            else
                            {
                                MessageBox.Show("Order placing fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Order placing fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Order placing fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supplier to place order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e) { }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only English letters (both upper and lower case) and control characters (like backspace)
            if (FieldValidations.isAllLetters(e))
            {
                e.Handled = true;
            }
        }

        private void txtGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only English letters (both upper and lower case) and control characters (like backspace)
            if (FieldValidations.isAllLetters(e))
            {
                e.Handled = true;
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            if (FieldValidations.isAllDigits(e))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            if (FieldValidations.isAllDigits(e))
            {
                e.Handled = true;
            }
        }

        private void txtStockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            if (FieldValidations.isAllDigits(e))
            {
                e.Handled = true;
            }
        }

        private void txtOrderQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            if (FieldValidations.isAllDigits(e))
            {
                e.Handled = true;
            }
        }
    }
}
