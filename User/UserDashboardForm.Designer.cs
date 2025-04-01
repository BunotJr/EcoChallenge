namespace EcoChallenge
{
    partial class UserDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboardForm));
            UDFTopbarPanel = new Panel();
            UDFClosebtn = new SiticoneNetCoreUI.SiticoneCloseButton();
            UDFMainPanel = new Panel();
            UDFInformationbtn = new SiticoneNetCoreUI.SiticoneButton();
            UDFSignoutbtn = new SiticoneNetCoreUI.SiticoneButton();
            UDFHomebtn = new SiticoneNetCoreUI.SiticoneButton();
            UDFRewardsBadgesbtn = new SiticoneNetCoreUI.SiticoneButton();
            UDFExploreChallengesbtn = new SiticoneNetCoreUI.SiticoneButton();
            UDFTrackProgressbtn = new SiticoneNetCoreUI.SiticoneButton();
            UDFSidePanel = new SiticoneNetCoreUI.SiticonePanel();
            UDFMainMenubtn = new Button();
            UDFSidebarPanel = new Panel();
            UDFSideBarTimer = new System.Windows.Forms.Timer(components);
            UDFTopbarPanel.SuspendLayout();
            UDFSidePanel.SuspendLayout();
            UDFSidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UDFTopbarPanel
            // 
            UDFTopbarPanel.BackColor = Color.LightGreen;
            UDFTopbarPanel.Controls.Add(UDFClosebtn);
            UDFTopbarPanel.Dock = DockStyle.Top;
            UDFTopbarPanel.Location = new Point(80, 0);
            UDFTopbarPanel.Margin = new Padding(2);
            UDFTopbarPanel.Name = "UDFTopbarPanel";
            UDFTopbarPanel.Size = new Size(920, 45);
            UDFTopbarPanel.TabIndex = 9;
            // 
            // UDFClosebtn
            // 
            UDFClosebtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UDFClosebtn.BackColor = Color.Transparent;
            UDFClosebtn.CountdownFont = new Font("Segoe UI", 9F);
            UDFClosebtn.Cursor = Cursors.Default;
            UDFClosebtn.EnableSound = false;
            UDFClosebtn.IconColor = Color.Green;
            UDFClosebtn.IconSize = 20;
            UDFClosebtn.IconThickness = 4;
            UDFClosebtn.Location = new Point(879, 5);
            UDFClosebtn.Margin = new Padding(0);
            UDFClosebtn.Name = "UDFClosebtn";
            UDFClosebtn.Size = new Size(36, 36);
            UDFClosebtn.TabIndex = 1;
            UDFClosebtn.TooltipText = "Close button";
            UDFClosebtn.Click += UDFClosebtn_Click;
            // 
            // UDFMainPanel
            // 
            UDFMainPanel.BackColor = Color.LightGreen;
            UDFMainPanel.Dock = DockStyle.Fill;
            UDFMainPanel.Location = new Point(80, 45);
            UDFMainPanel.Margin = new Padding(0);
            UDFMainPanel.Name = "UDFMainPanel";
            UDFMainPanel.Size = new Size(920, 595);
            UDFMainPanel.TabIndex = 10;
            // 
            // UDFInformationbtn
            // 
            UDFInformationbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UDFInformationbtn.AccessibleName = "";
            UDFInformationbtn.AutoSizeBasedOnText = false;
            UDFInformationbtn.BackColor = Color.Transparent;
            UDFInformationbtn.BadgeBackColor = Color.Red;
            UDFInformationbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UDFInformationbtn.BadgeValue = 0;
            UDFInformationbtn.BadgeValueForeColor = Color.White;
            UDFInformationbtn.BorderColor = Color.Transparent;
            UDFInformationbtn.BorderWidth = 2;
            UDFInformationbtn.ButtonBackColor = Color.Green;
            UDFInformationbtn.ButtonImage = (Image)resources.GetObject("UDFInformationbtn.ButtonImage");
            UDFInformationbtn.CanBeep = true;
            UDFInformationbtn.CanGlow = false;
            UDFInformationbtn.CanShake = true;
            UDFInformationbtn.ContextMenuStripEx = null;
            UDFInformationbtn.CornerRadiusBottomLeft = 23;
            UDFInformationbtn.CornerRadiusBottomRight = 23;
            UDFInformationbtn.CornerRadiusTopLeft = 23;
            UDFInformationbtn.CornerRadiusTopRight = 23;
            UDFInformationbtn.CustomCursor = Cursors.Default;
            UDFInformationbtn.DisabledTextColor = Color.Gray;
            UDFInformationbtn.EnableLongPress = false;
            UDFInformationbtn.EnablePressAnimation = true;
            UDFInformationbtn.EnableRippleEffect = true;
            UDFInformationbtn.EnableShadow = false;
            UDFInformationbtn.EnableTextWrapping = false;
            UDFInformationbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UDFInformationbtn.ForeColor = Color.White;
            UDFInformationbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UDFInformationbtn.GlowIntensity = 100;
            UDFInformationbtn.GlowRadius = 20F;
            UDFInformationbtn.GradientBackground = false;
            UDFInformationbtn.GradientColor = Color.FromArgb(114, 168, 255);
            UDFInformationbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UDFInformationbtn.HintText = null;
            UDFInformationbtn.HoverBackColor = Color.SeaGreen;
            UDFInformationbtn.HoverFontStyle = FontStyle.Regular;
            UDFInformationbtn.HoverTextColor = Color.White;
            UDFInformationbtn.HoverTransitionDuration = 250;
            UDFInformationbtn.ImageAlign = ContentAlignment.MiddleCenter;
            UDFInformationbtn.ImagePadding = 0;
            UDFInformationbtn.ImageSize = new Size(30, 30);
            UDFInformationbtn.IsRadial = true;
            UDFInformationbtn.IsReadOnly = false;
            UDFInformationbtn.IsToggleButton = false;
            UDFInformationbtn.IsToggled = false;
            UDFInformationbtn.Location = new Point(5, 269);
            UDFInformationbtn.LongPressDurationMS = 1000;
            UDFInformationbtn.Margin = new Padding(0);
            UDFInformationbtn.Name = "UDFInformationbtn";
            UDFInformationbtn.NormalFontStyle = FontStyle.Regular;
            UDFInformationbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UDFInformationbtn.ParticleCount = 15;
            UDFInformationbtn.PressAnimationScale = 0.97F;
            UDFInformationbtn.PressedBackColor = Color.LightGreen;
            UDFInformationbtn.PressedFontStyle = FontStyle.Regular;
            UDFInformationbtn.PressTransitionDuration = 150;
            UDFInformationbtn.ReadOnlyTextColor = Color.White;
            UDFInformationbtn.RippleColor = Color.FromArgb(255, 255, 255);
            UDFInformationbtn.RippleOpacity = 0.3F;
            UDFInformationbtn.RippleRadiusMultiplier = 0.6F;
            UDFInformationbtn.ShadowBlur = 5;
            UDFInformationbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UDFInformationbtn.ShadowOffset = new Point(2, 2);
            UDFInformationbtn.ShakeDuration = 500;
            UDFInformationbtn.ShakeIntensity = 5;
            UDFInformationbtn.Size = new Size(50, 50);
            UDFInformationbtn.TabIndex = 7;
            UDFInformationbtn.TextAlign = ContentAlignment.MiddleCenter;
            UDFInformationbtn.TextColor = Color.White;
            UDFInformationbtn.TooltipText = null;
            UDFInformationbtn.UseAdvancedRendering = true;
            UDFInformationbtn.UseParticles = false;
            UDFInformationbtn.Click += UDFInformationbtn_Click;
            // 
            // UDFSignoutbtn
            // 
            UDFSignoutbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UDFSignoutbtn.AccessibleName = "";
            UDFSignoutbtn.AutoSizeBasedOnText = false;
            UDFSignoutbtn.BackColor = Color.Transparent;
            UDFSignoutbtn.BadgeBackColor = Color.Red;
            UDFSignoutbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UDFSignoutbtn.BadgeValue = 0;
            UDFSignoutbtn.BadgeValueForeColor = Color.White;
            UDFSignoutbtn.BorderColor = Color.Transparent;
            UDFSignoutbtn.BorderWidth = 2;
            UDFSignoutbtn.ButtonBackColor = Color.Green;
            UDFSignoutbtn.ButtonImage = (Image)resources.GetObject("UDFSignoutbtn.ButtonImage");
            UDFSignoutbtn.CanBeep = true;
            UDFSignoutbtn.CanGlow = false;
            UDFSignoutbtn.CanShake = true;
            UDFSignoutbtn.ContextMenuStripEx = null;
            UDFSignoutbtn.CornerRadiusBottomLeft = 23;
            UDFSignoutbtn.CornerRadiusBottomRight = 23;
            UDFSignoutbtn.CornerRadiusTopLeft = 23;
            UDFSignoutbtn.CornerRadiusTopRight = 23;
            UDFSignoutbtn.CustomCursor = Cursors.Default;
            UDFSignoutbtn.DisabledTextColor = Color.Gray;
            UDFSignoutbtn.EnableLongPress = false;
            UDFSignoutbtn.EnablePressAnimation = true;
            UDFSignoutbtn.EnableRippleEffect = true;
            UDFSignoutbtn.EnableShadow = false;
            UDFSignoutbtn.EnableTextWrapping = false;
            UDFSignoutbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UDFSignoutbtn.ForeColor = Color.White;
            UDFSignoutbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UDFSignoutbtn.GlowIntensity = 100;
            UDFSignoutbtn.GlowRadius = 20F;
            UDFSignoutbtn.GradientBackground = false;
            UDFSignoutbtn.GradientColor = Color.FromArgb(114, 168, 255);
            UDFSignoutbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UDFSignoutbtn.HintText = null;
            UDFSignoutbtn.HoverBackColor = Color.SeaGreen;
            UDFSignoutbtn.HoverFontStyle = FontStyle.Regular;
            UDFSignoutbtn.HoverTextColor = Color.White;
            UDFSignoutbtn.HoverTransitionDuration = 250;
            UDFSignoutbtn.ImageAlign = ContentAlignment.MiddleCenter;
            UDFSignoutbtn.ImagePadding = 0;
            UDFSignoutbtn.ImageSize = new Size(30, 30);
            UDFSignoutbtn.IsRadial = true;
            UDFSignoutbtn.IsReadOnly = false;
            UDFSignoutbtn.IsToggleButton = false;
            UDFSignoutbtn.IsToggled = false;
            UDFSignoutbtn.Location = new Point(5, 319);
            UDFSignoutbtn.LongPressDurationMS = 1000;
            UDFSignoutbtn.Margin = new Padding(0);
            UDFSignoutbtn.Name = "UDFSignoutbtn";
            UDFSignoutbtn.NormalFontStyle = FontStyle.Regular;
            UDFSignoutbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UDFSignoutbtn.ParticleCount = 15;
            UDFSignoutbtn.PressAnimationScale = 0.97F;
            UDFSignoutbtn.PressedBackColor = Color.LightGreen;
            UDFSignoutbtn.PressedFontStyle = FontStyle.Regular;
            UDFSignoutbtn.PressTransitionDuration = 150;
            UDFSignoutbtn.ReadOnlyTextColor = Color.White;
            UDFSignoutbtn.RippleColor = Color.FromArgb(255, 255, 255);
            UDFSignoutbtn.RippleOpacity = 0.3F;
            UDFSignoutbtn.RippleRadiusMultiplier = 0.6F;
            UDFSignoutbtn.ShadowBlur = 5;
            UDFSignoutbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UDFSignoutbtn.ShadowOffset = new Point(2, 2);
            UDFSignoutbtn.ShakeDuration = 500;
            UDFSignoutbtn.ShakeIntensity = 5;
            UDFSignoutbtn.Size = new Size(50, 50);
            UDFSignoutbtn.TabIndex = 7;
            UDFSignoutbtn.TextAlign = ContentAlignment.MiddleCenter;
            UDFSignoutbtn.TextColor = Color.White;
            UDFSignoutbtn.TooltipText = null;
            UDFSignoutbtn.UseAdvancedRendering = true;
            UDFSignoutbtn.UseParticles = false;
            UDFSignoutbtn.Click += UDFSignoutbtn_Click;
            // 
            // UDFHomebtn
            // 
            UDFHomebtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UDFHomebtn.AccessibleName = "";
            UDFHomebtn.AutoSizeBasedOnText = false;
            UDFHomebtn.BackColor = Color.Transparent;
            UDFHomebtn.BadgeBackColor = Color.Red;
            UDFHomebtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UDFHomebtn.BadgeValue = 0;
            UDFHomebtn.BadgeValueForeColor = Color.White;
            UDFHomebtn.BorderColor = Color.Transparent;
            UDFHomebtn.BorderWidth = 2;
            UDFHomebtn.ButtonBackColor = Color.Green;
            UDFHomebtn.ButtonImage = (Image)resources.GetObject("UDFHomebtn.ButtonImage");
            UDFHomebtn.CanBeep = true;
            UDFHomebtn.CanGlow = false;
            UDFHomebtn.CanShake = true;
            UDFHomebtn.ContextMenuStripEx = null;
            UDFHomebtn.CornerRadiusBottomLeft = 23;
            UDFHomebtn.CornerRadiusBottomRight = 23;
            UDFHomebtn.CornerRadiusTopLeft = 23;
            UDFHomebtn.CornerRadiusTopRight = 23;
            UDFHomebtn.CustomCursor = Cursors.Default;
            UDFHomebtn.DisabledTextColor = Color.Gray;
            UDFHomebtn.EnableLongPress = false;
            UDFHomebtn.EnablePressAnimation = true;
            UDFHomebtn.EnableRippleEffect = true;
            UDFHomebtn.EnableShadow = false;
            UDFHomebtn.EnableTextWrapping = false;
            UDFHomebtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UDFHomebtn.ForeColor = Color.White;
            UDFHomebtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UDFHomebtn.GlowIntensity = 100;
            UDFHomebtn.GlowRadius = 20F;
            UDFHomebtn.GradientBackground = false;
            UDFHomebtn.GradientColor = Color.FromArgb(114, 168, 255);
            UDFHomebtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UDFHomebtn.HintText = null;
            UDFHomebtn.HoverBackColor = Color.SeaGreen;
            UDFHomebtn.HoverFontStyle = FontStyle.Regular;
            UDFHomebtn.HoverTextColor = Color.White;
            UDFHomebtn.HoverTransitionDuration = 250;
            UDFHomebtn.ImageAlign = ContentAlignment.MiddleCenter;
            UDFHomebtn.ImagePadding = 0;
            UDFHomebtn.ImageSize = new Size(30, 30);
            UDFHomebtn.IsRadial = true;
            UDFHomebtn.IsReadOnly = false;
            UDFHomebtn.IsToggleButton = false;
            UDFHomebtn.IsToggled = false;
            UDFHomebtn.Location = new Point(5, 69);
            UDFHomebtn.LongPressDurationMS = 1000;
            UDFHomebtn.Margin = new Padding(0);
            UDFHomebtn.Name = "UDFHomebtn";
            UDFHomebtn.NormalFontStyle = FontStyle.Regular;
            UDFHomebtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UDFHomebtn.ParticleCount = 15;
            UDFHomebtn.PressAnimationScale = 0.97F;
            UDFHomebtn.PressedBackColor = Color.LightGreen;
            UDFHomebtn.PressedFontStyle = FontStyle.Regular;
            UDFHomebtn.PressTransitionDuration = 150;
            UDFHomebtn.ReadOnlyTextColor = Color.White;
            UDFHomebtn.RippleColor = Color.FromArgb(255, 255, 255);
            UDFHomebtn.RippleOpacity = 0.3F;
            UDFHomebtn.RippleRadiusMultiplier = 0.6F;
            UDFHomebtn.ShadowBlur = 5;
            UDFHomebtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UDFHomebtn.ShadowOffset = new Point(2, 2);
            UDFHomebtn.ShakeDuration = 500;
            UDFHomebtn.ShakeIntensity = 5;
            UDFHomebtn.Size = new Size(50, 50);
            UDFHomebtn.TabIndex = 7;
            UDFHomebtn.TextAlign = ContentAlignment.MiddleCenter;
            UDFHomebtn.TextColor = Color.White;
            UDFHomebtn.TooltipText = null;
            UDFHomebtn.UseAdvancedRendering = true;
            UDFHomebtn.UseParticles = false;
            UDFHomebtn.Click += UDFHomebtn_Click;
            // 
            // UDFRewardsBadgesbtn
            // 
            UDFRewardsBadgesbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UDFRewardsBadgesbtn.AccessibleName = "";
            UDFRewardsBadgesbtn.AutoSizeBasedOnText = false;
            UDFRewardsBadgesbtn.BackColor = Color.Transparent;
            UDFRewardsBadgesbtn.BadgeBackColor = Color.Red;
            UDFRewardsBadgesbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UDFRewardsBadgesbtn.BadgeValue = 0;
            UDFRewardsBadgesbtn.BadgeValueForeColor = Color.White;
            UDFRewardsBadgesbtn.BorderColor = Color.Transparent;
            UDFRewardsBadgesbtn.BorderWidth = 2;
            UDFRewardsBadgesbtn.ButtonBackColor = Color.Green;
            UDFRewardsBadgesbtn.ButtonImage = (Image)resources.GetObject("UDFRewardsBadgesbtn.ButtonImage");
            UDFRewardsBadgesbtn.CanBeep = true;
            UDFRewardsBadgesbtn.CanGlow = false;
            UDFRewardsBadgesbtn.CanShake = true;
            UDFRewardsBadgesbtn.ContextMenuStripEx = null;
            UDFRewardsBadgesbtn.CornerRadiusBottomLeft = 23;
            UDFRewardsBadgesbtn.CornerRadiusBottomRight = 23;
            UDFRewardsBadgesbtn.CornerRadiusTopLeft = 23;
            UDFRewardsBadgesbtn.CornerRadiusTopRight = 23;
            UDFRewardsBadgesbtn.CustomCursor = Cursors.Default;
            UDFRewardsBadgesbtn.DisabledTextColor = Color.Gray;
            UDFRewardsBadgesbtn.EnableLongPress = false;
            UDFRewardsBadgesbtn.EnablePressAnimation = true;
            UDFRewardsBadgesbtn.EnableRippleEffect = true;
            UDFRewardsBadgesbtn.EnableShadow = false;
            UDFRewardsBadgesbtn.EnableTextWrapping = false;
            UDFRewardsBadgesbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UDFRewardsBadgesbtn.ForeColor = Color.White;
            UDFRewardsBadgesbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UDFRewardsBadgesbtn.GlowIntensity = 100;
            UDFRewardsBadgesbtn.GlowRadius = 20F;
            UDFRewardsBadgesbtn.GradientBackground = false;
            UDFRewardsBadgesbtn.GradientColor = Color.FromArgb(114, 168, 255);
            UDFRewardsBadgesbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UDFRewardsBadgesbtn.HintText = null;
            UDFRewardsBadgesbtn.HoverBackColor = Color.SeaGreen;
            UDFRewardsBadgesbtn.HoverFontStyle = FontStyle.Regular;
            UDFRewardsBadgesbtn.HoverTextColor = Color.White;
            UDFRewardsBadgesbtn.HoverTransitionDuration = 250;
            UDFRewardsBadgesbtn.ImageAlign = ContentAlignment.MiddleCenter;
            UDFRewardsBadgesbtn.ImagePadding = 0;
            UDFRewardsBadgesbtn.ImageSize = new Size(30, 30);
            UDFRewardsBadgesbtn.IsRadial = true;
            UDFRewardsBadgesbtn.IsReadOnly = false;
            UDFRewardsBadgesbtn.IsToggleButton = false;
            UDFRewardsBadgesbtn.IsToggled = false;
            UDFRewardsBadgesbtn.Location = new Point(5, 219);
            UDFRewardsBadgesbtn.LongPressDurationMS = 1000;
            UDFRewardsBadgesbtn.Margin = new Padding(0);
            UDFRewardsBadgesbtn.Name = "UDFRewardsBadgesbtn";
            UDFRewardsBadgesbtn.NormalFontStyle = FontStyle.Regular;
            UDFRewardsBadgesbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UDFRewardsBadgesbtn.ParticleCount = 15;
            UDFRewardsBadgesbtn.PressAnimationScale = 0.97F;
            UDFRewardsBadgesbtn.PressedBackColor = Color.LightGreen;
            UDFRewardsBadgesbtn.PressedFontStyle = FontStyle.Regular;
            UDFRewardsBadgesbtn.PressTransitionDuration = 150;
            UDFRewardsBadgesbtn.ReadOnlyTextColor = Color.White;
            UDFRewardsBadgesbtn.RippleColor = Color.FromArgb(255, 255, 255);
            UDFRewardsBadgesbtn.RippleOpacity = 0.3F;
            UDFRewardsBadgesbtn.RippleRadiusMultiplier = 0.6F;
            UDFRewardsBadgesbtn.ShadowBlur = 5;
            UDFRewardsBadgesbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UDFRewardsBadgesbtn.ShadowOffset = new Point(2, 2);
            UDFRewardsBadgesbtn.ShakeDuration = 500;
            UDFRewardsBadgesbtn.ShakeIntensity = 5;
            UDFRewardsBadgesbtn.Size = new Size(50, 50);
            UDFRewardsBadgesbtn.TabIndex = 7;
            UDFRewardsBadgesbtn.TextAlign = ContentAlignment.MiddleCenter;
            UDFRewardsBadgesbtn.TextColor = Color.White;
            UDFRewardsBadgesbtn.TooltipText = null;
            UDFRewardsBadgesbtn.UseAdvancedRendering = true;
            UDFRewardsBadgesbtn.UseParticles = false;
            UDFRewardsBadgesbtn.Click += UDFRewardsBadgesbtn_Click;
            // 
            // UDFExploreChallengesbtn
            // 
            UDFExploreChallengesbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UDFExploreChallengesbtn.AccessibleName = "";
            UDFExploreChallengesbtn.AutoSizeBasedOnText = false;
            UDFExploreChallengesbtn.BackColor = Color.Transparent;
            UDFExploreChallengesbtn.BadgeBackColor = Color.Red;
            UDFExploreChallengesbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UDFExploreChallengesbtn.BadgeValue = 0;
            UDFExploreChallengesbtn.BadgeValueForeColor = Color.White;
            UDFExploreChallengesbtn.BorderColor = Color.Transparent;
            UDFExploreChallengesbtn.BorderWidth = 2;
            UDFExploreChallengesbtn.ButtonBackColor = Color.Green;
            UDFExploreChallengesbtn.ButtonImage = (Image)resources.GetObject("UDFExploreChallengesbtn.ButtonImage");
            UDFExploreChallengesbtn.CanBeep = true;
            UDFExploreChallengesbtn.CanGlow = false;
            UDFExploreChallengesbtn.CanShake = true;
            UDFExploreChallengesbtn.ContextMenuStripEx = null;
            UDFExploreChallengesbtn.CornerRadiusBottomLeft = 23;
            UDFExploreChallengesbtn.CornerRadiusBottomRight = 23;
            UDFExploreChallengesbtn.CornerRadiusTopLeft = 23;
            UDFExploreChallengesbtn.CornerRadiusTopRight = 23;
            UDFExploreChallengesbtn.CustomCursor = Cursors.Default;
            UDFExploreChallengesbtn.DisabledTextColor = Color.Gray;
            UDFExploreChallengesbtn.EnableLongPress = false;
            UDFExploreChallengesbtn.EnablePressAnimation = true;
            UDFExploreChallengesbtn.EnableRippleEffect = true;
            UDFExploreChallengesbtn.EnableShadow = false;
            UDFExploreChallengesbtn.EnableTextWrapping = false;
            UDFExploreChallengesbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UDFExploreChallengesbtn.ForeColor = Color.White;
            UDFExploreChallengesbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UDFExploreChallengesbtn.GlowIntensity = 100;
            UDFExploreChallengesbtn.GlowRadius = 20F;
            UDFExploreChallengesbtn.GradientBackground = false;
            UDFExploreChallengesbtn.GradientColor = Color.FromArgb(114, 168, 255);
            UDFExploreChallengesbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UDFExploreChallengesbtn.HintText = null;
            UDFExploreChallengesbtn.HoverBackColor = Color.SeaGreen;
            UDFExploreChallengesbtn.HoverFontStyle = FontStyle.Regular;
            UDFExploreChallengesbtn.HoverTextColor = Color.White;
            UDFExploreChallengesbtn.HoverTransitionDuration = 250;
            UDFExploreChallengesbtn.ImageAlign = ContentAlignment.MiddleCenter;
            UDFExploreChallengesbtn.ImagePadding = 0;
            UDFExploreChallengesbtn.ImageSize = new Size(30, 30);
            UDFExploreChallengesbtn.IsRadial = true;
            UDFExploreChallengesbtn.IsReadOnly = false;
            UDFExploreChallengesbtn.IsToggleButton = false;
            UDFExploreChallengesbtn.IsToggled = false;
            UDFExploreChallengesbtn.Location = new Point(5, 119);
            UDFExploreChallengesbtn.LongPressDurationMS = 1000;
            UDFExploreChallengesbtn.Margin = new Padding(0);
            UDFExploreChallengesbtn.Name = "UDFExploreChallengesbtn";
            UDFExploreChallengesbtn.NormalFontStyle = FontStyle.Regular;
            UDFExploreChallengesbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UDFExploreChallengesbtn.ParticleCount = 15;
            UDFExploreChallengesbtn.PressAnimationScale = 0.97F;
            UDFExploreChallengesbtn.PressedBackColor = Color.LightGreen;
            UDFExploreChallengesbtn.PressedFontStyle = FontStyle.Regular;
            UDFExploreChallengesbtn.PressTransitionDuration = 150;
            UDFExploreChallengesbtn.ReadOnlyTextColor = Color.White;
            UDFExploreChallengesbtn.RippleColor = Color.FromArgb(255, 255, 255);
            UDFExploreChallengesbtn.RippleOpacity = 0.3F;
            UDFExploreChallengesbtn.RippleRadiusMultiplier = 0.6F;
            UDFExploreChallengesbtn.ShadowBlur = 5;
            UDFExploreChallengesbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UDFExploreChallengesbtn.ShadowOffset = new Point(2, 2);
            UDFExploreChallengesbtn.ShakeDuration = 500;
            UDFExploreChallengesbtn.ShakeIntensity = 5;
            UDFExploreChallengesbtn.Size = new Size(50, 50);
            UDFExploreChallengesbtn.TabIndex = 7;
            UDFExploreChallengesbtn.TextAlign = ContentAlignment.MiddleCenter;
            UDFExploreChallengesbtn.TextColor = Color.White;
            UDFExploreChallengesbtn.TooltipText = null;
            UDFExploreChallengesbtn.UseAdvancedRendering = true;
            UDFExploreChallengesbtn.UseParticles = false;
            UDFExploreChallengesbtn.Click += UDFExploreChallengesbtn_Click;
            // 
            // UDFTrackProgressbtn
            // 
            UDFTrackProgressbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UDFTrackProgressbtn.AccessibleName = "";
            UDFTrackProgressbtn.AutoSizeBasedOnText = false;
            UDFTrackProgressbtn.BackColor = Color.Transparent;
            UDFTrackProgressbtn.BadgeBackColor = Color.Red;
            UDFTrackProgressbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UDFTrackProgressbtn.BadgeValue = 0;
            UDFTrackProgressbtn.BadgeValueForeColor = Color.White;
            UDFTrackProgressbtn.BorderColor = Color.Transparent;
            UDFTrackProgressbtn.BorderWidth = 2;
            UDFTrackProgressbtn.ButtonBackColor = Color.Green;
            UDFTrackProgressbtn.ButtonImage = (Image)resources.GetObject("UDFTrackProgressbtn.ButtonImage");
            UDFTrackProgressbtn.CanBeep = true;
            UDFTrackProgressbtn.CanGlow = false;
            UDFTrackProgressbtn.CanShake = true;
            UDFTrackProgressbtn.ContextMenuStripEx = null;
            UDFTrackProgressbtn.CornerRadiusBottomLeft = 23;
            UDFTrackProgressbtn.CornerRadiusBottomRight = 23;
            UDFTrackProgressbtn.CornerRadiusTopLeft = 23;
            UDFTrackProgressbtn.CornerRadiusTopRight = 23;
            UDFTrackProgressbtn.CustomCursor = Cursors.Default;
            UDFTrackProgressbtn.DisabledTextColor = Color.Gray;
            UDFTrackProgressbtn.EnableLongPress = false;
            UDFTrackProgressbtn.EnablePressAnimation = true;
            UDFTrackProgressbtn.EnableRippleEffect = true;
            UDFTrackProgressbtn.EnableShadow = false;
            UDFTrackProgressbtn.EnableTextWrapping = false;
            UDFTrackProgressbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UDFTrackProgressbtn.ForeColor = Color.White;
            UDFTrackProgressbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UDFTrackProgressbtn.GlowIntensity = 100;
            UDFTrackProgressbtn.GlowRadius = 20F;
            UDFTrackProgressbtn.GradientBackground = false;
            UDFTrackProgressbtn.GradientColor = Color.FromArgb(114, 168, 255);
            UDFTrackProgressbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UDFTrackProgressbtn.HintText = null;
            UDFTrackProgressbtn.HoverBackColor = Color.SeaGreen;
            UDFTrackProgressbtn.HoverFontStyle = FontStyle.Regular;
            UDFTrackProgressbtn.HoverTextColor = Color.White;
            UDFTrackProgressbtn.HoverTransitionDuration = 250;
            UDFTrackProgressbtn.ImageAlign = ContentAlignment.MiddleCenter;
            UDFTrackProgressbtn.ImagePadding = 0;
            UDFTrackProgressbtn.ImageSize = new Size(30, 30);
            UDFTrackProgressbtn.IsRadial = true;
            UDFTrackProgressbtn.IsReadOnly = false;
            UDFTrackProgressbtn.IsToggleButton = false;
            UDFTrackProgressbtn.IsToggled = false;
            UDFTrackProgressbtn.Location = new Point(5, 169);
            UDFTrackProgressbtn.LongPressDurationMS = 1000;
            UDFTrackProgressbtn.Margin = new Padding(0);
            UDFTrackProgressbtn.Name = "UDFTrackProgressbtn";
            UDFTrackProgressbtn.NormalFontStyle = FontStyle.Regular;
            UDFTrackProgressbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UDFTrackProgressbtn.ParticleCount = 15;
            UDFTrackProgressbtn.PressAnimationScale = 0.97F;
            UDFTrackProgressbtn.PressedBackColor = Color.LightGreen;
            UDFTrackProgressbtn.PressedFontStyle = FontStyle.Regular;
            UDFTrackProgressbtn.PressTransitionDuration = 150;
            UDFTrackProgressbtn.ReadOnlyTextColor = Color.White;
            UDFTrackProgressbtn.RippleColor = Color.FromArgb(255, 255, 255);
            UDFTrackProgressbtn.RippleOpacity = 0.3F;
            UDFTrackProgressbtn.RippleRadiusMultiplier = 0.6F;
            UDFTrackProgressbtn.ShadowBlur = 5;
            UDFTrackProgressbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UDFTrackProgressbtn.ShadowOffset = new Point(2, 2);
            UDFTrackProgressbtn.ShakeDuration = 500;
            UDFTrackProgressbtn.ShakeIntensity = 5;
            UDFTrackProgressbtn.Size = new Size(50, 50);
            UDFTrackProgressbtn.TabIndex = 7;
            UDFTrackProgressbtn.TextAlign = ContentAlignment.MiddleCenter;
            UDFTrackProgressbtn.TextColor = Color.White;
            UDFTrackProgressbtn.TooltipText = null;
            UDFTrackProgressbtn.UseAdvancedRendering = true;
            UDFTrackProgressbtn.UseParticles = false;
            UDFTrackProgressbtn.Click += UDFTrackProgressbtn_Click;
            // 
            // UDFSidePanel
            // 
            UDFSidePanel.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            UDFSidePanel.BackColor = Color.Transparent;
            UDFSidePanel.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            UDFSidePanel.BorderDashPattern = null;
            UDFSidePanel.BorderGradientEndColor = Color.Purple;
            UDFSidePanel.BorderGradientStartColor = Color.Blue;
            UDFSidePanel.BorderThickness = 2F;
            UDFSidePanel.Controls.Add(UDFInformationbtn);
            UDFSidePanel.Controls.Add(UDFMainMenubtn);
            UDFSidePanel.Controls.Add(UDFSignoutbtn);
            UDFSidePanel.Controls.Add(UDFHomebtn);
            UDFSidePanel.Controls.Add(UDFRewardsBadgesbtn);
            UDFSidePanel.Controls.Add(UDFExploreChallengesbtn);
            UDFSidePanel.Controls.Add(UDFTrackProgressbtn);
            UDFSidePanel.CornerRadiusBottomLeft = 50F;
            UDFSidePanel.CornerRadiusBottomRight = 50F;
            UDFSidePanel.CornerRadiusTopLeft = 50F;
            UDFSidePanel.CornerRadiusTopRight = 50F;
            UDFSidePanel.EnableAcrylicEffect = false;
            UDFSidePanel.EnableMicaEffect = false;
            UDFSidePanel.EnableRippleEffect = false;
            UDFSidePanel.FillColor = Color.Green;
            UDFSidePanel.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            UDFSidePanel.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            UDFSidePanel.Location = new Point(9, 9);
            UDFSidePanel.Margin = new Padding(0);
            UDFSidePanel.MaximumSize = new Size(60, 375);
            UDFSidePanel.MinimumSize = new Size(60, 60);
            UDFSidePanel.Name = "UDFSidePanel";
            UDFSidePanel.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            UDFSidePanel.RippleAlpha = 50;
            UDFSidePanel.RippleAlphaDecrement = 3;
            UDFSidePanel.RippleColor = Color.FromArgb(50, 255, 255, 255);
            UDFSidePanel.RippleMaxSize = 600F;
            UDFSidePanel.RippleSpeed = 15F;
            UDFSidePanel.ShowBorder = true;
            UDFSidePanel.Size = new Size(60, 375);
            UDFSidePanel.TabIndex = 0;
            UDFSidePanel.TabStop = true;
            UDFSidePanel.UseBorderGradient = false;
            UDFSidePanel.UseMultiGradient = false;
            UDFSidePanel.UsePatternTexture = false;
            UDFSidePanel.UseRadialGradient = false;
            // 
            // UDFMainMenubtn
            // 
            UDFMainMenubtn.BackColor = Color.Transparent;
            UDFMainMenubtn.FlatAppearance.BorderSize = 0;
            UDFMainMenubtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            UDFMainMenubtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            UDFMainMenubtn.FlatStyle = FlatStyle.Flat;
            UDFMainMenubtn.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UDFMainMenubtn.ForeColor = Color.White;
            UDFMainMenubtn.Image = Properties.Resources.menu_burger32bt;
            UDFMainMenubtn.Location = new Point(5, 5);
            UDFMainMenubtn.Margin = new Padding(0);
            UDFMainMenubtn.Name = "UDFMainMenubtn";
            UDFMainMenubtn.Size = new Size(50, 50);
            UDFMainMenubtn.TabIndex = 6;
            UDFMainMenubtn.TextAlign = ContentAlignment.MiddleLeft;
            UDFMainMenubtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UDFMainMenubtn.UseVisualStyleBackColor = false;
            UDFMainMenubtn.Click += UDFMainMenubtn_Click;
            // 
            // UDFSidebarPanel
            // 
            UDFSidebarPanel.BackColor = Color.LightGreen;
            UDFSidebarPanel.Controls.Add(UDFSidePanel);
            UDFSidebarPanel.Dock = DockStyle.Left;
            UDFSidebarPanel.Location = new Point(0, 0);
            UDFSidebarPanel.Margin = new Padding(0);
            UDFSidebarPanel.MaximumSize = new Size(80, 640);
            UDFSidebarPanel.MinimumSize = new Size(80, 640);
            UDFSidebarPanel.Name = "UDFSidebarPanel";
            UDFSidebarPanel.Size = new Size(80, 640);
            UDFSidebarPanel.TabIndex = 8;
            // 
            // UDFSideBarTimer
            // 
            UDFSideBarTimer.Enabled = true;
            UDFSideBarTimer.Interval = 1;
            UDFSideBarTimer.Tick += UDFSidebarTimer_Tick;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1000, 640);
            Controls.Add(UDFMainPanel);
            Controls.Add(UDFTopbarPanel);
            Controls.Add(UDFSidebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(1000, 640);
            Name = "UserDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboardForm";
            UDFTopbarPanel.ResumeLayout(false);
            UDFSidePanel.ResumeLayout(false);
            UDFSidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SiticoneNetCoreUI.SiticoneDragPanel siticoneDragPanel1;
        private Panel UDFTopbarPanel;
        private SiticoneNetCoreUI.SiticoneCloseButton UDFClosebtn;
        private Panel UDFMainPanel;
        private SiticoneNetCoreUI.SiticoneButton UDFInformationbtn;
        private SiticoneNetCoreUI.SiticoneButton UDFSignoutbtn;
        private SiticoneNetCoreUI.SiticoneButton UDFHomebtn;
        private SiticoneNetCoreUI.SiticoneButton UDFRewardsBadgesbtn;
        private SiticoneNetCoreUI.SiticoneButton UDFExploreChallengesbtn;
        private SiticoneNetCoreUI.SiticoneButton UDFTrackProgressbtn;
        private SiticoneNetCoreUI.SiticonePanel UDFSidePanel;
        private Button UDFMainMenubtn;
        private Panel UDFSidebarPanel;
        private System.Windows.Forms.Timer UDFSideBarTimer;
    }
}