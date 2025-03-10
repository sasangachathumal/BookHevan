using BookHevan.Helper;
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
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            new Login().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
