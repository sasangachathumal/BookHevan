namespace BookHevan.View
{
    partial class SupplierOrderManagement
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
            btnClearOrder = new Button();
            btnDeleteOrder = new Button();
            dgvSupplierOrders = new DataGridView();
            groupBox2 = new GroupBox();
            lblSupplierAddress = new Label();
            lblSupplierEmail = new Label();
            lblSupplierPhoneNo = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comSupplierName = new ComboBox();
            groupBox1 = new GroupBox();
            btnHome = new Button();
            label1 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierOrders).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClearOrder
            // 
            btnClearOrder.BackColor = Color.SteelBlue;
            btnClearOrder.Cursor = Cursors.Hand;
            btnClearOrder.FlatAppearance.BorderSize = 0;
            btnClearOrder.FlatStyle = FlatStyle.Flat;
            btnClearOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearOrder.ForeColor = Color.White;
            btnClearOrder.Location = new Point(1176, 357);
            btnClearOrder.Name = "btnClearOrder";
            btnClearOrder.Size = new Size(66, 32);
            btnClearOrder.TabIndex = 15;
            btnClearOrder.Text = "Clear";
            btnClearOrder.UseVisualStyleBackColor = false;
            btnClearOrder.Click += btnClearOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.Brown;
            btnDeleteOrder.Cursor = Cursors.Hand;
            btnDeleteOrder.FlatAppearance.BorderSize = 0;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteOrder.ForeColor = Color.White;
            btnDeleteOrder.Location = new Point(1077, 357);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(93, 32);
            btnDeleteOrder.TabIndex = 14;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // dgvSupplierOrders
            // 
            dgvSupplierOrders.AllowUserToAddRows = false;
            dgvSupplierOrders.AllowUserToDeleteRows = false;
            dgvSupplierOrders.AllowUserToResizeColumns = false;
            dgvSupplierOrders.AllowUserToResizeRows = false;
            dgvSupplierOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplierOrders.BackgroundColor = Color.White;
            dgvSupplierOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierOrders.GridColor = Color.Black;
            dgvSupplierOrders.Location = new Point(6, 22);
            dgvSupplierOrders.MultiSelect = false;
            dgvSupplierOrders.Name = "dgvSupplierOrders";
            dgvSupplierOrders.ReadOnly = true;
            dgvSupplierOrders.ShowCellToolTips = false;
            dgvSupplierOrders.ShowEditingIcon = false;
            dgvSupplierOrders.Size = new Size(865, 232);
            dgvSupplierOrders.TabIndex = 0;
            dgvSupplierOrders.CellClick += dgvSupplierOrders_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSupplierOrders);
            groupBox2.Location = new Point(365, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(877, 260);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Supplier Orders";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Font = new Font("Segoe UI", 12F);
            lblSupplierAddress.Location = new Point(6, 194);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(0, 21);
            lblSupplierAddress.TabIndex = 9;
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.Font = new Font("Segoe UI", 12F);
            lblSupplierEmail.Location = new Point(6, 100);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(0, 21);
            lblSupplierEmail.TabIndex = 8;
            // 
            // lblSupplierPhoneNo
            // 
            lblSupplierPhoneNo.AutoSize = true;
            lblSupplierPhoneNo.Font = new Font("Segoe UI", 12F);
            lblSupplierPhoneNo.Location = new Point(6, 147);
            lblSupplierPhoneNo.Name = "lblSupplierPhoneNo";
            lblSupplierPhoneNo.Size = new Size(0, 21);
            lblSupplierPhoneNo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 173);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 6;
            label5.Text = "Supplier Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(185, 21);
            label4.TabIndex = 5;
            label4.Text = "Supplier Phone Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 79);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 3;
            label3.Text = "Supplier Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 1;
            label2.Text = "Supplier Name";
            // 
            // comSupplierName
            // 
            comSupplierName.DropDownStyle = ComboBoxStyle.DropDownList;
            comSupplierName.Font = new Font("Segoe UI", 12F);
            comSupplierName.FormattingEnabled = true;
            comSupplierName.Location = new Point(6, 43);
            comSupplierName.Name = "comSupplierName";
            comSupplierName.Size = new Size(331, 29);
            comSupplierName.TabIndex = 0;
            comSupplierName.SelectedIndexChanged += comSupplierName_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSupplierAddress);
            groupBox1.Controls.Add(lblSupplierEmail);
            groupBox1.Controls.Add(lblSupplierPhoneNo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comSupplierName);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 260);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aupplier Info";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DarkOrange;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(87, 34);
            btnHome.TabIndex = 21;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(393, 12);
            label1.Name = "label1";
            label1.Size = new Size(448, 45);
            label1.TabIndex = 20;
            label1.Text = "Supplier Order Management";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Brown;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1214, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 22;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // SupplierOrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1250, 398);
            Controls.Add(btnClearOrder);
            Controls.Add(btnDeleteOrder);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnHome);
            Controls.Add(label1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierOrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierOrderManagement";
            Load += SupplierOrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplierOrders).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClearOrder;
        private Button btnDeleteOrder;
        private DataGridView dgvSupplierOrders;
        private GroupBox groupBox2;
        private Label lblSupplierAddress;
        private Label lblSupplierEmail;
        private Label lblSupplierPhoneNo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comSupplierName;
        private GroupBox groupBox1;
        private Button btnHome;
        private Label label1;
        private Button btnClose;
    }
}