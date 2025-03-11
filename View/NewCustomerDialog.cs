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
    public partial class NewCustomerDialog : Form
    {
        public PointOfSales pointOfSales = new PointOfSales();
        public NewCustomerDialog(PointOfSales pointOfSales)
        {
            this.pointOfSales = pointOfSales;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all the text fields
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the values from the text fields
            string name = txtName.Text;
            string phone = txtPhoneNo.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            bool isSuccess = false;

            // Validate the email address
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
                // Create the customer
                isSuccess = customer.create();
                if (isSuccess)
                {
                    MessageBox.Show("Customer creating is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Search the customer by phone number
                    Customer searchedCustomer = Customer.searchByPhoneNo(phone);
                    if (searchedCustomer != null)
                    {
                        // Set the customer to the point of sales object
                        pointOfSales.SetCustomer(searchedCustomer);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Customer creation fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Customer creation fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please provide all the information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only English letters (both upper and lower case) and control characters (like backspace)
            if (FieldValidations.isAllLetters(e))
            {
                e.Handled = true;
            }
        }
    }
}
