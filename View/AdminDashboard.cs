using BookHevan.Helper;
using BookHevan.Model;
using BookHevan.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHevan
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnBookInventory_Click(object sender, EventArgs e)
        {
            new BookInventoryManagement().Show();
            this.Hide();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            new PointOfSales().Show();
            this.Hide();
        }

        private void btnCustomerOrder_Click(object sender, EventArgs e)
        {
            new CustomerOrderManagement().Show();
            this.Hide();
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            new CustomerManagement().Show();
            this.Hide();
        }

        private void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            new SupplierManagement().Show();
            this.Hide();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            new UserManagement().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSupplierOrder_Click(object sender, EventArgs e)
        {
            new SupplierOrderManagement().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SalesReports().Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            dgvInventoty.DataSource = SalesReportsModel.getSalesReportInventoryStatus();
            dgvInventoty.ClearSelection();

            string counts = SalesReportsModel.getSalesCounts();
            if (!string.IsNullOrEmpty(counts))
            {
                string[] results = counts.Split(',');
                lblTotalSales.Text = results[0];
                lblTotalOrders.Text = results[1];
            }

        }
    }
}
