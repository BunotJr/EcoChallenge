using SiticoneNetCoreUI;
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

namespace EcoChallenge
{
    public partial class UserHome : Form
    {
        //Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        UserDashboardForm dashboard;
        private bool isProfilePanelOpen = false;
        public UserHome(UserDashboardForm dashboardForm)
        {
            InitializeComponent();
            //Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            dashboard = dashboardForm;
            CustomPanel();
            this.MouseDown += UserHome_MouseDown;
        }
        // Initialize panels
        private void CustomPanel()
        {
            UHUserProfilePanel.Visible = false;
        }

        // Toggle panel visibility
        private void TogglePanel(Panel targetPanel)
        {
            if (!UHUserProfilePanel.Visible)
            {
                UHUserProfilePanel.Visible = true;
            }
        }

        private void UserHome_MouseDown(object sender, MouseEventArgs e)
        {
            // Convert mouse position to screen coordinates
            Point screenPoint = this.PointToScreen(e.Location);

            // Convert panel and pic to screen coordinates
            Rectangle panelBounds = UHUserProfilePanel.RectangleToScreen(UHUserProfilePanel.ClientRectangle);
            Rectangle picBounds = UHUserProfilePic.RectangleToScreen(UHUserProfilePic.ClientRectangle);

            if (UHUserProfilePanel.Visible &&
                !panelBounds.Contains(screenPoint) &&
                !picBounds.Contains(screenPoint))
            {
                UHUserProfilePanel.Visible = false;
            }
        }

        private void UHUserProfilePic_Click(object sender, EventArgs e)
        {
            TogglePanel(UHUserProfilePanel);
        }

        private void UHSignoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to sign out?",
            "Confirm Sign Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hide the dashboard form that opened this one
                dashboard.Hide();

                // Hide the current form (UserHome)
                this.Hide();

                // Show the sign in form
                SigninForm signIn = new SigninForm();
                signIn.Show();
            }
        }

        private void UHUserEditImagebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Profile Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    try
                    {
                        Image selectedImage = Image.FromFile(selectedImagePath);

                        // Update SiticoneImageButton
                        UHUserProfilePic.ImageNormal = selectedImage;
                        UHUserProfilePic.Size = new Size(50, 50); // ensures it fits your 50x50 button

                        // Update SiticonePictureBox (or SiticoneCirclePictureBox)
                        UHUserProfilePic2.Image = selectedImage;
                        UHUserProfilePic2.SizeMode = (SiticonePictureBoxSizeMode)PictureBoxSizeMode.Zoom;

                        // Optional: Save image path or image for future use
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
