using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;
using QRCoder;

public static class QRCodeHelper
{

    /*public static void GenerateQRCode(string data, string visitorID)
    {
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q))
            {
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                    {
                        string filePath = Path.Combine(Application.StartupPath, $"Visitor_{visitorID}.png");
                        qrCodeImage.Save(filePath, ImageFormat.Png);
                    }
                }
            }
        }
    }*/
    public static byte[] GenerateQRCode(string data, string visitorID)
    {
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q))
            {
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                        {
                            qrCodeImage.Save(ms, ImageFormat.Png);
                            return ms.ToArray(); // Return QR code as byte array
                        }
                    }
                }
            }
        }
    }

    /*public static bool SendEmailWithQRCode(string email, string filePath)
    {
        try
        {
            string senderEmail = Environment.GetEnvironmentVariable("SENDER_EMAIL") ?? "degolladomichael01@gmail.com";
            string senderPassword = Environment.GetEnvironmentVariable("SENDER_PASSWORD") ?? "ctor uogr wgin mvev";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("QR code file not found, email not sent.");
                return false;
            }

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail); // Change to your email
            mail.To.Add(email);
            mail.Subject = "Your Visitor QR Code";
            mail.Body = "Here is your QR code for your visit.";
            mail.Attachments.Add(new Attachment(filePath));

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // Change to your SMTP provider
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(senderEmail, senderPassword);
            smtp.EnableSsl = true;
            smtp.Send(mail);

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Email sending failed: " + ex.Message);
            return false;
        }
    }*/
    public static bool SendEmailWithQRCode(string email, byte[] qrCodeBytes)
    {
        try
        {
            string senderEmail = Environment.GetEnvironmentVariable("SENDER_EMAIL") ?? "degolladomichael01@gmail.com";
            string senderPassword = Environment.GetEnvironmentVariable("SENDER_PASSWORD") ?? "ctor uogr wgin mvev";

            using (MemoryStream ms = new MemoryStream(qrCodeBytes))
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(email);
                mail.Subject = "Your Visitor QR Code";
                mail.Body = "Here is your QR code for your visit.";
                mail.Attachments.Add(new Attachment(ms, "VisitorQRCode.png", "image/png"));

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Email sending failed: " + ex.Message);
            return false;
        }
    }
}
