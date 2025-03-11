namespace BookHevan.View
{
    partial class UserManagement
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
            dgvUsers = new DataGridView();
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtPhoneNo = new TextBox();
            groupBox1 = new GroupBox();
            checkRest = new CheckBox();
            label6 = new Label();
            comUserType = new ComboBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnRegister = new Button();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtSearchWord = new TextBox();
            btnHome = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.GridColor = Color.Black;
            dgvUsers.Location = new Point(11, 62);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsers.ShowCellToolTips = false;
            dgvUsers.ShowEditingIcon = false;
            dgvUsers.Size = new Size(943, 309);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(360, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 45);
            label1.TabIndex = 1;
            label1.Text = "User Management";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.Location = new Point(11, 50);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(226, 29);
            txtFullName.TabIndex = 1;
            txtFullName.KeyPress += txtFullName_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 26);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 3;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(256, 26);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(256, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 29);
            txtUsername.TabIndex = 2;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(505, 26);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(505, 50);
            txtPassword.MaxLength = 8;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '.';
            txtPassword.Size = new Size(214, 29);
            txtPassword.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(758, 26);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 9;
            label5.Text = "Phone Number";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 12F);
            txtPhoneNo.Location = new Point(758, 50);
            txtPhoneNo.MaxLength = 10;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(196, 29);
            txtPhoneNo.TabIndex = 4;
            txtPhoneNo.KeyPress += txtPhoneNo_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkRest);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comUserType);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(965, 153);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Info";
            // 
            // checkRest
            // 
            checkRest.AutoSize = true;
            checkRest.CheckAlign = ContentAlignment.MiddleRight;
            checkRest.Cursor = Cursors.Hand;
            checkRest.Enabled = false;
            checkRest.Font = new Font("Segoe UI", 10F);
            checkRest.Location = new Point(661, 24);
            checkRest.Name = "checkRest";
            checkRest.Size = new Size(58, 23);
            checkRest.TabIndex = 15;
            checkRest.Text = "reset";
            checkRest.UseVisualStyleBackColor = true;
            checkRest.Visible = false;
            checkRest.CheckedChanged += checkRest_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 82);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 14;
            label6.Text = "User Type";
            // 
            // comUserType
            // 
            comUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            comUserType.Font = new Font("Segoe UI", 12F);
            comUserType.FormattingEnabled = true;
            comUserType.Items.AddRange(new object[] { "~ select user type ~", "Admin", "Sales Clerk" });
            comUserType.Location = new Point(11, 106);
            comUserType.Name = "comUserType";
            comUserType.Size = new Size(226, 29);
            comUserType.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(473, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 32);
            btnClear.TabIndex = 8;
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
            btnDelete.Location = new Point(365, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 32);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkOrange;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.DarkOrange;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(256, 103);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(93, 32);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearchWord);
            groupBox2.Controls.Add(dgvUsers);
            groupBox2.Location = new Point(12, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(965, 384);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search user by username";
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
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchWord
            // 
            txtSearchWord.Font = new Font("Segoe UI", 12F);
            txtSearchWord.Location = new Point(11, 22);
            txtSearchWord.Name = "txtSearchWord";
            txtSearchWord.PlaceholderText = "Username";
            txtSearchWord.Size = new Size(331, 29);
            txtSearchWord.TabIndex = 9;
            txtSearchWord.KeyDown += txtSearchWord_KeyDown;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DarkOrange;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(12, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(87, 34);
            btnHome.TabIndex = 11;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Brown;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(949, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 12;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(989, 637);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnHome);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserManagement";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtPhoneNo;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnRegister;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtSearchWord;
        private Button btnHome;
        private Button btnClose;
        private Label label6;
        private ComboBox comUserType;
        private CheckBox checkRest;
    }
}