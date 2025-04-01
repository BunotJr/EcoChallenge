namespace EcoChallenge.User
{
    partial class UserTrackProgress
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
            UTPMainPanel = new Panel();
            UTPProgressBar = new SiticoneNetCoreUI.SiticoneHProgressBar();
            UTPProgrestxt = new Label();
            UTPPersonaltxt = new Label();
            UTPCommunitytxt = new Label();
            UTPTitletbx = new SiticoneNetCoreUI.SiticoneTextBox();
            UTPCompletebtn = new SiticoneNetCoreUI.SiticoneButton();
            UTPSubmitbtn = new SiticoneNetCoreUI.SiticoneButton();
            UTPPersonalChallengesdgv = new DataGridView();
            UTPCommunityChallengesdgv = new DataGridView();
            UTPTitle = new Label();
            UTPMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTPPersonalChallengesdgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UTPCommunityChallengesdgv).BeginInit();
            SuspendLayout();
            // 
            // UTPMainPanel
            // 
            UTPMainPanel.Controls.Add(UTPProgressBar);
            UTPMainPanel.Controls.Add(UTPProgrestxt);
            UTPMainPanel.Controls.Add(UTPPersonaltxt);
            UTPMainPanel.Controls.Add(UTPCommunitytxt);
            UTPMainPanel.Controls.Add(UTPTitletbx);
            UTPMainPanel.Controls.Add(UTPCompletebtn);
            UTPMainPanel.Controls.Add(UTPSubmitbtn);
            UTPMainPanel.Controls.Add(UTPPersonalChallengesdgv);
            UTPMainPanel.Controls.Add(UTPCommunityChallengesdgv);
            UTPMainPanel.Controls.Add(UTPTitle);
            UTPMainPanel.Location = new Point(22, 20);
            UTPMainPanel.Margin = new Padding(0);
            UTPMainPanel.Name = "UTPMainPanel";
            UTPMainPanel.Size = new Size(877, 554);
            UTPMainPanel.TabIndex = 6;
            // 
            // UTPProgressBar
            // 
            UTPProgressBar.AccessibleDescription = "This control shows the value of the horizontal progress bar.";
            UTPProgressBar.AccessibleName = "Advanced and modern horizontal progress bar control";
            UTPProgressBar.AccessibleRole = AccessibleRole.ProgressBar;
            UTPProgressBar.AnimationDurationMs = 300D;
            UTPProgressBar.AnimationTimerInterval = 15;
            UTPProgressBar.AutoLabelColor = false;
            UTPProgressBar.BackgroundBarColor = Color.White;
            UTPProgressBar.BorderColor = Color.FromArgb(34, 30, 65);
            UTPProgressBar.CanBeep = true;
            UTPProgressBar.CanShake = true;
            UTPProgressBar.CornerRadiusBottomLeft = 19;
            UTPProgressBar.CornerRadiusBottomRight = 19;
            UTPProgressBar.CornerRadiusTopLeft = 19;
            UTPProgressBar.CornerRadiusTopRight = 19;
            UTPProgressBar.CustomLabel = "";
            UTPProgressBar.EnableValueDragging = false;
            UTPProgressBar.ErrorColor = Color.Red;
            UTPProgressBar.GradientEndColor = Color.FromArgb(73, 64, 136);
            UTPProgressBar.GradientStartColor = Color.FromArgb(12, 10, 22);
            UTPProgressBar.Indeterminate = false;
            UTPProgressBar.IndeterminateBarColor = Color.FromArgb(34, 30, 65);
            UTPProgressBar.IsReadonly = false;
            UTPProgressBar.LabelColor = Color.White;
            UTPProgressBar.LabelFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            UTPProgressBar.Location = new Point(16, 336);
            UTPProgressBar.MakeRadial = true;
            UTPProgressBar.Maximum = 100;
            UTPProgressBar.Minimum = 0;
            UTPProgressBar.MinimumSize = new Size(50, 20);
            UTPProgressBar.Name = "UTPProgressBar";
            UTPProgressBar.ReadonlyBorderColor = Color.DimGray;
            UTPProgressBar.ReadonlyFillColor1 = Color.Gray;
            UTPProgressBar.ReadonlyFillColor2 = Color.DarkGray;
            UTPProgressBar.ReadonlyForeColor = Color.White;
            UTPProgressBar.ShowFocusCue = false;
            UTPProgressBar.Size = new Size(290, 38);
            UTPProgressBar.SuccessColor = Color.Green;
            UTPProgressBar.TabIndex = 15;
            UTPProgressBar.Text = "siticonehProgressBar1";
            UTPProgressBar.Value = 72;
            UTPProgressBar.ValueOrientation = SiticoneNetCoreUI.Helpers.ProgressBar.ProgressBarOrientation.Horizontal;
            UTPProgressBar.WarningColor = Color.Orange;
            // 
            // UTPProgrestxt
            // 
            UTPProgrestxt.AutoSize = true;
            UTPProgrestxt.BackColor = Color.Transparent;
            UTPProgrestxt.FlatStyle = FlatStyle.Flat;
            UTPProgrestxt.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UTPProgrestxt.ForeColor = Color.Green;
            UTPProgrestxt.Location = new Point(16, 297);
            UTPProgrestxt.Margin = new Padding(0);
            UTPProgrestxt.Name = "UTPProgrestxt";
            UTPProgrestxt.Size = new Size(106, 36);
            UTPProgrestxt.TabIndex = 13;
            UTPProgrestxt.Text = "Progress";
            // 
            // UTPPersonaltxt
            // 
            UTPPersonaltxt.AutoSize = true;
            UTPPersonaltxt.BackColor = Color.Transparent;
            UTPPersonaltxt.FlatStyle = FlatStyle.Flat;
            UTPPersonaltxt.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UTPPersonaltxt.ForeColor = Color.Green;
            UTPPersonaltxt.Location = new Point(349, 300);
            UTPPersonaltxt.Margin = new Padding(0);
            UTPPersonaltxt.Name = "UTPPersonaltxt";
            UTPPersonaltxt.Size = new Size(105, 36);
            UTPPersonaltxt.TabIndex = 13;
            UTPPersonaltxt.Text = "Personal";
            // 
            // UTPCommunitytxt
            // 
            UTPCommunitytxt.AutoSize = true;
            UTPCommunitytxt.BackColor = Color.Transparent;
            UTPCommunitytxt.FlatStyle = FlatStyle.Flat;
            UTPCommunitytxt.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UTPCommunitytxt.ForeColor = Color.Green;
            UTPCommunitytxt.Location = new Point(349, 56);
            UTPCommunitytxt.Margin = new Padding(0);
            UTPCommunitytxt.Name = "UTPCommunitytxt";
            UTPCommunitytxt.Size = new Size(138, 36);
            UTPCommunitytxt.TabIndex = 13;
            UTPCommunitytxt.Text = "Community";
            // 
            // UTPTitletbx
            // 
            UTPTitletbx.AccessibleDescription = "A customizable text input field.";
            UTPTitletbx.AccessibleName = "Text Box";
            UTPTitletbx.AccessibleRole = AccessibleRole.Text;
            UTPTitletbx.BackColor = Color.Transparent;
            UTPTitletbx.BlinkCount = 3;
            UTPTitletbx.BlinkShadow = false;
            UTPTitletbx.BorderColor1 = Color.Green;
            UTPTitletbx.BorderColor2 = Color.Green;
            UTPTitletbx.BorderFocusColor1 = Color.Green;
            UTPTitletbx.BorderFocusColor2 = Color.Green;
            UTPTitletbx.BorderSize = 2;
            UTPTitletbx.CanShake = true;
            UTPTitletbx.ContinuousBlink = false;
            UTPTitletbx.CornerRadiusBottomLeft = 10;
            UTPTitletbx.CornerRadiusBottomRight = 10;
            UTPTitletbx.CornerRadiusTopLeft = 10;
            UTPTitletbx.CornerRadiusTopRight = 10;
            UTPTitletbx.CursorBlinkRate = 500;
            UTPTitletbx.CursorColor = Color.Black;
            UTPTitletbx.CursorHeight = 26;
            UTPTitletbx.CursorOffset = 0;
            UTPTitletbx.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            UTPTitletbx.CursorWidth = 1;
            UTPTitletbx.DisabledBackColor = Color.WhiteSmoke;
            UTPTitletbx.DisabledBorderColor = Color.LightGray;
            UTPTitletbx.DisabledTextColor = Color.Gray;
            UTPTitletbx.EnableDropShadow = false;
            UTPTitletbx.FillColor1 = Color.White;
            UTPTitletbx.FillColor2 = Color.White;
            UTPTitletbx.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UTPTitletbx.ForeColor = Color.FromArgb(0, 64, 0);
            UTPTitletbx.HoverBorderColor1 = Color.Green;
            UTPTitletbx.HoverBorderColor2 = Color.Green;
            UTPTitletbx.IsEnabled = true;
            UTPTitletbx.Location = new Point(16, 90);
            UTPTitletbx.Margin = new Padding(0);
            UTPTitletbx.Name = "UTPTitletbx";
            UTPTitletbx.PlaceholderColor = Color.Gray;
            UTPTitletbx.PlaceholderText = "Title";
            UTPTitletbx.ReadOnlyBorderColor1 = Color.LightGray;
            UTPTitletbx.ReadOnlyBorderColor2 = Color.LightGray;
            UTPTitletbx.ReadOnlyFillColor1 = Color.WhiteSmoke;
            UTPTitletbx.ReadOnlyFillColor2 = Color.WhiteSmoke;
            UTPTitletbx.ReadOnlyPlaceholderColor = Color.DarkGray;
            UTPTitletbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            UTPTitletbx.ShadowAnimationDuration = 1;
            UTPTitletbx.ShadowBlur = 10;
            UTPTitletbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            UTPTitletbx.Size = new Size(300, 50);
            UTPTitletbx.SolidBorderColor = Color.Green;
            UTPTitletbx.SolidBorderFocusColor = Color.Green;
            UTPTitletbx.SolidBorderHoverColor = Color.Green;
            UTPTitletbx.SolidFillColor = Color.FromArgb(192, 255, 192);
            UTPTitletbx.TabIndex = 11;
            UTPTitletbx.TextPadding = new Padding(11, 2, 11, 2);
            UTPTitletbx.ValidationErrorMessage = "Invalid input.";
            UTPTitletbx.ValidationFunction = null;
            // 
            // UTPCompletebtn
            // 
            UTPCompletebtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UTPCompletebtn.AccessibleName = "Complete";
            UTPCompletebtn.AutoSizeBasedOnText = false;
            UTPCompletebtn.BackColor = Color.Transparent;
            UTPCompletebtn.BadgeBackColor = Color.Red;
            UTPCompletebtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UTPCompletebtn.BadgeValue = 0;
            UTPCompletebtn.BadgeValueForeColor = Color.Transparent;
            UTPCompletebtn.BorderColor = Color.Transparent;
            UTPCompletebtn.BorderWidth = 2;
            UTPCompletebtn.ButtonBackColor = Color.Green;
            UTPCompletebtn.ButtonImage = null;
            UTPCompletebtn.CanBeep = true;
            UTPCompletebtn.CanGlow = false;
            UTPCompletebtn.CanShake = true;
            UTPCompletebtn.ContextMenuStripEx = null;
            UTPCompletebtn.CornerRadiusBottomLeft = 25;
            UTPCompletebtn.CornerRadiusBottomRight = 25;
            UTPCompletebtn.CornerRadiusTopLeft = 25;
            UTPCompletebtn.CornerRadiusTopRight = 25;
            UTPCompletebtn.CustomCursor = Cursors.Default;
            UTPCompletebtn.DisabledTextColor = Color.Gray;
            UTPCompletebtn.EnableLongPress = false;
            UTPCompletebtn.EnablePressAnimation = true;
            UTPCompletebtn.EnableRippleEffect = true;
            UTPCompletebtn.EnableShadow = false;
            UTPCompletebtn.EnableTextWrapping = false;
            UTPCompletebtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UTPCompletebtn.ForeColor = Color.White;
            UTPCompletebtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UTPCompletebtn.GlowIntensity = 100;
            UTPCompletebtn.GlowRadius = 20F;
            UTPCompletebtn.GradientBackground = false;
            UTPCompletebtn.GradientColor = Color.FromArgb(114, 168, 255);
            UTPCompletebtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UTPCompletebtn.HintText = null;
            UTPCompletebtn.HoverBackColor = Color.SeaGreen;
            UTPCompletebtn.HoverFontStyle = FontStyle.Regular;
            UTPCompletebtn.HoverTextColor = Color.White;
            UTPCompletebtn.HoverTransitionDuration = 250;
            UTPCompletebtn.ImageAlign = ContentAlignment.MiddleLeft;
            UTPCompletebtn.ImagePadding = 5;
            UTPCompletebtn.ImageSize = new Size(16, 16);
            UTPCompletebtn.IsRadial = true;
            UTPCompletebtn.IsReadOnly = false;
            UTPCompletebtn.IsToggleButton = false;
            UTPCompletebtn.IsToggled = false;
            UTPCompletebtn.Location = new Point(191, 478);
            UTPCompletebtn.LongPressDurationMS = 1000;
            UTPCompletebtn.Margin = new Padding(0);
            UTPCompletebtn.Name = "UTPCompletebtn";
            UTPCompletebtn.NormalFontStyle = FontStyle.Regular;
            UTPCompletebtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UTPCompletebtn.ParticleCount = 15;
            UTPCompletebtn.PressAnimationScale = 0.97F;
            UTPCompletebtn.PressedBackColor = Color.LightGreen;
            UTPCompletebtn.PressedFontStyle = FontStyle.Regular;
            UTPCompletebtn.PressTransitionDuration = 150;
            UTPCompletebtn.ReadOnlyTextColor = Color.White;
            UTPCompletebtn.RippleColor = Color.FromArgb(255, 255, 255);
            UTPCompletebtn.RippleOpacity = 0.3F;
            UTPCompletebtn.RippleRadiusMultiplier = 0.6F;
            UTPCompletebtn.ShadowBlur = 5;
            UTPCompletebtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UTPCompletebtn.ShadowOffset = new Point(2, 2);
            UTPCompletebtn.ShakeDuration = 500;
            UTPCompletebtn.ShakeIntensity = 5;
            UTPCompletebtn.Size = new Size(125, 55);
            UTPCompletebtn.TabIndex = 10;
            UTPCompletebtn.Text = "Complete";
            UTPCompletebtn.TextAlign = ContentAlignment.MiddleCenter;
            UTPCompletebtn.TextColor = Color.White;
            UTPCompletebtn.TooltipText = null;
            UTPCompletebtn.UseAdvancedRendering = true;
            UTPCompletebtn.UseParticles = false;
            // 
            // UTPSubmitbtn
            // 
            UTPSubmitbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UTPSubmitbtn.AccessibleName = "Submit";
            UTPSubmitbtn.AutoSizeBasedOnText = false;
            UTPSubmitbtn.BackColor = Color.Transparent;
            UTPSubmitbtn.BadgeBackColor = Color.Red;
            UTPSubmitbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UTPSubmitbtn.BadgeValue = 0;
            UTPSubmitbtn.BadgeValueForeColor = Color.Transparent;
            UTPSubmitbtn.BorderColor = Color.Transparent;
            UTPSubmitbtn.BorderWidth = 2;
            UTPSubmitbtn.ButtonBackColor = Color.Green;
            UTPSubmitbtn.ButtonImage = null;
            UTPSubmitbtn.CanBeep = true;
            UTPSubmitbtn.CanGlow = false;
            UTPSubmitbtn.CanShake = true;
            UTPSubmitbtn.ContextMenuStripEx = null;
            UTPSubmitbtn.CornerRadiusBottomLeft = 25;
            UTPSubmitbtn.CornerRadiusBottomRight = 25;
            UTPSubmitbtn.CornerRadiusTopLeft = 25;
            UTPSubmitbtn.CornerRadiusTopRight = 25;
            UTPSubmitbtn.CustomCursor = Cursors.Default;
            UTPSubmitbtn.DisabledTextColor = Color.Gray;
            UTPSubmitbtn.EnableLongPress = false;
            UTPSubmitbtn.EnablePressAnimation = true;
            UTPSubmitbtn.EnableRippleEffect = true;
            UTPSubmitbtn.EnableShadow = false;
            UTPSubmitbtn.EnableTextWrapping = false;
            UTPSubmitbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UTPSubmitbtn.ForeColor = Color.White;
            UTPSubmitbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UTPSubmitbtn.GlowIntensity = 100;
            UTPSubmitbtn.GlowRadius = 20F;
            UTPSubmitbtn.GradientBackground = false;
            UTPSubmitbtn.GradientColor = Color.FromArgb(114, 168, 255);
            UTPSubmitbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UTPSubmitbtn.HintText = null;
            UTPSubmitbtn.HoverBackColor = Color.SeaGreen;
            UTPSubmitbtn.HoverFontStyle = FontStyle.Regular;
            UTPSubmitbtn.HoverTextColor = Color.White;
            UTPSubmitbtn.HoverTransitionDuration = 250;
            UTPSubmitbtn.ImageAlign = ContentAlignment.MiddleLeft;
            UTPSubmitbtn.ImagePadding = 5;
            UTPSubmitbtn.ImageSize = new Size(16, 16);
            UTPSubmitbtn.IsRadial = true;
            UTPSubmitbtn.IsReadOnly = false;
            UTPSubmitbtn.IsToggleButton = false;
            UTPSubmitbtn.IsToggled = false;
            UTPSubmitbtn.Location = new Point(16, 478);
            UTPSubmitbtn.LongPressDurationMS = 1000;
            UTPSubmitbtn.Margin = new Padding(0);
            UTPSubmitbtn.Name = "UTPSubmitbtn";
            UTPSubmitbtn.NormalFontStyle = FontStyle.Regular;
            UTPSubmitbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UTPSubmitbtn.ParticleCount = 15;
            UTPSubmitbtn.PressAnimationScale = 0.97F;
            UTPSubmitbtn.PressedBackColor = Color.LightGreen;
            UTPSubmitbtn.PressedFontStyle = FontStyle.Regular;
            UTPSubmitbtn.PressTransitionDuration = 150;
            UTPSubmitbtn.ReadOnlyTextColor = Color.White;
            UTPSubmitbtn.RippleColor = Color.FromArgb(255, 255, 255);
            UTPSubmitbtn.RippleOpacity = 0.3F;
            UTPSubmitbtn.RippleRadiusMultiplier = 0.6F;
            UTPSubmitbtn.ShadowBlur = 5;
            UTPSubmitbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UTPSubmitbtn.ShadowOffset = new Point(2, 2);
            UTPSubmitbtn.ShakeDuration = 500;
            UTPSubmitbtn.ShakeIntensity = 5;
            UTPSubmitbtn.Size = new Size(125, 55);
            UTPSubmitbtn.TabIndex = 10;
            UTPSubmitbtn.Text = "Submit";
            UTPSubmitbtn.TextAlign = ContentAlignment.MiddleCenter;
            UTPSubmitbtn.TextColor = Color.White;
            UTPSubmitbtn.TooltipText = null;
            UTPSubmitbtn.UseAdvancedRendering = true;
            UTPSubmitbtn.UseParticles = false;
            // 
            // UTPPersonalChallengesdgv
            // 
            UTPPersonalChallengesdgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            UTPPersonalChallengesdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UTPPersonalChallengesdgv.Location = new Point(349, 336);
            UTPPersonalChallengesdgv.Margin = new Padding(0);
            UTPPersonalChallengesdgv.Name = "UTPPersonalChallengesdgv";
            UTPPersonalChallengesdgv.RowHeadersWidth = 51;
            UTPPersonalChallengesdgv.Size = new Size(528, 200);
            UTPPersonalChallengesdgv.TabIndex = 6;
            // 
            // UTPCommunityChallengesdgv
            // 
            UTPCommunityChallengesdgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            UTPCommunityChallengesdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UTPCommunityChallengesdgv.Location = new Point(349, 92);
            UTPCommunityChallengesdgv.Margin = new Padding(0);
            UTPCommunityChallengesdgv.Name = "UTPCommunityChallengesdgv";
            UTPCommunityChallengesdgv.RowHeadersWidth = 51;
            UTPCommunityChallengesdgv.Size = new Size(528, 200);
            UTPCommunityChallengesdgv.TabIndex = 6;
            // 
            // UTPTitle
            // 
            UTPTitle.AutoSize = true;
            UTPTitle.BackColor = Color.Transparent;
            UTPTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UTPTitle.ForeColor = Color.Green;
            UTPTitle.Location = new Point(0, 0);
            UTPTitle.Margin = new Padding(0);
            UTPTitle.Name = "UTPTitle";
            UTPTitle.Size = new Size(253, 53);
            UTPTitle.TabIndex = 0;
            UTPTitle.Text = "Track Progress";
            // 
            // UserTrackProgress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 595);
            Controls.Add(UTPMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserTrackProgress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserTrackProgress";
            UTPMainPanel.ResumeLayout(false);
            UTPMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTPPersonalChallengesdgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)UTPCommunityChallengesdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel UTPMainPanel;
        private Label UTPPersonaltxt;
        private Label UTPCommunitytxt;
        private SiticoneNetCoreUI.SiticoneTextBox UTPTitletbx;
        private SiticoneNetCoreUI.SiticoneButton UTPSubmitbtn;
        private DataGridView UTPPersonalChallengesdgv;
        private DataGridView UTPCommunityChallengesdgv;
        private Label UTPTitle;
        private SiticoneNetCoreUI.SiticoneHProgressBar UTPProgressBar;
        private Label UTPProgrestxt;
        private SiticoneNetCoreUI.SiticoneButton UTPCompletebtn;
    }
}