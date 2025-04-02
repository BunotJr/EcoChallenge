using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace EcoChallenge
{
    public partial class AdminManageUsers : Form
    {
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private AdminDashboardForm adminDashboardForm;
        private int selectedUserID = -1;

        public AdminManageUsers(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.adminDashboardForm = adminDashboardForm;
            LoadUsers();
        }

        // Load Users
        private void LoadUsers()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT UserID, Username, Points, Status 
                        FROM UserTable";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        AMUUsersdgv.DataSource = dt;
                        AMUUsersdgv.Columns["UserID"].Visible = false; // Hide ID column
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Display selected user's information
        private void AMUUsersdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserID = Convert.ToInt32(AMUUsersdgv.Rows[e.RowIndex].Cells["UserID"].Value);
                AMUUsernametbx.Text = AMUUsersdgv.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                AMUPointstbx.Text = AMUUsersdgv.Rows[e.RowIndex].Cells["Points"].Value.ToString();
                // Load active challenges
                LoadUserChallenges(selectedUserID);
            }
        }

        // Load challenges for the selected user
        private void LoadUserChallenges(int userID)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT C.Title 
                        FROM ChallengesTable C
                        JOIN UserChallengesTable UC ON C.ChallengeID = UC.ChallengeID
                        WHERE UC.UserID = ? AND UC.Status = 'Completed'"; // Example: Completed challenges

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", userID);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Populate the challenges in the TextBox
                        StringBuilder challengeList = new StringBuilder();
                        foreach (DataRow row in dt.Rows)
                        {
                            challengeList.AppendLine(row["Title"].ToString());
                        }

                        AMUActiveChallengestbx.Text = challengeList.ToString(); // Display challenges in the TextBox
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user challenges: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Ban user
        private void AMUBanbtn_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1)
            {
                MessageBox.Show("Select a user to ban.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateUserStatus("Banned");
        }

        // Unban user
        private void AMUUnbanbtn_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1)
            {
                MessageBox.Show("Select a user to unban.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateUserStatus("Active");
        }

        // Update user status (Ban/Unban)
        private void UpdateUserStatus(string status)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE UserTable SET Status = ? WHERE UserID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", status);
                        cmd.Parameters.AddWithValue("?", selectedUserID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"User {status.ToLower()} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    selectedUserID = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Refresh user list
        private void AMURefreshbtn_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
