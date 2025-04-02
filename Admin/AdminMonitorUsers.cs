using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EcoChallenge.Admin
{
    public partial class AdminMonitorUsers : Form
    {
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
                                                        int nWidthEllipse, int nHeightEllipse);

        AdminDashboardForm adminDashboardForm;
        private int selectedUserID = -1;

        public AdminMonitorUsers(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            // Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.adminDashboardForm = adminDashboardForm;

            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT TOP 5 u.UserID, u.Username, u.Points, u.Barangay
                                     FROM UserTable u
                                     ORDER BY u.Points DESC, u.UserID ASC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        Label[] nameLabels = { AMUFirstPlacelbl, AMUSecondPlacelbl, AMUThirdPlacelbl, AMUFourthPlacelbl, AMUFifthPlacelbl };
                        Label[] pointsLabels = { AMUFirstPlacePoints, AMUSecondPlacePoints, AMUThirdPlacePoints, AMUFourthPlacePoints, AMUFifthPlacePoints };

                        for (int i = 0; i < 5; i++)
                        {
                            if (reader.Read())
                            {
                                nameLabels[i].Text = reader["Username"].ToString();
                                pointsLabels[i].Text = $"{reader["Points"]} pts";

                                if (i < 3) // Highlight top 3
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leaderboard: {ex.Message}", "Leaderboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserChallenges(int userId)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // Load Ongoing Challenges
                    string queryOngoing = @"SELECT c.Title 
                                            FROM ChallengesTable c
                                            INNER JOIN UserChallengesTable uc ON c.ChallengeID = uc.ChallengeID
                                            WHERE uc.UserID = ? AND uc.Status = 'Ongoing'";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(queryOngoing, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("?", userId);
                        DataTable dtOngoing = new DataTable();
                        adapter.Fill(dtOngoing);
                        AMUChallengeUpdatesdgv.DataSource = dtOngoing;
                    }

                    // Load Completed Challenges
                    string queryCompleted = @"SELECT c.Title 
                                              FROM ChallengesTable c
                                              INNER JOIN UserChallengesTable uc ON c.ChallengeID = uc.ChallengeID
                                              WHERE uc.UserID = ? AND uc.Status = 'Completed'";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(queryCompleted, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("?", userId);
                        DataTable dtCompleted = new DataTable();
                        adapter.Fill(dtCompleted);
                        AMUCompletedChallengesdgv.DataSource = dtCompleted;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user challenges: {ex.Message}", "Challenges Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserDetails(int userID)
        {
            selectedUserID = userID;
            LoadUserChallenges(userID);
        }

        // Refresh button to reload user details and leaderboard
        private void AMURefreshbtn_Click(object sender, EventArgs e)
        {
            if (selectedUserID != -1)
            {
                LoadUserDetails(selectedUserID);
            }
            else
            {
                MessageBox.Show("Please select a user to monitor.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
