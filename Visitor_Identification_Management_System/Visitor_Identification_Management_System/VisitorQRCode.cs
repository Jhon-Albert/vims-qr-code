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

namespace Visitor_Identification_Management_System
{
    public partial class VisitorQRCode : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
        public VisitorQRCode()
        {
            InitializeComponent();
        }

        private void VisitorQRCode_Load(object sender, EventArgs e)
        {
            displayData2();
        }
        public void displayData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Registration", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                /*if (dgv_visitorQRCode.Columns["ProfilePicture"] != null && dgv_visitorQRCode.Columns["ProfilePicture"] is DataGridViewImageColumn)
                {
                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgv_visitorQRCode.Columns["ProfilePicture"];
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }*/
                foreach (DataRow row in dt.Rows)
                {
                    /*if (row["ProfilePicture"] != DBNull.Value)
                    {
                        string profilePath = row["ProfilePicture"].ToString();
                        if (File.Exists(profilePath))
                            row["ProfilePicture"] = Image.FromFile(profilePath);
                    }
                    if (row["QRCodeImage"] != DBNull.Value)
                    {
                        string qrPath = row["QRCodeImage"].ToString();
                        if (File.Exists(qrPath))
                            row["QRCodeImage"] = Image.FromFile(qrPath);
                    }*/
                    if (row["ProfilePicture"] != DBNull.Value)
                    {
                        string profilePath = row["ProfilePicture"].ToString();
                        if (File.Exists(profilePath))
                            row["ProfilePicture"] = Image.FromStream(new MemoryStream(File.ReadAllBytes(profilePath))); // Prevent file lock
                    }
                    if (row["QRCodeImage"] != DBNull.Value)
                    {
                        string qrPath = row["QRCodeImage"].ToString();
                        if (File.Exists(qrPath))
                            row["QRCodeImage"] = Image.FromStream(new MemoryStream(File.ReadAllBytes(qrPath))); // Prevent file lock
                    }
                }

                dgv_visitorQRCode.DataSource = dt;

                if (dgv_visitorQRCode.Columns["ProfilePicture"] != null && dgv_visitorQRCode.Columns["ProfilePicture"] is DataGridViewImageColumn)
                {
                    DataGridViewImageColumn profileColumn = (DataGridViewImageColumn)dgv_visitorQRCode.Columns["ProfilePicture"];
                    profileColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                if (dgv_visitorQRCode.Columns["QRCodeImage"] != null && dgv_visitorQRCode.Columns["QRCodeImage"] is DataGridViewImageColumn)
                {
                    DataGridViewImageColumn qrColumn = (DataGridViewImageColumn)dgv_visitorQRCode.Columns["QRCodeImage"];
                    qrColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void displayData2()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Registration", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgv_visitorQRCode.DataSource = dt;
                dgv_visitorQRCode.AllowUserToAddRows = false;

                // Ensure images are displayed properly
                if (dgv_visitorQRCode.Columns["QRCodeImage"] is DataGridViewImageColumn qrColumn)
                    qrColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                if (dgv_visitorQRCode.Columns["ProfilePicture"] is DataGridViewImageColumn profileColumn)
                    profileColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void txt_searchVisitorQRCode_TextChanged(object sender, EventArgs e)
        {
            searchVisitor(txt_searchVisitorQRCode.Text);
        }
        private void searchVisitor(string searchText)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = "SELECT VisitorID, FirstName, LastName, Email, ContactNumber, Address, Purpose, ProfilePicture, QRCodeImage " +
                               "FROM Registration WHERE FirstName LIKE @search OR LastName LIKE @search OR VisitorID LIKE @search";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_visitorQRCode.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_downloadQRCode_Click(object sender, EventArgs e)
        {
            if (pb_visitorQRCode.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = "Visitor_QRCode.png";
                    saveFileDialog.Filter = "PNG Image|*.png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pb_visitorQRCode.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("QR Code downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No QR Code selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_visitorQRCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgv_visitorQRCode.Rows[e.RowIndex].Cells["QRCodeImage"].Value;

                if (cellValue != DBNull.Value && cellValue != null)
                {
                    try
                    {
                        byte[] imageBytes = (byte[])cellValue; // Convert to byte array
                        pb_visitorQRCode.Image = ByteArrayToImage(imageBytes); // Convert & Display
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading QR Code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No QR Code available for this visitor.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
