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
            displayData();
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
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT VisitorID, FirstName, MiddleName, LastName, Email, ContactNumber, Address, Purpose, ProfilePicture, ExpirationDate FROM Registration";
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
