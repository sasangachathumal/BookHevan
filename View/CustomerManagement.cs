using BookHevan.Helper;
using BookHevan.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CustomerManagement : Form
    {
        private Customer selectedCustomer = new Customer();
        private bool isUpdating = false;
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            viewRest();
        }

        /**
         * This method is used to reset the view to the initial state
         */
        private void viewRest()
        {
            // Clear all the text fields
            txtEmail.Clear();
            txtName.Clear();
            txtPhoneNo.Clear();
            txtAddress.Clear();
            txtSearchWord.Clear();
            // Load all the customers to the data grid view
            dgvCustomer.DataSource = Customer.getCustomersForDataTable();
            dgvCustomer.ClearSelection();
            // Set the button text to "Save" and set the isUpdating flag to false
            btnSave.Text = "Save";
            isUpdating = false;
            selectedCustomer = new Customer();
            // Set the focus to the name text field
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the values from the text fields
            string name = txtName.Text;
            string phone = txtPhoneNo.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            bool isSuccess = false;
            // Check if the email is valid
            if (!string.IsNullOrEmpty(email) && !FieldValidations.isEmailValid(email))
            {
                MessageBox.Show("Please provide a valid email address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the name and phone number are not empty
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phone))
            {
                // Create a new customer object
                Customer customer = new Customer();
                // Set the values to the customer object
                customer.name = name;
                customer.phoneNo = phone;
                customer.address = address;
                customer.email = email;
                // Check if the customer is updating
                if (isUpdating)
                {
                    // Set the customer id to the selected customer id
                    customer.id = selectedCustomer.id;
                    // Update the customer
                    isSuccess = customer.update();
                    if (isSuccess)
                    {
                        MessageBox.Show("Customer update is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewRest();
                    }
                    else
                    {
                        MessageBox.Show("Customer update fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Create a new customer
                    isSuccess = customer.create();
                    if (isSuccess)
                    {
                        MessageBox.Show("Customer creating is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewRest();
                    }
                    else
                    {
                        MessageBox.Show("Customer creation fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide all the information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                // Get data from specific columns
                selectedCustomer.id = int.Parse(row.Cells[0].Value.ToString());
                selectedCustomer.email = row.Cells[1].Value.ToString();
                selectedCustomer.name = row.Cells[2].Value.ToString();
                selectedCustomer.phoneNo = row.Cells[3].Value.ToString();
                selectedCustomer.address = row.Cells[4].Value.ToString();
                // Set the values to the text fields
                txtName.Text = selectedCustomer.name;
                txtEmail.Text = selectedCustomer.email;
                txtPhoneNo.Text = selectedCustomer.phoneNo;
                txtAddress.Text = selectedCustomer.address;
                // Set the button text to "Update" and set the isUpdating flag to true
                btnSave.Text = "Update";
                isUpdating = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the user is updating
            if (!isUpdating)
            {
                MessageBox.Show("Please select a customer to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Show a confirmation dialog
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Customer " +
                selectedCustomer.name + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check if the user confirmed the deletion
            if (diaRes == DialogResult.Yes)
            {
                // Delete the customer
                bool isSuccess = selectedCustomer.delete();
                if (isSuccess)
                {
                    MessageBox.Show("Customer successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer delete fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                viewRest();
            }
        }

        /**
         * This method is used to search for a customer based on the name
         */
        private void searchCustomer()
        {
            // Get the search word from the text field
            string searchWord = txtSearchWord.Text;
            // Check if the search word is empty
            if (string.IsNullOrEmpty(searchWord))
            {
                // Load all the customers to the data grid view if the search word is empty
                dgvCustomer.DataSource = Customer.getCustomersForDataTable();
                dgvCustomer.ClearSelection();
                return;
            }
            // Search for the customer based on the name
            dgvCustomer.DataSource = Customer.searchByCustomerNameForDataTable(searchWord);
            dgvCustomer.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchCustomer();
        }

        private void txtSearchWord_KeyDown(object sender, KeyEventArgs e)
        {
            searchCustomer();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only English letters (both upper and lower case) and control characters (like backspace)
            if (FieldValidations.isAllLetters(e))
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
