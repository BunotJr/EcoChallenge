using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EcoChallenge
{
    public partial class AdminManageChallenges : Form
    {
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EcoChallengeDatabase1.accdb";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private AdminDashboardForm adminDashboardForm;
        private int selectedChallengeID = -1; // Store selected ChallengeID internally

        public AdminManageChallenges(AdminDashboardForm adminDashboardForm)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.adminDashboardForm = adminDashboardForm;
            // Disable blank row
            AMCPersonalChallengesdgv.AllowUserToAddRows = false;
            AMCCommunityChallengesdgv.AllowUserToAddRows = false;
            LoadChallenges();

            // Attach event handlers
            AMCPersonalChallengesdgv.CellClick += personalChallengesDGV_CellClick;
            AMCCommunityChallengesdgv.CellClick += communityChallengesDGV_CellClick;
        }

        private void LoadChallenges()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    LoadChallengesByCategory(conn, "Personal", AMCPersonalChallengesdgv);
                    LoadChallengesByCategory(conn, "Community", AMCCommunityChallengesdgv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading challenges: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadChallengesByCategory(OleDbConnection conn, string category, DataGridView dgv)
        {
            string query = "SELECT ChallengeID, Title, PointsReward, Description, Category FROM ChallengesTable WHERE Category = ?";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", category);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv.DataSource = dt;
                dgv.Columns["ChallengeID"].Visible = false; // Hide ID column
            }
        }

        private void AMCLoadbtn_Click(object sender, EventArgs e)
        {
            LoadChallenges();
            ClearInputs();
        }

        private void AMCAddbtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO ChallengesTable (Title, PointsReward, Description, Category) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", AMCTitletbx.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Convert.ToInt32(AMCPointstbx.Text));
                        cmd.Parameters.AddWithValue("?", AMCDescriptiontbx.Text.Trim());
                        cmd.Parameters.AddWithValue("?", AMCCategorybx.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Challenge added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChallenges();
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding challenge: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AMCEditbtn_Click(object sender, EventArgs e)
        {
            if (selectedChallengeID == -1)
            {
                MessageBox.Show("Select a challenge to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE ChallengesTable SET Title = ?, PointsReward = ?, Description = ?, Category = ? WHERE ChallengeID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", AMCTitletbx.Text.Trim());
                        cmd.Parameters.AddWithValue("?", Convert.ToInt32(AMCPointstbx.Text));
                        cmd.Parameters.AddWithValue("?", AMCDescriptiontbx.Text.Trim());
                        cmd.Parameters.AddWithValue("?", AMCCategorybx.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?", selectedChallengeID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Challenge updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChallenges();
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating challenge: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AMCDeletebtn_Click(object sender, EventArgs e)
        {
            if (selectedChallengeID == -1)
            {
                MessageBox.Show("Select a challenge to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this challenge?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM ChallengesTable WHERE ChallengeID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", selectedChallengeID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Challenge deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChallenges();
                        ClearInputs();
                        selectedChallengeID = -1; // Reset selection
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting challenge: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void personalChallengesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                LoadSelectedChallenge(AMCPersonalChallengesdgv, e.RowIndex);
        }

        private void communityChallengesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                LoadSelectedChallenge(AMCCommunityChallengesdgv, e.RowIndex);
        }

        private void LoadSelectedChallenge(DataGridView dgv, int rowIndex)
        {
            selectedChallengeID = Convert.ToInt32(dgv.Rows[rowIndex].Cells["ChallengeID"].Value); // Store ID internally
            AMCTitletbx.Text = dgv.Rows[rowIndex].Cells["Title"].Value.ToString();
            AMCPointstbx.Text = dgv.Rows[rowIndex].Cells["PointsReward"].Value.ToString();
            AMCDescriptiontbx.Text = dgv.Rows[rowIndex].Cells["Description"].Value.ToString();
            AMCCategorybx.SelectedItem = dgv.Rows[rowIndex].Cells["Category"].Value.ToString();
        }

        private void ClearInputs()
        {
            AMCTitletbx.Clear();
            AMCPointstbx.Clear();
            AMCDescriptiontbx.Clear();
            AMCCategorybx.SelectedIndex = -1;
            selectedChallengeID = -1;
        }
    }
}
