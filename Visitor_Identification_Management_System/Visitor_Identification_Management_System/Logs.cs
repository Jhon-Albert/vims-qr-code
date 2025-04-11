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
    public partial class Logs : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"");
        public Logs()
        {
            InitializeComponent();
            displayData();
        }
        private void Logs_Load(object sender, EventArgs e)
        {

        }
        public void displayData()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from VisitorLogs", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_logs.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
        private void txt_search_logs_TextChanged(object sender, EventArgs e)
        {
            if (txt_search_logs.Text.Length > 0 && char.IsDigit(txt_search_logs.Text[0]))
            {
                // If search starts with a number, search VisitorID
                ((DataTable)dgv_logs.DataSource).DefaultView.RowFilter =
                    string.Format("convert(VisitorID, 'System.String') LIKE '%{0}%'",
                    txt_search_logs.Text);
            }
            else
            {
                // If search starts with a letter, search name and date
                ((DataTable)dgv_logs.DataSource).DefaultView.RowFilter =
                    string.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%' OR " +
                              "Email LIKE '%{0}%' OR Address LIKE '%{0}%' OR " +
                              "ContactNumber LIKE '%{0}%' OR Purpose LIKE '%{0}%'",
                    txt_search_logs.Text);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
