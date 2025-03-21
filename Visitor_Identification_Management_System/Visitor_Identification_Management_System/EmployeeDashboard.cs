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
    public partial class EmployeeDashboard: UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
        public EmployeeDashboard()
        {
            InitializeComponent();
            LoadStats();
        }

        private void LoadStats()
        {
            con.Open();
            //
            SqlCommand total_reg_cmd = new SqlCommand("select count(*) from Registration", con);
            lbl_total_regis.Text = total_reg_cmd .ExecuteScalar().ToString();
            //
            SqlCommand today_visitor_cmd = new SqlCommand("select count(*) from VisitorLogs where cast(CheckInTime as date) = cast(getdate() as date)", con);
            lbl_today.Text = today_visitor_cmd.ExecuteScalar().ToString();
            //
            SqlCommand current_visitor_cmd = new SqlCommand("select count(*) from VisitorLogs where CheckInTime is not null and CheckOutTime is null", con);
            lbl_current.Text = current_visitor_cmd .ExecuteScalar().ToString();
            con.Close();
        }
        private void LoadVisitorStatus()
        {
            panelVisitors.Controls.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM REGISTRATION"))
                    {

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
    }
}
