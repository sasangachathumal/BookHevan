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

        private void viewRest()
        {
            txtEmail.Clear();
            txtName.Clear();
            txtPhoneNo.Clear();
            txtAddress.Clear();
            txtSearchWord.Clear();

            dgvCustomer.DataSource = Customer.getCustomersForDataTable();
            dgvCustomer.ClearSelection();

            btnSave.Text = "Save";
            isUpdating = false;
            selectedCustomer = new Customer();

            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

                if (isUpdating)
                {
                    customer.id = selectedCustomer.id;
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

                txtName.Text = selectedCustomer.name;
                txtEmail.Text = selectedCustomer.email;
                txtPhoneNo.Text = selectedCustomer.phoneNo;
                txtAddress.Text = selectedCustomer.address;

                btnSave.Text = "Update";
                isUpdating = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                MessageBox.Show("Please select a customer to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Customer " +
                selectedCustomer.name + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
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

        private void searchCustomer()
        {
            string searchWord = txtSearchWord.Text;

            if (string.IsNullOrEmpty(searchWord))
            {
                dgvCustomer.DataSource = Customer.getCustomersForDataTable();
                dgvCustomer.ClearSelection();
                return;
            }

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
    }
}
