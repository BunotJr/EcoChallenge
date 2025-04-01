namespace EcoChallenge
{
    partial class LoadingScreenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreenForm));
            Logopb = new SiticoneNetCoreUI.SiticonePictureBox();
            MainTitle = new Label();
            SubTitle = new Label();
            LoadingPanel = new SiticoneNetCoreUI.SiticonePanel();
            LoadingBar = new SiticoneNetCoreUI.SiticonePanel();
            LoadingScreenTimer = new System.Windows.Forms.Timer(components);
            LoadingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Logopb
            // 
            Logopb.BackColor = Color.Transparent;
            Logopb.BackgroundImage = Properties.Resources.Logo;
            Logopb.BackgroundImageLayout = ImageLayout.Zoom;
            Logopb.BorderColor = Color.Black;
            Logopb.BorderWidth = 0;
            Logopb.Brightness = 1F;
            Logopb.Contrast = 1F;
            Logopb.CornerRadius = 0;
            Logopb.DraggingSpeed = 3.15F;
            Logopb.EnableAsyncLoading = false;
            Logopb.EnableCaching = false;
            Logopb.EnableDragDrop = false;
            Logopb.EnableExtendedImageSources = false;
            Logopb.EnableFilters = false;
            Logopb.EnableFlipping = false;
            Logopb.EnableGlow = false;
            Logopb.EnableHighDpiSupport = false;
            Logopb.EnableMouseInteraction = false;
            Logopb.EnablePlaceholder = false;
            Logopb.EnableRotation = false;
            Logopb.EnableShadow = false;
            Logopb.EnableSlideshow = false;
            Logopb.FlipHorizontal = false;
            Logopb.FlipVertical = false;
            Logopb.Grayscale = false;
            Logopb.Image = null;
            Logopb.ImageOpacity = 1F;
            Logopb.Images = (List<Image>)resources.GetObject("Logopb.Images");
            Logopb.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            Logopb.IsCircular = false;
            Logopb.Location = new Point(150, 80);
            Logopb.MaintainAspectRatio = true;
            Logopb.Margin = new Padding(0);
            Logopb.Name = "Logopb";
            Logopb.PlaceholderImage = null;
            Logopb.RotationAngle = 0F;
            Logopb.Saturation = 1F;
            Logopb.ShowBorder = false;
            Logopb.Size = new Size(200, 200);
            Logopb.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.Zoom;
            Logopb.TabIndex = 0;
            // 
            // MainTitle
            // 
            MainTitle.AutoSize = true;
            MainTitle.BackColor = Color.Transparent;
            MainTitle.Font = new Font("Poppins Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainTitle.ForeColor = Color.Green;
            MainTitle.Location = new Point(74, 287);
            MainTitle.Margin = new Padding(0);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(357, 70);
            MainTitle.TabIndex = 1;
            MainTitle.Text = "ECO CHALLENGE";
            // 
            // SubTitle
            // 
            SubTitle.AutoSize = true;
            SubTitle.BackColor = Color.Transparent;
            SubTitle.Font = new Font("Poppins Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubTitle.ForeColor = Color.Green;
            SubTitle.Location = new Point(47, 351);
            SubTitle.Margin = new Padding(2, 0, 2, 0);
            SubTitle.Name = "SubTitle";
            SubTitle.Size = new Size(396, 42);
            SubTitle.TabIndex = 1;
            SubTitle.Text = "Gamifying Sustainable Living";
            // 
            // LoadingPanel
            // 
            LoadingPanel.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            LoadingPanel.BackColor = Color.Transparent;
            LoadingPanel.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            LoadingPanel.BorderDashPattern = null;
            LoadingPanel.BorderGradientEndColor = Color.FromArgb(0, 120, 140);
            LoadingPanel.BorderGradientStartColor = Color.FromArgb(0, 120, 140);
            LoadingPanel.BorderThickness = 2F;
            LoadingPanel.Controls.Add(LoadingBar);
            LoadingPanel.CornerRadiusBottomLeft = 10F;
            LoadingPanel.CornerRadiusBottomRight = 10F;
            LoadingPanel.CornerRadiusTopLeft = 10F;
            LoadingPanel.CornerRadiusTopRight = 10F;
            LoadingPanel.EnableAcrylicEffect = false;
            LoadingPanel.EnableMicaEffect = false;
            LoadingPanel.EnableRippleEffect = false;
            LoadingPanel.FillColor = Color.Transparent;
            LoadingPanel.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            LoadingPanel.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            LoadingPanel.Location = new Point(22, 731);
            LoadingPanel.Margin = new Padding(0);
            LoadingPanel.Name = "LoadingPanel";
            LoadingPanel.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            LoadingPanel.RippleAlpha = 50;
            LoadingPanel.RippleAlphaDecrement = 3;
            LoadingPanel.RippleColor = Color.FromArgb(50, 255, 255, 255);
            LoadingPanel.RippleMaxSize = 600F;
            LoadingPanel.RippleSpeed = 15F;
            LoadingPanel.ShowBorder = true;
            LoadingPanel.Size = new Size(450, 40);
            LoadingPanel.TabIndex = 2;
            LoadingPanel.TabStop = true;
            LoadingPanel.UseBorderGradient = true;
            LoadingPanel.UseMultiGradient = false;
            LoadingPanel.UsePatternTexture = false;
            LoadingPanel.UseRadialGradient = false;
            // 
            // LoadingBar
            // 
            LoadingBar.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            LoadingBar.BackColor = Color.Transparent;
            LoadingBar.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            LoadingBar.BorderDashPattern = null;
            LoadingBar.BorderGradientEndColor = Color.Purple;
            LoadingBar.BorderGradientStartColor = Color.Blue;
            LoadingBar.BorderThickness = 2F;
            LoadingBar.CornerRadiusBottomLeft = 10F;
            LoadingBar.CornerRadiusBottomRight = 10F;
            LoadingBar.CornerRadiusTopLeft = 10F;
            LoadingBar.CornerRadiusTopRight = 10F;
            LoadingBar.EnableAcrylicEffect = false;
            LoadingBar.EnableMicaEffect = false;
            LoadingBar.EnableRippleEffect = false;
            LoadingBar.FillColor = Color.FromArgb(0, 120, 140);
            LoadingBar.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            LoadingBar.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            LoadingBar.Location = new Point(0, 0);
            LoadingBar.Margin = new Padding(0);
            LoadingBar.Name = "LoadingBar";
            LoadingBar.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            LoadingBar.RippleAlpha = 50;
            LoadingBar.RippleAlphaDecrement = 3;
            LoadingBar.RippleColor = Color.FromArgb(50, 255, 255, 255);
            LoadingBar.RippleMaxSize = 600F;
            LoadingBar.RippleSpeed = 15F;
            LoadingBar.ShowBorder = false;
            LoadingBar.Size = new Size(10, 40);
            LoadingBar.TabIndex = 0;
            LoadingBar.TabStop = true;
            LoadingBar.UseBorderGradient = false;
            LoadingBar.UseMultiGradient = false;
            LoadingBar.UsePatternTexture = false;
            LoadingBar.UseRadialGradient = false;
            // 
            // LoadingScreenTimer
            // 
            LoadingScreenTimer.Enabled = true;
            LoadingScreenTimer.Interval = 1;
            LoadingScreenTimer.Tick += LoadingScreenTimer_Tick;
            // 
            // LoadingScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(500, 800);
            Controls.Add(SubTitle);
            Controls.Add(MainTitle);
            Controls.Add(Logopb);
            Controls.Add(LoadingPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoadingScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eco Challenge";
            LoadingPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SiticoneNetCoreUI.SiticonePictureBox Logopb;
        private Label MainTitle;
        private Label SubTitle;
        private SiticoneNetCoreUI.SiticonePanel LoadingPanel;
        private SiticoneNetCoreUI.SiticonePanel LoadingBar;
        private System.Windows.Forms.Timer LoadingScreenTimer;
    }
}
