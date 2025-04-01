using System.Runtime.InteropServices;

namespace EcoChallenge
{
    public partial class LoadingScreenForm : Form
    {
        //Border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
        public LoadingScreenForm()
        {
            InitializeComponent();
            //Border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void LoadingScreenTimer_Tick(object sender, EventArgs e)
        {
            LoadingBar.Width += 10;
            if (LoadingBar.Width >= 450)
            {
                LoadingScreenTimer.Stop();

                //Call Sign in
                SigninForm signinForm = new SigninForm();
                signinForm.Show();
                this.Hide();
            }
        }
    }
}
