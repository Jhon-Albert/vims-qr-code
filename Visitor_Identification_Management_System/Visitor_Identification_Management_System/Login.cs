using Microsoft.Data.SqlClient;
using System.Data;

namespace Visitor_Identification_Management_System
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\VIMS_try\VIMS.mdf"";Integrated Security=True;Connect Timeout=30");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error Message: " + ex);
            }
        }

        private void cb_Pass_CheckedChanged(object sender, EventArgs e)
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
    }
}
