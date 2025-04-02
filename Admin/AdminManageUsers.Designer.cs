namespace EcoChallenge
{
    partial class AdminManageUsers
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            AMUMainPanel = new Panel();
            AMUActiveChallengestbx = new SiticoneNetCoreUI.SiticoneTextArea();
            AMUPointstbx = new SiticoneNetCoreUI.SiticoneTextBox();
            AMUUsernametbx = new SiticoneNetCoreUI.SiticoneTextBox();
            AMUUnbanbtn = new SiticoneNetCoreUI.SiticoneButton();
            AMURefreshbtn = new SiticoneNetCoreUI.SiticoneButton();
            AMUBanbtn = new SiticoneNetCoreUI.SiticoneButton();
            AMUUsersdgv = new DataGridView();
            AMUTitle = new Label();
            AMUMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AMUUsersdgv).BeginInit();
            SuspendLayout();
            // 
            // AMUMainPanel
            // 
            AMUMainPanel.Controls.Add(AMUActiveChallengestbx);
            AMUMainPanel.Controls.Add(AMUPointstbx);
            AMUMainPanel.Controls.Add(AMUUsernametbx);
            AMUMainPanel.Controls.Add(AMUUnbanbtn);
            AMUMainPanel.Controls.Add(AMURefreshbtn);
            AMUMainPanel.Controls.Add(AMUBanbtn);
            AMUMainPanel.Controls.Add(AMUUsersdgv);
            AMUMainPanel.Controls.Add(AMUTitle);
            AMUMainPanel.Location = new Point(22, 20);
            AMUMainPanel.Name = "AMUMainPanel";
            AMUMainPanel.Size = new Size(877, 554);
            AMUMainPanel.TabIndex = 5;
            // 
            // AMUActiveChallengestbx
            // 
            AMUActiveChallengestbx.BackColor = Color.FromArgb(192, 255, 192);
            AMUActiveChallengestbx.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AMUActiveChallengestbx.ForeColor = Color.FromArgb(0, 64, 0);
            AMUActiveChallengestbx.Location = new Point(16, 198);
            AMUActiveChallengestbx.Margin = new Padding(0);
            AMUActiveChallengestbx.MinimumSize = new Size(100, 100);
            AMUActiveChallengestbx.Multiline = true;
            AMUActiveChallengestbx.Name = "AMUActiveChallengestbx";
            AMUActiveChallengestbx.PlaceholderText = "Description...";
            AMUActiveChallengestbx.ReadOnly = true;
            AMUActiveChallengestbx.ScrollBars = ScrollBars.Vertical;
            AMUActiveChallengestbx.Size = new Size(321, 130);
            AMUActiveChallengestbx.TabIndex = 3;
            // 
            // AMUPointstbx
            // 
            AMUPointstbx.AccessibleDescription = "A customizable text input field.";
            AMUPointstbx.AccessibleName = "Text Box";
            AMUPointstbx.AccessibleRole = AccessibleRole.Text;
            AMUPointstbx.BackColor = Color.Transparent;
            AMUPointstbx.BlinkCount = 3;
            AMUPointstbx.BlinkShadow = false;
            AMUPointstbx.BorderColor1 = Color.Green;
            AMUPointstbx.BorderColor2 = Color.Green;
            AMUPointstbx.BorderFocusColor1 = Color.Green;
            AMUPointstbx.BorderFocusColor2 = Color.Green;
            AMUPointstbx.BorderSize = 2;
            AMUPointstbx.CanShake = true;
            AMUPointstbx.ContinuousBlink = false;
            AMUPointstbx.CornerRadiusBottomLeft = 10;
            AMUPointstbx.CornerRadiusBottomRight = 10;
            AMUPointstbx.CornerRadiusTopLeft = 10;
            AMUPointstbx.CornerRadiusTopRight = 10;
            AMUPointstbx.CursorBlinkRate = 500;
            AMUPointstbx.CursorColor = Color.Black;
            AMUPointstbx.CursorHeight = 26;
            AMUPointstbx.CursorOffset = 0;
            AMUPointstbx.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            AMUPointstbx.CursorWidth = 1;
            AMUPointstbx.DisabledBackColor = Color.WhiteSmoke;
            AMUPointstbx.DisabledBorderColor = Color.LightGray;
            AMUPointstbx.DisabledTextColor = Color.Gray;
            AMUPointstbx.EnableDropShadow = false;
            AMUPointstbx.FillColor1 = Color.White;
            AMUPointstbx.FillColor2 = Color.White;
            AMUPointstbx.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUPointstbx.ForeColor = Color.FromArgb(0, 64, 0);
            AMUPointstbx.HoverBorderColor1 = Color.Green;
            AMUPointstbx.HoverBorderColor2 = Color.Green;
            AMUPointstbx.IsEnabled = true;
            AMUPointstbx.IsReadOnly = true;
            AMUPointstbx.Location = new Point(16, 126);
            AMUPointstbx.Margin = new Padding(0);
            AMUPointstbx.Name = "AMUPointstbx";
            AMUPointstbx.PlaceholderColor = Color.Gray;
            AMUPointstbx.PlaceholderText = "Points";
            AMUPointstbx.ReadOnlyBorderColor1 = Color.FromArgb(0, 64, 0);
            AMUPointstbx.ReadOnlyBorderColor2 = Color.FromArgb(0, 64, 0);
            AMUPointstbx.ReadOnlyFillColor1 = Color.FromArgb(192, 255, 192);
            AMUPointstbx.ReadOnlyFillColor2 = Color.FromArgb(192, 255, 192);
            AMUPointstbx.ReadOnlyPlaceholderColor = Color.Gray;
            AMUPointstbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            AMUPointstbx.ShadowAnimationDuration = 1;
            AMUPointstbx.ShadowBlur = 10;
            AMUPointstbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            AMUPointstbx.Size = new Size(300, 50);
            AMUPointstbx.SolidBorderColor = Color.Green;
            AMUPointstbx.SolidBorderFocusColor = Color.Green;
            AMUPointstbx.SolidBorderHoverColor = Color.Green;
            AMUPointstbx.SolidFillColor = Color.FromArgb(192, 255, 192);
            AMUPointstbx.TabIndex = 2;
            AMUPointstbx.TextPadding = new Padding(11, 2, 11, 2);
            AMUPointstbx.ValidationErrorMessage = "Invalid input.";
            AMUPointstbx.ValidationFunction = null;
            // 
            // AMUUsernametbx
            // 
            AMUUsernametbx.AccessibleDescription = "A customizable text input field.";
            AMUUsernametbx.AccessibleName = "Text Box";
            AMUUsernametbx.AccessibleRole = AccessibleRole.Text;
            AMUUsernametbx.BackColor = Color.Transparent;
            AMUUsernametbx.BlinkCount = 3;
            AMUUsernametbx.BlinkShadow = false;
            AMUUsernametbx.BorderColor1 = Color.Green;
            AMUUsernametbx.BorderColor2 = Color.Green;
            AMUUsernametbx.BorderFocusColor1 = Color.Green;
            AMUUsernametbx.BorderFocusColor2 = Color.Green;
            AMUUsernametbx.BorderSize = 2;
            AMUUsernametbx.CanShake = true;
            AMUUsernametbx.ContinuousBlink = false;
            AMUUsernametbx.CornerRadiusBottomLeft = 10;
            AMUUsernametbx.CornerRadiusBottomRight = 10;
            AMUUsernametbx.CornerRadiusTopLeft = 10;
            AMUUsernametbx.CornerRadiusTopRight = 10;
            AMUUsernametbx.CursorBlinkRate = 500;
            AMUUsernametbx.CursorColor = Color.Black;
            AMUUsernametbx.CursorHeight = 26;
            AMUUsernametbx.CursorOffset = 0;
            AMUUsernametbx.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            AMUUsernametbx.CursorWidth = 1;
            AMUUsernametbx.DisabledBackColor = Color.WhiteSmoke;
            AMUUsernametbx.DisabledBorderColor = Color.LightGray;
            AMUUsernametbx.DisabledTextColor = Color.Gray;
            AMUUsernametbx.EnableDropShadow = false;
            AMUUsernametbx.FillColor1 = Color.White;
            AMUUsernametbx.FillColor2 = Color.White;
            AMUUsernametbx.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUUsernametbx.ForeColor = Color.FromArgb(0, 64, 0);
            AMUUsernametbx.HoverBorderColor1 = Color.Green;
            AMUUsernametbx.HoverBorderColor2 = Color.Green;
            AMUUsernametbx.IsEnabled = true;
            AMUUsernametbx.IsReadOnly = true;
            AMUUsernametbx.Location = new Point(16, 56);
            AMUUsernametbx.Margin = new Padding(0);
            AMUUsernametbx.Name = "AMUUsernametbx";
            AMUUsernametbx.PlaceholderColor = Color.Gray;
            AMUUsernametbx.PlaceholderText = "Username";
            AMUUsernametbx.ReadOnlyBorderColor1 = Color.FromArgb(0, 64, 0);
            AMUUsernametbx.ReadOnlyBorderColor2 = Color.LightGray;
            AMUUsernametbx.ReadOnlyFillColor1 = Color.FromArgb(192, 255, 192);
            AMUUsernametbx.ReadOnlyFillColor2 = Color.WhiteSmoke;
            AMUUsernametbx.ReadOnlyPlaceholderColor = Color.Gray;
            AMUUsernametbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            AMUUsernametbx.ShadowAnimationDuration = 1;
            AMUUsernametbx.ShadowBlur = 10;
            AMUUsernametbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            AMUUsernametbx.Size = new Size(300, 50);
            AMUUsernametbx.SolidBorderColor = Color.Green;
            AMUUsernametbx.SolidBorderFocusColor = Color.Green;
            AMUUsernametbx.SolidBorderHoverColor = Color.Green;
            AMUUsernametbx.SolidFillColor = Color.FromArgb(192, 255, 192);
            AMUUsernametbx.TabIndex = 1;
            AMUUsernametbx.TextPadding = new Padding(11, 2, 11, 2);
            AMUUsernametbx.ValidationErrorMessage = "Invalid input.";
            AMUUsernametbx.ValidationFunction = null;
            // 
            // AMUUnbanbtn
            // 
            AMUUnbanbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AMUUnbanbtn.AccessibleName = "Unban";
            AMUUnbanbtn.AutoSizeBasedOnText = false;
            AMUUnbanbtn.BackColor = Color.Transparent;
            AMUUnbanbtn.BadgeBackColor = Color.Red;
            AMUUnbanbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AMUUnbanbtn.BadgeValue = 0;
            AMUUnbanbtn.BadgeValueForeColor = Color.Transparent;
            AMUUnbanbtn.BorderColor = Color.Transparent;
            AMUUnbanbtn.BorderWidth = 2;
            AMUUnbanbtn.ButtonBackColor = Color.Green;
            AMUUnbanbtn.ButtonImage = null;
            AMUUnbanbtn.CanBeep = true;
            AMUUnbanbtn.CanGlow = false;
            AMUUnbanbtn.CanShake = true;
            AMUUnbanbtn.ContextMenuStripEx = null;
            AMUUnbanbtn.CornerRadiusBottomLeft = 25;
            AMUUnbanbtn.CornerRadiusBottomRight = 25;
            AMUUnbanbtn.CornerRadiusTopLeft = 25;
            AMUUnbanbtn.CornerRadiusTopRight = 25;
            AMUUnbanbtn.CustomCursor = Cursors.Default;
            AMUUnbanbtn.DisabledTextColor = Color.Gray;
            AMUUnbanbtn.EnableLongPress = false;
            AMUUnbanbtn.EnablePressAnimation = true;
            AMUUnbanbtn.EnableRippleEffect = true;
            AMUUnbanbtn.EnableShadow = false;
            AMUUnbanbtn.EnableTextWrapping = false;
            AMUUnbanbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUUnbanbtn.ForeColor = Color.White;
            AMUUnbanbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            AMUUnbanbtn.GlowIntensity = 100;
            AMUUnbanbtn.GlowRadius = 20F;
            AMUUnbanbtn.GradientBackground = false;
            AMUUnbanbtn.GradientColor = Color.FromArgb(114, 168, 255);
            AMUUnbanbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AMUUnbanbtn.HintText = null;
            AMUUnbanbtn.HoverBackColor = Color.SeaGreen;
            AMUUnbanbtn.HoverFontStyle = FontStyle.Regular;
            AMUUnbanbtn.HoverTextColor = Color.White;
            AMUUnbanbtn.HoverTransitionDuration = 250;
            AMUUnbanbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AMUUnbanbtn.ImagePadding = 5;
            AMUUnbanbtn.ImageSize = new Size(16, 16);
            AMUUnbanbtn.IsRadial = true;
            AMUUnbanbtn.IsReadOnly = false;
            AMUUnbanbtn.IsToggleButton = false;
            AMUUnbanbtn.IsToggled = false;
            AMUUnbanbtn.Location = new Point(160, 478);
            AMUUnbanbtn.LongPressDurationMS = 1000;
            AMUUnbanbtn.Margin = new Padding(0);
            AMUUnbanbtn.Name = "AMUUnbanbtn";
            AMUUnbanbtn.NormalFontStyle = FontStyle.Regular;
            AMUUnbanbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            AMUUnbanbtn.ParticleCount = 15;
            AMUUnbanbtn.PressAnimationScale = 0.97F;
            AMUUnbanbtn.PressedBackColor = Color.LightGreen;
            AMUUnbanbtn.PressedFontStyle = FontStyle.Regular;
            AMUUnbanbtn.PressTransitionDuration = 150;
            AMUUnbanbtn.ReadOnlyTextColor = Color.White;
            AMUUnbanbtn.RippleColor = Color.FromArgb(255, 255, 255);
            AMUUnbanbtn.RippleOpacity = 0.3F;
            AMUUnbanbtn.RippleRadiusMultiplier = 0.6F;
            AMUUnbanbtn.ShadowBlur = 5;
            AMUUnbanbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            AMUUnbanbtn.ShadowOffset = new Point(2, 2);
            AMUUnbanbtn.ShakeDuration = 500;
            AMUUnbanbtn.ShakeIntensity = 5;
            AMUUnbanbtn.Size = new Size(125, 55);
            AMUUnbanbtn.TabIndex = 6;
            AMUUnbanbtn.Text = "Unban";
            AMUUnbanbtn.TextAlign = ContentAlignment.MiddleCenter;
            AMUUnbanbtn.TextColor = Color.White;
            AMUUnbanbtn.TooltipText = null;
            AMUUnbanbtn.UseAdvancedRendering = true;
            AMUUnbanbtn.UseParticles = false;
            // 
            // AMURefreshbtn
            // 
            AMURefreshbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AMURefreshbtn.AccessibleName = "Refresh";
            AMURefreshbtn.AutoSizeBasedOnText = false;
            AMURefreshbtn.BackColor = Color.Transparent;
            AMURefreshbtn.BadgeBackColor = Color.Red;
            AMURefreshbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AMURefreshbtn.BadgeValue = 0;
            AMURefreshbtn.BadgeValueForeColor = Color.White;
            AMURefreshbtn.BorderColor = Color.Transparent;
            AMURefreshbtn.BorderWidth = 2;
            AMURefreshbtn.ButtonBackColor = Color.Green;
            AMURefreshbtn.ButtonImage = null;
            AMURefreshbtn.CanBeep = true;
            AMURefreshbtn.CanGlow = false;
            AMURefreshbtn.CanShake = true;
            AMURefreshbtn.ContextMenuStripEx = null;
            AMURefreshbtn.CornerRadiusBottomLeft = 25;
            AMURefreshbtn.CornerRadiusBottomRight = 25;
            AMURefreshbtn.CornerRadiusTopLeft = 25;
            AMURefreshbtn.CornerRadiusTopRight = 25;
            AMURefreshbtn.CustomCursor = Cursors.Default;
            AMURefreshbtn.DisabledTextColor = Color.Gray;
            AMURefreshbtn.EnableLongPress = false;
            AMURefreshbtn.EnablePressAnimation = true;
            AMURefreshbtn.EnableRippleEffect = true;
            AMURefreshbtn.EnableShadow = false;
            AMURefreshbtn.EnableTextWrapping = false;
            AMURefreshbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMURefreshbtn.ForeColor = Color.White;
            AMURefreshbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            AMURefreshbtn.GlowIntensity = 100;
            AMURefreshbtn.GlowRadius = 20F;
            AMURefreshbtn.GradientBackground = false;
            AMURefreshbtn.GradientColor = Color.FromArgb(114, 168, 255);
            AMURefreshbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AMURefreshbtn.HintText = null;
            AMURefreshbtn.HoverBackColor = Color.SeaGreen;
            AMURefreshbtn.HoverFontStyle = FontStyle.Regular;
            AMURefreshbtn.HoverTextColor = Color.White;
            AMURefreshbtn.HoverTransitionDuration = 250;
            AMURefreshbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AMURefreshbtn.ImagePadding = 5;
            AMURefreshbtn.ImageSize = new Size(16, 16);
            AMURefreshbtn.IsRadial = true;
            AMURefreshbtn.IsReadOnly = false;
            AMURefreshbtn.IsToggleButton = false;
            AMURefreshbtn.IsToggled = false;
            AMURefreshbtn.Location = new Point(18, 389);
            AMURefreshbtn.LongPressDurationMS = 1000;
            AMURefreshbtn.Margin = new Padding(0);
            AMURefreshbtn.Name = "AMURefreshbtn";
            AMURefreshbtn.NormalFontStyle = FontStyle.Regular;
            AMURefreshbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            AMURefreshbtn.ParticleCount = 15;
            AMURefreshbtn.PressAnimationScale = 0.97F;
            AMURefreshbtn.PressedBackColor = Color.LightGreen;
            AMURefreshbtn.PressedFontStyle = FontStyle.Regular;
            AMURefreshbtn.PressTransitionDuration = 150;
            AMURefreshbtn.ReadOnlyTextColor = Color.White;
            AMURefreshbtn.RippleColor = Color.FromArgb(255, 255, 255);
            AMURefreshbtn.RippleOpacity = 0.3F;
            AMURefreshbtn.RippleRadiusMultiplier = 0.6F;
            AMURefreshbtn.ShadowBlur = 5;
            AMURefreshbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            AMURefreshbtn.ShadowOffset = new Point(2, 2);
            AMURefreshbtn.ShakeDuration = 500;
            AMURefreshbtn.ShakeIntensity = 5;
            AMURefreshbtn.Size = new Size(125, 55);
            AMURefreshbtn.TabIndex = 4;
            AMURefreshbtn.Text = "Refresh";
            AMURefreshbtn.TextAlign = ContentAlignment.MiddleCenter;
            AMURefreshbtn.TextColor = Color.White;
            AMURefreshbtn.TooltipText = null;
            AMURefreshbtn.UseAdvancedRendering = true;
            AMURefreshbtn.UseParticles = false;
            // 
            // AMUBanbtn
            // 
            AMUBanbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AMUBanbtn.AccessibleName = "Ban";
            AMUBanbtn.AutoSizeBasedOnText = false;
            AMUBanbtn.BackColor = Color.Transparent;
            AMUBanbtn.BadgeBackColor = Color.Red;
            AMUBanbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AMUBanbtn.BadgeValue = 0;
            AMUBanbtn.BadgeValueForeColor = Color.White;
            AMUBanbtn.BorderColor = Color.Transparent;
            AMUBanbtn.BorderWidth = 2;
            AMUBanbtn.ButtonBackColor = Color.Green;
            AMUBanbtn.ButtonImage = null;
            AMUBanbtn.CanBeep = true;
            AMUBanbtn.CanGlow = false;
            AMUBanbtn.CanShake = true;
            AMUBanbtn.ContextMenuStripEx = null;
            AMUBanbtn.CornerRadiusBottomLeft = 25;
            AMUBanbtn.CornerRadiusBottomRight = 25;
            AMUBanbtn.CornerRadiusTopLeft = 25;
            AMUBanbtn.CornerRadiusTopRight = 25;
            AMUBanbtn.CustomCursor = Cursors.Default;
            AMUBanbtn.DisabledTextColor = Color.Gray;
            AMUBanbtn.EnableLongPress = false;
            AMUBanbtn.EnablePressAnimation = true;
            AMUBanbtn.EnableRippleEffect = true;
            AMUBanbtn.EnableShadow = false;
            AMUBanbtn.EnableTextWrapping = false;
            AMUBanbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUBanbtn.ForeColor = Color.White;
            AMUBanbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            AMUBanbtn.GlowIntensity = 100;
            AMUBanbtn.GlowRadius = 20F;
            AMUBanbtn.GradientBackground = false;
            AMUBanbtn.GradientColor = Color.FromArgb(114, 168, 255);
            AMUBanbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AMUBanbtn.HintText = null;
            AMUBanbtn.HoverBackColor = Color.SeaGreen;
            AMUBanbtn.HoverFontStyle = FontStyle.Regular;
            AMUBanbtn.HoverTextColor = Color.White;
            AMUBanbtn.HoverTransitionDuration = 250;
            AMUBanbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AMUBanbtn.ImagePadding = 5;
            AMUBanbtn.ImageSize = new Size(16, 16);
            AMUBanbtn.IsRadial = true;
            AMUBanbtn.IsReadOnly = false;
            AMUBanbtn.IsToggleButton = false;
            AMUBanbtn.IsToggled = false;
            AMUBanbtn.Location = new Point(160, 389);
            AMUBanbtn.LongPressDurationMS = 1000;
            AMUBanbtn.Margin = new Padding(0);
            AMUBanbtn.Name = "AMUBanbtn";
            AMUBanbtn.NormalFontStyle = FontStyle.Regular;
            AMUBanbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            AMUBanbtn.ParticleCount = 15;
            AMUBanbtn.PressAnimationScale = 0.97F;
            AMUBanbtn.PressedBackColor = Color.LightGreen;
            AMUBanbtn.PressedFontStyle = FontStyle.Regular;
            AMUBanbtn.PressTransitionDuration = 150;
            AMUBanbtn.ReadOnlyTextColor = Color.White;
            AMUBanbtn.RippleColor = Color.FromArgb(255, 255, 255);
            AMUBanbtn.RippleOpacity = 0.3F;
            AMUBanbtn.RippleRadiusMultiplier = 0.6F;
            AMUBanbtn.ShadowBlur = 5;
            AMUBanbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            AMUBanbtn.ShadowOffset = new Point(2, 2);
            AMUBanbtn.ShakeDuration = 500;
            AMUBanbtn.ShakeIntensity = 5;
            AMUBanbtn.Size = new Size(125, 55);
            AMUBanbtn.TabIndex = 5;
            AMUBanbtn.Text = "Ban";
            AMUBanbtn.TextAlign = ContentAlignment.MiddleCenter;
            AMUBanbtn.TextColor = Color.White;
            AMUBanbtn.TooltipText = null;
            AMUBanbtn.UseAdvancedRendering = true;
            AMUBanbtn.UseParticles = false;
            // 
            // AMUUsersdgv
            // 
            AMUUsersdgv.AllowUserToAddRows = false;
            AMUUsersdgv.AllowUserToDeleteRows = false;
            AMUUsersdgv.AllowUserToResizeColumns = false;
            AMUUsersdgv.AllowUserToResizeRows = false;
            AMUUsersdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AMUUsersdgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            AMUUsersdgv.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            AMUUsersdgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AMUUsersdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AMUUsersdgv.ColumnHeadersHeight = 50;
            AMUUsersdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AMUUsersdgv.EnableHeadersVisualStyles = false;
            AMUUsersdgv.GridColor = Color.Green;
            AMUUsersdgv.Location = new Point(349, 56);
            AMUUsersdgv.Margin = new Padding(0);
            AMUUsersdgv.MultiSelect = false;
            AMUUsersdgv.Name = "AMUUsersdgv";
            AMUUsersdgv.ReadOnly = true;
            AMUUsersdgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            AMUUsersdgv.RowHeadersVisible = false;
            AMUUsersdgv.RowHeadersWidth = 50;
            AMUUsersdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            AMUUsersdgv.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AMUUsersdgv.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
            AMUUsersdgv.RowTemplate.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AMUUsersdgv.RowTemplate.DefaultCellStyle.ForeColor = Color.Green;
            AMUUsersdgv.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Green;
            AMUUsersdgv.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(192, 255, 192);
            AMUUsersdgv.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            AMUUsersdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AMUUsersdgv.Size = new Size(528, 498);
            AMUUsersdgv.TabIndex = 6;
            // 
            // AMUTitle
            // 
            AMUTitle.AutoSize = true;
            AMUTitle.BackColor = Color.Transparent;
            AMUTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUTitle.ForeColor = Color.Green;
            AMUTitle.Location = new Point(0, 0);
            AMUTitle.Margin = new Padding(0);
            AMUTitle.Name = "AMUTitle";
            AMUTitle.Size = new Size(241, 53);
            AMUTitle.TabIndex = 0;
            AMUTitle.Text = "Manage Users";
            // 
            // AdminManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 595);
            Controls.Add(AMUMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageUsers";
            AMUMainPanel.ResumeLayout(false);
            AMUMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AMUUsersdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel AMUMainPanel;
        private SiticoneNetCoreUI.SiticoneTextBox AMUUsernametbx;
        private SiticoneNetCoreUI.SiticoneButton AMUUnbanbtn;
        private SiticoneNetCoreUI.SiticoneButton AMURefreshbtn;
        private SiticoneNetCoreUI.SiticoneButton AMUBanbtn;
        private DataGridView AMUUsersdgv;
        private Label AMUTitle;
        private SiticoneNetCoreUI.SiticoneTextBox AMUPointstbx;
        private SiticoneNetCoreUI.SiticoneTextArea AMUActiveChallengestbx;
    }
}