using BookHevan.Helper;
using BookHevan.Model;
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
    public partial class PointOfSales : Form
    {
        private Book selectedBook = new Book();
        private Customer selectedCustomer = new Customer();
        private List<NewOrderBookDetail> orderBookList = new List<NewOrderBookDetail>();
        private CustomerOrder newCustomerOrder = new CustomerOrder();
        public PointOfSales()
        {
            InitializeComponent();
        }

        private void PointOfSales_Load(object sender, EventArgs e)
        {
            viewRest();
        }
        /**
         * This method is used to reset the view
         */
        private void viewRest()
        {
            // Load all the books to the data grid view
            dgvBooks.DataSource = Book.getBooksForDataTable();
            dgvBooks.ClearSelection();
            // Clear the order details data grid view
            dgvOrderDetail.DataSource = null;
            // Clear all the text fields
            txtDiscount.Text = string.Empty;
            txtNetAmount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtSearchWord.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtQuantity.Enabled = false;
            btnAddBookToOrder.Enabled = false;
            txtTotalAmount.Text = string.Empty;
            // Clear the selected book and customer
            newCustomerOrder = new CustomerOrder();
            orderBookList = new List<NewOrderBookDetail>();
            selectedCustomer = new Customer();
            selectedBook = new Book();
        }

        private void txtSearchWord_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchWord.Text.Trim() == string.Empty)
            {
                dgvBooks.DataSource = Book.getBooksForDataTable();
                dgvBooks.ClearSelection();
            }
            else
            {
                dgvBooks.DataSource = Book.searchByKeywordForDataTable(txtSearchWord.Text.Trim());
                dgvBooks.ClearSelection();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                // Enable the quantity text field
                txtQuantity.Enabled = true;
                txtQuantity.Focus();
                btnAddBookToOrder.Enabled = true;
            }
        }

        private void btnAddBookToOrder_Click(object sender, EventArgs e)
        {
            // Check if the quantity is empty
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please enter quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the quantity is greater than the available quantity
            int quantity = int.Parse(txtQuantity.Text);

            if (selectedBook.quantity < quantity)
            {
                MessageBox.Show("Inventory not available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Set the customer order data
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
            // Load the order details to the data grid view
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = orderBookList;
            // Calculate the total amount
            decimal currentTotalAmount = 0;
            int discount = 0;
            int.TryParse(txtDiscount.Text, out discount);
            decimal.TryParse(txtTotalAmount.Text, out currentTotalAmount);
            decimal newTotalAmount = (selectedBook.price * int.Parse(txtQuantity.Text) + currentTotalAmount);
            // Set the total amount and net amount
            txtTotalAmount.Text = newTotalAmount.ToString();
            txtNetAmount.Text = ((newTotalAmount - discount)).ToString();
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e){}

        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Check if the phone number is empty
                if (string.IsNullOrEmpty(txtPhoneNo.Text))
                {
                    MessageBox.Show("Please enter phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Search the customer by phone number
                selectedCustomer = Customer.searchByPhoneNo(txtPhoneNo.Text.Trim());
                if (selectedCustomer.id == 0)
                {
                    MessageBox.Show("Customer not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Set the customer data to the labels
                lblCustAddress.Text = selectedCustomer.address;
                lblCustEmail.Text = selectedCustomer.email;
                lblCustPhoneNumber.Text = selectedCustomer.name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if the customer is selected
            if (selectedCustomer.id > 0)
            {
                // ser customer order data
                newCustomerOrder.type = "POS";
                newCustomerOrder.amount = decimal.Parse(txtNetAmount.Text);
                // Check if the discount is empty
                int discount = 0;
                int.TryParse(txtDiscount.Text, out discount);
                newCustomerOrder.discount = discount;
                // Create the customer order
                CustomerOrder customerOrder = newCustomerOrder.create();

                if (customerOrder != null && customerOrder.id != 0)
                {
                    // Loop through the order book list and save the order details
                    foreach (var item in orderBookList)
                    {
                        // Create the customer order details
                        CustomerOrderDetails customerOrderDetails = new CustomerOrderDetails();
                        customerOrderDetails.bookId = item.id;
                        customerOrderDetails.custOrderId = customerOrder.id;
                        customerOrderDetails.quantity = item.orderQuantity;
                        // Save the customer order details
                        customerOrderDetails.create();
                        // Update the book quantity
                        Book searchedBook = Book.searchById(item.id);
                        if (searchedBook != null)
                        {
                            // Update the book quantity
                            Book.updateQuantity(item.id, (searchedBook.quantity - item.orderQuantity));
                        }
                    }
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

        internal void SetCustomer(Customer customer)
        {
            selectedCustomer = customer;
            txtPhoneNo.Text = selectedCustomer.phoneNo;
            lblCustAddress.Text = selectedCustomer.address;
            lblCustEmail.Text = selectedCustomer.email;
            lblCustPhoneNumber.Text = selectedCustomer.name;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            new NewCustomerDialog(this).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
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

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            if (FieldValidations.isAllDigits(e))
            {
                e.Handled = true;
            }
        }
    }
}
