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
using System.Xml.Linq;

namespace BookHevan.View
{
    public partial class CustomerOrderManagement : Form
    {
        Customer selectedCustomer = new Customer();
        CustomerOrder selectedOrder = new CustomerOrder();
        CustomerOrderDetails selectedOrderDetail = new CustomerOrderDetails();
        bool isUpdatingOrder = false;
        bool isUpdatingOrderDetails = false;
        public CustomerOrderManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewCustomerOrder_Click(object sender, EventArgs e)
        {
            new NewCustomerOrder().ShowDialog();
        }

        private void CustomerOrderManagement_Load(object sender, EventArgs e)
        {
            viewRest();
        }

        /**
         * This method is used to reset the view
         */
        private void viewRest()
        {
            // Clear all the fields
            lblCustomerAddress.Text = string.Empty;
            lblCustomerEmail.Text = string.Empty;
            lblCustomerPhoneNo.Text = string.Empty;
            // Get all the customers and add them to the combo box
            DataTable customerDT = Customer.getCustomersForDataTable();
            comCustomerSelect.Items.Clear();
            comCustomerSelect.Items.Add("--SELECT--");
            foreach (DataRow Dr in customerDT.Rows)
            {
                comCustomerSelect.Items.Add(Dr["name"]);
            }
            comCustomerSelect.SelectedIndex = 0;
            // Clear the data grid views
            dgvOrderDetail.DataSource = null;
            dgvCustomerOrders.DataSource = null;
            // Disable the buttons
            btnClearOrderDetailSelect.Enabled = false;
            btnDeleteOrderDetail.Enabled = false;
            // Clear the text fields
            txtDiscount.Text = string.Empty;
            txtNetAmount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            // Reset the flags
            isUpdatingOrder = false;
            isUpdatingOrderDetails = false;
            // Reset the selected objects
            selectedCustomer = new Customer();
            selectedOrder = new CustomerOrder();
            selectedOrderDetail = new CustomerOrderDetails();
        }

