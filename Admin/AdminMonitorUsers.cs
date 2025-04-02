using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EcoChallenge.Admin
{
    public partial class AdminMonitorUsers : Form
    {
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        AdminDashboardForm adminDashboardForm;
        private int selectedUserID;

        public AdminMonitorUsers(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            // Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.adminDashboardForm = adminDashboardForm;
        }

        // Load the user's current and completed challenges, along with the leaderboard
        private void LoadUserDetails(int userID)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Load Current Challenges (Joined)
                    string queryCurrentChallenges = @"
                        SELECT ChallengesTable.Title
                        FROM ChallengesTable
                        INNER JOIN UserChallengesTable ON ChallengesTable.ChallengeID = UserChallengesTable.ChallengeID
                        WHERE UserChallengesTable.UserID = ? AND UserChallengesTable.Status = 'Active'";

                    using (OleDbCommand cmd = new OleDbCommand(queryCurrentChallenges, conn))
                    {
                        cmd.Parameters.AddWithValue("?", userID);
                        OleDbDataReader reader = cmd.ExecuteReader();

                        AMUChallengeUpdatesListbx.Items.Clear();
                        while (reader.Read())
                        {
                            AMUChallengeUpdatesListbx.Items.Add(reader["Title"].ToString());
                        }
                    }

                    // Load Completed Challenges
                    string queryCompletedChallenges = @"
                        SELECT ChallengesTable.Title
                        FROM ChallengesTable
                        INNER JOIN UserChallengesTable ON ChallengesTable.ChallengeID = UserChallengesTable.ChallengeID
                        WHERE UserChallengesTable.UserID = ? AND UserChallengesTable.Status = 'Completed'";

                    using (OleDbCommand cmd = new OleDbCommand(queryCompletedChallenges, conn))
                    {
                        cmd.Parameters.AddWithValue("?", userID);
                        OleDbDataReader reader = cmd.ExecuteReader();

                        AMUCompletedChallengesListbx.Items.Clear();
                        while (reader.Read())
                        {
                            AMUCompletedChallengesListbx.Items.Add(reader["Title"].ToString());
                        }
                    }

                    // Load Leaderboard (Top 5 users)
                    string queryLeaderboard = @"
                        SELECT UserTable.Username, UserTable.Points
                        FROM UserTable
                        ORDER BY UserTable.Points DESC, UserTable.UserID"; // Sorting by Points and UserID

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(queryLeaderboard, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Clear previous leaderboard labels
                        AMUFirstPlacelbl.Text = "";
                        AMUSecondPlacelbl.Text = "";
                        AMUThirdPlacelbl.Text = "";
                        AMUFourthPlacelbl.Text = "";
                        AMUFifthPlacelbl.Text = "";

                        // Set the leaderboard labels
                        if (dt.Rows.Count > 0) AMUFirstPlacelbl.Text = $"{dt.Rows[0]["Username"]} - {dt.Rows[0]["Points"]} points";
                        if (dt.Rows.Count > 1) AMUSecondPlacelbl.Text = $"{dt.Rows[1]["Username"]} - {dt.Rows[1]["Points"]} points";
                        if (dt.Rows.Count > 2) AMUThirdPlacelbl.Text = $"{dt.Rows[2]["Username"]} - {dt.Rows[2]["Points"]} points";
                        if (dt.Rows.Count > 3) AMUFourthPlacelbl.Text = $"{dt.Rows[3]["Username"]} - {dt.Rows[3]["Points"]} points";
                        if (dt.Rows.Count > 4) AMUFifthPlacelbl.Text = $"{dt.Rows[4]["Username"]} - {dt.Rows[4]["Points"]} points";

                        // Add empty labels if there are fewer than 5 users
                        for (int i = dt.Rows.Count; i < 5; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    AMUFirstPlacelbl.Text = "N/A";
                                    break;
                                case 1:
                                    AMUSecondPlacelbl.Text = "N/A";
                                    break;
                                case 2:
                                    AMUThirdPlacelbl.Text = "N/A";
                                    break;
                                case 3:
                                    AMUFourthPlacelbl.Text = "N/A";
                                    break;
                                case 4:
                                    AMUFifthPlacelbl.Text = "N/A";
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Refresh button to reload the user details and leaderboard
        private void AMURefreshbtn_Click(object sender, EventArgs e)
        {
            // Assuming the selectedUserID is already set when a user is clicked in a DataGridView or similar control
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
