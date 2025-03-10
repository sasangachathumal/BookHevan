namespace BookHevan.View
{
    partial class BookInventoryManagement
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
            txtSearchWord = new TextBox();
            txtTitle = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            groupBox2 = new GroupBox();
            dgvBooks = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label5 = new Label();
            btnHome = new Button();
            txtISBN = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtAuthor = new TextBox();
            groupBox1 = new GroupBox();
            txtStockQuantity = new TextBox();
            label7 = new Label();
            txtGenre = new TextBox();
            label6 = new Label();
            txtPrice = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
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
            btnClose.Location = new Point(949, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 18;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtSearchWord
            // 
            txtSearchWord.Font = new Font("Segoe UI", 12F);
            txtSearchWord.Location = new Point(11, 22);
            txtSearchWord.Name = "txtSearchWord";
            txtSearchWord.PlaceholderText = "Book title";
            txtSearchWord.Size = new Size(331, 29);
            txtSearchWord.TabIndex = 10;
            txtSearchWord.KeyDown += txtSearchWord_KeyDown;
            txtSearchWord.KeyPress += txtSearchWord_KeyPress;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.Location = new Point(11, 50);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(221, 29);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 26);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 3;
            label2.Text = "Title";
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
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearchWord);
            groupBox2.Controls.Add(dgvBooks);
            groupBox2.Location = new Point(12, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(965, 384);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search books";
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
            dgvBooks.Location = new Point(11, 62);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.ShowCellToolTips = false;
            dgvBooks.ShowEditingIcon = false;
            dgvBooks.Size = new Size(943, 309);
            dgvBooks.TabIndex = 12;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(708, 109);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 32);
            btnClear.TabIndex = 9;
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
            btnDelete.Location = new Point(600, 109);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 32);
            btnDelete.TabIndex = 8;
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
            btnSave.Location = new Point(491, 109);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 32);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(491, 26);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 9;
            label5.Text = "Genre";
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
            btnHome.TabIndex = 17;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 12F);
            txtISBN.Location = new Point(733, 50);
            txtISBN.MaxLength = 13;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(221, 29);
            txtISBN.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(251, 26);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 7;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(733, 26);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 5;
            label3.Text = "ISBN";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 12F);
            txtAuthor.Location = new Point(251, 50);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(221, 29);
            txtAuthor.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStockQuantity);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGenre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(965, 165);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Font = new Font("Segoe UI", 12F);
            txtStockQuantity.Location = new Point(251, 112);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(221, 29);
            txtStockQuantity.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(251, 88);
            label7.Name = "label7";
            label7.Size = new Size(111, 21);
            label7.TabIndex = 16;
            label7.Text = "Stock Quantity";
            // 
            // txtGenre
            // 
            txtGenre.Font = new Font("Segoe UI", 12F);
            txtGenre.Location = new Point(491, 50);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(221, 29);
            txtGenre.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 88);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(11, 112);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(221, 29);
            txtPrice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(292, 12);
            label1.Name = "label1";
            label1.Size = new Size(460, 45);
            label1.TabIndex = 14;
            label1.Text = "Book Inventory Management";
            // 
            // BookInventoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(989, 654);
            Controls.Add(btnClose);
            Controls.Add(groupBox2);
            Controls.Add(btnHome);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookInventoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookInventoryManagement";
            Load += BookInventoryManagement_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private TextBox txtSearchWord;
        private TextBox txtTitle;
        private Label label2;
        private Button btnSearch;
        private GroupBox groupBox2;
        private DataGridView dgvBooks;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Label label5;
        private Button btnHome;
        private TextBox txtISBN;
        private Label label4;
        private Label label3;
        private TextBox txtAuthor;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtStockQuantity;
        private Label label7;
        private TextBox txtGenre;
        private Label label6;
        private TextBox txtPrice;
    }
}