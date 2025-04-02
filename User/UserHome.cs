using SiticoneNetCoreUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoChallenge
{
    public partial class UserHome : Form
    {
        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";
        private int currentUserId;
        UserDashboardForm dashboard;
        private bool isProfilePanelOpen = false;

        public UserHome(UserDashboardForm dashboardForm, int userId)
        {
            InitializeComponent();
            currentUserId = userId;

            // Form border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            dashboard = dashboardForm;
            CustomPanel();
            this.MouseDown += UserHome_MouseDown;

            // Initialize progress bars to 0 first
            UHCommunityProgressBar.Value = 0;
            UHCommunityProgressBar.Text = "0%";
            UHPersonalProgressBar.Value = 0;
            UHPersonalProgressBar.Text = "0%";

            // Then load data
            LoadProfilePicture();
            LoadUserProgress();
            LoadLeaderboard();

            VerifyTablesExist(); // Temporary - remove after verification
        }

        // Initialize panels
        private void CustomPanel()
        {
            UHUserProfilePanel.Visible = false;
        }

        // Toggle panel visibility
        private void TogglePanel(Panel targetPanel)
        {
            if (!UHUserProfilePanel.Visible)
            {
                UHUserProfilePanel.Visible = true;
            }
        }

        private void UserHome_MouseDown(object sender, MouseEventArgs e)
        {
            // Convert mouse position to screen coordinates
            Point screenPoint = this.PointToScreen(e.Location);

            // Convert panel and pic to screen coordinates
            Rectangle panelBounds = UHUserProfilePanel.RectangleToScreen(UHUserProfilePanel.ClientRectangle);
            Rectangle picBounds = UHUserProfilePic1pbx.RectangleToScreen(UHUserProfilePic1pbx.ClientRectangle);

            if (UHUserProfilePanel.Visible &&
                !panelBounds.Contains(screenPoint) &&
                !picBounds.Contains(screenPoint))
            {
                UHUserProfilePanel.Visible = false;
            }
        }

        private void LoadUserProgress()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // Community Progress - Using separate queries instead of subqueries
                    int completed = 0;
                    int total = 0;

                    // Get completed challenges count
                    string completedQuery = "SELECT COUNT(*) FROM CompletedChallengesTable WHERE UserID = @userId";
                    using (OleDbCommand cmd = new OleDbCommand(completedQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        completed = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Get total challenges count
                    string totalQuery = "SELECT COUNT(*) FROM ChallengesTable";
                    using (OleDbCommand cmd = new OleDbCommand(totalQuery, conn))
                    {
                        total = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Calculate community progress
                    int communityProgress = total > 0 ? (completed * 100) / total : 0;
                    UHCommunityProgressBar.Value = communityProgress;
                    UHCommunityProgressBar.Text = $"{communityProgress}%";

                    // Personal Progress - Using separate queries
                    int personalCompleted = 0;
                    int personalTotal = 0;

                    // Get completed personal challenges
                    string personalCompletedQuery = "SELECT COUNT(*) FROM UserChallengesTable WHERE UserID = @userId AND Status = 'Completed'";
                    using (OleDbCommand cmd = new OleDbCommand(personalCompletedQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        personalCompleted = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Get total personal challenges
                    string personalTotalQuery = "SELECT COUNT(*) FROM UserChallengesTable WHERE UserID = @userId";
                    using (OleDbCommand cmd = new OleDbCommand(personalTotalQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        personalTotal = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Calculate personal progress
                    int personalProgress = personalTotal > 0 ? (personalCompleted * 100) / personalTotal : 0;
                    UHPersonalProgressBar.Value = personalProgress;
                    UHPersonalProgressBar.Text = $"{personalProgress}%";
                }
            }
            catch (OleDbException oleEx)
            {
                // More detailed error diagnostics
                string errorDetails = GetDatabaseErrorDetails();
                string message = $"Progress loading failed.\n\nError: {oleEx.Message}\n\n{errorDetails}";

                MessageBox.Show(message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDatabaseErrorDetails()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    StringBuilder details = new StringBuilder();
                    details.AppendLine("Database Verification:");

                    // Check if tables exist
                    string[] tables = { "CompletedChallengesTable", "ChallengesTable", "UserChallengesTable" };
                    foreach (string table in tables)
                    {
                        try
                        {
                            var cmd = new OleDbCommand($"SELECT TOP 1 * FROM {table}", conn);
                            cmd.ExecuteScalar();
                            details.AppendLine($"✓ {table} exists");
                        }
                        catch
                        {
                            details.AppendLine($"✗ {table} MISSING");
                        }
                    }

                    // Check if current user exists in UserChallengesTable
                    try
                    {
                        var cmd = new OleDbCommand("SELECT TOP 1 * FROM UserChallengesTable WHERE UserID = @userId", conn);
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        bool hasRecords = cmd.ExecuteScalar() != null;
                        details.AppendLine(hasRecords ? "✓ User has challenges" : "✗ User has no challenges");
                    }
                    catch
                    {
                        details.AppendLine("? Couldn't check user challenges");
                    }

                    return details.ToString();
                }
            }
            catch
            {
                return "Could not verify database details.";
            }
        }

        private void LoadLeaderboard()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // Simplified query using only UserTable (since Points are stored there)
                    string query = @"SELECT TOP 5 UserID, Username, Points, Barangay 
                           FROM UserTable 
                           ORDER BY Points DESC, UserID ASC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        Label[] nameLabels = { UHFirstPlacelbl, UHSecondPlacelbl, UHThirdPlacelbl,
                                     UHFourthPlacelbl, UHFifthPlacelbl };
                        Label[] pointsLabels = { UHFirstPlacePoints, UHSecondPlacePoints, UHThirdPlacePoints,
                                       UHFourthPlacePoints, UHFifthPlacePoints };

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (reader.Read())
                                {
                                    nameLabels[i].Text = $"{reader["Username"]}";
                                    pointsLabels[i].Text = $"{reader["Points"]} pts";

                                    if (Convert.ToInt32(reader["UserID"]) == currentUserId)
                                    {
                                        nameLabels[i].Font = new Font(nameLabels[i].Font, FontStyle.Bold);
                                        nameLabels[i].ForeColor = Color.Green;
                                        pointsLabels[i].Font = new Font(pointsLabels[i].Font, FontStyle.Bold);
                                        pointsLabels[i].ForeColor = Color.Green;
                                    }
                                    // Highlight top 3
                                    if (i < 3)
                                    {
                                        nameLabels[i].ForeColor = Color.Goldenrod;
                                        pointsLabels[i].ForeColor = Color.Goldenrod;
                                    }
                                }
                                else
                                {
                                    nameLabels[i].Text = "N/A";
                                    pointsLabels[i].Text = "0 pts";
                                }
                            }
                        }
                    }
                }
            }
            catch (OleDbException oleEx)
            {
                MessageBox.Show($"Database error loading leaderboard: {oleEx.Message}\n\nCheck if UserTable exists and contains Points field.",
                               "Database Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error loading leaderboard: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private string GetCurrentUsername()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT Username FROM UserTable WHERE UserID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@p1", currentUserId);
                        return cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        private void UHUserProfilePic1pbx_Click(object sender, EventArgs e)
        {
            TogglePanel(UHUserProfilePanel);
        }

        private void UHSignoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to sign out?",
                "Confirm Sign Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hide the dashboard form that opened this one
                dashboard.Hide();

                // Hide the current form (UserHome)
                this.Hide();

                // Show the sign in form
                SigninForm signIn = new SigninForm();
                signIn.Show();
            }
        }

        private void UHUserEditImagebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Profile Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read the image file
                        byte[] imageData = File.ReadAllBytes(openFileDialog.FileName);

                        // Update the picture boxes
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image selectedImage = Image.FromStream(ms);

                            // Update profile pictures with rounded corners
                            UHUserProfilePic1pbx.Image = RoundCorners(selectedImage, 20);
                            UHUserProfilePic2pbx.Image = RoundCorners(selectedImage, 72); // Half of 144 for perfect circle

                            // Save to database
                            SaveProfilePicture(imageData);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load or save image: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Method to create rounded corners for images
        private Image RoundCorners(Image image, int cornerRadius)
        {
            cornerRadius *= 2; // Double for better quality

            Bitmap roundedImage = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                using (Brush brush = new TextureBrush(image))
                {
                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(0, 0, image.Width, image.Height);
                    g.FillPath(brush, path);
                }
            }

            return roundedImage;
        }

        // Save profile picture to database
        private void SaveProfilePicture(byte[] imageData)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE UserTable SET ProfilePicture = ? WHERE UserID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@p1", imageData);
                        cmd.Parameters.AddWithValue("@p2", currentUserId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile picture: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load profile picture from database
        private void LoadProfilePicture()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT ProfilePicture FROM UserTable WHERE UserID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@p1", currentUserId);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            byte[] imageData = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                Image profileImage = Image.FromStream(ms);

                                // Apply rounded corners
                                UHUserProfilePic1pbx.Image = RoundCorners(profileImage, 20);
                                UHUserProfilePic2pbx.Image = RoundCorners(profileImage, 72);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile picture: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Paint events for rounded corners
        private void UHUserProfilePic1pbx_Paint(object sender, PaintEventArgs e)
        {
            if (UHUserProfilePic1pbx.Image != null)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, UHUserProfilePic1pbx.Width, UHUserProfilePic1pbx.Height);
                UHUserProfilePic1pbx.Region = new Region(path);
            }
        }

        private void UHUserProfilePic2pbx_Paint(object sender, PaintEventArgs e)
        {
            if (UHUserProfilePic2pbx.Image != null)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, UHUserProfilePic2pbx.Width, UHUserProfilePic2pbx.Height);
                UHUserProfilePic2pbx.Region = new Region(path);
            }
        }

        private void VerifyTablesExist()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    string[] tables = { "CompletedChallengesTable", "ChallengesTable", "UserChallengesTable" };

                    foreach (string table in tables)
                    {
                        try
                        {
                            var cmd = new OleDbCommand($"SELECT TOP 1 * FROM {table}", conn);
                            cmd.ExecuteScalar();
                            MessageBox.Show($"{table} exists and is accessible", "Verification",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show($"{table} DOES NOT EXIST or is not accessible", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Verification failed: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}