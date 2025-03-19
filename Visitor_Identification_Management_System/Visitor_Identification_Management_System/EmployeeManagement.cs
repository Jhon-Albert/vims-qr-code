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
    public partial class EmployeeManagement : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
        public EmployeeManagement()
        {
            InitializeComponent();
            displayData();
        }
        private void displayData()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_employeeManagement.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void dgv_employeeManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_employeeID.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_employeeName.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_employeeEmail.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_employeePassword.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void ClearTextFields()
        {
            txt_employeeID.Clear();
            txt_employeeName.Clear();
            txt_employeeEmail.Clear();
            txt_employeePassword.Clear();
        }
        //BUTTONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES(@EmployeeID, @Name, @Email, @Password)", con);
                cmd.Parameters.AddWithValue("@EmployeeID", txt_employeeID.Text);
                cmd.Parameters.AddWithValue("@Name", txt_employeeName.Text);
                cmd.Parameters.AddWithValue("@Email", txt_employeeEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txt_employeePassword.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee added successfully!");
                ClearTextFields();
                displayData(); // Refreshes DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Employee SET Name=@Name, Email=@Email, Password=@Password WHERE EmployeeID=@EmployeeID", con);
                cmd.Parameters.AddWithValue("@EmployeeID", txt_employeeID.Text);
                cmd.Parameters.AddWithValue("@Name", txt_employeeName.Text);
                cmd.Parameters.AddWithValue("@Email", txt_employeeEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txt_employeePassword.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee updated successfully!");
                    ClearTextFields();
                    displayData();
                }
                else
                {
                    MessageBox.Show("Employee not found!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_employeeID.Text))
                {
                    MessageBox.Show("Please select an employee to delete.");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmployeeID=@EmployeeID", con);
                    cmd.Parameters.AddWithValue("@EmployeeID", txt_employeeID.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully!");
                        ClearTextFields();
                        displayData();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }
    }
}
