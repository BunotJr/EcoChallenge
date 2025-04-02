using SiticoneNetCoreUI;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EcoChallenge.User
{
    public partial class UserExploreChallenges : Form
    {
        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";
        private UserDashboardForm userDashboardForm;
        private int currentUserId;
        private int selectedChallengeId = -1;

        public UserExploreChallenges(UserDashboardForm userDashboardForm, int userId)
        {
            InitializeComponent();
            // Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.userDashboardForm = userDashboardForm;
            this.currentUserId = userId;

            // Configure DataGridViews
            UECCommunityChallengesdgv.AllowUserToAddRows = false;
            UECPersonalChallengesdgv.AllowUserToAddRows = false;

            // Set up event handlers
            UECCommunityChallengesdgv.CellClick += CommunityChallengesDgv_CellClick;
            UECPersonalChallengesdgv.CellClick += PersonalChallengesDgv_CellClick;
            UECJoinbtn.Click += UECJoinbtn_Click;
            UECRefreshbtn.Click += UECRefreshbtn_Click;

            LoadChallenges();
        }

        private void LoadChallenges()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Load Community Challenges (with points)
                    string communityQuery = @"SELECT ChallengeID, Title, PointsReward, Description, Category 
                                              FROM ChallengesTable 
                                              WHERE Category = 'Community'";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(communityQuery, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        UECCommunityChallengesdgv.DataSource = dt;
                        UECCommunityChallengesdgv.Columns["ChallengeID"].Visible = false;
                        UECCommunityChallengesdgv.Columns["Category"].Visible = false;
                    }

                    // Load Personal Challenges (no points display)
                    string personalQuery = @"SELECT ChallengeID, Title, Description, Category 
                                             FROM ChallengesTable 
                                             WHERE Category = 'Personal'";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(personalQuery, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        UECPersonalChallengesdgv.DataSource = dt;
                        UECPersonalChallengesdgv.Columns["ChallengeID"].Visible = false;
                        UECPersonalChallengesdgv.Columns["Category"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading challenges: " + ex.Message,
                                    "Database Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void CommunityChallengesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                selectedChallengeId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["ChallengeID"].Value);

                UECTitletbx.Text = dgv.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                UECPointstbx.Text = dgv.Rows[e.RowIndex].Cells["PointsReward"].Value.ToString();
                UECDescriptiontbx.Text = dgv.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            }
        }

        private void PersonalChallengesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                selectedChallengeId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["ChallengeID"].Value);

                UECTitletbx.Text = dgv.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                UECPointstbx.Text = "0"; // Personal challenges don't have points
                UECDescriptiontbx.Text = dgv.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            }
        }

        private void UECJoinbtn_Click(object sender, EventArgs e)
        {
            if (selectedChallengeId == -1)
            {
                MessageBox.Show("Please select a challenge first.",
                               "No Selection",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // Check if already joined
                    string checkQuery = @"SELECT COUNT(*) FROM UserChallengesTable 
                                WHERE UserID = ? AND ChallengeID = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@userId", currentUserId);
                        checkCmd.Parameters.AddWithValue("@challengeId", selectedChallengeId);

                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("You've already joined this challenge!",
                                          "Already Joined",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Join the challenge with explicit timestamp
                    string joinQuery = @"INSERT INTO UserChallengesTable 
                               (UserID, ChallengeID, Status, JoinedAt, LastUpdated) 
                               VALUES (?, ?, 'Active', ?, ?)";
                    using (OleDbCommand joinCmd = new OleDbCommand(joinQuery, conn))
                    {
                        joinCmd.Parameters.AddWithValue("@userId", currentUserId);
                        joinCmd.Parameters.AddWithValue("@challengeId", selectedChallengeId);
                        joinCmd.Parameters.AddWithValue("@joinedAt", DateTime.Now);
                        joinCmd.Parameters.AddWithValue("@lastUpdated", DateTime.Now);

                        if (joinCmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Challenge joined successfully!",
                                          "Success",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                            LoadChallenges();
                            ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error joining challenge: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void UECRefreshbtn_Click(object sender, EventArgs e)
        {
            LoadChallenges();
            ClearSelection();
        }

        private void ClearSelection()
        {
            selectedChallengeId = -1;
            UECTitletbx.Clear();
            UECPointstbx.Clear();
            UECDescriptiontbx.Clear();
        }
    }
}
