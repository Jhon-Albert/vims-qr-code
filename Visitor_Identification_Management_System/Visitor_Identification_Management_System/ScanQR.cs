using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Aztec;
using Microsoft.Data.SqlClient;

namespace Visitor_Identification_Management_System
{
    public partial class ScanQR : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\VIMS_try\VIMS.mdf"";Integrated Security=True;Connect Timeout=30");
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public ScanQR()
        {
            InitializeComponent();
        }

        private void ScanQR_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmb_camera.Items.Add(Device.Name);
                cmb_camera.SelectedIndex = 0;
                FinalFrame = new VideoCaptureDevice();


            }
        }

        private void btn_camera_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmb_camera.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pb_scan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ScanQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame != null && FinalFrame.IsRunning == true)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
            }
            //if (FinalFrame.IsRunning == true)
                //FinalFrame.Stop();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
