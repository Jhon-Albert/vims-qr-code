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
    public partial class Blacklist : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"");
        public Blacklist()
        {
            InitializeComponent();
            displayData();
        }

        private void txt_search_blacklist_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_blacklist.DataSource != null)
                {
                    ((DataTable)dgv_blacklist.DataSource).DefaultView.RowFilter =
                    string.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%' OR Reason LIKE '%{0}%' OR CONVERT(Date, 'System.String') LIKE '%{0}%'",
                    txt_search_blacklist.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
        public void displayData()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Blacklist", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_blacklist.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
