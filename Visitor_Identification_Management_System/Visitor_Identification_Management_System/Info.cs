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
using System.Net;

namespace Visitor_Identification_Management_System
{
    public partial class Info : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
        public Info()
        {
            InitializeComponent();
            displayData2();
        }

        private void txt_search_info_TextChanged(object sender, EventArgs e)
        {
            if (txt_search_info.Text.Length > 0 && char.IsDigit(txt_search_info.Text[0]))
            {
                // If search starts with a number, search VisitorID
                ((DataTable)dgv_info.DataSource).DefaultView.RowFilter =
                    string.Format("convert(VisitorID, 'System.String') like '{0}%' OR convert(VisitorID, 'System.String') like '% {0}%'",
                    txt_search_info.Text);
            }
            else
            {
                // If search starts with a letter, search name and date
                ((DataTable)dgv_info.DataSource).DefaultView.RowFilter =
                    string.Format("Firstname like '{0}%' OR Firstname like '% {0}%' OR " +
                                  "Lastname like '{0}%' OR Lastname like '% {0}%' OR " +
                                  "convert(VisitDate, 'System.String') like '{0}%' OR convert(VisitDate, 'System.String') like '% {0}%'",
                    txt_search_info.Text);
            }
        }
        public void displayData()
        {
           try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Registration", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_info.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
        public void displayData2()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT VisitorID, FirstName, LastName, Email, ContactNumber, Address, Purpose, ProfilePicture FROM Registration";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgv_info.DataSource = dt;

                    if (dgv_info.Columns["ProfilePicture"] != null && dgv_info.Columns["ProfilePicture"] is DataGridViewImageColumn)
                    {
                        DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgv_info.Columns["ProfilePicture"];
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void displayData3()
        {
            using (SqlConnection con = new SqlConnection(@"Your_Connection_String"))
            {
                string query = "SELECT VisitorID, FirstName, LastName, Email, Address, ContactNumber, Purpose, ProfilePicture FROM Registration";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Convert 'ProfilePicture' column to store images
                    if (dt.Columns.Contains("ProfilePicture"))
                    {
                        dt.Columns["ProfilePicture"].DataType = typeof(Image);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        string imageUrl = row["ProfilePicture"]?.ToString();
                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            try
                            {
                                using (var webClient = new WebClient())
                                {
                                    byte[] imageBytes = webClient.DownloadData(imageUrl);
                                    using (var ms = new MemoryStream(imageBytes))
                                    {
                                        row["ProfilePicture"] = Image.FromStream(ms);
                                    }
                                }
                            }
                            catch
                            {
                                row["ProfilePicture"] = Properties.Resources.default_image; // Use default image on failure
                            }
                        }
                        else
                        {
                            row["ProfilePicture"] = Properties.Resources.default_image; // Use default image if no URL
                        }
                    }

                    // Bind updated DataTable with image data
                    dgv_info.DataSource = dt;

                    // Set 'ProfilePicture' column layout for proper image display
                    if (dgv_info.Columns["ProfilePicture"] is DataGridViewImageColumn imgColumn)
                    {
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        imgColumn.Width = 100; // Adjust width for better display
                    }
                }
            }
        }
    }
}
