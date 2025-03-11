namespace BookHevan.View
{
    partial class NewCustomerOrder
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
            btnClear = new Button();
            btnSave = new Button();
            label12 = new Label();
            txtNetAmount = new TextBox();
            label11 = new Label();
            txtDiscount = new TextBox();
            label10 = new Label();
            txtTotalAmount = new TextBox();
            dgvOrderDetail = new DataGridView();
            groupBox2 = new GroupBox();
            label6 = new Label();
            comType = new ComboBox();
            comAuthor = new ComboBox();
            comGenre = new ComboBox();
            comTitle = new ComboBox();
            label9 = new Label();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            dgvBooks = new DataGridView();
            comCustName = new ComboBox();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            lblCustAddress = new Label();
            lblCustEmail = new Label();
            lblCustPhoneNumber = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            txtTotalAmount.Enabled = false;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comType);
            groupBox2.Controls.Add(comAuthor);
            groupBox2.Controls.Add(comGenre);
            groupBox2.Controls.Add(comTitle);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(dgvBooks);
            groupBox2.Location = new Point(365, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(774, 260);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Info";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(325, 225);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 19;
            label6.Text = "Type";
            // 
            // comType
            // 
            comType.DropDownStyle = ComboBoxStyle.DropDownList;
            comType.Font = new Font("Segoe UI", 12F);
            comType.FormattingEnabled = true;
            comType.Items.AddRange(new object[] { "--Select order type--", "Pick up", "delivery" });
            comType.Location = new Point(373, 222);
            comType.Name = "comType";
            comType.Size = new Size(238, 29);
            comType.TabIndex = 18;
            // 
            // comAuthor
            // 
            comAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comAuthor.Font = new Font("Segoe UI", 12F);
            comAuthor.FormattingEnabled = true;
            comAuthor.Location = new Point(269, 23);
            comAuthor.Name = "comAuthor";
            comAuthor.Size = new Size(238, 29);
            comAuthor.TabIndex = 17;
            comAuthor.SelectedIndexChanged += comAuthor_SelectedIndexChanged;
            // 
            // comGenre
            // 
            comGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comGenre.Font = new Font("Segoe UI", 12F);
            comGenre.FormattingEnabled = true;
            comGenre.Location = new Point(530, 23);
            comGenre.Name = "comGenre";
            comGenre.Size = new Size(238, 29);
            comGenre.TabIndex = 16;
            comGenre.SelectedIndexChanged += comGenre_SelectedIndexChanged;
            // 
            // comTitle
            // 
            comTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comTitle.Font = new Font("Segoe UI", 12F);
            comTitle.FormattingEnabled = true;
            comTitle.Location = new Point(6, 23);
            comTitle.Name = "comTitle";
            comTitle.Size = new Size(238, 29);
            comTitle.TabIndex = 10;
            comTitle.SelectedIndexChanged += comTitle_SelectedIndexChanged;
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOrange;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.DarkOrange;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(675, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            // 
            // comCustName
            // 
            comCustName.DropDownStyle = ComboBoxStyle.DropDownList;
            comCustName.Font = new Font("Segoe UI", 12F);
            comCustName.FormattingEnabled = true;
            comCustName.Location = new Point(6, 43);
            comCustName.Name = "comCustName";
            comCustName.Size = new Size(331, 29);
            comCustName.TabIndex = 0;
            comCustName.SelectedIndexChanged += comCustName_SelectedIndexChanged;
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
            groupBox3.Location = new Point(12, 337);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1127, 230);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Details";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCustAddress);
            groupBox1.Controls.Add(lblCustEmail);
            groupBox1.Controls.Add(lblCustPhoneNumber);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comCustName);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 260);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Info";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(381, 12);
            label1.Name = "label1";
            label1.Size = new Size(337, 45);
            label1.TabIndex = 19;
            label1.Text = "New Customer Order";
            // 
            // NewCustomerOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 575);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewCustomerOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewCustomerOrder";
            Load += NewCustomerOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnSave;
        private Label label12;
        private TextBox txtNetAmount;
        private Label label11;
        private TextBox txtDiscount;
        private Label label10;
        private TextBox txtTotalAmount;
        private DataGridView dgvOrderDetail;
        private GroupBox groupBox2;
        private ComboBox comAuthor;
        private ComboBox comGenre;
        private ComboBox comTitle;
        private Label label9;
        private TextBox txtQuantity;
        private Button btnAdd;
        private DataGridView dgvBooks;
        private ComboBox comCustName;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Label lblCustAddress;
        private Label lblCustEmail;
        private Label lblCustPhoneNumber;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private ComboBox comType;
    }
}