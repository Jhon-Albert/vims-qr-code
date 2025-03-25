using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Visitor_Identification_Management_System
{
    public partial class Employee : Form
    {
        private static System.Timers.Timer syncTimer;
        public Employee()
        {
            InitializeComponent();
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            addUserControl(employeeDashboard);
        }

        private void StartAutoSync()
        {
            syncTimer = new System.Timers.Timer(10000);
            syncTimer.Elapsed += OnSyncTimerElapsed;
            syncTimer.AutoReset = true;
            syncTimer.Enabled = true;
        }

        private async void OnSyncTimerElapsed(object sender, ElapsedEventArgs e)
        {
            //await GoogleSync.SyncGoogleSheetData(); // Call the sync function from a separate class
            await Task.Run(async () => await GoogleSync.SyncGoogleSheetData());
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
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
        //BUTTONS
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            EmployeeDashboard uc = new EmployeeDashboard();
            addUserControl(uc);
        }

        private void btn_logs_Click_1(object sender, EventArgs e)
        {
            Logs uc = new Logs();
            addUserControl(uc);
        }

        private void btn_info_Click_1(object sender, EventArgs e)
        {
            Info uc = new Info();
            addUserControl(uc);
        }

        private void btn_blacklist_Click_1(object sender, EventArgs e)
        {
            Blacklist uc = new Blacklist();
            addUserControl(uc);
        }

        private void btn_scan_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is ScanQR)
                {
                    form.BringToFront();  // Bring the existing form to the front
                    return;  // Exit the method, preventing a new instance from being created
                }
            }
            ScanQR uc = new ScanQR();
            uc.Show();
        }

        private void btn_realTime_Click_1(object sender, EventArgs e)
        {
            RealTime uc = new RealTime();
            addUserControl(uc);
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Registration)
                {
                    form.BringToFront();  // Bring the existing form to the front
                    return;  // Exit the method, preventing a new instance from being created
                }
            }
            Registration uc = new Registration();
            uc.Show();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                using (frmLogin logIn = new frmLogin())
                {
                    logIn.ShowDialog();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            StartAutoSync();  // Start syncing when the Employee form loads
        }
    }
    public class GoogleSync
    {
        private static string CredentialsPath = @"C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\vims-visitor-registration-4e7c2a747133.json";
        private static string SpreadsheetId = "1FOcW7o8FLkPQumPZJzzefux3HyAfvcWKXv6AF_3frgc";
        private static string SheetName = "VisitorSheet";

        public static async Task SyncGoogleSheetData()
        {
            try
            {
                var credential = GoogleCredential.FromFile(CredentialsPath)
                    .CreateScoped(new[] { SheetsService.Scope.SpreadsheetsReadonly });

                using (var service = new SheetsService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Visitor_Identification_Management_System"
                }))
                {
                    var range = $"{SheetName}!B:H";
                    var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);
                    var response = await request.ExecuteAsync();

                    if (response.Values != null && response.Values.Count > 0)
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\Visitor_Identification_Management_System\VIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                        {
                            con.Open();
                            foreach (var row in response.Values.Skip(1))
                            {
                                if (row.Count >= 7)
                                {
                                    string visitorID = Registration.GenerateVisitorID();
                                    string firstName = row[0].ToString();
                                    string lastName = row[1].ToString();
                                    string email = row[2].ToString();
                                    string contactNumber = row[3].ToString();
                                    string address = row[4].ToString();
                                    string purpose = row[5].ToString();
                                    string profilePicture = row[6].ToString();

                                    string imageUrl = ConvertGoogleDriveLink(profilePicture);
                                    byte[] imageBytes = null;

                                    // Prevent duplicate entries
                                    string checkQuery = "SELECT COUNT(*) FROM Registration WHERE Email = @Email";
                                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                                    {
                                        checkCmd.Parameters.AddWithValue("@Email", email);
                                        int count = (int)checkCmd.ExecuteScalar();
                                        if (count > 0) continue;
                                    }
                                    
                                    // Insert new record
                                    string query = "INSERT INTO Registration (VisitorID, FirstName, LastName, Email, Address, ContactNumber, Purpose, ProfilePicture) VALUES (@VisitorID, @FirstName, @LastName, @Email, @Address, @ContactNumber, @Purpose, @ProfilePicture)";
                                    using (SqlCommand cmd = new SqlCommand(query, con))
                                    {
                                        cmd.Parameters.AddWithValue("@VisitorID", visitorID);
                                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                                        cmd.Parameters.AddWithValue("@LastName", lastName);
                                        cmd.Parameters.AddWithValue("@Email", email);
                                        cmd.Parameters.AddWithValue("@Address", address);
                                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                                        cmd.Parameters.AddWithValue("@Purpose", purpose);

                                        if (!string.IsNullOrEmpty(profilePicture))
                                        {
                                            try
                                            {
                                                using (var httpClient = new HttpClient())
                                                {
                                                    imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                                                    //byte[] imageBytes = await httpClient.GetByteArrayAsync(profilePicture);
                                                    //cmd.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = imageBytes;
                                                    cmd.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = imageBytes ?? (object)DBNull.Value;
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show($"Failed to download image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                cmd.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = DBNull.Value;
                                            }
                                        }
                                        else
                                        {
                                            cmd.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = DBNull.Value;
                                        }

                                        cmd.ExecuteNonQuery();
                                    }

                                    // Generate and send QR code
                                    string visitorData = $"{visitorID}|{firstName}|{lastName}|{address}|{contactNumber}|{purpose}";
                                    string filePath = Path.Combine(Application.StartupPath, $"Visitor_{visitorID}.png");
                                    QRCodeHelper.GenerateQRCode(visitorData, visitorID);

                                    if (QRCodeHelper.SendEmailWithQRCode(email, filePath))
                                    {
                                        MessageBox.Show($"QR Code sent to {email}");
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Failed to send QR Code to {email}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error syncing Google Sheets data: " + ex.Message, "Sync Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static string ConvertGoogleDriveLink(string driveLink)
        {
            if (string.IsNullOrWhiteSpace(driveLink)) return null;

            string pattern = @"(?:id=|\/d\/)([a-zA-Z0-9_-]+)";
            Match match = Regex.Match(driveLink, pattern);

            if (match.Success)
            {
                string fileId = match.Groups[1].Value;
                return $"https://drive.google.com/uc?export=download&id={fileId}";
            }

            return null;
        }
    }
}
