namespace BookHevan.View
{
    partial class SupplierManagement
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
            btnSearch = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtSearchWord = new TextBox();
            dgvSupplier = new DataGridView();
            btnHome = new Button();
            txtPhoneNo = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
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
            btnClose.Location = new Point(829, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 28;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(585, 26);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 14;
            label6.Text = "Phone Number";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearchWord);
            groupBox2.Controls.Add(dgvSupplier);
            groupBox2.Location = new Point(11, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(846, 384);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search suppliers";
            // 
            // txtSearchWord
            // 
            txtSearchWord.Font = new Font("Segoe UI", 12F);
            txtSearchWord.Location = new Point(11, 22);
            txtSearchWord.Name = "txtSearchWord";
            txtSearchWord.PlaceholderText = "Supplier name";
            txtSearchWord.Size = new Size(331, 29);
            txtSearchWord.TabIndex = 13;
            txtSearchWord.KeyDown += txtSearchWord_KeyDown;
            txtSearchWord.KeyPress += txtSearchWord_KeyPress;
            // 
            // dgvSupplier
            // 
            dgvSupplier.AllowUserToAddRows = false;
            dgvSupplier.AllowUserToDeleteRows = false;
            dgvSupplier.AllowUserToResizeColumns = false;
            dgvSupplier.AllowUserToResizeRows = false;
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.BackgroundColor = Color.White;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.GridColor = Color.Black;
            dgvSupplier.Location = new Point(11, 62);
            dgvSupplier.MultiSelect = false;
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.ReadOnly = true;
            dgvSupplier.ShowCellToolTips = false;
            dgvSupplier.ShowEditingIcon = false;
            dgvSupplier.Size = new Size(825, 309);
            dgvSupplier.TabIndex = 0;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
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
            btnHome.TabIndex = 27;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 12F);
            txtPhoneNo.Location = new Point(585, 50);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(250, 29);
            txtPhoneNo.TabIndex = 13;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(769, 147);
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
            btnDelete.Location = new Point(661, 147);
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
            btnSave.Location = new Point(552, 147);
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
            txtName.Size = new Size(257, 29);
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
            txtEmail.Size = new Size(248, 29);
            txtEmail.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(289, 12);
            label1.Name = "label1";
            label1.Size = new Size(352, 45);
            label1.TabIndex = 24;
            label1.Text = "Supplier Management";
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
            groupBox1.Size = new Size(845, 188);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Supplier Info";
            // 
            // SupplierManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(869, 673);
            Controls.Add(btnClose);
            Controls.Add(groupBox2);
            Controls.Add(btnHome);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierManagement";
            Load += SupplierManagement_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSearch;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtSearchWord;
        private DataGridView dgvSupplier;
        private Button btnHome;
        private TextBox txtPhoneNo;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAddress;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private Label label1;
        private GroupBox groupBox1;
    }
}