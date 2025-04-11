using Emgu.CV;
using Microsoft.Data.SqlClient;
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
using Timer = System.Windows.Forms.Timer;

namespace Visitor_Identification_Management_System
{
    public partial class RealTimeTracking : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"");
        private Timer refreshTimer;
        private VideoCapture capture1;
        private string cameraUrl1;
        public RealTimeTracking()
        {
            InitializeComponent();
        }

        private void RealTimeTracking_Load(object sender, EventArgs e)
        {
            lbl_date.Text = "Date: " + DateTime.Now.ToLongDateString();
            timer1.Interval = 1000;
            timer1.Start();
            StartRealTimeTracking();
        }

        private void StartRealTimeTracking()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 1000;
            refreshTimer.Tick += RefreshVisitorStatus;
            refreshTimer.Start();
            RefreshVisitorStatus(null, null);
        }

        private void RefreshVisitorStatus(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT TOP 1 r.FirstName, r.LastName, v.CheckInTime, v.CheckOutTime, r.ProfilePicture " +
                               "FROM VisitorLogs v " +
                               "INNER JOIN Registration r ON v.VisitorID = r.VisitorID " +
                               "ORDER BY v.CheckInTime DESC"; // Get the latest visitor activity

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                        DateTime? checkInTime = reader["CheckInTime"] as DateTime?;
                        DateTime? checkOutTime = reader["CheckOutTime"] as DateTime?;
                        byte[] imageData = reader["ProfilePicture"] != DBNull.Value ? (byte[])reader["ProfilePicture"] : null;

                        lbl_visitorName.Text = fullName;

                        if (checkOutTime == null)
                        {
                            lbl_visitorStatus.Text = "Checked In";
                            lbl_visitorTime.Text = "Time: " + checkInTime?.ToString("hh:mm tt");
                        }
                        else
                        {
                            lbl_visitorStatus.Text = "Checked Out";
                            lbl_visitorTime.Text = "Time: " + checkOutTime?.ToString("hh:mm tt");
                        }

                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pb_visitorProfilePicture.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pb_visitorProfilePicture.Image = Properties.Resources.default_image; // Use a default image
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating real-time tracking: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_liveCamera_Click(object sender, EventArgs e)
        {
            /*
            if (!string.IsNullOrEmpty(txt_urlCamera1.Text))
            {
                cameraUrl1 = txt_urlCamera1.Text;

                try
                {
                    if (capture1 != null)
                    {
                        capture1.Dispose();
                    }

                    capture1 = new VideoCapture(cameraUrl1);
                    capture1.ImageGrabbed += Capture_ImageGrabbed;
                    capture1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to camera: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid RTSP URL.");
            }
            */
            if (!string.IsNullOrEmpty(toolStripTextBox1_urlCamera1.Text))
            {
                cameraUrl1 = toolStripTextBox1_urlCamera1.Text;
                StartCamera1();
            }
            else
            {
                MessageBox.Show("Please enter a valid RTSP URL for Camera 1.");
            }
        }

        private void btn_liveCamera2_Click(object sender, EventArgs e)
        {
            /*
            if (!string.IsNullOrEmpty(txt_urlCamera2.Text))
            {
                cameraUrl2 = txt_urlCamera2.Text;

                try
                {
                    if (capture2 != null)
                    {
                        capture2.Dispose();
                    }

                    capture2 = new VideoCapture(cameraUrl2);
                    capture2.ImageGrabbed += Capture2_ImageGrabbed;
                    capture2.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to camera: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid RTSP URL.");
            }
            */
        }
        private void StartCamera1()
        {
            try
            {
                StopCamera1(); // Ensure the previous instance is closed

                capture1 = new VideoCapture(cameraUrl1);
                if (!capture1.IsOpened)
                {
                    MessageBox.Show("Failed to open Camera 1.");
                    return;
                }

                capture1.ImageGrabbed += Capture_ImageGrabbed;
                capture1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to Camera 1: " + ex.Message);
            }
        }

        private void btn_stopCamera_Click(object sender, EventArgs e)
        {
            StopCamera1();
        }

        private void StopCamera1()
        {
            if (capture1 != null)
            {
                capture1.Stop();
                capture1.Dispose();
                capture1 = null;
            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            /*
            try
            {
                using (Mat frame = new Mat())
                {
                    if (capture1 != null && capture1.IsOpened)
                    {
                        capture1.Retrieve(frame);
                        pb_camera1.Image = frame.ToBitmap();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error capturing frame: " + ex.Message);
            }
            */
            try
            {
                using (Mat frame = new Mat())
                {
                    if (capture1 != null && capture1.IsOpened)
                    {
                        capture1.Retrieve(frame);
                        if (!frame.IsEmpty)
                        {
                            pb_camera1.Invoke((MethodInvoker)(() =>
                            {
                                pb_camera1.Image?.Dispose(); // Dispose old image to prevent memory leaks
                                pb_camera1.Image = frame.ToBitmap();
                            }));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error capturing frame from Camera 1: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = "Time: " + DateTime.Now.ToLongTimeString();
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
            this.Close();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
