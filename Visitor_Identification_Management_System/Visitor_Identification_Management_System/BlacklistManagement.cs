﻿using System;
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
    public partial class BlacklistManagement : UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"");
        public BlacklistManagement()
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

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Blacklist", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_blacklist.DataSource = dt;
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
        private void dgv_blacklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_blacklistID.Text = dgv_blacklist.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_blacklistFirstname.Text = dgv_blacklist.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_blacklistMiddleName.Text = dgv_blacklist.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_blacklistLastname.Text = dgv_blacklist.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_reason.Text = dgv_blacklist.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_dateAdded.Text = dgv_blacklist.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void ClearTextFields()
        {
            txt_blacklistID.Clear();
            txt_blacklistFirstname.Clear();
            txt_blacklistMiddleName.Clear();
            txt_blacklistLastname.Clear();
            txt_reason.Clear();
            txt_dateAdded.Clear();
        }
        private void searchData(string search)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Blacklist WHERE FirstName LIKE @search OR LastName LIKE @search OR Reason LIKE @search OR BlacklistID LIKE @search", con);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_blacklist.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
        private void txt_search_blacklist_TextChanged(object sender, EventArgs e)
        {
            searchData(txt_search_blacklist.Text);
        }
        //BUTTONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Blacklist (FirstName, MiddleName, LastName, Reason) VALUES(@FirstName, @MiddleName, @LastName, @Reason)", con);
                cmd.Parameters.AddWithValue("@FirstName", txt_blacklistFirstname.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txt_blacklistMiddleName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_blacklistLastname.Text);
                cmd.Parameters.AddWithValue("@Reason", txt_reason.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Blacklist entry added successfully!");
                ClearTextFields();
                displayData();
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

                SqlCommand cmd = new SqlCommand("UPDATE Blacklist SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Reason=@Reason WHERE BlacklistID=@BlacklistID", con);
                cmd.Parameters.AddWithValue("@BlacklistID", txt_blacklistID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txt_blacklistFirstname.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txt_blacklistMiddleName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_blacklistLastname.Text);
                cmd.Parameters.AddWithValue("@Reason", txt_reason.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Blacklist entry updated successfully!");
                    ClearTextFields();
                    displayData();
                }
                else
                {
                    MessageBox.Show("Blacklist entry not found!");
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
                if (string.IsNullOrWhiteSpace(txt_blacklistID.Text))
                {
                    MessageBox.Show("Please select an entry to delete.");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this blacklist entry?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Blacklist WHERE BlacklistID=@BlacklistID", con);
                    cmd.Parameters.AddWithValue("@BlacklistID", txt_blacklistID.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Blacklist entry deleted successfully!");
                        ClearTextFields();
                        displayData();
                    }
                    else
                    {
                        MessageBox.Show("Blacklist entry not found!");
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
