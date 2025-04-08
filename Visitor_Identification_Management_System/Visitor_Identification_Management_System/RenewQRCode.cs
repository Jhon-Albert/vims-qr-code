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
using QRCoder;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;
using static QRCoder.PayloadGenerator.SwissQrCode;

namespace Visitor_Identification_Management_System
{
    public partial class RenewQRCode : UserControl
    {
        private string senderEmail;
        private string senderPassword;

        public RenewQRCode()
        {
            InitializeComponent();
            displayData();
            LoadEmailCredentials();
        }

        private void LoadEmailCredentials()
        {
            senderEmail = Environment.GetEnvironmentVariable("SENDER_EMAIL") ?? "YOUR-EMAIL@gmail.com";
            senderPassword = Environment.GetEnvironmentVariable("SENDER_PASSWORD") ?? "YOUR-EMAIL-PASSWORD";
        }

        private void displayData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT VisitorID, FirstName + ' ' + MiddleName + '.' + ' ' + LastName AS FullName FROM Registration";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgv_visitorQRCode.DataSource = dt;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string visitorInfo = reader["VisitorID"].ToString() + " - " + reader["FullName"].ToString();
                            cmb_visitor.Items.Add(visitorInfo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading visitors: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentQRCode(string visitorID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT QRCodeImage FROM Registration WHERE VisitorID = @VisitorID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VisitorID", visitorID);
                        byte[] qrCodeBytes = cmd.ExecuteScalar() as byte[];

                        if (qrCodeBytes != null)
                        {
                            using (MemoryStream ms = new MemoryStream(qrCodeBytes))
                            {
                                pb_currentQRCode.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading current QR code: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_renewQRCode_Click(object sender, EventArgs e)
        {
            string selectedVisitor = cmb_visitor.SelectedItem.ToString();
            string visitorID = selectedVisitor.Split(' ')[0]; // Extract VisitorID

            DateTime newExpirationDate = DateTime.Now.AddDays(7); // Example expiration date (7 days from today)
            byte[] newQRCodeBytes = GenerateQRCode(visitorID);

            // Update the visitor's QR code in the database and log the renewal
            RenewQRCodeInDatabase(visitorID, newQRCodeBytes, newExpirationDate);
        }

        private byte[] GenerateQRCode(string visitorID)
        {
            try
            {
                string qrContent = "";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    string query = "SELECT FirstName, MiddleName, LastName, Email, Address, ContactNumber, Purpose FROM Registration WHERE VisitorID = @VisitorID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VisitorID", visitorID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["FirstName"].ToString();
                                string middleName = reader["MiddleName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                string email = reader["Email"].ToString();
                                string address = reader["Address"].ToString();
                                string contact = reader["ContactNumber"].ToString();
                                string purpose = reader["Purpose"].ToString();

                                // You can format this as JSON or a delimited string
                                qrContent = $"{visitorID}|{firstName}|{middleName}|{lastName}|{email}|{address}|{contact}|{purpose}";
                                //$"{visitorID}|{txt_firstName.Text.Trim()}|{txt_middleName.Text.Trim()}|{txt_lastName.Text.Trim()}|{txt_email.Text.Trim()}|{txt_address.Text.Trim()}|{txt_contactNumber.Text.Trim()}|{cmb_purpose.Text.Trim()}";
                            }
                        }
                    }
                }

                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        using (Bitmap qrCodeImage = qrCode.GetGraphic(10))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                qrCodeImage.Save(ms, ImageFormat.Png);
                                return ms.ToArray(); // Return QR code as byte array
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating QR Code: " + ex.Message, "QR Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void RenewQRCodeInDatabase(string visitorID, byte[] newQRCodeBytes, DateTime newExpirationDate)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    // Get the current QR code for the visitor (before renewal) and email
                    byte[] oldQRCodeBytes = null;
                    string visitorEmail = null;
                    string queryOldQRCode = "SELECT QRCodeImage, Email FROM Registration WHERE VisitorID = @VisitorID";
                    using (SqlCommand cmd = new SqlCommand(queryOldQRCode, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@VisitorID", visitorID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                oldQRCodeBytes = reader["QRCodeImage"] as byte[];
                                visitorEmail = reader["Email"].ToString(); // Retrieve visitor's email
                            }
                        }
                    }

                    // Update the visitor's QR code in the Registration table
                    string queryUpdateQRCode = "UPDATE Registration SET QRCodeImage = @QRCodeImage, ExpirationDate = @ExpirationDate WHERE VisitorID = @VisitorID";
                    using (SqlCommand cmd = new SqlCommand(queryUpdateQRCode, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@VisitorID", visitorID);
                        cmd.Parameters.AddWithValue("@QRCodeImage", newQRCodeBytes);
                        cmd.Parameters.AddWithValue("@ExpirationDate", newExpirationDate);
                        cmd.ExecuteNonQuery();
                    }

                    // Log the renewal in the QRCodeRenewals table
                    string queryLogRenewal = "INSERT INTO QRCodeRenew (VisitorID, PreviousQRCode, NewQRCode, RenewalDate, NewExpirationDate) VALUES (@VisitorID, @PreviousQRCode, @NewQRCode, @RenewalDate, @NewExpirationDate)";
                    using (SqlCommand cmd = new SqlCommand(queryLogRenewal, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@VisitorID", visitorID);
                        cmd.Parameters.AddWithValue("@PreviousQRCode", oldQRCodeBytes ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NewQRCode", newQRCodeBytes);
                        cmd.Parameters.AddWithValue("@RenewalDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@NewExpirationDate", newExpirationDate);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    // Send the renewed QR code to the visitor's email
                    if (!string.IsNullOrEmpty(visitorEmail))
                    {
                        SendQRCodeEmail(visitorEmail, newQRCodeBytes);
                    }

                    MessageBox.Show("QR Code renewed and emailed successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error renewing QR Code: " + ex.Message, "Renewal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmb_visitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVisitor = cmb_visitor.SelectedItem.ToString();
            string visitorID = selectedVisitor.Split(' ')[0]; // Extract VisitorID

            // Load current QR code for the selected visitor
            LoadCurrentQRCode(visitorID);
        }

        private void SendQRCodeEmail(string visitorEmail, byte[] qrCodeImageBytes)
        {
            try
            {
                // Create the email message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail); // Your email address
                mail.To.Add(visitorEmail); // Visitor's email address
                mail.Subject = "Your QR Code Renewal";
                mail.Body = "Hello, \n\nYour QR Code has been successfully renewed. Please find the new QR Code attached.\n\nBest regards,\nVisitor Identification Management System";

                // Attach the QR code as a file
                using (MemoryStream ms = new MemoryStream(qrCodeImageBytes))
                {
                    Attachment attachment = new Attachment(ms, "QR_Code.png", "image/png");
                    mail.Attachments.Add(attachment);

                    // Send the email via SMTP
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); // SMTP server (Gmail)
                    smtpClient.Port = 587; // Gmail SMTP port
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword); // Your email and password
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
