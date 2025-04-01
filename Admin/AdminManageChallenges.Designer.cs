namespace EcoChallenge
{
    partial class AdminManageChallenges
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
            AMCTitle = new Label();
            AMCCategorybx = new ComboBox();
            AMCAddbtn = new SiticoneNetCoreUI.SiticoneButton();
            AMCLoadbtn = new SiticoneNetCoreUI.SiticoneButton();
            AMCDeletebtn = new SiticoneNetCoreUI.SiticoneButton();
            AMCEditbtn = new SiticoneNetCoreUI.SiticoneButton();
            AMCTitletbx = new SiticoneNetCoreUI.SiticoneTextBox();
            AMCDescriptiontbx = new SiticoneNetCoreUI.SiticoneTextArea();
            AMCMainPanel = new Panel();
            AMCPersonaltxt = new Label();
            AMCCommunitytxt = new Label();
            AMCPersonalChallengesdgv = new DataGridView();
            AMCCommunityChallengesdgv = new DataGridView();
            AMCMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AMCPersonalChallengesdgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AMCCommunityChallengesdgv).BeginInit();
            SuspendLayout();
            // 
            // AMCTitle
            // 
            AMCTitle.AutoSize = true;
            AMCTitle.BackColor = Color.Transparent;
            AMCTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMCTitle.ForeColor = Color.Green;
            AMCTitle.Location = new Point(0, 0);
            AMCTitle.Margin = new Padding(0);
            AMCTitle.Name = "AMCTitle";
            AMCTitle.Size = new Size(329, 53);
            AMCTitle.TabIndex = 0;
            AMCTitle.Text = "Manage Challenges";
            // 
            // AMCCategorybx
            // 
            AMCCategorybx.BackColor = Color.FromArgb(192, 255, 192);
            AMCCategorybx.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AMCCategorybx.ForeColor = Color.FromArgb(0, 64, 0);
            AMCCategorybx.FormattingEnabled = true;
            AMCCategorybx.Items.AddRange(new object[] { "Community", "Personal" });
            AMCCategorybx.Location = new Point(111, 289);
            AMCCategorybx.Margin = new Padding(0);
            AMCCategorybx.Name = "AMCCategorybx";
            AMCCategorybx.Size = new Size(205, 38);
            AMCCategorybx.TabIndex = 7;
            // 
            // AMCAddbtn
            // 
            AMCAddbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AMCAddbtn.AccessibleName = "Add";
            AMCAddbtn.AutoSizeBasedOnText = false;
            AMCAddbtn.BackColor = Color.Transparent;
            AMCAddbtn.BadgeBackColor = Color.Red;
            AMCAddbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AMCAddbtn.BadgeValue = 0;
            AMCAddbtn.BadgeValueForeColor = Color.White;
            AMCAddbtn.BorderColor = Color.Transparent;
            AMCAddbtn.BorderWidth = 2;
            AMCAddbtn.ButtonBackColor = Color.Green;
            AMCAddbtn.ButtonImage = null;
            AMCAddbtn.CanBeep = true;
            AMCAddbtn.CanGlow = false;
            AMCAddbtn.CanShake = true;
            AMCAddbtn.ContextMenuStripEx = null;
            AMCAddbtn.CornerRadiusBottomLeft = 25;
            AMCAddbtn.CornerRadiusBottomRight = 25;
            AMCAddbtn.CornerRadiusTopLeft = 25;
            AMCAddbtn.CornerRadiusTopRight = 25;
            AMCAddbtn.CustomCursor = Cursors.Default;
            AMCAddbtn.DisabledTextColor = Color.Gray;
            AMCAddbtn.EnableLongPress = false;
            AMCAddbtn.EnablePressAnimation = true;
            AMCAddbtn.EnableRippleEffect = true;
            AMCAddbtn.EnableShadow = false;
            AMCAddbtn.EnableTextWrapping = false;
            AMCAddbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMCAddbtn.ForeColor = Color.White;
            AMCAddbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            AMCAddbtn.GlowIntensity = 100;
            AMCAddbtn.GlowRadius = 20F;
            AMCAddbtn.GradientBackground = false;
            AMCAddbtn.GradientColor = Color.FromArgb(114, 168, 255);
            AMCAddbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AMCAddbtn.HintText = null;
            AMCAddbtn.HoverBackColor = Color.SeaGreen;
            AMCAddbtn.HoverFontStyle = FontStyle.Regular;
            AMCAddbtn.HoverTextColor = Color.White;
            AMCAddbtn.HoverTransitionDuration = 250;
            AMCAddbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AMCAddbtn.ImagePadding = 5;
            AMCAddbtn.ImageSize = new Size(16, 16);
            AMCAddbtn.IsRadial = true;
            AMCAddbtn.IsReadOnly = false;
            AMCAddbtn.IsToggleButton = false;
            AMCAddbtn.IsToggled = false;
            AMCAddbtn.Location = new Point(160, 389);
            AMCAddbtn.LongPressDurationMS = 1000;
            AMCAddbtn.Margin = new Padding(0);
            AMCAddbtn.Name = "AMCAddbtn";
            AMCAddbtn.NormalFontStyle = FontStyle.Regular;
            AMCAddbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            AMCAddbtn.ParticleCount = 15;
            AMCAddbtn.PressAnimationScale = 0.97F;
            AMCAddbtn.PressedBackColor = Color.LightGreen;
            AMCAddbtn.PressedFontStyle = FontStyle.Regular;
            AMCAddbtn.PressTransitionDuration = 150;
            AMCAddbtn.ReadOnlyTextColor = Color.White;
            AMCAddbtn.RippleColor = Color.FromArgb(255, 255, 255);
            AMCAddbtn.RippleOpacity = 0.3F;
            AMCAddbtn.RippleRadiusMultiplier = 0.6F;
            AMCAddbtn.ShadowBlur = 5;
            AMCAddbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            AMCAddbtn.ShadowOffset = new Point(2, 2);
            AMCAddbtn.ShakeDuration = 500;
            AMCAddbtn.ShakeIntensity = 5;
            AMCAddbtn.Size = new Size(125, 55);
            AMCAddbtn.TabIndex = 10;
            AMCAddbtn.Text = "Add";
            AMCAddbtn.TextAlign = ContentAlignment.MiddleCenter;
            AMCAddbtn.TextColor = Color.White;
            AMCAddbtn.TooltipText = null;
            AMCAddbtn.UseAdvancedRendering = true;
            AMCAddbtn.UseParticles = false;
            // 
            // AMCLoadbtn
            // 
            AMCLoadbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AMCLoadbtn.AccessibleName = "Load";
            AMCLoadbtn.AutoSizeBasedOnText = false;
            AMCLoadbtn.BackColor = Color.Transparent;
            AMCLoadbtn.BadgeBackColor = Color.Red;
            AMCLoadbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AMCLoadbtn.BadgeValue = 0;
            AMCLoadbtn.BadgeValueForeColor = Color.White;
            AMCLoadbtn.BorderColor = Color.Transparent;
            AMCLoadbtn.BorderWidth = 2;
            AMCLoadbtn.ButtonBackColor = Color.Green;
            AMCLoadbtn.ButtonImage = null;
            AMCLoadbtn.CanBeep = true;
            AMCLoadbtn.CanGlow = false;
            AMCLoadbtn.CanShake = true;
            AMCLoadbtn.ContextMenuStripEx = null;
            AMCLoadbtn.CornerRadiusBottomLeft = 25;
            AMCLoadbtn.CornerRadiusBottomRight = 25;
            AMCLoadbtn.CornerRadiusTopLeft = 25;
            AMCLoadbtn.CornerRadiusTopRight = 25;
            AMCLoadbtn.CustomCursor = Cursors.Default;
            AMCLoadbtn.DisabledTextColor = Color.Gray;
            AMCLoadbtn.EnableLongPress = false;
            AMCLoadbtn.EnablePressAnimation = true;
            AMCLoadbtn.EnableRippleEffect = true;
            AMCLoadbtn.EnableShadow = false;
            AMCLoadbtn.EnableTextWrapping = false;
            AMCLoadbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMCLoadbtn.ForeColor = Color.White;
            AMCLoadbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            AMCLoadbtn.GlowIntensity = 100;
            AMCLoadbtn.GlowRadius = 20F;
            AMCLoadbtn.GradientBackground = false;
            AMCLoadbtn.GradientColor = Color.FromArgb(114, 168, 255);
            AMCLoadbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AMCLoadbtn.HintText = null;
            AMCLoadbtn.HoverBackColor = Color.SeaGreen;
            AMCLoadbtn.HoverFontStyle = FontStyle.Regular;
            AMCLoadbtn.HoverTextColor = Color.White;
            AMCLoadbtn.HoverTransitionDuration = 250;
            AMCLoadbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AMCLoadbtn.ImagePadding = 5;
            AMCLoadbtn.ImageSize = new Size(16, 16);
            AMCLoadbtn.IsRadial = true;
            AMCLoadbtn.IsReadOnly = false;
            AMCLoadbtn.IsToggleButton = false;
            AMCLoadbtn.IsToggled = false;
            AMCLoadbtn.Location = new Point(18, 389);
            AMCLoadbtn.LongPressDurationMS = 1000;
            AMCLoadbtn.Margin = new Padding(0);
            AMCLoadbtn.Name = "AMCLoadbtn";
            AMCLoadbtn.NormalFontStyle = FontStyle.Regular;
            AMCLoadbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            AMCLoadbtn.ParticleCount = 15;
            AMCLoadbtn.PressAnimationScale = 0.97F;
            AMCLoadbtn.PressedBackColor = Color.LightGreen;
            AMCLoadbtn.PressedFontStyle = FontStyle.Regular;
            AMCLoadbtn.PressTransitionDuration = 150;
            AMCLoadbtn.ReadOnlyTextColor = Color.White;
            AMCLoadbtn.RippleColor = Color.FromArgb(255, 255, 255);
            AMCLoadbtn.RippleOpacity = 0.3F;
            AMCLoadbtn.RippleRadiusMultiplier = 0.6F;
            AMCLoadbtn.ShadowBlur = 5;
            AMCLoadbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            AMCLoadbtn.ShadowOffset = new Point(2, 2);
            AMCLoadbtn.ShakeDuration = 500;
            AMCLoadbtn.ShakeIntensity = 5;
            AMCLoadbtn.Size = new Size(125, 55);
            AMCLoadbtn.TabIndex = 10;
            AMCLoadbtn.Text = "Load";
            AMCLoadbtn.TextAlign = ContentAlignment.MiddleCenter;
            AMCLoadbtn.TextColor = Color.White;
            AMCLoadbtn.TooltipText = null;
            AMCLoadbtn.UseAdvancedRendering = true;
            AMCLoadbtn.UseParticles = false;
            // 
            // AMCDeletebtn
            // 
            AMCDeletebtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AMCDeletebtn.AccessibleName = "Delete";
            AMCDeletebtn.AutoSizeBasedOnText = false;
            AMCDeletebtn.BackColor = Color.Transparent;
            AMCDeletebtn.BadgeBackColor = Color.Red;
            AMCDeletebtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AMCDeletebtn.BadgeValue = 0;
            AMCDeletebtn.BadgeValueForeColor = Color.White;
            AMCDeletebtn.BorderColor = Color.Transparent;
            AMCDeletebtn.BorderWidth = 2;
            AMCDeletebtn.ButtonBackColor = Color.Green;
            AMCDeletebtn.ButtonImage = null;
            AMCDeletebtn.CanBeep = true;
            AMCDeletebtn.CanGlow = false;
            AMCDeletebtn.CanShake = true;
            AMCDeletebtn.ContextMenuStripEx = null;
            AMCDeletebtn.CornerRadiusBottomLeft = 25;
            AMCDeletebtn.CornerRadiusBottomRight = 25;
            AMCDeletebtn.CornerRadiusTopLeft = 25;
            AMCDeletebtn.CornerRadiusTopRight = 25;
            AMCDeletebtn.CustomCursor = Cursors.Default;
            AMCDeletebtn.DisabledTextColor = Color.Gray;
            AMCDeletebtn.EnableLongPress = false;
            AMCDeletebtn.EnablePressAnimation = true;
            AMCDeletebtn.EnableRippleEffect = true;
            AMCDeletebtn.EnableShadow = false;
            AMCDeletebtn.EnableTextWrapping = false;
            AMCDeletebtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMCDeletebtn.ForeColor = Color.White;
            AMCDeletebtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            AMCDeletebtn.GlowIntensity = 100;
            AMCDeletebtn.GlowRadius = 20F;
            AMCDeletebtn.GradientBackground = false;
            AMCDeletebtn.GradientColor = Color.FromArgb(114, 168, 255);
            AMCDeletebtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AMCDeletebtn.HintText = null;
            AMCDeletebtn.HoverBackColor = Color.SeaGreen;
            AMCDeletebtn.HoverFontStyle = FontStyle.Regular;
            AMCDeletebtn.HoverTextColor = Color.White;
            AMCDeletebtn.HoverTransitionDuration = 250;
            AMCDeletebtn.ImageAlign = ContentAlignment.MiddleLeft;
            AMCDeletebtn.ImagePadding = 5;
            AMCDeletebtn.ImageSize = new Size(16, 16);
            AMCDeletebtn.IsRadial = true;
            AMCDeletebtn.IsReadOnly = false;
            AMCDeletebtn.IsToggleButton = false;
            AMCDeletebtn.IsToggled = false;
            AMCDeletebtn.Location = new Point(160, 478);
            AMCDeletebtn.LongPressDurationMS = 1000;
            AMCDeletebtn.Margin = new Padding(0);
            AMCDeletebtn.Name = "AMCDeletebtn";
            AMCDeletebtn.NormalFontStyle = FontStyle.Regular;
            AMCDeletebtn.ParticleColor = Color.FromArgb(200, 200, 200);
            AMCDeletebtn.ParticleCount = 15;
            AMCDeletebtn.PressAnimationScale = 0.97F;
            AMCDeletebtn.PressedBackColor = Color.LightGreen;
            AMCDeletebtn.PressedFontStyle = FontStyle.Regular;
            AMCDeletebtn.PressTransitionDuration = 150;
            AMCDeletebtn.ReadOnlyTextColor = Color.White;
            AMCDeletebtn.RippleColor = Color.FromArgb(255, 255, 255);
            AMCDeletebtn.RippleOpacity = 0.3F;
            AMCDeletebtn.RippleRadiusMultiplier = 0.6F;
            AMCDeletebtn.ShadowBlur = 5;
            AMCDeletebtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            AMCDeletebtn.ShadowOffset = new Point(2, 2);
            AMCDeletebtn.ShakeDuration = 500;
            AMCDeletebtn.ShakeIntensity = 5;
            AMCDeletebtn.Size = new Size(125, 55);
            AMCDeletebtn.TabIndex = 10;
            AMCDeletebtn.Text = "Delete";
            AMCDeletebtn.TextAlign = ContentAlignment.MiddleCenter;
            AMCDeletebtn.TextColor = Color.White;
            AMCDeletebtn.TooltipText = null;
            AMCDeletebtn.UseAdvancedRendering = true;
            AMCDeletebtn.UseParticles = false;
            // 
            // AMCEditbtn
            // 
            AMCEditbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AMCEditbtn.AccessibleName = "Edit";
            AMCEditbtn.AutoSizeBasedOnText = false;
            AMCEditbtn.BackColor = Color.Transparent;
            AMCEditbtn.BadgeBackColor = Color.Red;
            AMCEditbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AMCEditbtn.BadgeValue = 0;
            AMCEditbtn.BadgeValueForeColor = Color.Transparent;
            AMCEditbtn.BorderColor = Color.Transparent;
            AMCEditbtn.BorderWidth = 2;
            AMCEditbtn.ButtonBackColor = Color.Green;
            AMCEditbtn.ButtonImage = null;
            AMCEditbtn.CanBeep = true;
            AMCEditbtn.CanGlow = false;
            AMCEditbtn.CanShake = true;
            AMCEditbtn.ContextMenuStripEx = null;
            AMCEditbtn.CornerRadiusBottomLeft = 25;
            AMCEditbtn.CornerRadiusBottomRight = 25;
            AMCEditbtn.CornerRadiusTopLeft = 25;
            AMCEditbtn.CornerRadiusTopRight = 25;
            AMCEditbtn.CustomCursor = Cursors.Default;
            AMCEditbtn.DisabledTextColor = Color.Gray;
            AMCEditbtn.EnableLongPress = false;
            AMCEditbtn.EnablePressAnimation = true;
            AMCEditbtn.EnableRippleEffect = true;
            AMCEditbtn.EnableShadow = false;
            AMCEditbtn.EnableTextWrapping = false;
            AMCEditbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMCEditbtn.ForeColor = Color.White;
            AMCEditbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            AMCEditbtn.GlowIntensity = 100;
            AMCEditbtn.GlowRadius = 20F;
            AMCEditbtn.GradientBackground = false;
            AMCEditbtn.GradientColor = Color.FromArgb(114, 168, 255);
            AMCEditbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AMCEditbtn.HintText = null;
            AMCEditbtn.HoverBackColor = Color.SeaGreen;
            AMCEditbtn.HoverFontStyle = FontStyle.Regular;
            AMCEditbtn.HoverTextColor = Color.White;
            AMCEditbtn.HoverTransitionDuration = 250;
            AMCEditbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AMCEditbtn.ImagePadding = 5;
            AMCEditbtn.ImageSize = new Size(16, 16);
            AMCEditbtn.IsRadial = true;
            AMCEditbtn.IsReadOnly = false;
            AMCEditbtn.IsToggleButton = false;
            AMCEditbtn.IsToggled = false;
            AMCEditbtn.Location = new Point(18, 478);
            AMCEditbtn.LongPressDurationMS = 1000;
            AMCEditbtn.Margin = new Padding(0);
            AMCEditbtn.Name = "AMCEditbtn";
            AMCEditbtn.NormalFontStyle = FontStyle.Regular;
            AMCEditbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            AMCEditbtn.ParticleCount = 15;
            AMCEditbtn.PressAnimationScale = 0.97F;
            AMCEditbtn.PressedBackColor = Color.LightGreen;
            AMCEditbtn.PressedFontStyle = FontStyle.Regular;
            AMCEditbtn.PressTransitionDuration = 150;
            AMCEditbtn.ReadOnlyTextColor = Color.White;
            AMCEditbtn.RippleColor = Color.FromArgb(255, 255, 255);
            AMCEditbtn.RippleOpacity = 0.3F;
            AMCEditbtn.RippleRadiusMultiplier = 0.6F;
            AMCEditbtn.ShadowBlur = 5;
            AMCEditbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            AMCEditbtn.ShadowOffset = new Point(2, 2);
            AMCEditbtn.ShakeDuration = 500;
            AMCEditbtn.ShakeIntensity = 5;
            AMCEditbtn.Size = new Size(125, 55);
            AMCEditbtn.TabIndex = 10;
            AMCEditbtn.Text = "Edit";
            AMCEditbtn.TextAlign = ContentAlignment.MiddleCenter;
            AMCEditbtn.TextColor = Color.White;
            AMCEditbtn.TooltipText = null;
            AMCEditbtn.UseAdvancedRendering = true;
            AMCEditbtn.UseParticles = false;
            // 
            // AMCTitletbx
            // 
            AMCTitletbx.AccessibleDescription = "A customizable text input field.";
            AMCTitletbx.AccessibleName = "Text Box";
            AMCTitletbx.AccessibleRole = AccessibleRole.Text;
            AMCTitletbx.BackColor = Color.Transparent;
            AMCTitletbx.BlinkCount = 3;
            AMCTitletbx.BlinkShadow = false;
            AMCTitletbx.BorderColor1 = Color.Green;
            AMCTitletbx.BorderColor2 = Color.Green;
            AMCTitletbx.BorderFocusColor1 = Color.Green;
            AMCTitletbx.BorderFocusColor2 = Color.Green;
            AMCTitletbx.BorderSize = 2;
            AMCTitletbx.CanShake = true;
            AMCTitletbx.ContinuousBlink = false;
            AMCTitletbx.CornerRadiusBottomLeft = 10;
            AMCTitletbx.CornerRadiusBottomRight = 10;
            AMCTitletbx.CornerRadiusTopLeft = 10;
            AMCTitletbx.CornerRadiusTopRight = 10;
            AMCTitletbx.CursorBlinkRate = 500;
            AMCTitletbx.CursorColor = Color.Black;
            AMCTitletbx.CursorHeight = 26;
            AMCTitletbx.CursorOffset = 0;
            AMCTitletbx.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            AMCTitletbx.CursorWidth = 1;
            AMCTitletbx.DisabledBackColor = Color.WhiteSmoke;
            AMCTitletbx.DisabledBorderColor = Color.LightGray;
            AMCTitletbx.DisabledTextColor = Color.Gray;
            AMCTitletbx.EnableDropShadow = false;
            AMCTitletbx.FillColor1 = Color.White;
            AMCTitletbx.FillColor2 = Color.White;
            AMCTitletbx.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMCTitletbx.ForeColor = Color.FromArgb(0, 64, 0);
            AMCTitletbx.HoverBorderColor1 = Color.Green;
            AMCTitletbx.HoverBorderColor2 = Color.Green;
            AMCTitletbx.IsEnabled = true;
            AMCTitletbx.Location = new Point(16, 56);
            AMCTitletbx.Margin = new Padding(0);
            AMCTitletbx.Name = "AMCTitletbx";
            AMCTitletbx.PlaceholderColor = Color.Gray;
            AMCTitletbx.PlaceholderText = "Title";
            AMCTitletbx.ReadOnlyBorderColor1 = Color.LightGray;
            AMCTitletbx.ReadOnlyBorderColor2 = Color.LightGray;
            AMCTitletbx.ReadOnlyFillColor1 = Color.WhiteSmoke;
            AMCTitletbx.ReadOnlyFillColor2 = Color.WhiteSmoke;
            AMCTitletbx.ReadOnlyPlaceholderColor = Color.DarkGray;
            AMCTitletbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            AMCTitletbx.ShadowAnimationDuration = 1;
            AMCTitletbx.ShadowBlur = 10;
            AMCTitletbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            AMCTitletbx.Size = new Size(300, 50);
            AMCTitletbx.SolidBorderColor = Color.Green;
            AMCTitletbx.SolidBorderFocusColor = Color.Green;
            AMCTitletbx.SolidBorderHoverColor = Color.Green;
            AMCTitletbx.SolidFillColor = Color.FromArgb(192, 255, 192);
            AMCTitletbx.TabIndex = 11;
            AMCTitletbx.TextPadding = new Padding(11, 2, 11, 2);
            AMCTitletbx.ValidationErrorMessage = "Invalid input.";
            AMCTitletbx.ValidationFunction = null;
            // 
            // AMCDescriptiontbx
            // 
            AMCDescriptiontbx.BackColor = Color.FromArgb(192, 255, 192);
            AMCDescriptiontbx.BorderStyle = BorderStyle.None;
            AMCDescriptiontbx.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AMCDescriptiontbx.ForeColor = Color.FromArgb(0, 64, 0);
            AMCDescriptiontbx.Location = new Point(18, 130);
            AMCDescriptiontbx.Margin = new Padding(0);
            AMCDescriptiontbx.MinimumSize = new Size(100, 100);
            AMCDescriptiontbx.Multiline = true;
            AMCDescriptiontbx.Name = "AMCDescriptiontbx";
            AMCDescriptiontbx.PlaceholderText = "Description...";
            AMCDescriptiontbx.ScrollBars = ScrollBars.Vertical;
            AMCDescriptiontbx.Size = new Size(321, 130);
            AMCDescriptiontbx.TabIndex = 12;
            // 
            // AMCMainPanel
            // 
            AMCMainPanel.Controls.Add(AMCPersonaltxt);
            AMCMainPanel.Controls.Add(AMCCommunitytxt);
            AMCMainPanel.Controls.Add(AMCPersonalChallengesdgv);
            AMCMainPanel.Controls.Add(AMCCommunityChallengesdgv);
            AMCMainPanel.Controls.Add(AMCDescriptiontbx);
            AMCMainPanel.Controls.Add(AMCTitletbx);
            AMCMainPanel.Controls.Add(AMCEditbtn);
            AMCMainPanel.Controls.Add(AMCDeletebtn);
            AMCMainPanel.Controls.Add(AMCLoadbtn);
            AMCMainPanel.Controls.Add(AMCAddbtn);
            AMCMainPanel.Controls.Add(AMCCategorybx);
            AMCMainPanel.Controls.Add(AMCTitle);
            AMCMainPanel.Location = new Point(22, 20);
            AMCMainPanel.Name = "AMCMainPanel";
            AMCMainPanel.Size = new Size(877, 554);
            AMCMainPanel.TabIndex = 4;
            // 
            // AMCPersonaltxt
            // 
            AMCPersonaltxt.AutoSize = true;
            AMCPersonaltxt.BackColor = Color.Transparent;
            AMCPersonaltxt.FlatStyle = FlatStyle.Flat;
            AMCPersonaltxt.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMCPersonaltxt.ForeColor = Color.Green;
            AMCPersonaltxt.Location = new Point(348, 300);
            AMCPersonaltxt.Margin = new Padding(0);
            AMCPersonaltxt.Name = "AMCPersonaltxt";
            AMCPersonaltxt.Size = new Size(105, 36);
            AMCPersonaltxt.TabIndex = 16;
            AMCPersonaltxt.Text = "Personal";
            // 
            // AMCCommunitytxt
            // 
            AMCCommunitytxt.AutoSize = true;
            AMCCommunitytxt.BackColor = Color.Transparent;
            AMCCommunitytxt.FlatStyle = FlatStyle.Flat;
            AMCCommunitytxt.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMCCommunitytxt.ForeColor = Color.Green;
            AMCCommunitytxt.Location = new Point(348, 56);
            AMCCommunitytxt.Margin = new Padding(0);
            AMCCommunitytxt.Name = "AMCCommunitytxt";
            AMCCommunitytxt.Size = new Size(138, 36);
            AMCCommunitytxt.TabIndex = 17;
            AMCCommunitytxt.Text = "Community";
            // 
            // AMCPersonalChallengesdgv
            // 
            AMCPersonalChallengesdgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            AMCPersonalChallengesdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AMCPersonalChallengesdgv.Location = new Point(348, 336);
            AMCPersonalChallengesdgv.Margin = new Padding(0);
            AMCPersonalChallengesdgv.Name = "AMCPersonalChallengesdgv";
            AMCPersonalChallengesdgv.RowHeadersWidth = 51;
            AMCPersonalChallengesdgv.Size = new Size(528, 200);
            AMCPersonalChallengesdgv.TabIndex = 14;
            // 
            // AMCCommunityChallengesdgv
            // 
            AMCCommunityChallengesdgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            AMCCommunityChallengesdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AMCCommunityChallengesdgv.Location = new Point(348, 92);
            AMCCommunityChallengesdgv.Margin = new Padding(0);
            AMCCommunityChallengesdgv.Name = "AMCCommunityChallengesdgv";
            AMCCommunityChallengesdgv.RowHeadersWidth = 51;
            AMCCommunityChallengesdgv.Size = new Size(528, 200);
            AMCCommunityChallengesdgv.TabIndex = 15;
            // 
            // AdminManageChallenges
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 595);
            Controls.Add(AMCMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageChallenges";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageChallenges";
            AMCMainPanel.ResumeLayout(false);
            AMCMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AMCPersonalChallengesdgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)AMCCommunityChallengesdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label AMCTitle;
        private ComboBox AMCCategorybx;
        private SiticoneNetCoreUI.SiticoneButton AMCAddbtn;
        private SiticoneNetCoreUI.SiticoneButton AMCLoadbtn;
        private SiticoneNetCoreUI.SiticoneButton AMCDeletebtn;
        private SiticoneNetCoreUI.SiticoneButton AMCEditbtn;
        private SiticoneNetCoreUI.SiticoneTextBox AMCTitletbx;
        private SiticoneNetCoreUI.SiticoneTextArea AMCDescriptiontbx;
        private Panel AMCMainPanel;
        private Label AMCPersonaltxt;
        private Label AMCCommunitytxt;
        private DataGridView AMCPersonalChallengesdgv;
        private DataGridView AMCCommunityChallengesdgv;
    }
}