using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            adminPanelContainer.Controls.Clear();
            adminPanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
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
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
