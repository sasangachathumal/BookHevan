namespace BookHevan.View
{
    partial class PointOfSales
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
            groupBox2 = new GroupBox();
            txtSearchWord = new TextBox();
            label9 = new Label();
            txtQuantity = new TextBox();
            btnAddBookToOrder = new Button();
            dgvBooks = new DataGridView();
            groupBox3 = new GroupBox();
            btnClear = new Button();
            btnSave = new Button();
            label12 = new Label();
            txtNetAmount = new TextBox();
            label11 = new Label();
            txtDiscount = new TextBox();
            label10 = new Label();
            txtTotalAmount = new TextBox();
            dgvOrderDetail = new DataGridView();
            groupBox1 = new GroupBox();
            txtPhoneNo = new TextBox();
            btnNewCustomer = new Button();
            lblCustAddress = new Label();
            lblCustEmail = new Label();
            lblCustPhoneNumber = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            groupBox1.SuspendLayout();
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
            btnClose.Location = new Point(1111, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 16;
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
            btnHome.TabIndex = 15;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(463, 12);
            label1.Name = "label1";
            label1.Size = new Size(228, 45);
            label1.TabIndex = 14;
            label1.Text = "Point Of Sales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearchWord);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(btnAddBookToOrder);
            groupBox2.Controls.Add(dgvBooks);
            groupBox2.Location = new Point(12, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(774, 260);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Info";
            // 
            // txtSearchWord
            // 
            txtSearchWord.Font = new Font("Segoe UI", 12F);
            txtSearchWord.Location = new Point(6, 23);
            txtSearchWord.Name = "txtSearchWord";
            txtSearchWord.PlaceholderText = "Enter Book Title or ISBN to search";
            txtSearchWord.Size = new Size(570, 29);
            txtSearchWord.TabIndex = 26;
            txtSearchWord.TextChanged += txtSearchWord_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(6, 225);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 15;
            label9.Text = "Quantiry";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F);
            txtQuantity.Location = new Point(83, 222);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(219, 29);
            txtQuantity.TabIndex = 14;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // btnAddBookToOrder
            // 
            btnAddBookToOrder.BackColor = Color.DarkOrange;
            btnAddBookToOrder.Cursor = Cursors.Hand;
            btnAddBookToOrder.FlatAppearance.BorderColor = Color.DarkOrange;
            btnAddBookToOrder.FlatAppearance.BorderSize = 0;
            btnAddBookToOrder.FlatStyle = FlatStyle.Flat;
            btnAddBookToOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddBookToOrder.ForeColor = Color.White;
            btnAddBookToOrder.Location = new Point(675, 222);
            btnAddBookToOrder.Name = "btnAddBookToOrder";
            btnAddBookToOrder.Size = new Size(93, 29);
            btnAddBookToOrder.TabIndex = 13;
            btnAddBookToOrder.Text = "Add";
            btnAddBookToOrder.UseVisualStyleBackColor = false;
            btnAddBookToOrder.Click += btnAddBookToOrder_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToResizeColumns = false;
            dgvBooks.AllowUserToResizeRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.GridColor = Color.Black;
            dgvBooks.Location = new Point(6, 58);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.ShowCellToolTips = false;
            dgvBooks.ShowEditingIcon = false;
            dgvBooks.ShowRowErrors = false;
            dgvBooks.Size = new Size(762, 157);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellClick += dgvBooks_CellClick;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtNetAmount);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtDiscount);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtTotalAmount);
            groupBox3.Controls.Add(dgvOrderDetail);
            groupBox3.Location = new Point(12, 343);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1127, 230);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Details";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1055, 192);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 32);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkOrange;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.DarkOrange;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(956, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 32);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(902, 133);
            label12.Name = "label12";
            label12.Size = new Size(95, 21);
            label12.TabIndex = 21;
            label12.Text = "Net Amount";
            // 
            // txtNetAmount
            // 
            txtNetAmount.Enabled = false;
            txtNetAmount.Font = new Font("Segoe UI", 12F);
            txtNetAmount.Location = new Point(902, 157);
            txtNetAmount.Name = "txtNetAmount";
            txtNetAmount.Size = new Size(219, 29);
            txtNetAmount.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(902, 77);
            label11.Name = "label11";
            label11.Size = new Size(71, 21);
            label11.TabIndex = 19;
            label11.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 12F);
            txtDiscount.Location = new Point(902, 101);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(219, 29);
            txtDiscount.TabIndex = 20;
            txtDiscount.KeyDown += txtDiscount_KeyDown;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(902, 21);
            label10.Name = "label10";
            label10.Size = new Size(102, 21);
            label10.TabIndex = 18;
            label10.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 12F);
            txtTotalAmount.Location = new Point(902, 45);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(219, 29);
            txtTotalAmount.TabIndex = 18;
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
            dgvOrderDetail.Size = new Size(890, 164);
            dgvOrderDetail.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(btnNewCustomer);
            groupBox1.Controls.Add(lblCustAddress);
            groupBox1.Controls.Add(lblCustEmail);
            groupBox1.Controls.Add(lblCustPhoneNumber);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(792, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 260);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Info";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 12F);
            txtPhoneNo.Location = new Point(6, 43);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(236, 29);
            txtPhoneNo.TabIndex = 26;
            txtPhoneNo.TextChanged += txtPhoneNo_TextChanged;
            txtPhoneNo.KeyDown += txtPhoneNo_KeyDown;
            txtPhoneNo.KeyPress += txtPhoneNo_KeyPress;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.BackColor = Color.DarkOrange;
            btnNewCustomer.Cursor = Cursors.Hand;
            btnNewCustomer.FlatAppearance.BorderColor = Color.DarkOrange;
            btnNewCustomer.FlatAppearance.BorderSize = 0;
            btnNewCustomer.FlatStyle = FlatStyle.Flat;
            btnNewCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Location = new Point(248, 43);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(93, 29);
            btnNewCustomer.TabIndex = 27;
            btnNewCustomer.Text = "+ New";
            btnNewCustomer.UseVisualStyleBackColor = false;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // lblCustAddress
            // 
            lblCustAddress.AutoSize = true;
            lblCustAddress.Font = new Font("Segoe UI", 12F);
            lblCustAddress.Location = new Point(6, 194);
            lblCustAddress.Name = "lblCustAddress";
            lblCustAddress.Size = new Size(0, 21);
            lblCustAddress.TabIndex = 9;
            // 
            // lblCustEmail
            // 
            lblCustEmail.AutoSize = true;
            lblCustEmail.Font = new Font("Segoe UI", 12F);
            lblCustEmail.Location = new Point(6, 100);
            lblCustEmail.Name = "lblCustEmail";
            lblCustEmail.Size = new Size(0, 21);
            lblCustEmail.TabIndex = 8;
            // 
            // lblCustPhoneNumber
            // 
            lblCustPhoneNumber.AutoSize = true;
            lblCustPhoneNumber.Font = new Font("Segoe UI", 12F);
            lblCustPhoneNumber.Location = new Point(6, 147);
            lblCustPhoneNumber.Name = "lblCustPhoneNumber";
            lblCustPhoneNumber.Size = new Size(0, 21);
            lblCustPhoneNumber.TabIndex = 7;
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
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(188, 21);
            label4.TabIndex = 5;
            label4.Text = "Customer Phone Number";
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
            label2.Location = new Point(6, 126);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 1;
            label2.Text = "Customer Name :";
            // 
            // PointOfSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 583);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(btnHome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PointOfSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PointOfSales";
            Load += PointOfSales_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnHome;
        private Label label1;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txtQuantity;
        private Button btnAddBookToOrder;
        private DataGridView dgvBooks;
        private GroupBox groupBox3;
        private Button btnClear;
        private Button btnSave;
        private Label label12;
        private TextBox txtNetAmount;
        private Label label11;
        private TextBox txtDiscount;
        private Label label10;
        private TextBox txtTotalAmount;
        private DataGridView dgvOrderDetail;
        private GroupBox groupBox1;
        private Label lblCustAddress;
        private Label lblCustEmail;
        private Label lblCustPhoneNumber;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSearchWord;
        private Button btnNewCustomer;
        private TextBox txtPhoneNo;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}