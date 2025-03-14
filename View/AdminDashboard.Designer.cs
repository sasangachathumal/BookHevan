﻿namespace BookHevan
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            label1 = new Label();
            btnBookInventory = new Button();
            btnPOS = new Button();
            btnCustomerManagement = new Button();
            btnCustomerOrder = new Button();
            btnSupplierOrder = new Button();
            btnSupplierManagement = new Button();
            btnUserManagement = new Button();
            groupBox3 = new GroupBox();
            dgvInventoty = new DataGridView();
            button1 = new Button();
            btnLogout = new Button();
            label2 = new Label();
            label3 = new Label();
            lblTotalSales = new Label();
            lblTotalOrders = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventoty).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Brown;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(915, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 20;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(323, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 45);
            label1.TabIndex = 19;
            label1.Text = "Admin Dashboard";
            // 
            // btnBookInventory
            // 
            btnBookInventory.BackColor = Color.DarkOrange;
            btnBookInventory.Cursor = Cursors.Hand;
            btnBookInventory.FlatAppearance.BorderSize = 0;
            btnBookInventory.FlatStyle = FlatStyle.Flat;
            btnBookInventory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBookInventory.ForeColor = Color.White;
            btnBookInventory.Location = new Point(12, 98);
            btnBookInventory.Name = "btnBookInventory";
            btnBookInventory.Size = new Size(218, 44);
            btnBookInventory.TabIndex = 0;
            btnBookInventory.Text = "Book Inventory";
            btnBookInventory.UseVisualStyleBackColor = false;
            btnBookInventory.Click += btnBookInventory_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackColor = Color.DarkOrange;
            btnPOS.Cursor = Cursors.Hand;
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPOS.ForeColor = Color.White;
            btnPOS.Location = new Point(250, 98);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(218, 44);
            btnPOS.TabIndex = 21;
            btnPOS.Text = "POS";
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.DarkOrange;
            btnCustomerManagement.Cursor = Cursors.Hand;
            btnCustomerManagement.FlatAppearance.BorderSize = 0;
            btnCustomerManagement.FlatStyle = FlatStyle.Flat;
            btnCustomerManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerManagement.ForeColor = Color.White;
            btnCustomerManagement.Location = new Point(12, 174);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(218, 44);
            btnCustomerManagement.TabIndex = 22;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnCustomerOrder
            // 
            btnCustomerOrder.BackColor = Color.DarkOrange;
            btnCustomerOrder.Cursor = Cursors.Hand;
            btnCustomerOrder.FlatAppearance.BorderSize = 0;
            btnCustomerOrder.FlatStyle = FlatStyle.Flat;
            btnCustomerOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerOrder.ForeColor = Color.White;
            btnCustomerOrder.Location = new Point(489, 98);
            btnCustomerOrder.Name = "btnCustomerOrder";
            btnCustomerOrder.Size = new Size(218, 44);
            btnCustomerOrder.TabIndex = 23;
            btnCustomerOrder.Text = "Customer Order";
            btnCustomerOrder.UseVisualStyleBackColor = false;
            btnCustomerOrder.Click += btnCustomerOrder_Click;
            // 
            // btnSupplierOrder
            // 
            btnSupplierOrder.BackColor = Color.DarkOrange;
            btnSupplierOrder.Cursor = Cursors.Hand;
            btnSupplierOrder.FlatAppearance.BorderSize = 0;
            btnSupplierOrder.FlatStyle = FlatStyle.Flat;
            btnSupplierOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSupplierOrder.ForeColor = Color.White;
            btnSupplierOrder.Location = new Point(725, 98);
            btnSupplierOrder.Name = "btnSupplierOrder";
            btnSupplierOrder.Size = new Size(218, 44);
            btnSupplierOrder.TabIndex = 25;
            btnSupplierOrder.Text = "Supplier Order";
            btnSupplierOrder.UseVisualStyleBackColor = false;
            btnSupplierOrder.Click += btnSupplierOrder_Click;
            // 
            // btnSupplierManagement
            // 
            btnSupplierManagement.BackColor = Color.DarkOrange;
            btnSupplierManagement.Cursor = Cursors.Hand;
            btnSupplierManagement.FlatAppearance.BorderSize = 0;
            btnSupplierManagement.FlatStyle = FlatStyle.Flat;
            btnSupplierManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSupplierManagement.ForeColor = Color.White;
            btnSupplierManagement.Location = new Point(250, 174);
            btnSupplierManagement.Name = "btnSupplierManagement";
            btnSupplierManagement.Size = new Size(218, 44);
            btnSupplierManagement.TabIndex = 24;
            btnSupplierManagement.Text = "Supplier Management";
            btnSupplierManagement.UseVisualStyleBackColor = false;
            btnSupplierManagement.Click += btnSupplierManagement_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.DarkOrange;
            btnUserManagement.Cursor = Cursors.Hand;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(489, 174);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(218, 44);
            btnUserManagement.TabIndex = 26;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvInventoty);
            groupBox3.Location = new Point(337, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(606, 348);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Inventory List";
            // 
            // dgvInventoty
            // 
            dgvInventoty.AllowUserToAddRows = false;
            dgvInventoty.AllowUserToDeleteRows = false;
            dgvInventoty.AllowUserToResizeColumns = false;
            dgvInventoty.AllowUserToResizeRows = false;
            dgvInventoty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventoty.BackgroundColor = Color.White;
            dgvInventoty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoty.GridColor = Color.Black;
            dgvInventoty.Location = new Point(6, 22);
            dgvInventoty.MultiSelect = false;
            dgvInventoty.Name = "dgvInventoty";
            dgvInventoty.ReadOnly = true;
            dgvInventoty.ShowCellErrors = false;
            dgvInventoty.ShowCellToolTips = false;
            dgvInventoty.ShowEditingIcon = false;
            dgvInventoty.ShowRowErrors = false;
            dgvInventoty.Size = new Size(594, 320);
            dgvInventoty.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(725, 174);
            button1.Name = "button1";
            button1.Size = new Size(218, 44);
            button1.TabIndex = 29;
            button1.Text = "Sales Reports";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 32);
            btnLogout.TabIndex = 30;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(62, 272);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 0;
            label2.Text = "Total Sales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(51, 435);
            label3.Name = "label3";
            label3.Size = new Size(175, 37);
            label3.TabIndex = 31;
            label3.Text = "Total Orders";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.FlatStyle = FlatStyle.Flat;
            lblTotalSales.Font = new Font("Segoe UI", 18F);
            lblTotalSales.Location = new Point(88, 333);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(0, 32);
            lblTotalSales.TabIndex = 32;
            lblTotalSales.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalSales.UseWaitCursor = true;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.FlatStyle = FlatStyle.Flat;
            lblTotalOrders.Font = new Font("Segoe UI", 18F);
            lblTotalOrders.Location = new Point(88, 499);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(0, 32);
            lblTotalOrders.TabIndex = 33;
            lblTotalOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(958, 603);
            ControlBox = false;
            Controls.Add(lblTotalOrders);
            Controls.Add(lblTotalSales);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(btnUserManagement);
            Controls.Add(btnSupplierOrder);
            Controls.Add(btnSupplierManagement);
            Controls.Add(btnCustomerOrder);
            Controls.Add(btnCustomerManagement);
            Controls.Add(btnPOS);
            Controls.Add(btnBookInventory);
            Controls.Add(btnClose);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventoty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Button btnBookInventory;
        private Button btnPOS;
        private Button btnCustomerManagement;
        private Button btnCustomerOrder;
        private Button btnSupplierOrder;
        private Button btnSupplierManagement;
        private Button btnUserManagement;
        private GroupBox groupBox3;
        private Button button1;
        private Button btnLogout;
        private Label label2;
        private DataGridView dgvInventoty;
        private Label label3;
        private Label lblTotalSales;
        private Label lblTotalOrders;
    }
}