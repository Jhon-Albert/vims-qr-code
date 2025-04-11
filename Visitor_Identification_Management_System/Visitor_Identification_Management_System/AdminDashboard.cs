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
    public partial class AdminDashboard: UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"");
        public AdminDashboard()
        {
            InitializeComponent();
            LoadStats();
        }
        private void LoadStats()
        {
            con.Open();
            SqlCommand total_visitor_reg = new SqlCommand("select count(*) from Registration", con);
            lbl_visitor_reg.Text = total_visitor_reg.ExecuteScalar().ToString();
            //
            SqlCommand total_employee = new SqlCommand("select count(*) from Employee", con);
            lbl_employee.Text = total_employee.ExecuteScalar().ToString();
            //
            SqlCommand total_admin = new SqlCommand("select count(*) from Admin", con);
            lbl_admin.Text = total_admin.ExecuteScalar().ToString();
            con.Close();
        }
    }
}
