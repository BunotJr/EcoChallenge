namespace EcoChallenge
{
    partial class SigninForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigninForm));
            SFLogo = new SiticoneNetCoreUI.SiticonePictureBox();
            SFSubTitle = new Label();
            SFMainTitle = new Label();
            SFSigninbtn = new SiticoneNetCoreUI.SiticoneButton();
            SFToCaLink = new SiticoneNetCoreUI.SiticoneLinkedLabel();
            SFClosebtn = new Button();
            SFPasswordtbx = new SiticoneNetCoreUI.SiticoneTextBox();
            SFUsernametbx = new SiticoneNetCoreUI.SiticoneTextBox();
            SFShowPasswordbtn = new Button();
            SFHidePasswordbtn = new Button();
            SuspendLayout();
            // 
            // SFLogo
            // 
            SFLogo.BackColor = Color.Transparent;
            SFLogo.BackgroundImage = Properties.Resources.Logo;
            SFLogo.BackgroundImageLayout = ImageLayout.Zoom;
            SFLogo.BorderColor = Color.Black;
            SFLogo.BorderWidth = 0;
            SFLogo.Brightness = 1F;
            SFLogo.Contrast = 1F;
            SFLogo.CornerRadius = 0;
            SFLogo.DraggingSpeed = 3.15F;
            SFLogo.EnableAsyncLoading = false;
            SFLogo.EnableCaching = false;
            SFLogo.EnableDragDrop = false;
            SFLogo.EnableExtendedImageSources = false;
            SFLogo.EnableFilters = false;
            SFLogo.EnableFlipping = false;
            SFLogo.EnableGlow = false;
            SFLogo.EnableHighDpiSupport = false;
            SFLogo.EnableMouseInteraction = false;
            SFLogo.EnablePlaceholder = false;
            SFLogo.EnableRotation = false;
            SFLogo.EnableShadow = false;
            SFLogo.EnableSlideshow = false;
            SFLogo.FlipHorizontal = false;
            SFLogo.FlipVertical = false;
            SFLogo.Grayscale = false;
            SFLogo.Image = null;
            SFLogo.ImageOpacity = 1F;
            SFLogo.Images = (List<Image>)resources.GetObject("SFLogo.Images");
            SFLogo.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            SFLogo.IsCircular = false;
            SFLogo.Location = new Point(150, 75);
            SFLogo.MaintainAspectRatio = true;
            SFLogo.Margin = new Padding(0);
            SFLogo.Name = "SFLogo";
            SFLogo.PlaceholderImage = null;
            SFLogo.RotationAngle = 0F;
            SFLogo.Saturation = 1F;
            SFLogo.ShowBorder = false;
            SFLogo.Size = new Size(200, 200);
            SFLogo.SizeMode = SiticoneNetCoreUI.SiticonePictureBoxSizeMode.Zoom;
            SFLogo.TabIndex = 0;
            // 
            // SFSubTitle
            // 
            SFSubTitle.AutoSize = true;
            SFSubTitle.BackColor = Color.Transparent;
            SFSubTitle.Font = new Font("Poppins Medium", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SFSubTitle.ForeColor = Color.Green;
            SFSubTitle.Location = new Point(34, 364);
            SFSubTitle.Margin = new Padding(0);
            SFSubTitle.Name = "SFSubTitle";
            SFSubTitle.Size = new Size(426, 28);
            SFSubTitle.TabIndex = 2;
            SFSubTitle.Text = "Sign in to continue your sustainability journey!";
            // 
            // SFMainTitle
            // 
            SFMainTitle.AutoSize = true;
            SFMainTitle.BackColor = Color.Transparent;
            SFMainTitle.Font = new Font("Poppins Black", 28.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SFMainTitle.ForeColor = Color.Green;
            SFMainTitle.Location = new Point(102, 280);
            SFMainTitle.Margin = new Padding(0);
            SFMainTitle.Name = "SFMainTitle";
            SFMainTitle.Size = new Size(297, 84);
            SFMainTitle.TabIndex = 1;
            SFMainTitle.Text = "Welcome!";
            // 
            // SFSigninbtn
            // 
            SFSigninbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            SFSigninbtn.AccessibleName = "Sign in";
            SFSigninbtn.AutoSizeBasedOnText = false;
            SFSigninbtn.BackColor = Color.Transparent;
            SFSigninbtn.BadgeBackColor = Color.Red;
            SFSigninbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            SFSigninbtn.BadgeValue = 0;
            SFSigninbtn.BadgeValueForeColor = Color.White;
            SFSigninbtn.BorderColor = Color.Transparent;
            SFSigninbtn.BorderWidth = 2;
            SFSigninbtn.ButtonBackColor = Color.Green;
            SFSigninbtn.ButtonImage = null;
            SFSigninbtn.CanBeep = true;
            SFSigninbtn.CanGlow = false;
            SFSigninbtn.CanShake = true;
            SFSigninbtn.ContextMenuStripEx = null;
            SFSigninbtn.CornerRadiusBottomLeft = 24;
            SFSigninbtn.CornerRadiusBottomRight = 24;
            SFSigninbtn.CornerRadiusTopLeft = 24;
            SFSigninbtn.CornerRadiusTopRight = 24;
            SFSigninbtn.CustomCursor = Cursors.Default;
            SFSigninbtn.DisabledTextColor = Color.Gray;
            SFSigninbtn.EnableLongPress = false;
            SFSigninbtn.EnablePressAnimation = true;
            SFSigninbtn.EnableRippleEffect = true;
            SFSigninbtn.EnableShadow = false;
            SFSigninbtn.EnableTextWrapping = false;
            SFSigninbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SFSigninbtn.ForeColor = Color.White;
            SFSigninbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            SFSigninbtn.GlowIntensity = 100;
            SFSigninbtn.GlowRadius = 20F;
            SFSigninbtn.GradientBackground = false;
            SFSigninbtn.GradientColor = Color.FromArgb(114, 168, 255);
            SFSigninbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            SFSigninbtn.HintText = null;
            SFSigninbtn.HoverBackColor = Color.SeaGreen;
            SFSigninbtn.HoverFontStyle = FontStyle.Regular;
            SFSigninbtn.HoverTextColor = Color.White;
            SFSigninbtn.HoverTransitionDuration = 250;
            SFSigninbtn.ImageAlign = ContentAlignment.MiddleLeft;
            SFSigninbtn.ImagePadding = 5;
            SFSigninbtn.ImageSize = new Size(16, 16);
            SFSigninbtn.IsRadial = true;
            SFSigninbtn.IsReadOnly = false;
            SFSigninbtn.IsToggleButton = false;
            SFSigninbtn.IsToggled = false;
            SFSigninbtn.Location = new Point(170, 600);
            SFSigninbtn.LongPressDurationMS = 1000;
            SFSigninbtn.Margin = new Padding(0);
            SFSigninbtn.Name = "SFSigninbtn";
            SFSigninbtn.NormalFontStyle = FontStyle.Regular;
            SFSigninbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            SFSigninbtn.ParticleCount = 15;
            SFSigninbtn.PressAnimationScale = 0.97F;
            SFSigninbtn.PressedBackColor = Color.LightGreen;
            SFSigninbtn.PressedFontStyle = FontStyle.Regular;
            SFSigninbtn.PressTransitionDuration = 150;
            SFSigninbtn.ReadOnlyTextColor = Color.White;
            SFSigninbtn.RippleColor = Color.FromArgb(255, 255, 255);
            SFSigninbtn.RippleOpacity = 0.3F;
            SFSigninbtn.RippleRadiusMultiplier = 0.6F;
            SFSigninbtn.ShadowBlur = 5;
            SFSigninbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            SFSigninbtn.ShadowOffset = new Point(2, 2);
            SFSigninbtn.ShakeDuration = 500;
            SFSigninbtn.ShakeIntensity = 5;
            SFSigninbtn.Size = new Size(160, 52);
            SFSigninbtn.TabIndex = 6;
            SFSigninbtn.Text = "Sign in";
            SFSigninbtn.TextAlign = ContentAlignment.MiddleCenter;
            SFSigninbtn.TextColor = Color.White;
            SFSigninbtn.TooltipText = null;
            SFSigninbtn.UseAdvancedRendering = true;
            SFSigninbtn.UseParticles = false;
            SFSigninbtn.Click += SFSigninbtn_Click;
            // 
            // SFToCaLink
            // 
            SFToCaLink.AutoSize = true;
            SFToCaLink.BackColor = Color.Transparent;
            SFToCaLink.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SFToCaLink.Location = new Point(161, 665);
            SFToCaLink.Margin = new Padding(2, 0, 2, 0);
            SFToCaLink.Name = "SFToCaLink";
            SFToCaLink.Size = new Size(178, 25);
            SFToCaLink.TabIndex = 7;
            SFToCaLink.TabStop = true;
            SFToCaLink.Text = "Don't have an account?";
            SFToCaLink.LinkClicked += SFToCaLink_LinkClicked;
            // 
            // SFClosebtn
            // 
            SFClosebtn.BackColor = Color.Transparent;
            SFClosebtn.FlatAppearance.BorderSize = 0;
            SFClosebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            SFClosebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            SFClosebtn.FlatStyle = FlatStyle.Flat;
            SFClosebtn.Image = Properties.Resources.closebtn32bt;
            SFClosebtn.Location = new Point(467, 9);
            SFClosebtn.Margin = new Padding(0);
            SFClosebtn.Name = "SFClosebtn";
            SFClosebtn.Size = new Size(24, 24);
            SFClosebtn.TabIndex = 8;
            SFClosebtn.UseVisualStyleBackColor = false;
            SFClosebtn.Click += SFClosebtn_Click;
            // 
            // SFPasswordtbx
            // 
            SFPasswordtbx.AccessibleDescription = "A customizable text input field.";
            SFPasswordtbx.AccessibleName = "Text Box";
            SFPasswordtbx.AccessibleRole = AccessibleRole.Text;
            SFPasswordtbx.BackColor = Color.Transparent;
            SFPasswordtbx.BlinkCount = 3;
            SFPasswordtbx.BlinkShadow = false;
            SFPasswordtbx.BorderColor1 = Color.LightSlateGray;
            SFPasswordtbx.BorderColor2 = Color.LightSlateGray;
            SFPasswordtbx.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            SFPasswordtbx.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            SFPasswordtbx.BorderSize = 2;
            SFPasswordtbx.CanShake = true;
            SFPasswordtbx.ContinuousBlink = false;
            SFPasswordtbx.CornerRadiusBottomLeft = 10;
            SFPasswordtbx.CornerRadiusBottomRight = 10;
            SFPasswordtbx.CornerRadiusTopLeft = 10;
            SFPasswordtbx.CornerRadiusTopRight = 10;
            SFPasswordtbx.CursorBlinkRate = 500;
            SFPasswordtbx.CursorColor = Color.Black;
            SFPasswordtbx.CursorHeight = 26;
            SFPasswordtbx.CursorOffset = 0;
            SFPasswordtbx.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            SFPasswordtbx.CursorWidth = 1;
            SFPasswordtbx.DisabledBackColor = Color.WhiteSmoke;
            SFPasswordtbx.DisabledBorderColor = Color.LightGray;
            SFPasswordtbx.DisabledTextColor = Color.Gray;
            SFPasswordtbx.EnableDropShadow = false;
            SFPasswordtbx.FillColor1 = Color.White;
            SFPasswordtbx.FillColor2 = Color.White;
            SFPasswordtbx.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SFPasswordtbx.ForeColor = Color.Gray;
            SFPasswordtbx.HoverBorderColor1 = Color.Gray;
            SFPasswordtbx.HoverBorderColor2 = Color.Gray;
            SFPasswordtbx.IsEnabled = true;
            SFPasswordtbx.Location = new Point(95, 510);
            SFPasswordtbx.Margin = new Padding(0);
            SFPasswordtbx.Name = "SFPasswordtbx";
            SFPasswordtbx.PlaceholderColor = Color.Gray;
            SFPasswordtbx.PlaceholderText = "Password";
            SFPasswordtbx.ReadOnlyBorderColor1 = Color.LightGray;
            SFPasswordtbx.ReadOnlyBorderColor2 = Color.LightGray;
            SFPasswordtbx.ReadOnlyFillColor1 = Color.WhiteSmoke;
            SFPasswordtbx.ReadOnlyFillColor2 = Color.WhiteSmoke;
            SFPasswordtbx.ReadOnlyPlaceholderColor = Color.DarkGray;
            SFPasswordtbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            SFPasswordtbx.ShadowAnimationDuration = 1;
            SFPasswordtbx.ShadowBlur = 10;
            SFPasswordtbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            SFPasswordtbx.Size = new Size(300, 50);
            SFPasswordtbx.SolidBorderColor = Color.FromArgb(0, 64, 0);
            SFPasswordtbx.SolidBorderFocusColor = Color.FromArgb(0, 64, 0);
            SFPasswordtbx.SolidBorderHoverColor = Color.Gray;
            SFPasswordtbx.SolidFillColor = Color.White;
            SFPasswordtbx.TabIndex = 4;
            SFPasswordtbx.TextPadding = new Padding(11, 2, 11, 2);
            SFPasswordtbx.UseSystemPasswordChar = true;
            SFPasswordtbx.ValidationErrorMessage = "Invalid input.";
            SFPasswordtbx.ValidationFunction = null;
            // 
            // SFUsernametbx
            // 
            SFUsernametbx.AccessibleDescription = "A customizable text input field.";
            SFUsernametbx.AccessibleName = "Text Box";
            SFUsernametbx.AccessibleRole = AccessibleRole.Text;
            SFUsernametbx.BackColor = Color.Transparent;
            SFUsernametbx.BlinkCount = 3;
            SFUsernametbx.BlinkShadow = false;
            SFUsernametbx.BorderColor1 = Color.LightSlateGray;
            SFUsernametbx.BorderColor2 = Color.LightSlateGray;
            SFUsernametbx.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            SFUsernametbx.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            SFUsernametbx.BorderSize = 2;
            SFUsernametbx.CanShake = true;
            SFUsernametbx.ContinuousBlink = false;
            SFUsernametbx.CornerRadiusBottomLeft = 10;
            SFUsernametbx.CornerRadiusBottomRight = 10;
            SFUsernametbx.CornerRadiusTopLeft = 10;
            SFUsernametbx.CornerRadiusTopRight = 10;
            SFUsernametbx.CursorBlinkRate = 500;
            SFUsernametbx.CursorColor = Color.Black;
            SFUsernametbx.CursorHeight = 26;
            SFUsernametbx.CursorOffset = 0;
            SFUsernametbx.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            SFUsernametbx.CursorWidth = 1;
            SFUsernametbx.DisabledBackColor = Color.WhiteSmoke;
            SFUsernametbx.DisabledBorderColor = Color.LightGray;
            SFUsernametbx.DisabledTextColor = Color.Gray;
            SFUsernametbx.EnableDropShadow = false;
            SFUsernametbx.FillColor1 = Color.White;
            SFUsernametbx.FillColor2 = Color.White;
            SFUsernametbx.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SFUsernametbx.ForeColor = Color.Gray;
            SFUsernametbx.HoverBorderColor1 = Color.Gray;
            SFUsernametbx.HoverBorderColor2 = Color.Gray;
            SFUsernametbx.IsEnabled = true;
            SFUsernametbx.Location = new Point(95, 439);
            SFUsernametbx.Margin = new Padding(0);
            SFUsernametbx.Name = "SFUsernametbx";
            SFUsernametbx.PlaceholderColor = Color.Gray;
            SFUsernametbx.PlaceholderText = "Username";
            SFUsernametbx.ReadOnlyBorderColor1 = Color.LightGray;
            SFUsernametbx.ReadOnlyBorderColor2 = Color.LightGray;
            SFUsernametbx.ReadOnlyFillColor1 = Color.WhiteSmoke;
            SFUsernametbx.ReadOnlyFillColor2 = Color.WhiteSmoke;
            SFUsernametbx.ReadOnlyPlaceholderColor = Color.DarkGray;
            SFUsernametbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            SFUsernametbx.ShadowAnimationDuration = 1;
            SFUsernametbx.ShadowBlur = 10;
            SFUsernametbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            SFUsernametbx.Size = new Size(300, 50);
            SFUsernametbx.SolidBorderColor = Color.FromArgb(0, 64, 0);
            SFUsernametbx.SolidBorderFocusColor = Color.FromArgb(0, 64, 0);
            SFUsernametbx.SolidBorderHoverColor = Color.Gray;
            SFUsernametbx.SolidFillColor = Color.White;
            SFUsernametbx.TabIndex = 3;
            SFUsernametbx.TextPadding = new Padding(11, 2, 11, 2);
            SFUsernametbx.ValidationErrorMessage = "Invalid input.";
            SFUsernametbx.ValidationFunction = null;
            // 
            // SFShowPasswordbtn
            // 
            SFShowPasswordbtn.BackColor = Color.White;
            SFShowPasswordbtn.FlatAppearance.BorderSize = 0;
            SFShowPasswordbtn.FlatAppearance.MouseDownBackColor = Color.White;
            SFShowPasswordbtn.FlatAppearance.MouseOverBackColor = Color.White;
            SFShowPasswordbtn.FlatStyle = FlatStyle.Flat;
            SFShowPasswordbtn.Image = Properties.Resources.hidepass32bt;
            SFShowPasswordbtn.Location = new Point(354, 515);
            SFShowPasswordbtn.Margin = new Padding(2);
            SFShowPasswordbtn.Name = "SFShowPasswordbtn";
            SFShowPasswordbtn.Size = new Size(40, 40);
            SFShowPasswordbtn.TabIndex = 5;
            SFShowPasswordbtn.UseVisualStyleBackColor = false;
            SFShowPasswordbtn.Click += SFShowPasswordbtn_Click;
            // 
            // SFHidePasswordbtn
            // 
            SFHidePasswordbtn.BackColor = Color.White;
            SFHidePasswordbtn.FlatAppearance.BorderSize = 0;
            SFHidePasswordbtn.FlatAppearance.MouseDownBackColor = Color.White;
            SFHidePasswordbtn.FlatAppearance.MouseOverBackColor = Color.White;
            SFHidePasswordbtn.FlatStyle = FlatStyle.Flat;
            SFHidePasswordbtn.Image = Properties.Resources.showpass32bt;
            SFHidePasswordbtn.Location = new Point(354, 515);
            SFHidePasswordbtn.Margin = new Padding(2);
            SFHidePasswordbtn.Name = "SFHidePasswordbtn";
            SFHidePasswordbtn.Size = new Size(40, 40);
            SFHidePasswordbtn.TabIndex = 12;
            SFHidePasswordbtn.UseVisualStyleBackColor = false;
            SFHidePasswordbtn.Click += SFHidePasswordbtn_Click;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(500, 800);
            Controls.Add(SFShowPasswordbtn);
            Controls.Add(SFHidePasswordbtn);
            Controls.Add(SFPasswordtbx);
            Controls.Add(SFUsernametbx);
            Controls.Add(SFClosebtn);
            Controls.Add(SFToCaLink);
            Controls.Add(SFSigninbtn);
            Controls.Add(SFSubTitle);
            Controls.Add(SFMainTitle);
            Controls.Add(SFLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "SigninForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SigninForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SiticoneNetCoreUI.SiticonePictureBox SFLogo;
        private Label SFSubTitle;
        private Label SFMainTitle;
        private SiticoneNetCoreUI.SiticoneButton SFSigninbtn;
        private SiticoneNetCoreUI.SiticoneLinkedLabel SFToCaLink;
        private Button SFClosebtn;
        private SiticoneNetCoreUI.SiticoneTextBox SFPasswordtbx;
        private SiticoneNetCoreUI.SiticoneTextBox SFUsernametbx;
        private Button SFShowPasswordbtn;
        private Button SFHidePasswordbtn;
    }
}