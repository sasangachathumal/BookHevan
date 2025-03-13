using BookHevan.Helper;
using BookHevan.Model;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHevan.View
{
    public partial class SalesReports : Form
    {

        public SalesReports()
        {
            InitializeComponent();
        }

        private void comReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable the date pickers and buttons based on the selected report type
            if (comReportType.SelectedIndex > 0)
            {
                dtpTo.Enabled = true;
                dtpFrom.Enabled = true;
                btnExport.Enabled = true;
                btnGenerate.Enabled = true;
                int selectedReportType = comReportType.SelectedIndex;

                // Disable the date pickers based on the selected report type
                if (selectedReportType == 1)
                {
                    dtpTo.Enabled = false;
                }
                // Disable the date pickers based on the selected report type
                if (selectedReportType == 4 || selectedReportType == 5)
                {
                    dtpTo.Enabled = false;
                    dtpFrom.Enabled = false;
                }

            }
            else
            {
                dtpTo.Enabled = false;
                dtpFrom.Enabled = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Check if the report type is selected
            if (comReportType.SelectedIndex > 0)
            {
                // Get the selected report type
                int selectedReportType = comReportType.SelectedIndex;
                // Get the start and end date
                string startDate = dtpFrom.Value.ToString("yyyy-MM-dd");
                string endDate = dtpTo.Value.ToString("yyyy-MM-dd");

                // Check if the selected report type is daily sales
                if (selectedReportType == 1)
                {
                    if (string.IsNullOrEmpty(startDate))
                    {
                        MessageBox.Show("Please select the date to generate the report");
                        return;
                    }
                    // Get daily sales report
                    DataTable dailySales = SalesReportsModel.getDailySalesReport(startDate);
                    if (dailySales != null)
                    {
                        dgvReport.DataSource = dailySales;
                    }
                    string counts = SalesReportsModel.getSalesCountsByDate(startDate);
                    if (!string.IsNullOrEmpty(counts))
                    {
                        string[] results = counts.Split(',');
                        lblTotalSales.Text = results[0];
                        lblTotalOrders.Text = results[1];
                    }
                }
                else if (selectedReportType == 2)
                {
                    if (getDateDifference() > 7)
                    {
                        MessageBox.Show("Please select a date range of 7 days or less to generate weekly report");
                        return;
                    }

                    // Get weekly sales report
                    DataTable weeklySales = SalesReportsModel.getSalesReportByDateRange(startDate, endDate);
                    if (weeklySales != null)
                    {
                        dgvReport.DataSource = weeklySales;
                    }
                    string counts = SalesReportsModel.getSalesCountsByDateRange(startDate, endDate);
                    if (!string.IsNullOrEmpty(counts))
                    {
                        string[] results = counts.Split(',');
                        lblTotalSales.Text = results[0];
                        lblTotalOrders.Text = results[1];
                    }
                }
                else if (selectedReportType == 3)
                {
                    if (getDateDifference() > 30)
                    {
                        MessageBox.Show("Please select a date range of 30 days or less to generate monthly report");
                        return;
                    }
                    // Get monthly sales report
                    DataTable monthlySales = SalesReportsModel.getSalesReportByDateRange(startDate, endDate);
                    if (monthlySales != null)
                    {
                        dgvReport.DataSource = monthlySales;
                    }
                    string counts = SalesReportsModel.getSalesCountsByDateRange(startDate, endDate);
                    if (!string.IsNullOrEmpty(counts))
                    {
                        string[] results = counts.Split(',');
                        lblTotalSales.Text = results[0];
                        lblTotalOrders.Text = results[1];
                    }
                }
                else if (selectedReportType == 4)
                {
                    // Get best salling books report
                    DataTable monthlySales = SalesReportsModel.getSalesReportBestSellingBooks();
                    if (monthlySales != null)
                    {
                        dgvReport.DataSource = monthlySales;
                    }
                }
                else if (selectedReportType == 5)
                {
                    // Get inventory status report
                    DataTable monthlySales = SalesReportsModel.getSalesReportInventoryStatus();
                    if (monthlySales != null)
                    {
                        dgvReport.DataSource = monthlySales;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SalesReports_Load(object sender, EventArgs e)
        {
            dtpTo.Enabled = false;
            dtpFrom.Enabled = false;
            btnExport.Enabled = false;
            btnGenerate.Enabled = false;
        }

        private int getDateDifference()
        {
            DateTime startDate = dtpFrom.Value;
            DateTime endDate = dtpTo.Value;
            TimeSpan difference = endDate.Subtract(startDate);
            return difference.Days;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Open file dialog to save the PDF
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = "Sales_Report.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Ensure DataGridView has data
                if (dgvReport.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Export to PDF
                ExportDataGridViewToPDF(dgvReport, sfd.FileName);
                MessageBox.Show("PDF Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportDataGridViewToPDF(DataGridView dgv, string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                // Load a bold font explicitly
                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                // Add title with bold font
                document.Add(new Paragraph("Sales Report")
                    .SetFont(boldFont) // Set explicitly bold font
                    .SetFontSize(18)
                    .SetTextAlignment(TextAlignment.CENTER));

                // Create table with column count
                Table table = new Table(dgv.ColumnCount);

                // Add header row with bold font
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText).SetFont(boldFont)));
                }

                // Add data rows with normal font
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "").SetFont(normalFont)));
                    }
                }

                document.Add(table);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserNavigation.navigateToDashboard(this);
        }
    }
}
