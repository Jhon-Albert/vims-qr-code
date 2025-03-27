using Microsoft.Data.SqlClient;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System.Timers;
using System.Data;

namespace Visitor_Identification_Management_System
{
    public partial class Registration : Form
    {
        private string senderEmail;
        private string senderPassword;
        private System.Timers.Timer syncTimer;

        public Registration()
        {
            InitializeComponent();
            LoadEmailCredentials();
        }

        private void LoadEmailCredentials()
        {
            senderEmail = Environment.GetEnvironmentVariable("SENDER_EMAIL") ?? "degolladomichael01@gmail.com";
            senderPassword = Environment.GetEnvironmentVariable("SENDER_PASSWORD") ?? "ctor uogr wgin mvev";
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string[] purpose = { "Delivery", "Personal Visit", "Maintenance", "Official Business", "Service Appointment", "Others" };
            foreach (string purposes in purpose)
            {
                cmb_purpose.Items.Add(purposes);
            }
        }

        //GENERATE VISITOR ID
        public static string GenerateVisitorID()
        {
            int lastVisitorNumber = 10000; // Start from V10001
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT TOP 1 VisitorID FROM Registration ORDER BY VisitorID DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastVisitorID = result.ToString();
                            if (lastVisitorID.StartsWith("V") && int.TryParse(lastVisitorID.Substring(1), out int visitorNumber))
                            {
                                lastVisitorNumber = visitorNumber; // Get the last used number
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching last VisitorID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return $"V{(lastVisitorNumber + 1):D5}"; // Ensure it's always "V10001", "V10002", etc.
        }

        //GENERATE VISITOR QR CODE
        private void GenerateQRCode(string data, string visitorID)
        {
            try
            {
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(10);

                        // Save QR code as an image file
                        string filePath = Path.Combine(Application.StartupPath, $"Visitor_{visitorID}.png");
                        qrCodeImage.Save(filePath, ImageFormat.Png);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating QR Code: " + ex.Message, "QR Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //SEND VISITOR QR CODE TO EMAIL
        private bool SendEmailWithQRCode(string recipientEmail, string qrFilePath)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "Your Visitor QR Code";
                    mail.Body = "Dear Visitor,\n\nAttached is your generated QR Code for verification upon arrival.\n\nThank you!";
                    mail.Attachments.Add(new Attachment(qrFilePath));

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }

                // Delete QR code file after sending email
                if (File.Exists(qrFilePath))
                {
                    File.Delete(qrFilePath);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool IsValidEmail(string email)
        {
            try { return new MailAddress(email).Address == email; }
            catch { return false; }
        }

        private void ClearTextFields()
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_email.Clear();
            txt_contactNumber.Clear();
            txt_address.Clear();
            cmb_purpose.SelectedIndex = -1;
            pb_uploadProfile.Image = null;
        }

        //IMAGE
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        //BUTTONS
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_firstName.Text) ||
                string.IsNullOrWhiteSpace(txt_lastName.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text) ||
                string.IsNullOrWhiteSpace(txt_contactNumber.Text) ||
                string.IsNullOrWhiteSpace(cmb_purpose.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string visitorID = GenerateVisitorID();
                byte[] profilePicture = pb_uploadProfile.Image != null ? ImageToByteArray(pb_uploadProfile.Image) : null;
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    string query = "INSERT INTO Registration (VisitorID, FirstName, MiddleName, LastName, Email, Address, ContactNumber, Purpose, ProfilePicture) VALUES (@VisitorID, @FirstName, @MiddleName, @LastName, @Email, @Address, @ContactNumber, @Purpose, @ProfilePicture)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VisitorID", visitorID.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", txt_firstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@MiddleName", txt_middleName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txt_lastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txt_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txt_contactNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@Purpose", cmb_purpose.Text.Trim());

                        if(profilePicture != null)
                        {
                            cmd.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = profilePicture;
                        }
                        else
                        {
                            cmd.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

                            cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully.");
                    }
                }

                string visitorData = $"VisitorID: {visitorID}\nFirstName: {txt_firstName.Text.Trim()}\nMiddleName: {txt_middleName.Text.Trim()}\nLastName: {txt_lastName.Text.Trim()}\nAddress: {txt_address.Text.Trim()}\nContact: {txt_contactNumber.Text.Trim()}\nPurpose: {cmb_purpose.Text.Trim()}";
                string systemVisitorData = $"{visitorID}|{txt_firstName.Text.Trim()}|{txt_middleName.Text.Trim()}|{txt_lastName.Text.Trim()}|{txt_address.Text.Trim()}|{txt_contactNumber.Text.Trim()}|{cmb_purpose.Text.Trim()}";
                string filePath = Path.Combine(Application.StartupPath, $"Visitor_{visitorID}.png");
                GenerateQRCode(systemVisitorData, visitorID);

                if (SendEmailWithQRCode(txt_email.Text.Trim(), filePath))
                {
                    MessageBox.Show("Visitor Registered Successfully and QR Code sent to " + txt_email.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Visitor registered, but QR code email failed to send.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClearTextFields();
            }
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

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pb_uploadProfile.Image = Image.FromFile(openFile.FileName);
            }
        }
    }
}
