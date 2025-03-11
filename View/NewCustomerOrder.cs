using BookHevan.Helper;
using BookHevan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHevan.View
{
    public partial class NewCustomerOrder : Form
    {
        private Book selectedBook = new Book();
        private Customer selectedCustomer = new Customer();
        private List<NewOrderBookDetail> orderBookList = new List<NewOrderBookDetail>();
        private CustomerOrder newCustomerOrder = new CustomerOrder();

        public NewCustomerOrder()
        {
            InitializeComponent();
        }

        private void NewCustomerOrder_Load(object sender, EventArgs e)
        {
            viewRest();
        }

        /**
         * This method is used to reset the view to its initial state.
         * */
        private void viewRest()
        {
            // Load all books in the data grid view
            dgvBooks.DataSource = Book.getBooksForDataTable();
            dgvBooks.ClearSelection();
            // Clear the order details data grid view
            dgvOrderDetail.DataSource = null;
            // Clear the text boxes
            txtDiscount.Text = string.Empty;
            txtNetAmount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;

            txtQuantity.Enabled = false;
            btnAdd.Enabled = false;
            comType.Enabled = false;
            // Reset the private objects
            newCustomerOrder = new CustomerOrder();
            orderBookList = new List<NewOrderBookDetail>();
            selectedCustomer = new Customer();
            selectedBook = new Book();
            // Load the combo boxes
            loadComboBox();
        }

        /**
         * This method is used to load the combo boxes with the data.
         * */
        private void loadComboBox()
        {
            // Load the customer names in the combo box
            DataTable customerDT = Customer.getCustomersForDataTable();
            comCustName.Items.Clear();
            comCustName.Items.Add("--Select--");
            foreach (DataRow Dr in customerDT.Rows)
            {
                comCustName.Items.Add(Dr["name"]);
            }
            comCustName.SelectedIndex = 0;

            // Load the book titles in the combo box
            DataTable BookDT = Book.getBooksForDataTable();
            comTitle.Items.Clear();
            comAuthor.Items.Clear();
            comGenre.Items.Clear();
            comTitle.Items.Add("--Filter by title--");
            comAuthor.Items.Add("--Filter by author--");
            comGenre.Items.Add("--Filter by genre--");
            foreach (DataRow Dr in BookDT.Rows)
            {
                comTitle.Items.Add(Dr["title"]);
                comAuthor.Items.Add(Dr["author"]);
                comGenre.Items.Add(Dr["genre"]);
            }
            comTitle.SelectedIndex = 0;
            comAuthor.SelectedIndex = 0;
            comGenre.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void comCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected index is greater than 0
            if (comCustName.SelectedIndex > 0)
            {
                // Get the selected customer name
                string selectedCustomerName = comCustName.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selectedCustomerName))
                {
                    // Search the customer by name
                    Customer searched = Customer.searchByName(selectedCustomerName);
                    if (searched?.id != null)
                    {
                        // Set the customer details in the labels
                        lblCustEmail.Text = searched.email;
                        lblCustAddress.Text = searched.address;
                        lblCustPhoneNumber.Text = searched.phoneNo;
                        // Set the selected customer object
                        selectedCustomer.id = searched.id;
                        selectedCustomer.address = searched.address;
                        selectedCustomer.email = searched.email;
                        selectedCustomer.phoneNo = searched.phoneNo;
                        selectedCustomer.name = searched.name;
                    }
                }
            }
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

                txtQuantity.Enabled = true;
                txtQuantity.Focus();
                btnAdd.Enabled = true;
                comType.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the quantity is empty
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please enter quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the quantity is not a number
            int quantity = int.Parse(txtQuantity.Text);

            // Check if the quantity is greater than the available quantity
            if (selectedBook.quantity < quantity)
            {
                MessageBox.Show("Inventory not available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Set the customer order details
            newCustomerOrder.customerId = selectedCustomer.id;
            newCustomerOrder.userId = UserSession.id;
            newCustomerOrder.date = DateTime.Now.ToString("yyyy-MM-dd");
            newCustomerOrder.noOfItems = (quantity + newCustomerOrder.noOfItems);
            // Add the book to the order list
            orderBookList.Add(new NewOrderBookDetail
            {
                id = selectedBook.id,
                title = selectedBook.title,
                author = selectedBook.author,
                genre = selectedBook.genre,
                isbn = selectedBook.isbn,
                price = selectedBook.price,
                orderQuantity = int.Parse(txtQuantity.Text)
            });
            // Set the data source of the data grid view
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = orderBookList;

            // Calculate the total amount
            decimal currentTotalAmount = 0;
            int discount = 0;
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                int.TryParse(txtDiscount.Text, out discount);
            }
            decimal.TryParse(txtTotalAmount.Text, out currentTotalAmount);
            decimal newTotalAmount = (selectedBook.price * int.Parse(txtQuantity.Text) + currentTotalAmount);

            // Set the total amount and net amount
            txtTotalAmount.Text = newTotalAmount.ToString();
            txtNetAmount.Text = ((newTotalAmount - discount)).ToString();
            newCustomerOrder.amount = (newTotalAmount - discount);
        }

        private void comTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTitle.SelectedIndex > 0)
            {
                string bookTitle = comTitle.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(bookTitle))
                {
                    dgvBooks.DataSource = Book.filterByTitle(bookTitle);
                    dgvBooks.ClearSelection();

                    txtQuantity.Text = string.Empty;
                    txtQuantity.Enabled = false;
                    btnAdd.Enabled = false;
                    comType.Enabled = false;
                }
            }
        }

        private void comAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comAuthor.SelectedIndex > 0)
            {
                string bookAuthor = comAuthor.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(bookAuthor))
                {
                    dgvBooks.DataSource = Book.filterByAuthor(bookAuthor);
                    dgvBooks.ClearSelection();

                    txtQuantity.Text = string.Empty;
                    txtQuantity.Enabled = false;
                    btnAdd.Enabled = false;
                    comType.Enabled = false;
                }
            }
        }

        private void comGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comGenre.SelectedIndex > 0)
            {
                string bookGenre = comGenre.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(bookGenre))
                {
                    dgvBooks.DataSource = Book.filterByGenre(bookGenre);
                    dgvBooks.ClearSelection();

                    txtQuantity.Text = string.Empty;
                    txtQuantity.Enabled = false;
                    btnAdd.Enabled = false;
                    comType.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comType.SelectedIndex > 0)
            {
                newCustomerOrder.type = comType.SelectedItem.ToString();
                // Check if the discount is empty
                int discount = 0;
                if (!string.IsNullOrEmpty(txtDiscount.Text))
                {
                    int.TryParse(txtDiscount.Text, out discount);
                }
                newCustomerOrder.discount = discount;

                // Save the customer order
                CustomerOrder customerOrder = newCustomerOrder.create();

                if (customerOrder != null && customerOrder.id != 0)
                {
                    // Loop the order book list and save the order details
                    foreach (var item in orderBookList)
                    {
                        // Set the customer order details
                        CustomerOrderDetails customerOrderDetails = new CustomerOrderDetails();
                        customerOrderDetails.bookId = item.id;
                        customerOrderDetails.custOrderId = customerOrder.id;
                        customerOrderDetails.quantity = item.orderQuantity;
                        // Save the order details
                        customerOrderDetails.create();

                        // Update the book quantity
                        Book searchedBook = Book.searchById(item.id);
                        if (searchedBook.id != 0)
                        {
                            // Update the book quantity
                            Book.updateQuantity(item.id, (searchedBook.quantity - item.orderQuantity));
                        }
                    }
                    // Reset the view
                    viewRest();
                    MessageBox.Show("Order successfully Placed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order not placed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    MessageBox.Show("Please enter discount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtNetAmount.Text = (decimal.Parse(txtTotalAmount.Text) - decimal.Parse(txtDiscount.Text)).ToString();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            if (FieldValidations.isAllDigits(e))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            if (FieldValidations.isAllDigits(e))
            {
                e.Handled = true;
            }
        }
    }
}
