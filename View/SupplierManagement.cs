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
    public partial class SupplierManagement : Form
    {
        private Supplier selectedSupplier = new Supplier();
        private bool isUpdating = false;
        public SupplierManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewRest()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
            txtSearchWord.Clear();

            dgvSupplier.DataSource = Supplier.getSupplierForDataTable();
            dgvSupplier.ClearSelection();

            btnSave.Text = "Save";
            isUpdating = false;
            selectedSupplier = new Supplier();

            txtName.Focus();
        }

        private void SupplierManagement_Load(object sender, EventArgs e)
        {
            viewRest();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];

                // Get data from specific columns
                selectedSupplier.id = int.Parse(row.Cells[0].Value.ToString());
                selectedSupplier.name = row.Cells[1].Value.ToString();
                selectedSupplier.email = row.Cells[2].Value.ToString();
                selectedSupplier.phoneNo = row.Cells[3].Value.ToString();
                selectedSupplier.address = row.Cells[4].Value.ToString();

                txtName.Text = selectedSupplier.name;
                txtEmail.Text = selectedSupplier.email;
                txtPhoneNo.Text = selectedSupplier.phoneNo;
                txtAddress.Text = selectedSupplier.address;

                btnSave.Text = "Update";
                isUpdating = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phoneNo = txtPhoneNo.Text;
            string address = txtAddress.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(phoneNo) && !string.IsNullOrEmpty(address))
            {
                Supplier supplier = new Supplier();
                supplier.name = name;
                supplier.email = email;
                supplier.phoneNo = phoneNo;
                supplier.address = address;
                bool isSuccess = false;

                if (isUpdating)
                {
                    supplier.id = selectedSupplier.id;
                    isSuccess = supplier.update();
                    if (isSuccess)
                    {
                        MessageBox.Show("Supplier update is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewRest();
                    }
                    else
                    {
                        MessageBox.Show("Supplier update fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    isSuccess = supplier.create();
                    if (isSuccess)
                    {
                        MessageBox.Show("Supplier creating is successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewRest();
                    }
                    else
                    {
                        MessageBox.Show("Supplier creation fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide all the information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                MessageBox.Show("Please select a supplier to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Supplier " +
                selectedSupplier.name + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                bool isSuccess = selectedSupplier.delete();
                if (isSuccess)
                {
                    MessageBox.Show("Supplier successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Supplier delete fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                viewRest();
            }
        }

        private void searchSupplier()
        {
            string searchWord = txtSearchWord.Text;

            if (string.IsNullOrEmpty(searchWord))
            {
                dgvSupplier.DataSource = Supplier.getSupplierForDataTable();
                dgvSupplier.ClearSelection();
                return;
            }

            dgvSupplier.DataSource = Supplier.searchByNameForDataTable(searchWord);
            dgvSupplier.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchSupplier();
        }

        private void txtSearchWord_KeyDown(object sender, KeyEventArgs e)
        {
            //searchSupplier();
        }

        private void txtSearchWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchSupplier();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
        }
    }
}
