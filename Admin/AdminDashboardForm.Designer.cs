namespace EcoChallenge
{
    partial class AdminDashboardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            ADFTopbarPanel = new Panel();
            ADFClosebtn = new SiticoneNetCoreUI.SiticoneCloseButton();
            ADFMainPanel = new Panel();
            ADFReportsAnalyticsbtn = new SiticoneNetCoreUI.SiticoneButton();
            ADFSignoutbtn = new SiticoneNetCoreUI.SiticoneButton();
            ADFReviewSubmissionbtn = new SiticoneNetCoreUI.SiticoneButton();
            ADFManageUsersbtn = new SiticoneNetCoreUI.SiticoneButton();
            ADFManageChallengesbtn = new SiticoneNetCoreUI.SiticoneButton();
            ADFHomebtn = new SiticoneNetCoreUI.SiticoneButton();
            ADFSidePanel = new SiticoneNetCoreUI.SiticonePanel();
            ADFMainMenubtn = new Button();
            ADFSidebarPanel = new Panel();
            ADFSideBarTimer = new System.Windows.Forms.Timer(components);
            ADFMonitorUsersbtn = new SiticoneNetCoreUI.SiticoneButton();
            ADFTopbarPanel.SuspendLayout();
            ADFSidePanel.SuspendLayout();
            ADFSidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ADFTopbarPanel
            // 
            ADFTopbarPanel.BackColor = Color.LightGreen;
            ADFTopbarPanel.Controls.Add(ADFClosebtn);
            ADFTopbarPanel.Dock = DockStyle.Top;
            ADFTopbarPanel.Location = new Point(80, 0);
            ADFTopbarPanel.Margin = new Padding(2);
            ADFTopbarPanel.Name = "ADFTopbarPanel";
            ADFTopbarPanel.Size = new Size(920, 45);
            ADFTopbarPanel.TabIndex = 6;
            // 
            // ADFClosebtn
            // 
            ADFClosebtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ADFClosebtn.BackColor = Color.Transparent;
            ADFClosebtn.CountdownFont = new Font("Segoe UI", 9F);
            ADFClosebtn.Cursor = Cursors.Default;
            ADFClosebtn.EnableSound = false;
            ADFClosebtn.IconColor = Color.Green;
            ADFClosebtn.IconSize = 20;
            ADFClosebtn.IconThickness = 4;
            ADFClosebtn.Location = new Point(879, 5);
            ADFClosebtn.Margin = new Padding(0);
            ADFClosebtn.Name = "ADFClosebtn";
            ADFClosebtn.Size = new Size(36, 36);
            ADFClosebtn.TabIndex = 1;
            ADFClosebtn.TooltipText = "Close button";
            ADFClosebtn.Click += ADFClosebtn_Click;
            // 
            // ADFMainPanel
            // 
            ADFMainPanel.BackColor = Color.LightGreen;
            ADFMainPanel.Dock = DockStyle.Fill;
            ADFMainPanel.Location = new Point(80, 45);
            ADFMainPanel.Margin = new Padding(0);
            ADFMainPanel.Name = "ADFMainPanel";
            ADFMainPanel.Size = new Size(920, 595);
            ADFMainPanel.TabIndex = 7;
            // 
            // ADFReportsAnalyticsbtn
            // 
            ADFReportsAnalyticsbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ADFReportsAnalyticsbtn.AccessibleName = "";
            ADFReportsAnalyticsbtn.AutoSizeBasedOnText = false;
            ADFReportsAnalyticsbtn.BackColor = Color.Transparent;
            ADFReportsAnalyticsbtn.BadgeBackColor = Color.Red;
            ADFReportsAnalyticsbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ADFReportsAnalyticsbtn.BadgeValue = 0;
            ADFReportsAnalyticsbtn.BadgeValueForeColor = Color.White;
            ADFReportsAnalyticsbtn.BorderColor = Color.Transparent;
            ADFReportsAnalyticsbtn.BorderWidth = 2;
            ADFReportsAnalyticsbtn.ButtonBackColor = Color.Green;
            ADFReportsAnalyticsbtn.ButtonImage = (Image)resources.GetObject("ADFReportsAnalyticsbtn.ButtonImage");
            ADFReportsAnalyticsbtn.CanBeep = true;
            ADFReportsAnalyticsbtn.CanGlow = false;
            ADFReportsAnalyticsbtn.CanShake = true;
            ADFReportsAnalyticsbtn.ContextMenuStripEx = null;
            ADFReportsAnalyticsbtn.CornerRadiusBottomLeft = 23;
            ADFReportsAnalyticsbtn.CornerRadiusBottomRight = 23;
            ADFReportsAnalyticsbtn.CornerRadiusTopLeft = 23;
            ADFReportsAnalyticsbtn.CornerRadiusTopRight = 23;
            ADFReportsAnalyticsbtn.CustomCursor = Cursors.Default;
            ADFReportsAnalyticsbtn.DisabledTextColor = Color.Gray;
            ADFReportsAnalyticsbtn.EnableLongPress = false;
            ADFReportsAnalyticsbtn.EnablePressAnimation = true;
            ADFReportsAnalyticsbtn.EnableRippleEffect = true;
            ADFReportsAnalyticsbtn.EnableShadow = false;
            ADFReportsAnalyticsbtn.EnableTextWrapping = false;
            ADFReportsAnalyticsbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADFReportsAnalyticsbtn.ForeColor = Color.White;
            ADFReportsAnalyticsbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ADFReportsAnalyticsbtn.GlowIntensity = 100;
            ADFReportsAnalyticsbtn.GlowRadius = 20F;
            ADFReportsAnalyticsbtn.GradientBackground = false;
            ADFReportsAnalyticsbtn.GradientColor = Color.FromArgb(114, 168, 255);
            ADFReportsAnalyticsbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ADFReportsAnalyticsbtn.HintText = null;
            ADFReportsAnalyticsbtn.HoverBackColor = Color.SeaGreen;
            ADFReportsAnalyticsbtn.HoverFontStyle = FontStyle.Regular;
            ADFReportsAnalyticsbtn.HoverTextColor = Color.White;
            ADFReportsAnalyticsbtn.HoverTransitionDuration = 250;
            ADFReportsAnalyticsbtn.ImageAlign = ContentAlignment.MiddleCenter;
            ADFReportsAnalyticsbtn.ImagePadding = 0;
            ADFReportsAnalyticsbtn.ImageSize = new Size(30, 30);
            ADFReportsAnalyticsbtn.IsRadial = true;
            ADFReportsAnalyticsbtn.IsReadOnly = false;
            ADFReportsAnalyticsbtn.IsToggleButton = false;
            ADFReportsAnalyticsbtn.IsToggled = false;
            ADFReportsAnalyticsbtn.Location = new Point(5, 319);
            ADFReportsAnalyticsbtn.LongPressDurationMS = 1000;
            ADFReportsAnalyticsbtn.Margin = new Padding(0);
            ADFReportsAnalyticsbtn.Name = "ADFReportsAnalyticsbtn";
            ADFReportsAnalyticsbtn.NormalFontStyle = FontStyle.Regular;
            ADFReportsAnalyticsbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ADFReportsAnalyticsbtn.ParticleCount = 15;
            ADFReportsAnalyticsbtn.PressAnimationScale = 0.97F;
            ADFReportsAnalyticsbtn.PressedBackColor = Color.LightGreen;
            ADFReportsAnalyticsbtn.PressedFontStyle = FontStyle.Regular;
            ADFReportsAnalyticsbtn.PressTransitionDuration = 150;
            ADFReportsAnalyticsbtn.ReadOnlyTextColor = Color.White;
            ADFReportsAnalyticsbtn.RippleColor = Color.FromArgb(255, 255, 255);
            ADFReportsAnalyticsbtn.RippleOpacity = 0.3F;
            ADFReportsAnalyticsbtn.RippleRadiusMultiplier = 0.6F;
            ADFReportsAnalyticsbtn.ShadowBlur = 5;
            ADFReportsAnalyticsbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ADFReportsAnalyticsbtn.ShadowOffset = new Point(2, 2);
            ADFReportsAnalyticsbtn.ShakeDuration = 500;
            ADFReportsAnalyticsbtn.ShakeIntensity = 5;
            ADFReportsAnalyticsbtn.Size = new Size(50, 50);
            ADFReportsAnalyticsbtn.TabIndex = 7;
            ADFReportsAnalyticsbtn.TextAlign = ContentAlignment.MiddleCenter;
            ADFReportsAnalyticsbtn.TextColor = Color.White;
            ADFReportsAnalyticsbtn.TooltipText = null;
            ADFReportsAnalyticsbtn.UseAdvancedRendering = true;
            ADFReportsAnalyticsbtn.UseParticles = false;
            ADFReportsAnalyticsbtn.Click += ADFReportsAnalyticsbtn_Click_1;
            // 
            // ADFSignoutbtn
            // 
            ADFSignoutbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ADFSignoutbtn.AccessibleName = "";
            ADFSignoutbtn.AutoSizeBasedOnText = false;
            ADFSignoutbtn.BackColor = Color.Transparent;
            ADFSignoutbtn.BadgeBackColor = Color.Red;
            ADFSignoutbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ADFSignoutbtn.BadgeValue = 0;
            ADFSignoutbtn.BadgeValueForeColor = Color.White;
            ADFSignoutbtn.BorderColor = Color.Transparent;
            ADFSignoutbtn.BorderWidth = 2;
            ADFSignoutbtn.ButtonBackColor = Color.Green;
            ADFSignoutbtn.ButtonImage = (Image)resources.GetObject("ADFSignoutbtn.ButtonImage");
            ADFSignoutbtn.CanBeep = true;
            ADFSignoutbtn.CanGlow = false;
            ADFSignoutbtn.CanShake = true;
            ADFSignoutbtn.ContextMenuStripEx = null;
            ADFSignoutbtn.CornerRadiusBottomLeft = 23;
            ADFSignoutbtn.CornerRadiusBottomRight = 23;
            ADFSignoutbtn.CornerRadiusTopLeft = 23;
            ADFSignoutbtn.CornerRadiusTopRight = 23;
            ADFSignoutbtn.CustomCursor = Cursors.Default;
            ADFSignoutbtn.DisabledTextColor = Color.Gray;
            ADFSignoutbtn.EnableLongPress = false;
            ADFSignoutbtn.EnablePressAnimation = true;
            ADFSignoutbtn.EnableRippleEffect = true;
            ADFSignoutbtn.EnableShadow = false;
            ADFSignoutbtn.EnableTextWrapping = false;
            ADFSignoutbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADFSignoutbtn.ForeColor = Color.White;
            ADFSignoutbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ADFSignoutbtn.GlowIntensity = 100;
            ADFSignoutbtn.GlowRadius = 20F;
            ADFSignoutbtn.GradientBackground = false;
            ADFSignoutbtn.GradientColor = Color.FromArgb(114, 168, 255);
            ADFSignoutbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ADFSignoutbtn.HintText = null;
            ADFSignoutbtn.HoverBackColor = Color.SeaGreen;
            ADFSignoutbtn.HoverFontStyle = FontStyle.Regular;
            ADFSignoutbtn.HoverTextColor = Color.White;
            ADFSignoutbtn.HoverTransitionDuration = 250;
            ADFSignoutbtn.ImageAlign = ContentAlignment.MiddleCenter;
            ADFSignoutbtn.ImagePadding = 0;
            ADFSignoutbtn.ImageSize = new Size(30, 30);
            ADFSignoutbtn.IsRadial = true;
            ADFSignoutbtn.IsReadOnly = false;
            ADFSignoutbtn.IsToggleButton = false;
            ADFSignoutbtn.IsToggled = false;
            ADFSignoutbtn.Location = new Point(5, 369);
            ADFSignoutbtn.LongPressDurationMS = 1000;
            ADFSignoutbtn.Margin = new Padding(0);
            ADFSignoutbtn.Name = "ADFSignoutbtn";
            ADFSignoutbtn.NormalFontStyle = FontStyle.Regular;
            ADFSignoutbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ADFSignoutbtn.ParticleCount = 15;
            ADFSignoutbtn.PressAnimationScale = 0.97F;
            ADFSignoutbtn.PressedBackColor = Color.LightGreen;
            ADFSignoutbtn.PressedFontStyle = FontStyle.Regular;
            ADFSignoutbtn.PressTransitionDuration = 150;
            ADFSignoutbtn.ReadOnlyTextColor = Color.White;
            ADFSignoutbtn.RippleColor = Color.FromArgb(255, 255, 255);
            ADFSignoutbtn.RippleOpacity = 0.3F;
            ADFSignoutbtn.RippleRadiusMultiplier = 0.6F;
            ADFSignoutbtn.ShadowBlur = 5;
            ADFSignoutbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ADFSignoutbtn.ShadowOffset = new Point(2, 2);
            ADFSignoutbtn.ShakeDuration = 500;
            ADFSignoutbtn.ShakeIntensity = 5;
            ADFSignoutbtn.Size = new Size(50, 50);
            ADFSignoutbtn.TabIndex = 7;
            ADFSignoutbtn.TextAlign = ContentAlignment.MiddleCenter;
            ADFSignoutbtn.TextColor = Color.White;
            ADFSignoutbtn.TooltipText = null;
            ADFSignoutbtn.UseAdvancedRendering = true;
            ADFSignoutbtn.UseParticles = false;
            ADFSignoutbtn.Click += ADFSignoutbtn_Click_1;
            // 
            // ADFReviewSubmissionbtn
            // 
            ADFReviewSubmissionbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ADFReviewSubmissionbtn.AccessibleName = "";
            ADFReviewSubmissionbtn.AutoSizeBasedOnText = false;
            ADFReviewSubmissionbtn.BackColor = Color.Transparent;
            ADFReviewSubmissionbtn.BadgeBackColor = Color.Red;
            ADFReviewSubmissionbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ADFReviewSubmissionbtn.BadgeValue = 0;
            ADFReviewSubmissionbtn.BadgeValueForeColor = Color.White;
            ADFReviewSubmissionbtn.BorderColor = Color.Transparent;
            ADFReviewSubmissionbtn.BorderWidth = 2;
            ADFReviewSubmissionbtn.ButtonBackColor = Color.Green;
            ADFReviewSubmissionbtn.ButtonImage = (Image)resources.GetObject("ADFReviewSubmissionbtn.ButtonImage");
            ADFReviewSubmissionbtn.CanBeep = true;
            ADFReviewSubmissionbtn.CanGlow = false;
            ADFReviewSubmissionbtn.CanShake = true;
            ADFReviewSubmissionbtn.ContextMenuStripEx = null;
            ADFReviewSubmissionbtn.CornerRadiusBottomLeft = 23;
            ADFReviewSubmissionbtn.CornerRadiusBottomRight = 23;
            ADFReviewSubmissionbtn.CornerRadiusTopLeft = 23;
            ADFReviewSubmissionbtn.CornerRadiusTopRight = 23;
            ADFReviewSubmissionbtn.CustomCursor = Cursors.Default;
            ADFReviewSubmissionbtn.DisabledTextColor = Color.Gray;
            ADFReviewSubmissionbtn.EnableLongPress = false;
            ADFReviewSubmissionbtn.EnablePressAnimation = true;
            ADFReviewSubmissionbtn.EnableRippleEffect = true;
            ADFReviewSubmissionbtn.EnableShadow = false;
            ADFReviewSubmissionbtn.EnableTextWrapping = false;
            ADFReviewSubmissionbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADFReviewSubmissionbtn.ForeColor = Color.White;
            ADFReviewSubmissionbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ADFReviewSubmissionbtn.GlowIntensity = 100;
            ADFReviewSubmissionbtn.GlowRadius = 20F;
            ADFReviewSubmissionbtn.GradientBackground = false;
            ADFReviewSubmissionbtn.GradientColor = Color.FromArgb(114, 168, 255);
            ADFReviewSubmissionbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ADFReviewSubmissionbtn.HintText = null;
            ADFReviewSubmissionbtn.HoverBackColor = Color.SeaGreen;
            ADFReviewSubmissionbtn.HoverFontStyle = FontStyle.Regular;
            ADFReviewSubmissionbtn.HoverTextColor = Color.White;
            ADFReviewSubmissionbtn.HoverTransitionDuration = 250;
            ADFReviewSubmissionbtn.ImageAlign = ContentAlignment.MiddleCenter;
            ADFReviewSubmissionbtn.ImagePadding = 0;
            ADFReviewSubmissionbtn.ImageSize = new Size(30, 30);
            ADFReviewSubmissionbtn.IsRadial = true;
            ADFReviewSubmissionbtn.IsReadOnly = false;
            ADFReviewSubmissionbtn.IsToggleButton = false;
            ADFReviewSubmissionbtn.IsToggled = false;
            ADFReviewSubmissionbtn.Location = new Point(5, 269);
            ADFReviewSubmissionbtn.LongPressDurationMS = 1000;
            ADFReviewSubmissionbtn.Margin = new Padding(0);
            ADFReviewSubmissionbtn.Name = "ADFReviewSubmissionbtn";
            ADFReviewSubmissionbtn.NormalFontStyle = FontStyle.Regular;
            ADFReviewSubmissionbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ADFReviewSubmissionbtn.ParticleCount = 15;
            ADFReviewSubmissionbtn.PressAnimationScale = 0.97F;
            ADFReviewSubmissionbtn.PressedBackColor = Color.LightGreen;
            ADFReviewSubmissionbtn.PressedFontStyle = FontStyle.Regular;
            ADFReviewSubmissionbtn.PressTransitionDuration = 150;
            ADFReviewSubmissionbtn.ReadOnlyTextColor = Color.White;
            ADFReviewSubmissionbtn.RippleColor = Color.FromArgb(255, 255, 255);
            ADFReviewSubmissionbtn.RippleOpacity = 0.3F;
            ADFReviewSubmissionbtn.RippleRadiusMultiplier = 0.6F;
            ADFReviewSubmissionbtn.ShadowBlur = 5;
            ADFReviewSubmissionbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ADFReviewSubmissionbtn.ShadowOffset = new Point(2, 2);
            ADFReviewSubmissionbtn.ShakeDuration = 500;
            ADFReviewSubmissionbtn.ShakeIntensity = 5;
            ADFReviewSubmissionbtn.Size = new Size(50, 50);
            ADFReviewSubmissionbtn.TabIndex = 7;
            ADFReviewSubmissionbtn.TextAlign = ContentAlignment.MiddleCenter;
            ADFReviewSubmissionbtn.TextColor = Color.White;
            ADFReviewSubmissionbtn.TooltipText = null;
            ADFReviewSubmissionbtn.UseAdvancedRendering = true;
            ADFReviewSubmissionbtn.UseParticles = false;
            ADFReviewSubmissionbtn.Click += ADFReviewSubmissionbtn_Click_1;
            // 
            // ADFManageUsersbtn
            // 
            ADFManageUsersbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ADFManageUsersbtn.AccessibleName = "";
            ADFManageUsersbtn.AutoSizeBasedOnText = false;
            ADFManageUsersbtn.BackColor = Color.Transparent;
            ADFManageUsersbtn.BadgeBackColor = Color.Red;
            ADFManageUsersbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ADFManageUsersbtn.BadgeValue = 0;
            ADFManageUsersbtn.BadgeValueForeColor = Color.White;
            ADFManageUsersbtn.BorderColor = Color.Transparent;
            ADFManageUsersbtn.BorderWidth = 2;
            ADFManageUsersbtn.ButtonBackColor = Color.Green;
            ADFManageUsersbtn.ButtonImage = (Image)resources.GetObject("ADFManageUsersbtn.ButtonImage");
            ADFManageUsersbtn.CanBeep = true;
            ADFManageUsersbtn.CanGlow = false;
            ADFManageUsersbtn.CanShake = true;
            ADFManageUsersbtn.ContextMenuStripEx = null;
            ADFManageUsersbtn.CornerRadiusBottomLeft = 23;
            ADFManageUsersbtn.CornerRadiusBottomRight = 23;
            ADFManageUsersbtn.CornerRadiusTopLeft = 23;
            ADFManageUsersbtn.CornerRadiusTopRight = 23;
            ADFManageUsersbtn.CustomCursor = Cursors.Default;
            ADFManageUsersbtn.DisabledTextColor = Color.Gray;
            ADFManageUsersbtn.EnableLongPress = false;
            ADFManageUsersbtn.EnablePressAnimation = true;
            ADFManageUsersbtn.EnableRippleEffect = true;
            ADFManageUsersbtn.EnableShadow = false;
            ADFManageUsersbtn.EnableTextWrapping = false;
            ADFManageUsersbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADFManageUsersbtn.ForeColor = Color.White;
            ADFManageUsersbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ADFManageUsersbtn.GlowIntensity = 100;
            ADFManageUsersbtn.GlowRadius = 20F;
            ADFManageUsersbtn.GradientBackground = false;
            ADFManageUsersbtn.GradientColor = Color.FromArgb(114, 168, 255);
            ADFManageUsersbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ADFManageUsersbtn.HintText = null;
            ADFManageUsersbtn.HoverBackColor = Color.SeaGreen;
            ADFManageUsersbtn.HoverFontStyle = FontStyle.Regular;
            ADFManageUsersbtn.HoverTextColor = Color.White;
            ADFManageUsersbtn.HoverTransitionDuration = 250;
            ADFManageUsersbtn.ImageAlign = ContentAlignment.MiddleCenter;
            ADFManageUsersbtn.ImagePadding = 0;
            ADFManageUsersbtn.ImageSize = new Size(30, 30);
            ADFManageUsersbtn.IsRadial = true;
            ADFManageUsersbtn.IsReadOnly = false;
            ADFManageUsersbtn.IsToggleButton = false;
            ADFManageUsersbtn.IsToggled = false;
            ADFManageUsersbtn.Location = new Point(5, 169);
            ADFManageUsersbtn.LongPressDurationMS = 1000;
            ADFManageUsersbtn.Margin = new Padding(0);
            ADFManageUsersbtn.Name = "ADFManageUsersbtn";
            ADFManageUsersbtn.NormalFontStyle = FontStyle.Regular;
            ADFManageUsersbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ADFManageUsersbtn.ParticleCount = 15;
            ADFManageUsersbtn.PressAnimationScale = 0.97F;
            ADFManageUsersbtn.PressedBackColor = Color.LightGreen;
            ADFManageUsersbtn.PressedFontStyle = FontStyle.Regular;
            ADFManageUsersbtn.PressTransitionDuration = 150;
            ADFManageUsersbtn.ReadOnlyTextColor = Color.White;
            ADFManageUsersbtn.RippleColor = Color.FromArgb(255, 255, 255);
            ADFManageUsersbtn.RippleOpacity = 0.3F;
            ADFManageUsersbtn.RippleRadiusMultiplier = 0.6F;
            ADFManageUsersbtn.ShadowBlur = 5;
            ADFManageUsersbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ADFManageUsersbtn.ShadowOffset = new Point(2, 2);
            ADFManageUsersbtn.ShakeDuration = 500;
            ADFManageUsersbtn.ShakeIntensity = 5;
            ADFManageUsersbtn.Size = new Size(50, 50);
            ADFManageUsersbtn.TabIndex = 7;
            ADFManageUsersbtn.TextAlign = ContentAlignment.MiddleCenter;
            ADFManageUsersbtn.TextColor = Color.White;
            ADFManageUsersbtn.TooltipText = null;
            ADFManageUsersbtn.UseAdvancedRendering = true;
            ADFManageUsersbtn.UseParticles = false;
            ADFManageUsersbtn.Click += ADFManageUsersbtn_Click_1;
            // 
            // ADFManageChallengesbtn
            // 
            ADFManageChallengesbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ADFManageChallengesbtn.AccessibleName = "";
            ADFManageChallengesbtn.AutoSizeBasedOnText = false;
            ADFManageChallengesbtn.BackColor = Color.Transparent;
            ADFManageChallengesbtn.BadgeBackColor = Color.Red;
            ADFManageChallengesbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ADFManageChallengesbtn.BadgeValue = 0;
            ADFManageChallengesbtn.BadgeValueForeColor = Color.White;
            ADFManageChallengesbtn.BorderColor = Color.Transparent;
            ADFManageChallengesbtn.BorderWidth = 2;
            ADFManageChallengesbtn.ButtonBackColor = Color.Green;
            ADFManageChallengesbtn.ButtonImage = (Image)resources.GetObject("ADFManageChallengesbtn.ButtonImage");
            ADFManageChallengesbtn.CanBeep = true;
            ADFManageChallengesbtn.CanGlow = false;
            ADFManageChallengesbtn.CanShake = true;
            ADFManageChallengesbtn.ContextMenuStripEx = null;
            ADFManageChallengesbtn.CornerRadiusBottomLeft = 23;
            ADFManageChallengesbtn.CornerRadiusBottomRight = 23;
            ADFManageChallengesbtn.CornerRadiusTopLeft = 23;
            ADFManageChallengesbtn.CornerRadiusTopRight = 23;
            ADFManageChallengesbtn.CustomCursor = Cursors.Default;
            ADFManageChallengesbtn.DisabledTextColor = Color.Gray;
            ADFManageChallengesbtn.EnableLongPress = false;
            ADFManageChallengesbtn.EnablePressAnimation = true;
            ADFManageChallengesbtn.EnableRippleEffect = true;
            ADFManageChallengesbtn.EnableShadow = false;
            ADFManageChallengesbtn.EnableTextWrapping = false;
            ADFManageChallengesbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADFManageChallengesbtn.ForeColor = Color.White;
            ADFManageChallengesbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ADFManageChallengesbtn.GlowIntensity = 100;
            ADFManageChallengesbtn.GlowRadius = 20F;
            ADFManageChallengesbtn.GradientBackground = false;
            ADFManageChallengesbtn.GradientColor = Color.FromArgb(114, 168, 255);
            ADFManageChallengesbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ADFManageChallengesbtn.HintText = null;
            ADFManageChallengesbtn.HoverBackColor = Color.SeaGreen;
            ADFManageChallengesbtn.HoverFontStyle = FontStyle.Regular;
            ADFManageChallengesbtn.HoverTextColor = Color.White;
            ADFManageChallengesbtn.HoverTransitionDuration = 250;
            ADFManageChallengesbtn.ImageAlign = ContentAlignment.MiddleCenter;
            ADFManageChallengesbtn.ImagePadding = 0;
            ADFManageChallengesbtn.ImageSize = new Size(30, 30);
            ADFManageChallengesbtn.IsRadial = true;
            ADFManageChallengesbtn.IsReadOnly = false;
            ADFManageChallengesbtn.IsToggleButton = false;
            ADFManageChallengesbtn.IsToggled = false;
            ADFManageChallengesbtn.Location = new Point(5, 119);
            ADFManageChallengesbtn.LongPressDurationMS = 1000;
            ADFManageChallengesbtn.Margin = new Padding(0);
            ADFManageChallengesbtn.Name = "ADFManageChallengesbtn";
            ADFManageChallengesbtn.NormalFontStyle = FontStyle.Regular;
            ADFManageChallengesbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ADFManageChallengesbtn.ParticleCount = 15;
            ADFManageChallengesbtn.PressAnimationScale = 0.97F;
            ADFManageChallengesbtn.PressedBackColor = Color.LightGreen;
            ADFManageChallengesbtn.PressedFontStyle = FontStyle.Regular;
            ADFManageChallengesbtn.PressTransitionDuration = 150;
            ADFManageChallengesbtn.ReadOnlyTextColor = Color.White;
            ADFManageChallengesbtn.RippleColor = Color.FromArgb(255, 255, 255);
            ADFManageChallengesbtn.RippleOpacity = 0.3F;
            ADFManageChallengesbtn.RippleRadiusMultiplier = 0.6F;
            ADFManageChallengesbtn.ShadowBlur = 5;
            ADFManageChallengesbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ADFManageChallengesbtn.ShadowOffset = new Point(2, 2);
            ADFManageChallengesbtn.ShakeDuration = 500;
            ADFManageChallengesbtn.ShakeIntensity = 5;
            ADFManageChallengesbtn.Size = new Size(50, 50);
            ADFManageChallengesbtn.TabIndex = 7;
            ADFManageChallengesbtn.TextAlign = ContentAlignment.MiddleCenter;
            ADFManageChallengesbtn.TextColor = Color.White;
            ADFManageChallengesbtn.TooltipText = null;
            ADFManageChallengesbtn.UseAdvancedRendering = true;
            ADFManageChallengesbtn.UseParticles = false;
            ADFManageChallengesbtn.Click += ADFManageChallengesbtn_Click_1;
            // 
            // ADFHomebtn
            // 
            ADFHomebtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ADFHomebtn.AccessibleName = "";
            ADFHomebtn.AutoSizeBasedOnText = false;
            ADFHomebtn.BackColor = Color.Transparent;
            ADFHomebtn.BadgeBackColor = Color.Red;
            ADFHomebtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ADFHomebtn.BadgeValue = 0;
            ADFHomebtn.BadgeValueForeColor = Color.White;
            ADFHomebtn.BorderColor = Color.Transparent;
            ADFHomebtn.BorderWidth = 2;
            ADFHomebtn.ButtonBackColor = Color.Green;
            ADFHomebtn.ButtonImage = (Image)resources.GetObject("ADFHomebtn.ButtonImage");
            ADFHomebtn.CanBeep = true;
            ADFHomebtn.CanGlow = false;
            ADFHomebtn.CanShake = true;
            ADFHomebtn.ContextMenuStripEx = null;
            ADFHomebtn.CornerRadiusBottomLeft = 23;
            ADFHomebtn.CornerRadiusBottomRight = 23;
            ADFHomebtn.CornerRadiusTopLeft = 23;
            ADFHomebtn.CornerRadiusTopRight = 23;
            ADFHomebtn.CustomCursor = Cursors.Default;
            ADFHomebtn.DisabledTextColor = Color.Gray;
            ADFHomebtn.EnableLongPress = false;
            ADFHomebtn.EnablePressAnimation = true;
            ADFHomebtn.EnableRippleEffect = true;
            ADFHomebtn.EnableShadow = false;
            ADFHomebtn.EnableTextWrapping = false;
            ADFHomebtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADFHomebtn.ForeColor = Color.White;
            ADFHomebtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ADFHomebtn.GlowIntensity = 100;
            ADFHomebtn.GlowRadius = 20F;
            ADFHomebtn.GradientBackground = false;
            ADFHomebtn.GradientColor = Color.FromArgb(114, 168, 255);
            ADFHomebtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ADFHomebtn.HintText = null;
            ADFHomebtn.HoverBackColor = Color.SeaGreen;
            ADFHomebtn.HoverFontStyle = FontStyle.Regular;
            ADFHomebtn.HoverTextColor = Color.White;
            ADFHomebtn.HoverTransitionDuration = 250;
            ADFHomebtn.ImageAlign = ContentAlignment.MiddleCenter;
            ADFHomebtn.ImagePadding = 0;
            ADFHomebtn.ImageSize = new Size(30, 30);
            ADFHomebtn.IsRadial = true;
            ADFHomebtn.IsReadOnly = false;
            ADFHomebtn.IsToggleButton = false;
            ADFHomebtn.IsToggled = false;
            ADFHomebtn.Location = new Point(5, 69);
            ADFHomebtn.LongPressDurationMS = 1000;
            ADFHomebtn.Margin = new Padding(0);
            ADFHomebtn.Name = "ADFHomebtn";
            ADFHomebtn.NormalFontStyle = FontStyle.Regular;
            ADFHomebtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ADFHomebtn.ParticleCount = 15;
            ADFHomebtn.PressAnimationScale = 0.97F;
            ADFHomebtn.PressedBackColor = Color.LightGreen;
            ADFHomebtn.PressedFontStyle = FontStyle.Regular;
            ADFHomebtn.PressTransitionDuration = 150;
            ADFHomebtn.ReadOnlyTextColor = Color.White;
            ADFHomebtn.RippleColor = Color.FromArgb(255, 255, 255);
            ADFHomebtn.RippleOpacity = 0.3F;
            ADFHomebtn.RippleRadiusMultiplier = 0.6F;
            ADFHomebtn.ShadowBlur = 5;
            ADFHomebtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ADFHomebtn.ShadowOffset = new Point(2, 2);
            ADFHomebtn.ShakeDuration = 500;
            ADFHomebtn.ShakeIntensity = 5;
            ADFHomebtn.Size = new Size(50, 50);
            ADFHomebtn.TabIndex = 7;
            ADFHomebtn.TextAlign = ContentAlignment.MiddleCenter;
            ADFHomebtn.TextColor = Color.White;
            ADFHomebtn.TooltipText = null;
            ADFHomebtn.UseAdvancedRendering = true;
            ADFHomebtn.UseParticles = false;
            ADFHomebtn.Click += ADFHomebtn_Click_1;
            // 
            // ADFSidePanel
            // 
            ADFSidePanel.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            ADFSidePanel.BackColor = Color.Transparent;
            ADFSidePanel.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            ADFSidePanel.BorderDashPattern = null;
            ADFSidePanel.BorderGradientEndColor = Color.Purple;
            ADFSidePanel.BorderGradientStartColor = Color.Blue;
            ADFSidePanel.BorderThickness = 2F;
            ADFSidePanel.Controls.Add(ADFReportsAnalyticsbtn);
            ADFSidePanel.Controls.Add(ADFMainMenubtn);
            ADFSidePanel.Controls.Add(ADFSignoutbtn);
            ADFSidePanel.Controls.Add(ADFHomebtn);
            ADFSidePanel.Controls.Add(ADFReviewSubmissionbtn);
            ADFSidePanel.Controls.Add(ADFManageChallengesbtn);
            ADFSidePanel.Controls.Add(ADFMonitorUsersbtn);
            ADFSidePanel.Controls.Add(ADFManageUsersbtn);
            ADFSidePanel.CornerRadiusBottomLeft = 50F;
            ADFSidePanel.CornerRadiusBottomRight = 50F;
            ADFSidePanel.CornerRadiusTopLeft = 50F;
            ADFSidePanel.CornerRadiusTopRight = 50F;
            ADFSidePanel.EnableAcrylicEffect = false;
            ADFSidePanel.EnableMicaEffect = false;
            ADFSidePanel.EnableRippleEffect = false;
            ADFSidePanel.FillColor = Color.Green;
            ADFSidePanel.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            ADFSidePanel.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            ADFSidePanel.Location = new Point(9, 9);
            ADFSidePanel.Margin = new Padding(0);
            ADFSidePanel.MaximumSize = new Size(60, 425);
            ADFSidePanel.MinimumSize = new Size(60, 60);
            ADFSidePanel.Name = "ADFSidePanel";
            ADFSidePanel.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            ADFSidePanel.RippleAlpha = 50;
            ADFSidePanel.RippleAlphaDecrement = 3;
            ADFSidePanel.RippleColor = Color.FromArgb(50, 255, 255, 255);
            ADFSidePanel.RippleMaxSize = 600F;
            ADFSidePanel.RippleSpeed = 15F;
            ADFSidePanel.ShowBorder = true;
            ADFSidePanel.Size = new Size(60, 425);
            ADFSidePanel.TabIndex = 0;
            ADFSidePanel.TabStop = true;
            ADFSidePanel.UseBorderGradient = false;
            ADFSidePanel.UseMultiGradient = false;
            ADFSidePanel.UsePatternTexture = false;
            ADFSidePanel.UseRadialGradient = false;
            // 
            // ADFMainMenubtn
            // 
            ADFMainMenubtn.BackColor = Color.Transparent;
            ADFMainMenubtn.FlatAppearance.BorderSize = 0;
            ADFMainMenubtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ADFMainMenubtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ADFMainMenubtn.FlatStyle = FlatStyle.Flat;
            ADFMainMenubtn.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADFMainMenubtn.ForeColor = Color.White;
            ADFMainMenubtn.Image = Properties.Resources.menu_burger32bt;
            ADFMainMenubtn.Location = new Point(5, 5);
            ADFMainMenubtn.Margin = new Padding(0);
            ADFMainMenubtn.Name = "ADFMainMenubtn";
            ADFMainMenubtn.Size = new Size(50, 50);
            ADFMainMenubtn.TabIndex = 6;
            ADFMainMenubtn.TextAlign = ContentAlignment.MiddleLeft;
            ADFMainMenubtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ADFMainMenubtn.UseVisualStyleBackColor = false;
            ADFMainMenubtn.Click += ADFMainMenubtn_Click;
            // 
            // ADFSidebarPanel
            // 
            ADFSidebarPanel.BackColor = Color.LightGreen;
            ADFSidebarPanel.Controls.Add(ADFSidePanel);
            ADFSidebarPanel.Dock = DockStyle.Left;
            ADFSidebarPanel.Location = new Point(0, 0);
            ADFSidebarPanel.Margin = new Padding(0);
            ADFSidebarPanel.MaximumSize = new Size(80, 640);
            ADFSidebarPanel.MinimumSize = new Size(80, 640);
            ADFSidebarPanel.Name = "ADFSidebarPanel";
            ADFSidebarPanel.Size = new Size(80, 640);
            ADFSidebarPanel.TabIndex = 5;
            // 
            // ADFSideBarTimer
            // 
            ADFSideBarTimer.Enabled = true;
            ADFSideBarTimer.Interval = 1;
            ADFSideBarTimer.Tick += ADFSideBarTimer_Tick;
            // 
            // ADFMonitorUsersbtn
            // 
            ADFMonitorUsersbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ADFMonitorUsersbtn.AccessibleName = "";
            ADFMonitorUsersbtn.AutoSizeBasedOnText = false;
            ADFMonitorUsersbtn.BackColor = Color.Transparent;
            ADFMonitorUsersbtn.BadgeBackColor = Color.Red;
            ADFMonitorUsersbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ADFMonitorUsersbtn.BadgeValue = 0;
            ADFMonitorUsersbtn.BadgeValueForeColor = Color.White;
            ADFMonitorUsersbtn.BorderColor = Color.Transparent;
            ADFMonitorUsersbtn.BorderWidth = 2;
            ADFMonitorUsersbtn.ButtonBackColor = Color.Green;
            ADFMonitorUsersbtn.ButtonImage = (Image)resources.GetObject("ADFMonitorUsersbtn.ButtonImage");
            ADFMonitorUsersbtn.CanBeep = true;
            ADFMonitorUsersbtn.CanGlow = false;
            ADFMonitorUsersbtn.CanShake = true;
            ADFMonitorUsersbtn.ContextMenuStripEx = null;
            ADFMonitorUsersbtn.CornerRadiusBottomLeft = 23;
            ADFMonitorUsersbtn.CornerRadiusBottomRight = 23;
            ADFMonitorUsersbtn.CornerRadiusTopLeft = 23;
            ADFMonitorUsersbtn.CornerRadiusTopRight = 23;
            ADFMonitorUsersbtn.CustomCursor = Cursors.Default;
            ADFMonitorUsersbtn.DisabledTextColor = Color.Gray;
            ADFMonitorUsersbtn.EnableLongPress = false;
            ADFMonitorUsersbtn.EnablePressAnimation = true;
            ADFMonitorUsersbtn.EnableRippleEffect = true;
            ADFMonitorUsersbtn.EnableShadow = false;
            ADFMonitorUsersbtn.EnableTextWrapping = false;
            ADFMonitorUsersbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADFMonitorUsersbtn.ForeColor = Color.White;
            ADFMonitorUsersbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ADFMonitorUsersbtn.GlowIntensity = 100;
            ADFMonitorUsersbtn.GlowRadius = 20F;
            ADFMonitorUsersbtn.GradientBackground = false;
            ADFMonitorUsersbtn.GradientColor = Color.FromArgb(114, 168, 255);
            ADFMonitorUsersbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ADFMonitorUsersbtn.HintText = null;
            ADFMonitorUsersbtn.HoverBackColor = Color.SeaGreen;
            ADFMonitorUsersbtn.HoverFontStyle = FontStyle.Regular;
            ADFMonitorUsersbtn.HoverTextColor = Color.White;
            ADFMonitorUsersbtn.HoverTransitionDuration = 250;
            ADFMonitorUsersbtn.ImageAlign = ContentAlignment.MiddleCenter;
            ADFMonitorUsersbtn.ImagePadding = 0;
            ADFMonitorUsersbtn.ImageSize = new Size(30, 30);
            ADFMonitorUsersbtn.IsRadial = true;
            ADFMonitorUsersbtn.IsReadOnly = false;
            ADFMonitorUsersbtn.IsToggleButton = false;
            ADFMonitorUsersbtn.IsToggled = false;
            ADFMonitorUsersbtn.Location = new Point(5, 219);
            ADFMonitorUsersbtn.LongPressDurationMS = 1000;
            ADFMonitorUsersbtn.Margin = new Padding(0);
            ADFMonitorUsersbtn.Name = "ADFMonitorUsersbtn";
            ADFMonitorUsersbtn.NormalFontStyle = FontStyle.Regular;
            ADFMonitorUsersbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ADFMonitorUsersbtn.ParticleCount = 15;
            ADFMonitorUsersbtn.PressAnimationScale = 0.97F;
            ADFMonitorUsersbtn.PressedBackColor = Color.LightGreen;
            ADFMonitorUsersbtn.PressedFontStyle = FontStyle.Regular;
            ADFMonitorUsersbtn.PressTransitionDuration = 150;
            ADFMonitorUsersbtn.ReadOnlyTextColor = Color.White;
            ADFMonitorUsersbtn.RippleColor = Color.FromArgb(255, 255, 255);
            ADFMonitorUsersbtn.RippleOpacity = 0.3F;
            ADFMonitorUsersbtn.RippleRadiusMultiplier = 0.6F;
            ADFMonitorUsersbtn.ShadowBlur = 5;
            ADFMonitorUsersbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ADFMonitorUsersbtn.ShadowOffset = new Point(2, 2);
            ADFMonitorUsersbtn.ShakeDuration = 500;
            ADFMonitorUsersbtn.ShakeIntensity = 5;
            ADFMonitorUsersbtn.Size = new Size(50, 50);
            ADFMonitorUsersbtn.TabIndex = 7;
            ADFMonitorUsersbtn.TextAlign = ContentAlignment.MiddleCenter;
            ADFMonitorUsersbtn.TextColor = Color.White;
            ADFMonitorUsersbtn.TooltipText = null;
            ADFMonitorUsersbtn.UseAdvancedRendering = true;
            ADFMonitorUsersbtn.UseParticles = false;
            ADFMonitorUsersbtn.Click += ADFMonitorUsersbtn_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1000, 640);
            Controls.Add(ADFMainPanel);
            Controls.Add(ADFTopbarPanel);
            Controls.Add(ADFSidebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            ADFTopbarPanel.ResumeLayout(false);
            ADFSidePanel.ResumeLayout(false);
            ADFSidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel ADFTopbarPanel;
        private SiticoneNetCoreUI.SiticoneCloseButton ADFClosebtn;
        private Panel ADFMainPanel;
        private SiticoneNetCoreUI.SiticonePanel ADFSidePanel;
        private Button ADFMainMenubtn;
        private Panel ADFSidebarPanel;
        private System.Windows.Forms.Timer ADFSideBarTimer;
        private SiticoneNetCoreUI.SiticoneButton ADFSignoutbtn;
        private SiticoneNetCoreUI.SiticoneButton ADFReviewSubmissionbtn;
        private SiticoneNetCoreUI.SiticoneButton ADFManageUsersbtn;
        private SiticoneNetCoreUI.SiticoneButton ADFManageChallengesbtn;
        private SiticoneNetCoreUI.SiticoneButton ADFHomebtn;
        private SiticoneNetCoreUI.SiticoneButton ADFReportsAnalyticsbtn;
        private SiticoneNetCoreUI.SiticoneButton ADFMonitorUsersbtn;
    }
}