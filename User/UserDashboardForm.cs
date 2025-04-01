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
using EcoChallenge.User;

namespace EcoChallenge
{
    public partial class UserDashboardForm : Form
    {
        //Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        //Sidebar
        bool SidebarExpand = false;
        int SidebarMaxHeight = 375;
        int SidebarMinHeight = 60;

        public UserDashboardForm()
        {
            InitializeComponent();
            //Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Load AdminHome on startup
            loadform(new UserHome(this));

            // Ensure the panel starts collapsed
            UDFSidePanel.Height = SidebarMinHeight;

            // Make sure the Timer is disabled initially
            UDFSideBarTimer.Enabled = false;
        }

        private void UDFSidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                UDFSidePanel.Height -= 10; // Collapse
                if (UDFSidePanel.Height <= SidebarMinHeight)
                {
                    UDFSidePanel.Height = SidebarMinHeight; // Ensure exact height
                    SidebarExpand = false;
                    UDFSideBarTimer.Stop();
                }
            }
            else
            {
                UDFSidePanel.Height += 10; // Expand
                if (UDFSidePanel.Height >= SidebarMaxHeight)
                {
                    UDFSidePanel.Height = SidebarMaxHeight; // Ensure exact height
                    SidebarExpand = true;
                    UDFSideBarTimer.Stop();
                }
            }
        }
        public void loadform(object Form)
        {
            if (this.UDFMainPanel.Controls.Count > 0)
                this.UDFMainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.UDFMainPanel.Controls.Add(f);
            this.UDFMainPanel.Tag = f;
            f.Show();
        }

        private void UDFMainMenubtn_Click(object sender, EventArgs e)
        {
            if (!UDFSideBarTimer.Enabled) // Only start if not already running
            {
                UDFSideBarTimer.Start();
            }
        }

        private void UDFClosebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UDFHomebtn_Click(object sender, EventArgs e)
        {
            loadform(new UserHome(this));
        }

        private void UDFExploreChallengesbtn_Click(object sender, EventArgs e)
        {
            loadform(new UserExploreChallenges(this));
        }

        private void UDFTrackProgressbtn_Click(object sender, EventArgs e)
        {
            loadform(new UserTrackProgress(this));
        }

        private void UDFRewardsBadgesbtn_Click(object sender, EventArgs e)
        {
            loadform(new UserRewardsAndBadges(this));
        }

        private void UDFInformationbtn_Click(object sender, EventArgs e)
        {

        }

        private void UDFSignoutbtn_Click(object sender, EventArgs e)
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
