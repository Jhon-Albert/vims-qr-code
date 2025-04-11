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
    public partial class VisitorManagement : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"");
        public VisitorManagement()
        {
            InitializeComponent();
            displayData();
        }

        private void VisitorManagement_Load(object sender, EventArgs e)
        {

        }
        private void displayData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Registration", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_visitorManagement.DataSource = dt;

                if (dgv_visitorManagement.Columns["ProfilePicture"] != null && dgv_visitorManagement.Columns["ProfilePicture"] is DataGridViewImageColumn)
                {
                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgv_visitorManagement.Columns["ProfilePicture"];
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                if (dgv_visitorManagement.Columns["QRCodeImage"] != null && dgv_visitorManagement.Columns["QRCodeImage"] is DataGridViewImageColumn)
                {
                    DataGridViewImageColumn qrColumn = (DataGridViewImageColumn)dgv_visitorManagement.Columns["QRCodeImage"];
                    qrColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
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
        private void dgv_visitorManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_visitorID.Text = dgv_visitorManagement.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_firstName.Text = dgv_visitorManagement.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_middleName.Text = dgv_visitorManagement.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_lastName.Text = dgv_visitorManagement.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_email.Text = dgv_visitorManagement.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_address.Text = dgv_visitorManagement.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_contactNumber.Text = dgv_visitorManagement.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_purpose.Text = dgv_visitorManagement.Rows[e.RowIndex].Cells[7].Value.ToString();

        }
        private void ClearTextFields()
        {
            txt_visitorID.Clear();
            txt_firstName.Clear();
            txt_middleName.Clear();
            txt_lastName.Clear();
            txt_email.Clear();
            txt_contactNumber.Clear();
            txt_purpose.Clear();
            txt_address.Clear();
        }
        //BUTTONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Registration VALUES(@VisitorID, @FirstName, @MiddleName, @LastName, @Email, @ContactNumber, @Purpose, @Address)", con);
                cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txt_firstName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txt_middleName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_lastName.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txt_contactNumber.Text);
                cmd.Parameters.AddWithValue("@Purpose", txt_purpose.Text);
                cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Visitor added successfully!");
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

                SqlCommand cmd = new SqlCommand("UPDATE Registration SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Email=@Email, ContactNumber=@ContactNumber, Purpose=@Purpose, Address=@Address WHERE VisitorID=@VisitorID", con);
                cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txt_firstName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txt_middleName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_lastName.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txt_contactNumber.Text);
                cmd.Parameters.AddWithValue("@Purpose", txt_purpose.Text);
                cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Visitor updated successfully!");
                    ClearTextFields();
                    displayData(); // Refreshes DataGridView
                }
                else
                {
                    MessageBox.Show("Visitor not found!");
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
                if (string.IsNullOrWhiteSpace(txt_visitorID.Text))
                {
                    MessageBox.Show("Please select a visitor to delete.");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this visitor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Registration WHERE VisitorID=@VisitorID", con);
                    cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Visitor deleted successfully!");
                        ClearTextFields();
                        displayData(); // Refreshes DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Visitor not found!");
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void txt_searchVisitor_TextChanged(object sender, EventArgs e)
        {
            searchData(txt_searchVisitor.Text);
        }
        private void searchData(string search)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Registration WHERE FirstName LIKE @search OR LastName LIKE @search OR Email LIKE @search OR VisitorID LIKE @search", con);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_visitorManagement.DataSource = dt;
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
