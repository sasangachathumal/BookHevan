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
            btnCustomerOrder = new Button();
            btnCustomerManagement = new Button();
            btnPOS = new Button();
            btnBookInventory = new Button();
            btnClose = new Button();
            label1 = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnCustomerOrder
            // 
            btnCustomerOrder.BackColor = Color.DarkOrange;
            btnCustomerOrder.Cursor = Cursors.Hand;
            btnCustomerOrder.FlatAppearance.BorderSize = 0;
            btnCustomerOrder.FlatStyle = FlatStyle.Flat;
            btnCustomerOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerOrder.ForeColor = Color.White;
            btnCustomerOrder.Location = new Point(13, 172);
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
            btnCustomerManagement.Location = new Point(249, 172);
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
            btnClose.Location = new Point(441, 9);
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
            label1.Location = new Point(70, 9);
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
            btnLogout.Location = new Point(13, 237);
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
            ClientSize = new Size(485, 285);
            Controls.Add(btnLogout);
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
        private Button btnCustomerOrder;
        private Button btnCustomerManagement;
        private Button btnPOS;
        private Button btnBookInventory;
        private Button btnClose;
        private Label label1;
        private Button btnLogout;
    }
}