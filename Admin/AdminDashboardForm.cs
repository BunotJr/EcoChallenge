using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoChallenge.Admin;

namespace EcoChallenge
{
    public partial class AdminDashboardForm : Form
    {
        //Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
        //Sidebar
        bool SidebarExpand = false;
        int SidebarMaxHeight = 425;
        int SidebarMinHeight = 60;

        public AdminDashboardForm()
        {
            InitializeComponent();

            //Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Load AdminHome on startup
            loadform(new AdminHome(this));

            // Ensure the panel starts collapsed
            ADFSidePanel.Height = SidebarMinHeight;

            // Make sure the Timer is disabled initially
            ADFSideBarTimer.Enabled = false;
        }

        private void ADFMainMenubtn_Click(object sender, EventArgs e)
        {
            if (!ADFSideBarTimer.Enabled) // Only start if not already running
            {
                ADFSideBarTimer.Start();
            }
        }

        private void ADFSideBarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                ADFSidePanel.Height -= 10; // Collapse
                if (ADFSidePanel.Height <= SidebarMinHeight)
                {
                    ADFSidePanel.Height = SidebarMinHeight; // Ensure exact height
                    SidebarExpand = false;
                    ADFSideBarTimer.Stop();
                }
            }
            else
            {
                ADFSidePanel.Height += 10; // Expand
                if (ADFSidePanel.Height >= SidebarMaxHeight)
                {
                    ADFSidePanel.Height = SidebarMaxHeight; // Ensure exact height
                    SidebarExpand = true;
                    ADFSideBarTimer.Stop();
                }
            }
        }

        private void ADFClosebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loadform(object Form)
        {
            if (this.ADFMainPanel.Controls.Count > 0)
                this.ADFMainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.ADFMainPanel.Controls.Add(f);
            this.ADFMainPanel.Tag = f;
            f.Show();
        }

        private void ADFHomebtn_Click_1(object sender, EventArgs e)
        {
            loadform(new AdminHome(this));
        }

        private void ADFManageChallengesbtn_Click_1(object sender, EventArgs e)
        {
            loadform(new AdminManageChallenges(this));
        }

        private void ADFManageUsersbtn_Click_1(object sender, EventArgs e)
        {
            loadform(new AdminManageUsers(this));
        }

        private void ADFMonitorUsersbtn_Click(object sender, EventArgs e)
        {
            loadform(new AdminMonitorUsers(this));
        }

        private void ADFReviewSubmissionbtn_Click_1(object sender, EventArgs e)
        {
            loadform(new AdminChallengeSubmissions(this));
        }

        private void ADFReportsAnalyticsbtn_Click_1(object sender, EventArgs e)
        {
            loadform(new AdminReports_Analytics(this));
        }

        private void ADFSignoutbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to sign out?",
            "Confirm Sign Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                // Show the sign in form
                SigninForm signIn = new SigninForm();
                signIn.Show();
            }
        }
    }
}