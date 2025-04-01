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
    public partial class CreateAccountForm : Form
    {
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase.accdb";

        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        public CreateAccountForm()
        {
            InitializeComponent();
            ApplyRoundedCornersToButtons();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void CAFClosebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CAFCreateAccountbtn_Click(object sender, EventArgs e)
        {
            string username = CAUsernametbx.Text.Trim();
            string email = CAFEmailtbx.Text.Trim();
            string password = CAFPasswordtbx.Text;
            string confirmPassword = CAFConfirmPasswordtbx.Text;
            string barangay = CAFBarangaytbx.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(barangay))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string passwordHash = HashPassword(password);

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Check if username or email already exists
                    string checkQuery = "SELECT COUNT(*) FROM UserTable WHERE Username = @Username OR Email = @Email";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username or Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new user (without UserID)
                    string query = "INSERT INTO UserTable ([Username], [Email], [Barangay], [Password]) " +
                                   "VALUES (@Username, @Email, @Barangay, @Password)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("@Username", OleDbType.VarChar)).Value = username;
                        cmd.Parameters.Add(new OleDbParameter("@Email", OleDbType.VarChar)).Value = email;
                        cmd.Parameters.Add(new OleDbParameter("@Barangay", OleDbType.VarChar)).Value = barangay;
                        cmd.Parameters.Add(new OleDbParameter("@Password", OleDbType.VarChar)).Value = passwordHash;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    SigninForm signinForm = new SigninForm();
                    signinForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CAFToSFLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SigninForm signform = new SigninForm();
            signform.Show();
            this.Hide();
        }

        private void CAFShowPasswordbtn_Click(object sender, EventArgs e)
        {
            TogglePasswordField(true);
        }

        private void CAFHidePasswordbtn_Click(object sender, EventArgs e)
        {
            TogglePasswordField(false);
        }

        private void CAFShowConfirmPasswordbtn_Click(object sender, EventArgs e)
        {
            ToggleConfirmPasswordField(true);
        }

        private void CAFHideConfirmPasswordbtn_Click(object sender, EventArgs e)
        {
            ToggleConfirmPasswordField(false);
        }

        private void TogglePasswordField(bool show)
        {
            CAFPasswordtbx.UseSystemPasswordChar = !show;
            CAFPasswordtbx.PasswordChar = show ? '\0' : '●';

            if (show)
                CAFHidePasswordbtn.BringToFront();
            else
                CAFShowPasswordbtn.BringToFront();
        }

        private void ToggleConfirmPasswordField(bool show)
        {
            CAFConfirmPasswordtbx.UseSystemPasswordChar = !show;
            CAFConfirmPasswordtbx.PasswordChar = show ? '\0' : '●';

            if (show)
                CAFHideConfirmPasswordbtn.BringToFront();
            else
                CAFShowConfirmPasswordbtn.BringToFront();
        }

        private void ApplyRoundedCornersToButtons()
        {
            int radius = 15; // adjust for roundness

            CAFShowPasswordbtn.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, CAFShowPasswordbtn.Width, CAFShowPasswordbtn.Height, radius, radius));

            CAFHidePasswordbtn.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, CAFHidePasswordbtn.Width, CAFHidePasswordbtn.Height, radius, radius));

            CAFShowConfirmPasswordbtn.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, CAFShowConfirmPasswordbtn.Width, CAFShowConfirmPasswordbtn.Height, radius, radius));

            CAFHideConfirmPasswordbtn.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, CAFHideConfirmPasswordbtn.Width, CAFHideConfirmPasswordbtn.Height, radius, radius));
        }
    }
}
