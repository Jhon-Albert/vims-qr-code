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
        private readonly SqlConnection con = new SqlConnection(@"");
        public EmployeeManagement()
        {
            InitializeComponent();
            displayData();
        }
        private void displayData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_employeeManagement.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void dgv_employeeManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_employeeID.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_employeeFirstName.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_employeeMiddleName.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_employeeLastName.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_employeeEmail.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_employeePassword.Text = dgv_employeeManagement.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void ClearTextFields()
        {
            txt_employeeID.Clear();
            txt_employeeFirstName.Clear();
            txt_employeeMiddleName.Clear();
            txt_employeeLastName.Clear();
            txt_employeeEmail.Clear();
            txt_employeePassword.Clear();
        }
        //BUTTONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES(@EmployeeID, @FirstName, @MiddleName, @LastName, @Email, @Password)", con);
                cmd.Parameters.AddWithValue("@EmployeeID", txt_employeeID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txt_employeeFirstName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txt_employeeMiddleName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_employeeLastName.Text);
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
            finally
            {
                con.Close();
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Employee SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Email=@Email, Password=@Password WHERE EmployeeID=@EmployeeID", con);
                cmd.Parameters.AddWithValue("@EmployeeID", txt_employeeID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txt_employeeFirstName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txt_employeeMiddleName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_employeeLastName.Text);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            finally
            {
                con.Close();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void txt_searchEmployee_TextChanged(object sender, EventArgs e)
        {
            searchData(txt_searchEmployee.Text);
        }

        private void searchData(string search)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee WHERE FirstName LIKE @search OR LastName LIKE @search OR Email LIKE @search OR EmployeeID LIKE @search", con);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
