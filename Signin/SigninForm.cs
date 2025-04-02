using SiticoneNetCoreUI;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EcoChallenge
{
    public partial class SigninForm : Form
    {
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        public SigninForm()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            ConfigureFormBehavior();
        }

        private void ApplyRoundedCorners()
        {
            // Form border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Button radius
            int radius = 15;
            SFShowPasswordbtn.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, SFShowPasswordbtn.Width, SFShowPasswordbtn.Height, radius, radius));
            SFHidePasswordbtn.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, SFHidePasswordbtn.Width, SFHidePasswordbtn.Height, radius, radius));
        }

        private void ConfigureFormBehavior()
        {
            // Enter key to trigger login
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SFSigninbtn.PerformClick();
                }
            };
        }

        private void SFClosebtn_Click(object sender, EventArgs e) => Application.Exit();

        private async void SFSigninbtn_Click(object sender, EventArgs e)
        {
            string username = SFUsernametbx.Text.Trim();
            string password = SFPasswordtbx.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show loading state
            SFSigninbtn.Enabled = false;
            SFSigninbtn.Text = "Signing in...";

            try
            {
                string passwordHash = HashPassword(password);

                // Check admin credentials first
                if (await ValidateAdminCredentials(username, passwordHash))
                {
                    this.Hide();
                    new AdminDashboardForm().Show();
                    return;
                }

                // Check regular user credentials
                int? userId = await ValidateUserCredentials(username, passwordHash);
                if (userId.HasValue)
                {
                    // Store UserID in SessionManager
                    SessionManager.UserID = userId.Value;
                    SessionManager.Username = username;

                    this.Hide();
                    new UserDashboardForm(userId.Value).Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SFPasswordtbx.Clear();
                    SFPasswordtbx.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset button state
                SFSigninbtn.Enabled = true;
                SFSigninbtn.Text = "Sign In";
            }
        }

        private async Task<bool> ValidateAdminCredentials(string username, string passwordHash)
        {
            // In a real application, these should be stored securely (not hardcoded)
            string adminUsername = "admin";
            string adminPasswordHash = HashPassword("Admin@123"); // Pre-hashed in production

            return await Task.Run(() =>
                username.Equals(adminUsername, StringComparison.OrdinalIgnoreCase) &&
                passwordHash.Equals(adminPasswordHash, StringComparison.Ordinal));
        }

        private async Task<int?> ValidateUserCredentials(string username, string passwordHash)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                await conn.OpenAsync();
                string query = "SELECT UserID FROM UserTable WHERE Username = ? AND Password = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", username);
                    cmd.Parameters.AddWithValue("?", passwordHash);

                    object result = await cmd.ExecuteScalarAsync();
                    return result != null ? (int?)Convert.ToInt32(result) : null;
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void SFToCaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new CreateAccountForm().Show();
        }

        private void SFShowPasswordbtn_Click(object sender, EventArgs e) =>
            TogglePasswordVisibility(true);

        private void SFHidePasswordbtn_Click(object sender, EventArgs e) =>
            TogglePasswordVisibility(false);

        private void TogglePasswordVisibility(bool show)
        {
            SFPasswordtbx.UseSystemPasswordChar = !show;
            SFPasswordtbx.PasswordChar = show ? '\0' : '●';
            (show ? SFHidePasswordbtn : SFShowPasswordbtn).BringToFront();
        }
    }
}