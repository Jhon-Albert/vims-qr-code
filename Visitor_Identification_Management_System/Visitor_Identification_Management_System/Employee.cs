using Microsoft.VisualBasic.Logging;
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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            addUserControl(employeeDashboard);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDashboard uc = new EmployeeDashboard();
            addUserControl(uc);
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            Logs uc = new Logs();
            addUserControl(uc);
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Info uc = new Info();
            addUserControl(uc);
        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            Notification uc = new Notification();
            addUserControl(uc);
        }

        private void btn_blacklist_Click(object sender, EventArgs e)
        {
            Blacklist uc = new Blacklist();
            addUserControl(uc);
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            ScanQR uc = new ScanQR();
            uc.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                using (frmLogin logIn = new frmLogin())
                {
                    logIn.ShowDialog();
                }
            }
            //AddButtonEffects(btn_logout);
        }
    }
}
