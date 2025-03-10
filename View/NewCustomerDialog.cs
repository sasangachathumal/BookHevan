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
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhoneNo.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            bool isSuccess = false;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phone))
            {

                Customer customer = new Customer();
                customer.name = name;
                customer.phoneNo = phone;
                customer.address = address;
                customer.email = email;

                isSuccess = customer.create();
                if (isSuccess)
                {
                    MessageBox.Show("Customer creating is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Customer searchedCustomer = Customer.searchByPhoneNo(phone);
                    if (searchedCustomer != null)
                    {
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
    }
}
