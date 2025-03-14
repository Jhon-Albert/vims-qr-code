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

namespace Visitor_Identification_Management_System
{
    public partial class VisitorReports : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
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
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        PdfPTable table = new PdfPTable(dgv_reports.Columns.Count);
                        foreach (DataGridViewColumn col in dgv_reports.Columns)
                        {
                            table.AddCell(new Phrase(col.HeaderText));
                        }

                        foreach (DataGridViewRow row in dgv_reports.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                        MessageBox.Show("Exported to PDF successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
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
    }
}
