namespace BookHevan.View
{
    partial class StaffDashboard
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
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            btnCustomerOrder = new Button();
            btnCustomerManagement = new Button();
            btnPOS = new Button();
            btnBookInventory = new Button();
            btnClose = new Button();
            label1 = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(487, 172);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(456, 300);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 147);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 147);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnCustomerOrder
            // 
            btnCustomerOrder.BackColor = Color.DarkOrange;
            btnCustomerOrder.Cursor = Cursors.Hand;
            btnCustomerOrder.FlatAppearance.BorderSize = 0;
            btnCustomerOrder.FlatStyle = FlatStyle.Flat;
            btnCustomerOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerOrder.ForeColor = Color.White;
            btnCustomerOrder.Location = new Point(490, 98);
            btnCustomerOrder.Name = "btnCustomerOrder";
            btnCustomerOrder.Size = new Size(218, 44);
            btnCustomerOrder.TabIndex = 35;
            btnCustomerOrder.Text = "Customer Order";
            btnCustomerOrder.UseVisualStyleBackColor = false;
            btnCustomerOrder.Click += btnCustomerOrder_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.DarkOrange;
            btnCustomerManagement.Cursor = Cursors.Hand;
            btnCustomerManagement.FlatAppearance.BorderSize = 0;
            btnCustomerManagement.FlatStyle = FlatStyle.Flat;
            btnCustomerManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerManagement.ForeColor = Color.White;
            btnCustomerManagement.Location = new Point(726, 98);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(218, 44);
            btnCustomerManagement.TabIndex = 34;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackColor = Color.DarkOrange;
            btnPOS.Cursor = Cursors.Hand;
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPOS.ForeColor = Color.White;
            btnPOS.Location = new Point(251, 98);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(218, 44);
            btnPOS.TabIndex = 33;
            btnPOS.Text = "POS";
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnBookInventory
            // 
            btnBookInventory.BackColor = Color.DarkOrange;
            btnBookInventory.Cursor = Cursors.Hand;
            btnBookInventory.FlatAppearance.BorderSize = 0;
            btnBookInventory.FlatStyle = FlatStyle.Flat;
            btnBookInventory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBookInventory.ForeColor = Color.White;
            btnBookInventory.Location = new Point(13, 98);
            btnBookInventory.Name = "btnBookInventory";
            btnBookInventory.Size = new Size(218, 44);
            btnBookInventory.TabIndex = 30;
            btnBookInventory.Text = "Book Inventory";
            btnBookInventory.UseVisualStyleBackColor = false;
            btnBookInventory.Click += btnBookInventory_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Brown;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(916, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 32;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(324, 9);
            label1.Name = "label1";
            label1.Size = new Size(354, 45);
            label1.TabIndex = 31;
            label1.Text = "Sales Clerk Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(13, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 32);
            btnLogout.TabIndex = 42;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(956, 483);
            Controls.Add(btnLogout);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCustomerOrder);
            Controls.Add(btnCustomerManagement);
            Controls.Add(btnPOS);
            Controls.Add(btnBookInventory);
            Controls.Add(btnClose);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnCustomerOrder;
        private Button btnCustomerManagement;
        private Button btnPOS;
        private Button btnBookInventory;
        private Button btnClose;
        private Label label1;
        private Button btnLogout;
    }
}