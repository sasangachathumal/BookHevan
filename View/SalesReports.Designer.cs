namespace BookHevan.View
{
    partial class SalesReports
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
            label1 = new Label();
            comReportType = new ComboBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            btnExport = new Button();
            btnGenerate = new Button();
            label2 = new Label();
            dgvReport = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            lblTotalSales = new Label();
            lblTotalOrders = new Label();
            btnHome = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
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
            btnClose.Location = new Point(1048, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 24);
            btnClose.TabIndex = 22;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(456, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 45);
            label1.TabIndex = 21;
            label1.Text = "Reports";
            // 
            // comReportType
            // 
            comReportType.Cursor = Cursors.Hand;
            comReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            comReportType.Font = new Font("Segoe UI", 12F);
            comReportType.FormattingEnabled = true;
            comReportType.Items.AddRange(new object[] { "--Select--", "Daily Sales Report", "Weekly Sales Report", "Monthly Sales Report", "Best Salling Books", "Inventory Status" });
            comReportType.Location = new Point(6, 43);
            comReportType.Name = "comReportType";
            comReportType.Size = new Size(164, 29);
            comReportType.TabIndex = 23;
            comReportType.SelectedIndexChanged += comReportType_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpTo);
            groupBox1.Controls.Add(dtpFrom);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comReportType);
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1064, 92);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(444, 19);
            label4.Name = "label4";
            label4.Size = new Size(25, 21);
            label4.TabIndex = 33;
            label4.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(226, 19);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 32;
            label3.Text = "From";
            label3.Click += label3_Click;
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Segoe UI", 12F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(444, 40);
            dtpTo.MinDate = new DateTime(2025, 3, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(164, 29);
            dtpTo.TabIndex = 31;
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Segoe UI", 12F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(226, 40);
            dtpFrom.MinDate = new DateTime(2025, 3, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(164, 29);
            dtpFrom.TabIndex = 30;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.SteelBlue;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderColor = Color.DarkOrange;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(965, 37);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(93, 39);
            btnExport.TabIndex = 29;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.DarkOrange;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderColor = Color.DarkOrange;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(857, 37);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(93, 39);
            btnGenerate.TabIndex = 28;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 25;
            label2.Text = "Report Type";
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AllowUserToResizeColumns = false;
            dgvReport.AllowUserToResizeRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.GridColor = Color.Black;
            dgvReport.Location = new Point(12, 244);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.ShowCellErrors = false;
            dgvReport.ShowCellToolTips = false;
            dgvReport.ShowEditingIcon = false;
            dgvReport.ShowRowErrors = false;
            dgvReport.Size = new Size(1064, 393);
            dgvReport.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 200);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 26;
            label5.Text = "Total Sales :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(401, 200);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 27;
            label6.Text = "Total Orders :";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 12F);
            lblTotalSales.Location = new Point(107, 200);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(0, 21);
            lblTotalSales.TabIndex = 28;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Font = new Font("Segoe UI", 12F);
            lblTotalOrders.Location = new Point(508, 200);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(0, 21);
            lblTotalOrders.TabIndex = 29;
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
            btnHome.TabIndex = 30;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // SalesReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 650);
            Controls.Add(btnHome);
            Controls.Add(lblTotalOrders);
            Controls.Add(lblTotalSales);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvReport);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesReports";
            Load += SalesReports_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private ComboBox comReportType;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnExport;
        private Button btnGenerate;
        private DataGridView dgvReport;
        private Label label3;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTotalSales;
        private Label lblTotalOrders;
        private Button btnHome;
    }
}