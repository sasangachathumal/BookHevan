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

        private void viewRest()
        {
            txtAuthor.Clear();
            txtGenre.Clear();
            txtTitle.Clear();
            txtPrice.Clear();
            txtISBN.Clear();
            txtStockQuantity.Clear();
            txtSearchWord.Clear();

            dgvBooks.DataSource = Book.getBooksForDataTable();
            dgvBooks.ClearSelection();

            btnSave.Text = "Save";
            isUpdating = false;
            selectedBook = new Book();

            txtTitle.Focus();

            DataTable supplierDT = Supplier.getSupplierForDataTable();
            comSupplier.Items.Clear();
            comSupplier.Items.Add("--SELECT--");
            foreach (DataRow Dr in supplierDT.Rows)
            {
                comSupplier.Items.Add(Dr["name"]);
            }
            comSupplier.SelectedIndex = 0;

            txtOrderQuantity.Enabled = false;
            btnSupplierOrder.Enabled = false;

            if (UserSession.type != "Admin")
            {
                txtOrderQuantity.Visible = false;
                btnSupplierOrder.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string genre = txtGenre.Text;
            string isbn = txtISBN.Text;
            decimal price;
            int quantity;
            bool isSuccess = false;

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author) &&
                !string.IsNullOrEmpty(genre) && !string.IsNullOrEmpty(isbn) &&
                decimal.TryParse(txtPrice.Text, out price) && int.TryParse(txtStockQuantity.Text, out quantity) &&
                selectedSupplier.id > 0)
            {
                Book book = new Book();
                book.author = author;
                book.genre = genre;
                book.isbn = isbn;
                book.price = price;
                book.quantity = quantity;
                book.title = title;

                if (isUpdating)
                {
                    book.id = selectedBook.id;
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

                txtTitle.Text = selectedBook.title;
                txtAuthor.Text = selectedBook.author;
                txtGenre.Text = selectedBook.genre;
                txtISBN.Text = selectedBook.isbn;
                txtPrice.Text = selectedBook.price.ToString();
                txtStockQuantity.Text = selectedBook.quantity.ToString();
                comSupplier.SelectedItem = selectedBook.supplier;

                btnSave.Text = "Update";
                isUpdating = true;
                txtOrderQuantity.Enabled = true;
                btnSupplierOrder.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                MessageBox.Show("Please select a book to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Book " +
                selectedBook.title + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
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

        private void searchBooks()
        {
            string searchWord = txtSearchWord.Text;

            if (string.IsNullOrEmpty(searchWord))
            {
                dgvBooks.DataSource = Book.getBooksForDataTable();
                dgvBooks.ClearSelection();
                return;
            }

            dgvBooks.DataSource = Book.searchByTitleForDataTable(searchWord);
            dgvBooks.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchBooks();
        }

        private void txtSearchWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchBooks();
        }

        private void txtSearchWord_KeyDown(object sender, KeyEventArgs e)
        {
            searchBooks();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
        }

        private void comSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSupplier.SelectedIndex > 0)
            {
                string selectedSupplierName = comSupplier.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selectedSupplierName))
                {
                    Supplier searched = Supplier.searchByName(selectedSupplierName);
                    if (searched?.id != null)
                    {
                        selectedSupplier = searched;
                    }
                }
            }
        }

        private void btnSupplierOrder_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                MessageBox.Show("Please select a book to place order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comSupplier.SelectedIndex > 0)
            {
                string selectedSupplierName = comSupplier.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedSupplierName))
                {
                    Supplier searched = Supplier.searchByName(selectedSupplierName);
                    if (searched?.id > 0)
                    {
                        SupplierOrder newSupplierOrder = new SupplierOrder();
                        newSupplierOrder.supplierId = searched.id;
                        newSupplierOrder.bookId = selectedBook.id;
                        newSupplierOrder.quantity = int.Parse(txtOrderQuantity.Text);
                        newSupplierOrder.userId = UserSession.id;
                        newSupplierOrder.date = DateTime.Now.ToString("yyyy-MM-dd");

                        SupplierOrder savedOrder = newSupplierOrder.create();
                        if (savedOrder?.id > 0)
                        {

                            selectedBook.quantity += newSupplierOrder.quantity;
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
    }
}
