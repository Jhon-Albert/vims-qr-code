using Microsoft.Data.SqlClient;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Visitor_Identification_Management_System
{
    public partial class Registration : Form
    {
        private string senderEmail;
        private string senderPassword;

        public Registration()
        {
            InitializeComponent();
            LoadEmailCredentials();
        }

        private void LoadEmailCredentials()
        {
            // Ideally load from a secure configuration or environment variables
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
                MessageBox.Show("Error generating QR Code: " + ex.Message);
            }
        }

        private bool SendEmailWithQRCode(string recipientEmail, string qrFilePath)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = "Your Visitor QR Code";
                mail.Body = "Dear Visitor,\n\nAttached is your generated QR Code for verification upon arrival.\n\nThank you!";

                Attachment attachment = new Attachment(qrFilePath);
                mail.Attachments.Add(attachment);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
                return false;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\VIMS_try\VIMS.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    string query = "INSERT INTO Registration (Email, FirstName, LastName, Address, ContactNumber, Purpose) VALUES (@Email, @FirstName, @LastName, @Address, @ContactNumber, @Purpose)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", txt_firstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txt_lastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txt_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txt_contactNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@Purpose", cmb_purpose.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully.");
                    }
                }

                string visitorData = $"Name: {txt_firstName.Text.Trim()} {txt_lastName.Text.Trim()}\nAddress: {txt_address.Text.Trim()}\nContact: {txt_contactNumber.Text.Trim()}\nPurpose: {cmb_purpose.Text.Trim()}";
                string filePath = Path.Combine(Application.StartupPath, $"Visitor_{txt_firstName.Text.Trim()}{txt_lastName.Text.Trim()}.png");
                GenerateQRCode(visitorData, txt_firstName.Text.Trim() + txt_lastName.Text.Trim());

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
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
