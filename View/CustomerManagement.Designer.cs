namespace BookHevan.View
{
    partial class CustomerManagement
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
            label1 = new Label();
            label6 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            label2 = new Label();
            txtPhoneNo = new TextBox();
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            btnHome = new Button();
            dgvCustomer = new DataGridView();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtSearchWord = new TextBox();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(313, 12);
            label1.Name = "label1";
            label1.Size = new Size(371, 45);
            label1.TabIndex = 19;
            label1.Text = "Customer Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(595, 26);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 14;
            label6.Text = "Phone Number";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(797, 147);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 32);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(689, 147);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 32);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnSave.Location = new Point(580, 147);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 32);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(11, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 29);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 26);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 12F);
            txtPhoneNo.Location = new Point(595, 50);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(268, 29);
            txtPhoneNo.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 192);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Info";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(11, 116);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(330, 63);
            txtAddress.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(301, 26);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 92);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(301, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 29);
            txtEmail.TabIndex = 6;
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
            btnHome.TabIndex = 22;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AllowUserToResizeColumns = false;
            dgvCustomer.AllowUserToResizeRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.GridColor = Color.Black;
            dgvCustomer.Location = new Point(11, 62);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.ShowCellToolTips = false;
            dgvCustomer.ShowEditingIcon = false;
            dgvCustomer.Size = new Size(852, 309);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearchWord);
            groupBox2.Controls.Add(dgvCustomer);
            groupBox2.Location = new Point(12, 285);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(877, 384);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search customers";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkOrange;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(348, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchWord
            // 
            txtSearchWord.Font = new Font("Segoe UI", 12F);
            txtSearchWord.Location = new Point(11, 22);
            txtSearchWord.Name = "txtSearchWord";
            txtSearchWord.PlaceholderText = "Customer name";
            txtSearchWord.Size = new Size(331, 29);
            txtSearchWord.TabIndex = 13;
            txtSearchWord.KeyDown += txtSearchWord_KeyDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Brown;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(861, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 23;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 679);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnHome);
            Controls.Add(groupBox2);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerManagement";
            Load += CustomerManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPhoneNo;
        private GroupBox groupBox1;
        private TextBox txtAddress;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private Button btnHome;
        private DataGridView dgvCustomer;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtSearchWord;
        private Button btnClose;
    }
}