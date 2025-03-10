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
    public partial class SupplierOrderManagement : Form
    {
        private bool isUpdatingOrder = false;
        private Supplier selectedSupplier = new Supplier();
        private SupplierOrder selectedOrder = new SupplierOrder();

        public SupplierOrderManagement()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewRest()
        {
            lblSupplierAddress.Text = string.Empty;
            lblSupplierEmail.Text = string.Empty;
            lblSupplierPhoneNo.Text = string.Empty;

            DataTable supplierDT = Supplier.getSupplierForDataTable();
            comSupplierName.Items.Clear();
            comSupplierName.Items.Add("--SELECT--");
            foreach (DataRow Dr in supplierDT.Rows)
            {
                comSupplierName.Items.Add(Dr["name"]);
            }
            comSupplierName.SelectedIndex = 0;

            dgvSupplierOrders.DataSource = null;
            isUpdatingOrder = false;
            selectedSupplier = new Supplier();
        }

        private void SupplierOrderManagement_Load(object sender, EventArgs e)
        {
            viewRest();
        }

        private void comSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSupplierName.SelectedIndex > 0)
            {
                string selectedSupplierName = comSupplierName.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selectedSupplierName))
                {
                    Supplier searched = Supplier.searchByName(selectedSupplierName);
                    if (searched?.id != null)
                    {
                        lblSupplierEmail.Text = searched.email;
                        lblSupplierAddress.Text = searched.address;
                        lblSupplierPhoneNo.Text = searched.phoneNo;

                        selectedSupplier.id = searched.id;
                        selectedSupplier.address = searched.address;
                        selectedSupplier.email = searched.email;
                        selectedSupplier.phoneNo = searched.phoneNo;
                        selectedSupplier.name = searched.name;

                        dgvSupplierOrders.DataSource = SupplierOrder.getOrdersBySupplierForDataTable(selectedSupplier.id);
                        dgvSupplierOrders.ClearSelection();
                    }
                }
            }
        }

        private void dgvSupplierOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplierOrders.Rows[e.RowIndex];

                // Get data from specific columns
                selectedOrder.id = int.Parse(row.Cells[0].Value.ToString());
                selectedOrder.date = row.Cells[1].Value.ToString();

                SupplierOrder searched = SupplierOrder.searchById(selectedOrder.id);
                if (searched?.id != null)
                {
                    selectedOrder = searched;
                    isUpdatingOrder = true;
                }
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            viewRest();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (!isUpdatingOrder)
            {
                MessageBox.Show("Please select a order to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Supplier Order " +
                selectedOrder.id + " from the System? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                bool isSuccess = selectedOrder.delete();
                if (isSuccess)
                {
                    MessageBox.Show("Customer order successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSupplierOrders.DataSource = SupplierOrder.getOrdersBySupplierForDataTable(selectedSupplier.id);
                    dgvSupplierOrders.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Customer order delete fail. Plese try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
