using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EcoChallenge.Admin
{
    public partial class AdminReports_Analytics : Form
    {
        // Database connection string
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        // Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private AdminDashboardForm adminDashboardForm;

        public AdminReports_Analytics(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            // Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.adminDashboardForm = adminDashboardForm;

            LoadBarangayCategories();
            LoadTimeFilters();
            LoadPopularBarangays();
            LoadPopularChallenges();
        }

        // Load Barangay categories into the ComboBox
        private void LoadBarangayCategories()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT Barangay FROM UserTable ORDER BY Barangay";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        OleDbDataReader reader = cmd.ExecuteReader();
                        ARABrgyCategorybx.Items.Clear();
                        ARABrgyCategorybx.Items.Add("All Barangays");

                        while (reader.Read())
                        {
                            ARABrgyCategorybx.Items.Add(reader["Barangay"].ToString());
                        }
                    }
                    ARABrgyCategorybx.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading barangay categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Load Time Filters into the ComboBox
        private void LoadTimeFilters()
        {
            ARADateTimebx.Items.Add("All Time");
            ARADateTimebx.Items.Add("Weekly");
            ARADateTimebx.Items.Add("Monthly");
            ARADateTimebx.Items.Add("Yearly");
            ARADateTimebx.SelectedIndex = 0;
        }

        // Load Popular Barangays (Bar Chart)
        private void LoadPopularBarangays()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT UserTable.Barangay, COUNT(UserChallengesTable.UserID) AS ParticipationCount
                        FROM UserTable
                        INNER JOIN UserChallengesTable ON UserTable.UserID = UserChallengesTable.UserID
                        GROUP BY UserTable.Barangay
                        ORDER BY ParticipationCount DESC";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        ARABrgyChart.Series.Clear();
                        Series series = new Series("Popular Barangays")
                        {
                            ChartType = SeriesChartType.Bar
                        };

                        foreach (DataRow row in dt.Rows)
                        {
                            series.Points.AddXY(row["Barangay"].ToString(), Convert.ToInt32(row["ParticipationCount"]));
                        }

                        ARABrgyChart.Series.Add(series);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading popular barangays: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Load Popular Challenges (Pie Chart)
        private void LoadPopularChallenges()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT ChallengesTable.Title, COUNT(UserChallengesTable.ChallengeID) AS ParticipationCount
                        FROM ChallengesTable
                        INNER JOIN UserChallengesTable ON ChallengesTable.ChallengeID = UserChallengesTable.ChallengeID
                        GROUP BY ChallengesTable.Title
                        ORDER BY ParticipationCount DESC";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        ARAChallengesChart.Series.Clear();
                        Series series = new Series("Popular Challenges")
                        {
                            ChartType = SeriesChartType.Pie
                        };

                        foreach (DataRow row in dt.Rows)
                        {
                            series.Points.AddXY(row["Title"].ToString(), Convert.ToInt32(row["ParticipationCount"]));
                        }

                        ARAChallengesChart.Series.Add(series);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading popular challenges: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event when Barangay Filter is Changed
        private void ARABarangaycmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPopularBarangays();
        }

        // Event when Time Filter is Changed
        private void ARATimeFiltercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPopularChallenges();
        }
    }
}