        private void comCustomerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comCustomerSelect.SelectedIndex > 0)
            {
                // Get the selected customer name
                string selectedCustomerName = comCustomerSelect.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selectedCustomerName))
                {
                    // Search for the customer by name
                    Customer searched = Customer.searchByName(selectedCustomerName);
                    if (searched?.id != null)
                    {
                        // Set the customer details
                        lblCustomerEmail.Text = searched.email;
                        lblCustomerAddress.Text = searched.address;
                        lblCustomerPhoneNo.Text = searched.phoneNo;
                        // Set the selected customer
                        selectedCustomer.id = searched.id;
                        selectedCustomer.address = searched.address;
                        selectedCustomer.email = searched.email;
                        selectedCustomer.phoneNo = searched.phoneNo;
                        selectedCustomer.name = searched.name;
                        // Get the customer orders and add them to the data grid view
                        dgvCustomerOrders.DataSource = CustomerOrder.getOrdersByCustomerForDataTable(selectedCustomer.id);
                        dgvCustomerOrders.ClearSelection();
                    }
                }
            }
        }

        private void dgvCustomerOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomerOrders.Rows[e.RowIndex];

                // Get data from specific columns
                selectedOrder.id = int.Parse(row.Cells[0].Value.ToString());
                selectedOrder.date = row.Cells[1].Value.ToString();
                selectedOrder.amount = decimal.Parse(row.Cells[2].Value.ToString());
                if (row.Cells[3].Value.ToString() != "")
                {
                    selectedOrder.discount = int.Parse(row.Cells[3].Value.ToString());
                }
                else { selectedOrder.discount = 0; }
                selectedOrder.noOfItems = int.Parse(row.Cells[4].Value.ToString());
                selectedOrder.type = row.Cells[5].Value.ToString();
                // Set the flags
                isUpdatingOrder = true;
                isUpdatingOrderDetails = false;
                // Reset the selected order details
                selectedOrderDetail = new CustomerOrderDetails();
                // Get the order details and add them to the data grid view
                dgvOrderDetail.DataSource = CustomerOrderDetails.getOrdersDetailsByOrderForDataTable(selectedOrder.id);
                dgvOrderDetail.ClearSelection();
                // Set the text fields
                txtDiscount.Text = selectedOrder.discount.ToString();
                txtNetAmount.Text = selectedOrder.amount.ToString();
                txtTotalAmount.Text = (selectedOrder.amount + selectedOrder.discount).ToString();
            }
        }

        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrderDetail.Rows[e.RowIndex];

                // Get data from specific columns
                selectedOrderDetail.custOrderId = int.Parse(row.Cells[0].Value.ToString());
                selectedOrderDetail.bookId = int.Parse(row.Cells[1].Value.ToString());
                selectedOrderDetail.quantity = int.Parse(row.Cells[7].Value.ToString());
                // Set the flags
                isUpdatingOrderDetails = true;
                // Set the text fields
                txtQuantity.Text = selectedOrderDetail.quantity.ToString();

                btnClearOrderDetailSelect.Enabled = true;
                btnDeleteOrderDetail.Enabled = true;
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void btnClearOrderDetailSelect_Click(object sender, EventArgs e)
        {
            // reset the text fields
            txtDiscount.Text = string.Empty;
            txtNetAmount.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            // reset the flags
            txtQuantity.Enabled = false;
            // reset the selected order details
            dgvOrderDetail.ClearSelection();
            // reset the buttons
            btnClearOrderDetailSelect.Enabled = false;
            btnDeleteOrderDetail.Enabled = false;
            // reset the selected order details
            selectedOrderDetail = new CustomerOrderDetails();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Check if the user is updating an order
            if (!isUpdatingOrder)
            {
                MessageBox.Show("Please select a order to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Confirm the delete action
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Customer Order " +
                selectedOrder.id + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check the user response
            if (diaRes == DialogResult.Yes)
            {
                // Delete the order
                bool isSuccess = selectedOrder.delete();
                if (isSuccess)
                {
                    MessageBox.Show("Customer order successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear the text fields
                    txtDiscount.Text = string.Empty;
                    txtNetAmount.Text = string.Empty;
                    txtTotalAmount.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                    // Disable the text field
                    txtQuantity.Enabled = false;
                    // Clear the data grid views
                    dgvOrderDetail.DataSource = null;
                    dgvCustomerOrders.DataSource = CustomerOrder.getOrdersByCustomerForDataTable(selectedCustomer.id);
                    dgvCustomerOrders.ClearSelection();
                    // Reset the buttons
                    btnClearOrderDetailSelect.Enabled = false;
                    btnDeleteOrderDetail.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Customer order delete fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (!isUpdatingOrderDetails)
            {
                MessageBox.Show("Please select a order item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Customer Order item " +
                selectedOrderDetail.bookId + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                bool isSuccess = selectedOrderDetail.delete();
                if (isSuccess)
                {
                    MessageBox.Show("Customer order item successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiscount.Text = string.Empty;
                    txtNetAmount.Text = string.Empty;
                    txtTotalAmount.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                    txtQuantity.Enabled = false;
                    dgvOrderDetail.ClearSelection();
                    btnClearOrderDetailSelect.Enabled = false;
                    btnDeleteOrderDetail.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Customer order item delete fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            // get the new quantity
            int newQuantity = int.Parse(txtQuantity.Text);
            // check if the quantity is not changed
            if (newQuantity == selectedOrderDetail.quantity)
            {
                MessageBox.Show("Quantity not changed to perform an update", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int difference = newQuantity - selectedOrderDetail.quantity;
            selectedOrderDetail.quantity = newQuantity;
            bool isSuccess = selectedOrderDetail.update();
            if (isSuccess)
            {
                Book searchedBook = Book.searchById(selectedOrderDetail.bookId);
                if (searchedBook.price > 0)
                {
                    decimal differenceInPrice = searchedBook.price * difference;
                    decimal newAmount = selectedOrder.amount + differenceInPrice;
                    selectedOrder.amount = newAmount;
                    selectedOrder.noOfItems += difference;
                    bool isOrderUpdateSuccess = selectedOrder.update();

                    if (isOrderUpdateSuccess)
                    {
                        dgvCustomerOrders.DataSource = CustomerOrder.getOrdersByCustomerForDataTable(selectedCustomer.id);
                        dgvOrderDetail.DataSource = CustomerOrderDetails.getOrdersDetailsByOrderForDataTable(selectedOrder.id);

                        txtDiscount.Text = string.Empty;
                        txtNetAmount.Text = string.Empty;
                        txtTotalAmount.Text = string.Empty;
                        txtQuantity.Text = string.Empty;
                        txtQuantity.Enabled = false;
                        dgvOrderDetail.ClearSelection();
                        btnClearOrderDetailSelect.Enabled = false;
                        btnDeleteOrderDetail.Enabled = false;
                        MessageBox.Show("Order item quantity updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Order item quantity update fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Order item quantity update fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
        }
    }
}
