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
using Timer = System.Windows.Forms.Timer;




namespace Visitor_Identification_Management_System
{
    public partial class EmployeeDashboard: UserControl
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
        private List<Visitor> checkedInVisitors = new List<Visitor>();
        private int currentIndex = 0;
        private Timer visitorTimer;
        public EmployeeDashboard()
        {
            InitializeComponent();
            LoadStats();
            LoadCheckedInVisitors();
            StartVisitorRotation();
            LoadRecentCheckOutVisitor();
        }

        private void LoadStats()
        {
            con.Open();
            //
            SqlCommand total_reg_cmd = new SqlCommand("select count(*) from Registration", con);
            lbl_total_regis.Text = total_reg_cmd .ExecuteScalar().ToString();
            //
            SqlCommand today_visitor_cmd = new SqlCommand("select count(*) from VisitorLogs where cast(CheckInTime as date) = cast(getdate() as date)", con);
            lbl_today.Text = today_visitor_cmd.ExecuteScalar().ToString();
            //
            SqlCommand current_visitor_cmd = new SqlCommand("select count(*) from VisitorLogs where CheckInTime is not null and CheckOutTime is null", con);
            lbl_current.Text = current_visitor_cmd .ExecuteScalar().ToString();
            con.Close();
        }

        //CHECK IN VISITOR
        private void LoadCheckedInVisitors()
        {
            checkedInVisitors.Clear(); // Clear the previous list

            try
            {
                con.Open();
                string query = "SELECT r.FirstName, r.LastName, v.CheckInTime, r.ProfilePicture FROM VisitorLogs v " +
                               "INNER JOIN Registration r ON v.VisitorID = r.VisitorID " +
                               "WHERE v.CheckInTime IS NOT NULL AND v.CheckOutTime IS NULL ORDER BY v.CheckInTime ASC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checkedInVisitors.Add(new Visitor
                            {
                                FullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString(),
                                CheckInTime = Convert.ToDateTime(reader["CheckInTime"]).ToString("hh:mm tt"),
                                ImageData = reader["ProfilePicture"] != DBNull.Value ? (byte[])reader["ProfilePicture"] : null
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading visitors: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // RECENT CHECK OUT VISITOR
        private void LoadRecentCheckOutVisitor()
        {
            try
            {
                con.Open();
                string query = "SELECT TOP 1 r.FirstName, r.LastName, v.CheckOutTime, r.ProfilePicture " +
                               "FROM VisitorLogs v " +
                               "INNER JOIN Registration r ON v.VisitorID = r.VisitorID " +
                               "WHERE v.CheckOutTime IS NOT NULL " +
                               "ORDER BY v.CheckOutTime DESC"; // Get the most recent check-out

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var recentVisitor = new Visitor
                            {
                                FullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString(),
                                CheckOutTime = Convert.ToDateTime(reader["CheckOutTime"]).ToString("hh:mm tt"),
                                ImageData = reader["ProfilePicture"] != DBNull.Value ? (byte[])reader["ProfilePicture"] : null
                            };

                            DisplayRecentCheckOut(recentVisitor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent check-out: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void StartVisitorRotation()
        {
            if (checkedInVisitors.Count > 0)
            {
                visitorTimer = new Timer();
                visitorTimer.Interval = 5000; // Change visitor every 5 seconds
                visitorTimer.Tick += VisitorTimer_Tick;
                visitorTimer.Start();
                DisplayVisitor(0); // Show first visitor immediately
            }
        }

        private void VisitorTimer_Tick(object sender, EventArgs e)
        {
            if (checkedInVisitors.Count > 0)
            {
                currentIndex = (currentIndex + 1) % checkedInVisitors.Count; // Cycle through visitors
                DisplayVisitor(currentIndex);
            }
        }

        //CURRENT VISITOR
        private void DisplayVisitor(int index)
        {
            if (checkedInVisitors.Count == 0) return;

            var visitor = checkedInVisitors[index];
            lbl_status.Text = "Currently Inside";
            lbl_visitorName.Text = visitor.FullName;
            lbl_time.Text = "Checked In: " + visitor.CheckInTime;

            if (visitor.ImageData != null)
            {
                using (MemoryStream ms = new MemoryStream(visitor.ImageData))
                {
                    pb_displayProfile.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pb_displayProfile.Image = Properties.Resources.default_image; // Use a default image
            }
        }

        //RECENT VISITOR
        private void DisplayRecentCheckOut(Visitor visitor)
        {
            lbl_recentStatus.Text = "Last Checked Out";  // Label for status
            lbl_recentVisitorName.Text = visitor.FullName;
            lbl_recentTime.Text = "Checked Out: " + visitor.CheckOutTime;

            if (visitor.ImageData != null)
            {
                using (MemoryStream ms = new MemoryStream(visitor.ImageData))
                {
                    pb_recentDisplayProfile.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pb_recentDisplayProfile.Image = Properties.Resources.default_image; // Default image
            }
        }


        private class Visitor
        {
            public string FullName { get; set; }
            public string CheckInTime { get; set; }
            public byte[] ImageData { get; set; }
            public string CheckOutTime { get; set; }
        }
    }
}
