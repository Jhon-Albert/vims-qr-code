using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Visitor_Identification_Management_System
{
    public partial class ScanQR : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;");
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private RealTimeTracking trackingForm;

        public ScanQR()//RealTimeTracking form)
        {
            InitializeComponent();
            //trackingForm = form;
        }

        private void ScanQR_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
            {
                cmb_camera.Items.Add(device.Name);
            }

            int droidCamIndex = -1;
            for (int i = 0; i < cmb_camera.Items.Count; i++)
            {
                if (cmb_camera.Items[i].ToString().ToLower().Contains("droidcam"))
                {
                    droidCamIndex = i;
                    break;
                }
            }
            if (droidCamIndex != -1)
            {
                cmb_camera.SelectedIndex = droidCamIndex;
            }

            lbl_date.Text = "Date: " + DateTime.Now.ToLongDateString();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pb_scan.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void StopCamera()
        {
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
                FinalFrame = null;
            }
        }
        private void ScanQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
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

                        if (visitorInfo.Length == 8)
                        {
                            txt_visitorID.Text = visitorInfo[0];
                            txt_firstName.Text = visitorInfo[1];   
                            txt_middleName.Text = visitorInfo[2];    
                            txt_lastName.Text = visitorInfo[3];
                            txt_email.Text = visitorInfo[4];
                            txt_address.Text = visitorInfo[5];  
                            txt_contactNumber.Text = visitorInfo[6];
                            txt_purpose.Text = visitorInfo[7];   

                            if (!string.IsNullOrEmpty(txt_visitorID.Text))
                            {
                                using (SqlCommand cmd = new SqlCommand("SELECT VisitorID, FirstName, MiddleName, LastName, Email, Address, ContactNumber, Purpose, ProfilePicture, ExpirationDate FROM Registration WHERE VisitorID = @VisitorID", con))
                                {
                                    cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);

                                    if (con.State != System.Data.ConnectionState.Open)
                                        con.Open();

                                    using (SqlDataReader dr = cmd.ExecuteReader())
                                    {
                                        if (dr.Read())
                                        {
                                            txt_email.Text = dr["Email"].ToString();

                                            if (dr["ProfilePicture"] != DBNull.Value)
                                            {
                                                byte[] imageBytes = (byte[])dr["ProfilePicture"];
                                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                                {
                                                    pb_profilePic.Image = Image.FromStream(ms);
                                                }
                                            }
                                            else
                                            {
                                                pb_profilePic.Image = null;
                                            }

                                            // CHECK EXPIRATION DATE 
                                            if (dr["ExpirationDate"] != DBNull.Value)
                                            {
                                                DateTime expirationDate = Convert.ToDateTime(dr["ExpirationDate"]);

                                                if (DateTime.Now > expirationDate)  // QR Code Expired
                                                {
                                                    MessageBox.Show("QR Code has expired. Please renew it before checking in.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    ClearTextFields();
                                                    btn_confirm.Enabled = false;
                                                    btn_checkOut.Enabled = false;
                                                    return;
                                                }
                                                else
                                                {
                                                    btn_confirm.Enabled = true;
                                                    btn_checkOut.Enabled = true;
                                                }
                                            }
                                            //trackingForm?.UpdateVisitorInfo(txt_visitorID.Text, txt_firstName.Text, txt_lastName.Text, txt_address.Text, txt_contactNumber.Text, txt_purpose.Text, profilePic);
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
            txt_middleName.Clear();
            txt_lastName.Clear();
            txt_address.Clear();
            txt_contactNumber.Clear();
            txt_purpose.Clear();
            txt_email.Clear();
            //pb_profilePic.Image = null;
            pb_profilePic.Image = Image.FromFile(@"C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\Visitor_Identification_Management_System\Resources\image.png");
        }

        // BUTTON
        private void btn_camera_Click(object sender, EventArgs e)
        {
            StopCamera();
            if (CaptureDevice.Count > 0)
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[cmb_camera.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += FinalFrame_NewFrame;
                FinalFrame.Start();
            }
            else
            {
                MessageBox.Show("No camera device found.");
                return;
            }
        }

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

                // CHECK IF CHECKIN DUPLICATES
                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM VisitorLogs WHERE VisitorID = @VisitorID AND Status = 'Checked In'", con))
                {
                    checkCmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This visitor is already checked in.");
                        return;
                    }
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO VisitorLogs (VisitorID, FirstName, MiddleName, LastName, Purpose, CheckInTime, Status) VALUES (@VisitorID, @FirstName, @MiddleName, @LastName, @Purpose, @CheckInTime, @Status)", con);
                cmd.Parameters.AddWithValue("@VisitorID", txt_visitorID.Text);
                cmd.Parameters.AddWithValue("@FirstName", txt_firstName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txt_middleName.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_lastName.Text);
                cmd.Parameters.AddWithValue("@Purpose", txt_purpose.Text);
                cmd.Parameters.AddWithValue("@CheckInTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "Checked In");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Visitor Checked In Successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            finally
            {
                ClearTextFields();
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

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message);
            }
            finally
            {
                ClearTextFields();
            }
        }

        private void btn_refreshCamera_Click(object sender, EventArgs e)
        {
            StopCamera();
            pb_scan.Image = null;
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }
    }
}