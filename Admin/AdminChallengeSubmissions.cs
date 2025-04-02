using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EcoChallenge.Admin
{
    public partial class AdminChallengeSubmissions : Form
    {
        // Database connection string
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private AdminDashboardForm adminDashboardForm;
        private int selectedSubmissionID = -1;

        public AdminChallengeSubmissions(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            // Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.adminDashboardForm = adminDashboardForm;
            LoadSubmissions();
        }

        // Load challenge submissions into the DataGridView
        private void LoadSubmissions()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT SubmissionID, UserTable.Username, ChallengeTable.Title, SubmissionTable.Status, SubmissionTable.SubmissionData
                        FROM SubmissionTable
                        INNER JOIN UserTable ON SubmissionTable.UserID = UserTable.UserID
                        INNER JOIN ChallengeTable ON SubmissionTable.ChallengeID = ChallengeTable.ChallengeID";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        ARCSSubmissionsdgv.DataSource = dt;
                        ARCSSubmissionsdgv.Columns["SubmissionID"].Visible = false; // Hide the SubmissionID column
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading submissions: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // When a row in the DataGridView is clicked
        private void AMUSubmissionsdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedSubmissionID = Convert.ToInt32(ARCSSubmissionsdgv.Rows[e.RowIndex].Cells["SubmissionID"].Value);
                string userName = ARCSSubmissionsdgv.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                string challengeTitle = ARCSSubmissionsdgv.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                string status = ARCSSubmissionsdgv.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                string submissionData = ARCSSubmissionsdgv.Rows[e.RowIndex].Cells["SubmissionData"].Value.ToString();

                // Display the proof image
                if (!string.IsNullOrEmpty(submissionData))
                {
                    ARCSProofImagebx.Image = Image.FromFile(submissionData);  // Assuming submissionData contains the file path
                }
            }
        }

        // Approve the submission
        private void AMUApprovebtn_Click(object sender, EventArgs e)
        {
            if (selectedSubmissionID == -1)
            {
                MessageBox.Show("Select a submission to approve.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Update submission status to "Approved"
                    string queryUpdateStatus = "UPDATE SubmissionTable SET Status = 'Approved' WHERE SubmissionID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(queryUpdateStatus, conn))
                    {
                        cmd.Parameters.AddWithValue("?", selectedSubmissionID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Submission approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubmissions();
                    selectedSubmissionID = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error approving submission: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Reject the submission
        private void AMURejectbtn_Click(object sender, EventArgs e)
        {
            if (selectedSubmissionID == -1)
            {
                MessageBox.Show("Select a submission to reject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Update submission status to "Rejected"
                    string queryUpdateStatus = "UPDATE SubmissionTable SET Status = 'Rejected' WHERE SubmissionID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(queryUpdateStatus, conn))
                    {
                        cmd.Parameters.AddWithValue("?", selectedSubmissionID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Submission rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubmissions();
                    selectedSubmissionID = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error rejecting submission: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
