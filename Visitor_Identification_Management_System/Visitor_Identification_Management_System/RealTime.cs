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
using Emgu.CV;
using System.Text.RegularExpressions;

namespace Visitor_Identification_Management_System
{
    public partial class RealTime : UserControl
    {
        private VideoCapture capture;
        private string cameraUrl = "";
        public RealTime()
        {
            InitializeComponent();
        }

        private void RealTime_Load(object sender, EventArgs e)
        {
            lbl_date.Text = "Date: " + DateTime.Now.ToLongDateString();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btn_liveCamera_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_urlCamera.Text))
            {
                cameraUrl = txt_urlCamera.Text;

                try
                {
                    if (capture != null)
                    {
                        capture.Dispose();
                    }

                    capture = new VideoCapture(cameraUrl);
                    capture.ImageGrabbed += Capture_ImageGrabbed;
                    capture.Start();
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
        }
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                using (Mat frame = new Mat())
                {
                    if (capture != null && capture.IsOpened)
                    {
                        capture.Retrieve(frame);
                        pb_camera1.Image = frame.ToBitmap();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error capturing frame: " + ex.Message);
            }
        }
        public void StopCamera()
        {
            if (capture != null && capture.IsOpened)
            {
                capture.Stop();
                capture.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = "Time: " + DateTime.Now.ToLongTimeString();
        }
    }
}
