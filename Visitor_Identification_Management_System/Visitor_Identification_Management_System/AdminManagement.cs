using Microsoft.Data.SqlClient;
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
    public partial class AdminManagement : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
        public AdminManagement()
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

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Admin", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_adminManagement.DataSource = dt;
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

        private void dgv_adminManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_adminID.Text = dgv_adminManagement.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_fullName.Text = dgv_adminManagement.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_adminEmail.Text = dgv_adminManagement.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_adminPassword.Text = dgv_adminManagement.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void ClearTextFields()
        {
            txt_adminID.Clear();
            txt_fullName.Clear();
            txt_adminEmail.Clear();
            txt_adminPassword.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Admin VALUES(@AdminID, @Name, @Email, @Password)", con);
                cmd.Parameters.AddWithValue("@AdminID", txt_adminID.Text);
                cmd.Parameters.AddWithValue("@Name", txt_fullName.Text);
                cmd.Parameters.AddWithValue("@Email", txt_adminEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txt_adminPassword.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Admin added successfully!");
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

                SqlCommand cmd = new SqlCommand("UPDATE Admin SET Name=@Name, Email=@Email, Password=@Password WHERE AdminID=@AdminID", con);
                cmd.Parameters.AddWithValue("@AdminID", txt_adminID.Text);
                cmd.Parameters.AddWithValue("@Name", txt_fullName.Text);
                cmd.Parameters.AddWithValue("@Email", txt_adminEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txt_adminPassword.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin updated successfully!");
                    ClearTextFields();
                    displayData();
                }
                else
                {
                    MessageBox.Show("Admin not found!");
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
                if (string.IsNullOrWhiteSpace(txt_adminID.Text))
                {
                    MessageBox.Show("Please select an admin to delete.");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Admin WHERE AdminID=@AdminID", con);
                    cmd.Parameters.AddWithValue("@AdminID", txt_adminID.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin deleted successfully!");
                        ClearTextFields();
                        displayData();
                    }
                    else
                    {
                        MessageBox.Show("Admin not found!");
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

        private void txt_searchAdmin_TextChanged(object sender, EventArgs e)
        {
            searchData(txt_searchAdmin.Text);
        }

        private void searchData(string search)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Admin WHERE Name LIKE @search OR Email LIKE @search OR AdminID LIKE @search", con);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_adminManagement.DataSource = dt;
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
