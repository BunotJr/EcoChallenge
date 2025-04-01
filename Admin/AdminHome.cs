using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace EcoChallenge
{
    public partial class AdminHome : Form
    {
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private AdminDashboardForm adminDashboardForm;

        public AdminHome(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.adminDashboardForm = adminDashboardForm;

            LoadAdminDashboardData();
        }

        private void LoadAdminDashboardData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Total Users
                    AHTotalUserstbx.Text = GetCount(conn, "SELECT COUNT(UserID) FROM UserTable").ToString();

                    // Total Completed Challenges
                    AHTotalChallengestbx.Text = GetCount(conn, "SELECT COUNT(CompletionID) FROM CompletedChallengesTable").ToString();

                    // Pending Submissions
                    AHPendingSubmissionstbx.Text = GetCount(conn, "SELECT COUNT(SubmissionID) FROM SubmissionTable WHERE Status = 'Pending'").ToString();

                    // Load Challenge Updates
                    LoadChallengeUpdates(conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading admin data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetCount(OleDbConnection conn, string query)
        {
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        private void LoadChallengeUpdates(OleDbConnection conn)
        {
            AHChallengeUpdatesListbx.Items.Clear(); // Assuming a ListBox is named challengeUpdatesListBox

            string query = @"
                SELECT U.Username, 'joined', C.Title FROM UserChallengesTable UC
                INNER JOIN UserTable U ON UC.UserID = U.UserID
                INNER JOIN ChallengesTable C ON UC.ChallengeID = C.ChallengeID
                UNION
                SELECT U.Username, 'completed', C.Title FROM CompletedChallengesTable CC
                INNER JOIN UserTable U ON CC.UserID = U.UserID
                INNER JOIN ChallengesTable C ON CC.ChallengeID = C.ChallengeID
                UNION
                SELECT U.Username, 'submitted proof for', C.Title FROM SubmissionTable S
                INNER JOIN UserTable U ON S.UserID = U.UserID
                INNER JOIN ChallengesTable C ON S.ChallengeID = C.ChallengeID;";

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string updateText = $"{reader[0]} {reader[1]} '{reader[2]}'";
                    AHChallengeUpdatesListbx.Items.Add(updateText);
                }
            }
        }
    }
}
