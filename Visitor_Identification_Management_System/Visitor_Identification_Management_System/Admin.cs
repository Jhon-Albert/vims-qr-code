using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Identification_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            AdminDashboard adminDashboard = new AdminDashboard();
            addUserControl(adminDashboard);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //BUTTONS
        private void btn_admin_dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard uc = new AdminDashboard();
            addUserControl(uc);
        }

        private void btn_visitorManagement_Click(object sender, EventArgs e)
        {
            VisitorManagement uc = new VisitorManagement();
            addUserControl(uc);
        }

        private void btn_employeeManagement_Click(object sender, EventArgs e)
        {
            EmployeeManagement uc = new EmployeeManagement();
            addUserControl(uc);
        }

        private void btn_visitorReports_Click(object sender, EventArgs e)
        {
            VisitorReports uc = new VisitorReports();
            addUserControl(uc);
        }

        private void btn_blacklistManagement_Click(object sender, EventArgs e)
        {
            BlacklistManagement uc = new BlacklistManagement();
            addUserControl(uc);
        }

        private void btn_realtimeTracking_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                using (frmLogin logIn = new frmLogin())
                {
                    logIn.ShowDialog();
                }
                this.Close();
            }
            //AddButtonEffects(btn_logout);
        }
    }
}
