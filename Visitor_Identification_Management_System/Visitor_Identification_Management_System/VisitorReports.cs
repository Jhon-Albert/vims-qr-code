using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Emgu.CV.ImgHash;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using ZXing.OneD;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using Font = iTextSharp.text.Font;
using Document = iTextSharp.text.Document;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;

namespace Visitor_Identification_Management_System
{
    public partial class VisitorReports : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"");
        public VisitorReports()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VisitorLogs", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_reports.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
        private void searchData(string search)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VisitorLogs WHERE FirstName LIKE @search OR LastName LIKE @search OR Purpose LIKE @search", con);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_reports.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
        private void txt_search_reports_TextChanged(object sender, EventArgs e)
        {
            searchData(txt_search_reports.Text);
        }
        //BUTTONS
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files (*.pdf)|*.pdf", FileName = "VisitorReports.pdf" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Document doc = new Document(PageSize.A4, 20f, 20f, 40f, 40f);
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        // Create a table with 2 columns (Logo + Title)
                        PdfPTable headerTable = new PdfPTable(2)
                        {
                            WidthPercentage = 100
                        };
                        headerTable.SetWidths(new float[] { 1f, 3f }); // Set column widths (logo smaller)

                        // Add System Logo (if exists)
                        string logoPath = "C:\\Users\\Jhon Albert Ogana\\Pictures\\VIMS logo circle.PNG"; // Change path
                        PdfPCell logoCell = new PdfPCell();
                        if (File.Exists(logoPath))
                        {
                            Image logo = Image.GetInstance(logoPath);
                            logo.ScaleAbsolute(70f, 70f); // Resize
                            logoCell = new PdfPCell(logo)
                            {
                                Border = Rectangle.NO_BORDER,
                                HorizontalAlignment = Element.ALIGN_LEFT,
                                PaddingLeft = 10f
                            };
                        }

                        // Title: Visitor Identification Management System
                        Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK);
                        Paragraph title = new Paragraph("Visitor Identification Management System", titleFont)
                        {
                            Alignment = Element.ALIGN_LEFT
                        };
                        PdfPCell titleCell = new PdfPCell(title)
                        {
                            Border = Rectangle.NO_BORDER,
                            HorizontalAlignment = Element.ALIGN_LEFT,
                            VerticalAlignment = Element.ALIGN_MIDDLE
                        };

                        // Add cells to the header table
                        headerTable.AddCell(logoCell);
                        headerTable.AddCell(titleCell);
                        doc.Add(headerTable);

                        // Subtitle: Report Title
                        Font reportTitleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.DARK_GRAY);
                        Paragraph reportTitle = new Paragraph("Visitor Report", reportTitleFont)
                        {
                            Alignment = Element.ALIGN_CENTER,
                            SpacingAfter = 20f
                        };
                        doc.Add(reportTitle);

                        // Table
                        PdfPTable table = new PdfPTable(dgv_reports.Columns.Count)
                        {
                            WidthPercentage = 100,
                            SpacingBefore = 10f
                        };

                        // Set Column Widths
                        float[] columnWidths = new float[dgv_reports.Columns.Count];
                        for (int i = 0; i < dgv_reports.Columns.Count; i++)
                        {
                            columnWidths[i] = 1.5f;
                        }
                        table.SetWidths(columnWidths);

                        // Header Styling
                        Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                        BaseColor headerColor = new BaseColor(0, 102, 204); // Blue background

                        foreach (DataGridViewColumn col in dgv_reports.Columns)
                        {
                            PdfPCell headerCell = new PdfPCell(new Phrase(col.HeaderText, headerFont))
                            {
                                BackgroundColor = headerColor,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 5
                            };
                            table.AddCell(headerCell);
                        }

                        // Row Styling
                        Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                        BaseColor rowColor1 = new BaseColor(240, 240, 240); // Light gray
                        BaseColor rowColor2 = BaseColor.WHITE;
                        bool alternate = false;

                        foreach (DataGridViewRow row in dgv_reports.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", cellFont))
                                {
                                    BackgroundColor = alternate ? rowColor1 : rowColor2,
                                    Padding = 5,
                                    HorizontalAlignment = Element.ALIGN_CENTER
                                };
                                table.AddCell(dataCell);
                            }
                            alternate = !alternate; // Alternate row colors
                        }

                        doc.Add(table);

                        // Footer with timestamp
                        Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY);
                        Paragraph footer = new Paragraph("Generated on: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), footerFont)
                        {
                            Alignment = Element.ALIGN_RIGHT,
                            SpacingBefore = 10f
                        };
                        doc.Add(footer);

                        doc.Close();
                        writer.Close();
                        MessageBox.Show("Exported to PDF successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, ev) =>
            {
                Bitmap bm = new Bitmap(dgv_reports.Width, dgv_reports.Height);
                dgv_reports.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, dgv_reports.Width, dgv_reports.Height));
                ev.Graphics.DrawImage(bm, 0, 0);
            };

            PrintDialog printDialog = new PrintDialog { Document = printDoc };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xlsx)|*.xlsx",
                Title = "Select a file to import"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".csv")
                {
                    ImportCSV(filePath);
                }
                else if (fileExtension == ".xlsx")
                {
                    ImportExcel(filePath);
                }
                else
                {
                    MessageBox.Show("Unsupported file type selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ImportCSV(string filePath)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@""))
                {
                    con.Open();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        bool isHeader = true;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (isHeader) // Skip the header row
                            {
                                isHeader = false;
                                continue;
                            }

                            string[] values = line.Split(',');

                            string query = "INSERT INTO VisitorLogs (VisitorID, FirstName, MiddleName, LastName, Purpose, CheckInTime, CheckOutTime, Status) VALUES (@VisitorID, @FirstName, @MiddleName, @LastName, @Purpose, @CheckInTime, @CheckOutTime, @Status)";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@VisitorID", values[0]);
                                cmd.Parameters.AddWithValue("@FirstName", values[1]);
                                cmd.Parameters.AddWithValue("@MiddleName", values[2]);
                                cmd.Parameters.AddWithValue("@LastName", values[3]);
                                cmd.Parameters.AddWithValue("@Purpose", values[4]);
                                cmd.Parameters.AddWithValue("@CheckInTime", DateTime.Parse(values[5]));
                                cmd.Parameters.AddWithValue("@CheckOutTime", string.IsNullOrEmpty(values[6]) ? (object)DBNull.Value : DateTime.Parse(values[6]));
                                cmd.Parameters.AddWithValue("@Status", values[7]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("CSV Data Imported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayData(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImportExcel(string filePath)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Required for EPPlus
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // First sheet
                    int rowCount = worksheet.Dimension.Rows;

                    using (SqlConnection con = new SqlConnection(@""))
                    {
                        con.Open();

                        for (int row = 2; row <= rowCount; row++) // Skip header (start from row 2)
                        {
                            string VisitorID = worksheet.Cells[row, 1].Text;
                            string FirstName = worksheet.Cells[row, 2].Text;
                            string MiddleName = worksheet.Cells[row,3].Text;
                            string LastName = worksheet.Cells[row, 4].Text;
                            string Purpose = worksheet.Cells[row, 5].Text;
                            string CheckInTime = worksheet.Cells[row, 6].Text;
                            string CheckOutTime = worksheet.Cells[row, 7].Text;
                            string Status = worksheet.Cells[row, 8].Text;

                            string query = "INSERT INTO VisitorLogs (VisitorID, FirstName, MiddleName, LastName, Purpose, CheckInTime, CheckOutTime, Status) VALUES (@VisitorID, @FirstName, @MiddleName, @LastName, @Purpose, @CheckInTime, @CheckOutTime, @Status)";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@VisitorID", VisitorID);
                                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                                cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                                cmd.Parameters.AddWithValue("@LastName", LastName);
                                cmd.Parameters.AddWithValue("@Purpose", Purpose);
                                cmd.Parameters.AddWithValue("@CheckInTime", DateTime.Parse(CheckInTime));
                                cmd.Parameters.AddWithValue("@CheckOutTime", string.IsNullOrEmpty(CheckOutTime) ? (object)DBNull.Value : DateTime.Parse(CheckOutTime));
                                cmd.Parameters.AddWithValue("@Status", Status);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Excel Data Imported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayData(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
