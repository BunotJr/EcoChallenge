using SiticoneNetCoreUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace EcoChallenge
{
    public partial class SigninForm : Form
    {

        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        //Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
        public SigninForm()
        {
            InitializeComponent();

            // Rounded corners
            ApplyRoundedCornersToButtons();
            //Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //Key pressed
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SFSigninbtn.PerformClick();
                }
            };
        }

        private void SFClosebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SFSigninbtn_Click(object sender, EventArgs e)
        {
            string username = SFUsernametbx.Text.Trim();
            string password = SFPasswordtbx.Text;
            string passwordHash = HashPassword(password);

            // Hardcoded Admin Credentials
            string adminUsername = "admin";
            string adminPasswordHash = HashPassword("Admin@123"); // Ensure password is hashed

            if (username == adminUsername && passwordHash == adminPasswordHash)
            {
                MessageBox.Show("Admin login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminDashboardForm adminDashboard = new AdminDashboardForm();
                adminDashboard.Show();
                this.Hide();
                return;
            }

            // Check for normal user in database (Username only)
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UserID FROM UserTable WHERE Username = ? AND Password = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", passwordHash);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            MessageBox.Show("User login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UserDashboardForm userDashboardForm = new UserDashboardForm();
                            userDashboardForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
            this.Hide();
        }

        private void SFShowPasswordbtn_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(true);
        }

        private void SFHidePasswordbtn_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(false);
        }
        private void TogglePasswordVisibility(bool show)
        {
            SFPasswordtbx.UseSystemPasswordChar = !show;
            SFPasswordtbx.PasswordChar = show ? '\0' : '●';

            if (show)
                SFHidePasswordbtn.BringToFront();
            else
                SFShowPasswordbtn.BringToFront();
        }
        private void ApplyRoundedCornersToButtons()
        {
            int radius = 15; // adjust for roundness

            SFShowPasswordbtn.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, SFShowPasswordbtn.Width, SFShowPasswordbtn.Height, radius, radius));

            SFHidePasswordbtn.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, SFHidePasswordbtn.Width, SFHidePasswordbtn.Height, radius, radius));
        }
    }
}