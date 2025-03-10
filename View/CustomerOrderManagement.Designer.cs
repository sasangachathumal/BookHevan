namespace BookHevan.View
{
    partial class CustomerOrderManagement
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
            btnHome = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblCustomerAddress = new Label();
            lblCustomerEmail = new Label();
            lblCustomerPhoneNo = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comCustomerSelect = new ComboBox();
            groupBox2 = new GroupBox();
            btnClearOrder = new Button();
            btnDeleteOrder = new Button();
            dgvCustomerOrders = new DataGridView();
            btnNewCustomerOrder = new Button();
            groupBox3 = new GroupBox();
            btnUpdateOrderDetail = new Button();
            label9 = new Label();
            txtNetAmount = new TextBox();
            btnClearOrderDetailSelect = new Button();
            btnDeleteOrderDetail = new Button();
            label12 = new Label();
            txtDiscount = new TextBox();
            label11 = new Label();
            txtTotalAmount = new TextBox();
            label10 = new Label();
            txtQuantity = new TextBox();
            dgvOrderDetail = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
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
            btnClose.Location = new Point(1157, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 15;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            btnHome.TabIndex = 14;
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
            label1.Size = new Size(467, 45);
            label1.TabIndex = 13;
            label1.Text = "Customer Order Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCustomerAddress);
            groupBox1.Controls.Add(lblCustomerEmail);
            groupBox1.Controls.Add(lblCustomerPhoneNo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comCustomerSelect);
            groupBox1.Location = new Point(12, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 260);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Info";
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Font = new Font("Segoe UI", 12F);
            lblCustomerAddress.Location = new Point(6, 194);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(0, 21);
            lblCustomerAddress.TabIndex = 9;
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.Font = new Font("Segoe UI", 12F);
            lblCustomerEmail.Location = new Point(6, 100);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(0, 21);
            lblCustomerEmail.TabIndex = 8;
            // 
            // lblCustomerPhoneNo
            // 
            lblCustomerPhoneNo.AutoSize = true;
            lblCustomerPhoneNo.Font = new Font("Segoe UI", 12F);
            lblCustomerPhoneNo.Location = new Point(6, 147);
            lblCustomerPhoneNo.Name = "lblCustomerPhoneNo";
            lblCustomerPhoneNo.Size = new Size(0, 21);
            lblCustomerPhoneNo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 173);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 6;
            label5.Text = "Customer Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(195, 21);
            label4.TabIndex = 5;
            label4.Text = "Customer Phone Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 79);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 3;
            label3.Text = "Customer Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            // 
            // comCustomerSelect
            // 
            comCustomerSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            comCustomerSelect.Font = new Font("Segoe UI", 12F);
            comCustomerSelect.FormattingEnabled = true;
            comCustomerSelect.Location = new Point(6, 43);
            comCustomerSelect.Name = "comCustomerSelect";
            comCustomerSelect.Size = new Size(331, 29);
            comCustomerSelect.TabIndex = 0;
            comCustomerSelect.SelectedIndexChanged += comCustomerSelect_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClearOrder);
            groupBox2.Controls.Add(btnDeleteOrder);
            groupBox2.Controls.Add(dgvCustomerOrders);
            groupBox2.Location = new Point(365, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(819, 260);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer Orders";
            // 
            // btnClearOrder
            // 
            btnClearOrder.BackColor = Color.SteelBlue;
            btnClearOrder.Cursor = Cursors.Hand;
            btnClearOrder.FlatAppearance.BorderSize = 0;
            btnClearOrder.FlatStyle = FlatStyle.Flat;
            btnClearOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearOrder.ForeColor = Color.White;
            btnClearOrder.Location = new Point(747, 221);
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
            btnDeleteOrder.Location = new Point(648, 221);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(93, 32);
            btnDeleteOrder.TabIndex = 14;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.AllowUserToAddRows = false;
            dgvCustomerOrders.AllowUserToDeleteRows = false;
            dgvCustomerOrders.AllowUserToResizeColumns = false;
            dgvCustomerOrders.AllowUserToResizeRows = false;
            dgvCustomerOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerOrders.BackgroundColor = Color.White;
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.GridColor = Color.Black;
            dgvCustomerOrders.Location = new Point(6, 22);
            dgvCustomerOrders.MultiSelect = false;
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.ShowCellToolTips = false;
            dgvCustomerOrders.ShowEditingIcon = false;
            dgvCustomerOrders.Size = new Size(807, 193);
            dgvCustomerOrders.TabIndex = 0;
            dgvCustomerOrders.CellClick += dgvCustomerOrders_CellClick;
            // 
            // btnNewCustomerOrder
            // 
            btnNewCustomerOrder.BackColor = Color.DarkOrange;
            btnNewCustomerOrder.Cursor = Cursors.Hand;
            btnNewCustomerOrder.FlatAppearance.BorderSize = 0;
            btnNewCustomerOrder.FlatStyle = FlatStyle.Flat;
            btnNewCustomerOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewCustomerOrder.ForeColor = Color.White;
            btnNewCustomerOrder.Location = new Point(12, 83);
            btnNewCustomerOrder.Name = "btnNewCustomerOrder";
            btnNewCustomerOrder.Size = new Size(201, 34);
            btnNewCustomerOrder.TabIndex = 18;
            btnNewCustomerOrder.Text = "+ New Customer Order";
            btnNewCustomerOrder.UseVisualStyleBackColor = false;
            btnNewCustomerOrder.Click += btnNewCustomerOrder_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnUpdateOrderDetail);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtNetAmount);
            groupBox3.Controls.Add(btnClearOrderDetailSelect);
            groupBox3.Controls.Add(btnDeleteOrderDetail);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtDiscount);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtTotalAmount);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtQuantity);
            groupBox3.Controls.Add(dgvOrderDetail);
            groupBox3.Location = new Point(12, 410);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1173, 289);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer Order Details";
            // 
            // btnUpdateOrderDetail
            // 
            btnUpdateOrderDetail.BackColor = Color.DarkOrange;
            btnUpdateOrderDetail.Cursor = Cursors.Hand;
            btnUpdateOrderDetail.Enabled = false;
            btnUpdateOrderDetail.FlatAppearance.BorderColor = Color.DarkOrange;
            btnUpdateOrderDetail.FlatAppearance.BorderSize = 0;
            btnUpdateOrderDetail.FlatStyle = FlatStyle.Flat;
            btnUpdateOrderDetail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateOrderDetail.ForeColor = Color.White;
            btnUpdateOrderDetail.Location = new Point(902, 249);
            btnUpdateOrderDetail.Name = "btnUpdateOrderDetail";
            btnUpdateOrderDetail.Size = new Size(93, 32);
            btnUpdateOrderDetail.TabIndex = 31;
            btnUpdateOrderDetail.Text = "Update";
            btnUpdateOrderDetail.UseVisualStyleBackColor = false;
            btnUpdateOrderDetail.Visible = false;
            btnUpdateOrderDetail.Click += btnUpdateOrderDetail_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(902, 190);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 29;
            label9.Text = "Net Amount";
            // 
            // txtNetAmount
            // 
            txtNetAmount.Enabled = false;
            txtNetAmount.Font = new Font("Segoe UI", 12F);
            txtNetAmount.Location = new Point(902, 214);
            txtNetAmount.Name = "txtNetAmount";
            txtNetAmount.Size = new Size(264, 29);
            txtNetAmount.TabIndex = 30;
            // 
            // btnClearOrderDetailSelect
            // 
            btnClearOrderDetailSelect.BackColor = Color.SteelBlue;
            btnClearOrderDetailSelect.Cursor = Cursors.Hand;
            btnClearOrderDetailSelect.Enabled = false;
            btnClearOrderDetailSelect.FlatAppearance.BorderSize = 0;
            btnClearOrderDetailSelect.FlatStyle = FlatStyle.Flat;
            btnClearOrderDetailSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearOrderDetailSelect.ForeColor = Color.White;
            btnClearOrderDetailSelect.Location = new Point(1100, 249);
            btnClearOrderDetailSelect.Name = "btnClearOrderDetailSelect";
            btnClearOrderDetailSelect.Size = new Size(66, 32);
            btnClearOrderDetailSelect.TabIndex = 17;
            btnClearOrderDetailSelect.Text = "Clear";
            btnClearOrderDetailSelect.UseVisualStyleBackColor = false;
            btnClearOrderDetailSelect.Click += btnClearOrderDetailSelect_Click;
            // 
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.BackColor = Color.Brown;
            btnDeleteOrderDetail.Cursor = Cursors.Hand;
            btnDeleteOrderDetail.Enabled = false;
            btnDeleteOrderDetail.FlatAppearance.BorderSize = 0;
            btnDeleteOrderDetail.FlatStyle = FlatStyle.Flat;
            btnDeleteOrderDetail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteOrderDetail.ForeColor = Color.White;
            btnDeleteOrderDetail.Location = new Point(1001, 249);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(93, 32);
            btnDeleteOrderDetail.TabIndex = 16;
            btnDeleteOrderDetail.Text = "Delete";
            btnDeleteOrderDetail.UseVisualStyleBackColor = false;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(902, 134);
            label12.Name = "label12";
            label12.Size = new Size(71, 21);
            label12.TabIndex = 27;
            label12.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Enabled = false;
            txtDiscount.Font = new Font("Segoe UI", 12F);
            txtDiscount.Location = new Point(902, 158);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(264, 29);
            txtDiscount.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(902, 78);
            label11.Name = "label11";
            label11.Size = new Size(102, 21);
            label11.TabIndex = 25;
            label11.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Enabled = false;
            txtTotalAmount.Font = new Font("Segoe UI", 12F);
            txtTotalAmount.Location = new Point(902, 102);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(264, 29);
            txtTotalAmount.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(902, 19);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 23;
            label10.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Enabled = false;
            txtQuantity.Font = new Font("Segoe UI", 12F);
            txtQuantity.Location = new Point(902, 43);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(264, 29);
            txtQuantity.TabIndex = 24;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.AllowUserToAddRows = false;
            dgvOrderDetail.AllowUserToDeleteRows = false;
            dgvOrderDetail.AllowUserToResizeColumns = false;
            dgvOrderDetail.AllowUserToResizeRows = false;
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.BackgroundColor = Color.White;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.GridColor = Color.Black;
            dgvOrderDetail.Location = new Point(6, 22);
            dgvOrderDetail.MultiSelect = false;
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.ShowCellToolTips = false;
            dgvOrderDetail.ShowEditingIcon = false;
            dgvOrderDetail.ShowRowErrors = false;
            dgvOrderDetail.Size = new Size(890, 221);
            dgvOrderDetail.TabIndex = 0;
            dgvOrderDetail.CellClick += dgvOrderDetail_CellClick;
            // 
            // CustomerOrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 709);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(btnNewCustomerOrder);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(btnHome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerOrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerOrderManagement";
            Load += CustomerOrderManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnHome;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comCustomerSelect;
        private Label label3;
        private Label lblCustomerAddress;
        private Label lblCustomerEmail;
        private Label lblCustomerPhoneNo;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dgvCustomerOrders;
        private Button btnClearOrder;
        private Button btnDeleteOrder;
        private Button btnNewCustomerOrder;
        private GroupBox groupBox3;
        private DataGridView dgvOrderDetail;
        private Label label12;
        private TextBox txtDiscount;
        private Label label11;
        private TextBox txtTotalAmount;
        private Label label10;
        private TextBox txtQuantity;
        private Button btnClearOrderDetailSelect;
        private Button btnDeleteOrderDetail;
        private Label label9;
        private TextBox txtNetAmount;
        private Button btnUpdateOrderDetail;
    }
}