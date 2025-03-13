using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;
using Microsoft.Data.SqlClient;

namespace Visitor_Identification_Management_System
{
    public partial class ScanQR : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public ScanQR()
        {
            InitializeComponent();
        }
        private void ScanQR_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
            {
                cmb_camera.Items.Add(device.Name);
            }
            if (cmb_camera.Items.Count > 0)
            {
                cmb_camera.SelectedIndex = 0;
            }

            lbl_date.Text = "Date: " + DateTime.Now.ToLongDateString();
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pb_scan.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void ScanQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
            }
        }
        private void btn_camera_Click(object sender, EventArgs e)
        {
            if (CaptureDevice.Count > 0)
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[cmb_camera.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += FinalFrame_NewFrame;
                FinalFrame.Start();
            }
            else
            {
                MessageBox.Show("No camera device found.");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = "Time: " + DateTime.Now.ToLongTimeString();
            if (pb_scan.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pb_scan.Image);
                if (result != null)
                {
                    try
                    {
                        string decode = result.ToString().Trim();

                        // Split the QR data assuming it's using a pipe '|' delimiter
                        string[] visitorInfo = decode.Split('|');

                        if (visitorInfo.Length == 6)
                        {
                            txt_visitorID.Text = visitorInfo[0];       // Visitor ID
                            txt_firstName.Text = visitorInfo[1];      // First Name
                            txt_lastName.Text = visitorInfo[2];       // Last Name
                            txt_address.Text = visitorInfo[3];        // Address
                            txt_contactNumber.Text = visitorInfo[4];  // Contact Number
                            txt_purpose.Text = visitorInfo[5];        // Purpose

                            // Now fetch additional info from the database if needed
                            if (!string.IsNullOrEmpty(txt_visitorID.Text))
                            {
                                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Registration WHERE VisitorID = @VisitorID", con))
                                {
                                    cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);

                                    if (con.State != System.Data.ConnectionState.Open)
                                        con.Open();

                                    using (SqlDataReader dr = cmd.ExecuteReader())
                                    {
                                        if (dr.Read())
                                        {
                                            txt_email.Text = dr["Email"].ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Unauthorized QR code. This visitor is not registered.");
                                            ClearTextFields();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid QR code data format. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message: " + ex.Message);
                    }
                    finally
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                            con.Close();
                    }
                }
            }
        }
        private void ClearTextFields()
        {
            txt_visitorID.Clear();
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_address.Clear();
            txt_contactNumber.Clear();
            txt_purpose.Clear();
            txt_email.Clear();
        }
        //BUTTON
        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_visitorID.Text))
            {
                MessageBox.Show("No visitor selected. Please scan a valid QR code first.");
                return;
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO VisitorLogs (VisitorID, FirstName, LastName, Purpose, CheckInTime, Status) VALUES (@VisitorID, @FirstName, @LastName, @Purpose, @CheckInTime, @Status)", con);
                cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txt_firstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_lastName.Text);
                cmd.Parameters.AddWithValue("@Purpose", txt_purpose.Text);
                cmd.Parameters.AddWithValue("@CheckInTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "Checked In");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Visitor Checked In Successfully");
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_visitorID.Text))
            {
                MessageBox.Show("No visitor selected. Please scan a valid QR code first.");
                return;
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE VisitorLogs SET CheckOutTime = @CheckOutTime, Status = @Status WHERE VisitorID = @VisitorID AND CheckOutTime IS NULL", con);
                cmd.Parameters.AddWithValue("@CheckOutTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "Checked Out");
                cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Visitor Checked Out Successfully");
                }
                else
                {
                    MessageBox.Show("No active check-in found for this visitor.");
                }

                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
        }
    }
}
