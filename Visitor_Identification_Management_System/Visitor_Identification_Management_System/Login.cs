using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace Visitor_Identification_Management_System
{
    public partial class frmLogin : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"");
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Roles
                string role = rbtn_Employee.Checked ? "Employee" : rbtn_Admin.Checked ? "Admin" : string.Empty;
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please select a role (Employee or Admin).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                string tableName = role == "Employee" ? "Employee" : "Admin";
                SqlCommand cmd = new SqlCommand($"select * from {tableName} where Email = @Email and Password = @Password", con);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@Password", txt_Password.Text);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successfully");
                    if (role == "Employee")
                    {
                        Employee dash = new Employee();
                        this.Hide();
                        dash.Show();
                    }
                    else if (role == "Admin")
                    {

                        Admin dash_admin = new Admin();
                        this.Hide();
                        dash_admin.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Email.Clear();
                    txt_Password.Clear();
                    txt_Email.Focus();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }

        private void cb_Pass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_Pass.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
