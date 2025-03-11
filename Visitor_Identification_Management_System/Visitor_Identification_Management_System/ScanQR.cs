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
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhon Albert Ogana\source\repos\VIMS_try\VIMS.mdf;Integrated Security=True;Connect Timeout=30");
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
                                con.Open();
                                SqlCommand cmd = new SqlCommand("SELECT * FROM Registration WHERE VisitorID = @VisitorID", con);
                                cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);
                                SqlDataReader dr = cmd.ExecuteReader();

                                if (dr.Read()) // Only read if there’s a row
                                {
                                    txt_email.Text = dr["Email"].ToString();
                                }
                                con.Close();
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
                }
            }
        }
        //BUTTON
        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
