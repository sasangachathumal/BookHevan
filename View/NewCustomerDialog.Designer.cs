namespace BookHevan.View
{
    partial class NewCustomerDialog
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtPhoneNo = new TextBox();
            btnClear = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 45);
            label1.TabIndex = 20;
            label1.Text = "New Customer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 371);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Info";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 19);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 14;
            label6.Text = "Phone Number";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 12F);
            txtPhoneNo.Location = new Point(11, 43);
            txtPhoneNo.MaxLength = 10;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(268, 29);
            txtPhoneNo.TabIndex = 0;
            txtPhoneNo.KeyPress += txtPhoneNo_KeyPress;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(11, 328);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(268, 32);
            btnClear.TabIndex = 5;
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
            btnSave.Location = new Point(11, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(268, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(11, 99);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 29);
            txtName.TabIndex = 1;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 75);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(11, 211);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(268, 63);
            txtAddress.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(11, 131);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 187);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(11, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 29);
            txtEmail.TabIndex = 2;
            // 
            // NewCustomerDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(317, 452);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewCustomerDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewCustomerDialog";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtPhoneNo;
        private Button btnClear;
        private Button btnSave;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAddress;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
    }
}