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
        private void viewRest()
        {
            dgvBooks.DataSource = Book.getBooksForDataTable();
            dgvBooks.ClearSelection();

            dgvOrderDetail.DataSource = null;

            txtDiscount.Text = string.Empty;
            txtNetAmount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtSearchWord.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtQuantity.Enabled = false;
            btnAddBookToOrder.Enabled = false;
            txtTotalAmount.Text = string.Empty;

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

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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

                txtQuantity.Enabled = true;
                txtQuantity.Focus();
                btnAddBookToOrder.Enabled = true;
            }
        }

        private void btnAddBookToOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please enter quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int quantity = int.Parse(txtQuantity.Text);

            if (selectedBook.quantity < quantity)
            {
                MessageBox.Show("Inventory not available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newCustomerOrder.customerId = selectedCustomer.id;
            newCustomerOrder.userId = UserSession.id;
            newCustomerOrder.date = DateTime.Now.ToString("yyyy-MM-dd");
            newCustomerOrder.noOfItems = (quantity + newCustomerOrder.noOfItems);

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
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = orderBookList;

            decimal currentTotalAmount = 0;
            int discount = 0;
            int.TryParse(txtDiscount.Text, out discount);
            decimal.TryParse(txtTotalAmount.Text, out currentTotalAmount);
            decimal newTotalAmount = (selectedBook.price * int.Parse(txtQuantity.Text) + currentTotalAmount);

            txtTotalAmount.Text = newTotalAmount.ToString();
            txtNetAmount.Text = ((newTotalAmount - discount)).ToString();
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtPhoneNo.Text))
                {
                    MessageBox.Show("Please enter phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selectedCustomer = Customer.searchByPhoneNo(txtPhoneNo.Text.Trim());
                if (selectedCustomer.id == 0)
                {
                    MessageBox.Show("Customer not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lblCustAddress.Text = selectedCustomer.address;
                lblCustEmail.Text = selectedCustomer.email;
                lblCustPhoneNumber.Text = selectedCustomer.name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedCustomer.id > 0)
            {
                newCustomerOrder.type = "POS";
                newCustomerOrder.amount = decimal.Parse(txtNetAmount.Text);
                int discount = 0;
                int.TryParse(txtDiscount.Text, out discount);
                newCustomerOrder.discount = discount;

                CustomerOrder customerOrder = newCustomerOrder.create();

                if (customerOrder != null && customerOrder.id != 0)
                {
                    foreach (var item in orderBookList)
                    {
                        CustomerOrderDetails customerOrderDetails = new CustomerOrderDetails();
                        customerOrderDetails.bookId = item.id;
                        customerOrderDetails.custOrderId = customerOrder.id;
                        customerOrderDetails.quantity = item.orderQuantity;
                        customerOrderDetails.create();

                        Book searchedBook = Book.searchById(item.id);
                        if (searchedBook != null)
                        {
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
    }
}
