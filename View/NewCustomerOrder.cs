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
        Book selectedBook = new Book();
        Customer selectedCustomer = new Customer();
        List<NewOrderBookDetail> orderBookList = new List<NewOrderBookDetail>();
        CustomerOrder newCustomerOrder = new CustomerOrder();

        public NewCustomerOrder()
        {
            InitializeComponent();
        }

        private void NewCustomerOrder_Load(object sender, EventArgs e)
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
            txtQuantity.Enabled = false;
            btnAdd.Enabled = false;
            txtTotalAmount.Text = string.Empty;
            comType.Enabled = false;

            newCustomerOrder = new CustomerOrder();
            orderBookList = new List<NewOrderBookDetail>();
            selectedCustomer = new Customer();
            selectedBook = new Book();

            loadComboBox();
        }

        private void loadComboBox()
        {
            DataTable customerDT = Customer.getCustomersForDataTable();
            comCustName.Items.Clear();
            comCustName.Items.Add("--Select--");
            foreach (DataRow Dr in customerDT.Rows)
            {
                comCustName.Items.Add(Dr["name"]);
            }
            comCustName.SelectedIndex = 0;

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
            if (comCustName.SelectedIndex > 0)
            {
                string selectedCustomerName = comCustName.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selectedCustomerName))
                {
                    Customer searched = Customer.searchByName(selectedCustomerName);
                    if (searched?.id != null)
                    {
                        lblCustEmail.Text = searched.email;
                        lblCustAddress.Text = searched.address;
                        lblCustPhoneNumber.Text = searched.phoneNo;

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
            //newCustomerOrder.amount = (selectedBook.price * int.Parse(txtQuantity.Text));

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
    }
}
