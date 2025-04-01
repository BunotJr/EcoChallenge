using SiticoneNetCoreUI;

namespace EcoChallenge.Admin
{
    partial class AdminChallengeSubmissions
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
            ARCSMainPanel = new Panel();
            ARCSProofImagebx = new PictureBox();
            ARCSApprovebtn = new SiticoneButton();
            ARCSRejectbtn = new SiticoneButton();
            ARCSSubmissionsdgv = new DataGridView();
            ARCSProofImagelbl = new Label();
            ARCSTitle = new Label();
            ARCSMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ARCSProofImagebx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ARCSSubmissionsdgv).BeginInit();
            SuspendLayout();
            // 
            // ARCSMainPanel
            // 
            ARCSMainPanel.Controls.Add(ARCSProofImagebx);
            ARCSMainPanel.Controls.Add(ARCSApprovebtn);
            ARCSMainPanel.Controls.Add(ARCSRejectbtn);
            ARCSMainPanel.Controls.Add(ARCSSubmissionsdgv);
            ARCSMainPanel.Controls.Add(ARCSProofImagelbl);
            ARCSMainPanel.Controls.Add(ARCSTitle);
            ARCSMainPanel.Location = new Point(22, 20);
            ARCSMainPanel.Name = "ARCSMainPanel";
            ARCSMainPanel.Size = new Size(877, 554);
            ARCSMainPanel.TabIndex = 6;
            // 
            // ARCSProofImagebx
            // 
            ARCSProofImagebx.BackColor = Color.FromArgb(192, 255, 192);
            ARCSProofImagebx.BorderStyle = BorderStyle.FixedSingle;
            ARCSProofImagebx.Location = new Point(32, 106);
            ARCSProofImagebx.Margin = new Padding(0);
            ARCSProofImagebx.Name = "ARCSProofImagebx";
            ARCSProofImagebx.Size = new Size(265, 265);
            ARCSProofImagebx.SizeMode = PictureBoxSizeMode.Zoom;
            ARCSProofImagebx.TabIndex = 11;
            ARCSProofImagebx.TabStop = false;
            // 
            // ARCSApprovebtn
            // 
            ARCSApprovebtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ARCSApprovebtn.AccessibleName = "Approve";
            ARCSApprovebtn.AutoSizeBasedOnText = false;
            ARCSApprovebtn.BackColor = Color.Transparent;
            ARCSApprovebtn.BadgeBackColor = Color.Red;
            ARCSApprovebtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ARCSApprovebtn.BadgeValue = 0;
            ARCSApprovebtn.BadgeValueForeColor = Color.White;
            ARCSApprovebtn.BorderColor = Color.Transparent;
            ARCSApprovebtn.BorderWidth = 2;
            ARCSApprovebtn.ButtonBackColor = Color.Green;
            ARCSApprovebtn.ButtonImage = null;
            ARCSApprovebtn.CanBeep = true;
            ARCSApprovebtn.CanGlow = false;
            ARCSApprovebtn.CanShake = true;
            ARCSApprovebtn.ContextMenuStripEx = null;
            ARCSApprovebtn.CornerRadiusBottomLeft = 25;
            ARCSApprovebtn.CornerRadiusBottomRight = 25;
            ARCSApprovebtn.CornerRadiusTopLeft = 25;
            ARCSApprovebtn.CornerRadiusTopRight = 25;
            ARCSApprovebtn.CustomCursor = Cursors.Default;
            ARCSApprovebtn.DisabledTextColor = Color.Gray;
            ARCSApprovebtn.EnableLongPress = false;
            ARCSApprovebtn.EnablePressAnimation = true;
            ARCSApprovebtn.EnableRippleEffect = true;
            ARCSApprovebtn.EnableShadow = false;
            ARCSApprovebtn.EnableTextWrapping = false;
            ARCSApprovebtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ARCSApprovebtn.ForeColor = Color.White;
            ARCSApprovebtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ARCSApprovebtn.GlowIntensity = 100;
            ARCSApprovebtn.GlowRadius = 20F;
            ARCSApprovebtn.GradientBackground = false;
            ARCSApprovebtn.GradientColor = Color.FromArgb(114, 168, 255);
            ARCSApprovebtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ARCSApprovebtn.HintText = null;
            ARCSApprovebtn.HoverBackColor = Color.SeaGreen;
            ARCSApprovebtn.HoverFontStyle = FontStyle.Regular;
            ARCSApprovebtn.HoverTextColor = Color.White;
            ARCSApprovebtn.HoverTransitionDuration = 250;
            ARCSApprovebtn.ImageAlign = ContentAlignment.MiddleLeft;
            ARCSApprovebtn.ImagePadding = 5;
            ARCSApprovebtn.ImageSize = new Size(16, 16);
            ARCSApprovebtn.IsRadial = true;
            ARCSApprovebtn.IsReadOnly = false;
            ARCSApprovebtn.IsToggleButton = false;
            ARCSApprovebtn.IsToggled = false;
            ARCSApprovebtn.Location = new Point(32, 455);
            ARCSApprovebtn.LongPressDurationMS = 1000;
            ARCSApprovebtn.Margin = new Padding(0);
            ARCSApprovebtn.Name = "ARCSApprovebtn";
            ARCSApprovebtn.NormalFontStyle = FontStyle.Regular;
            ARCSApprovebtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ARCSApprovebtn.ParticleCount = 15;
            ARCSApprovebtn.PressAnimationScale = 0.97F;
            ARCSApprovebtn.PressedBackColor = Color.LightGreen;
            ARCSApprovebtn.PressedFontStyle = FontStyle.Regular;
            ARCSApprovebtn.PressTransitionDuration = 150;
            ARCSApprovebtn.ReadOnlyTextColor = Color.White;
            ARCSApprovebtn.RippleColor = Color.FromArgb(255, 255, 255);
            ARCSApprovebtn.RippleOpacity = 0.3F;
            ARCSApprovebtn.RippleRadiusMultiplier = 0.6F;
            ARCSApprovebtn.ShadowBlur = 5;
            ARCSApprovebtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ARCSApprovebtn.ShadowOffset = new Point(2, 2);
            ARCSApprovebtn.ShakeDuration = 500;
            ARCSApprovebtn.ShakeIntensity = 5;
            ARCSApprovebtn.Size = new Size(125, 55);
            ARCSApprovebtn.TabIndex = 10;
            ARCSApprovebtn.Text = "Approve";
            ARCSApprovebtn.TextAlign = ContentAlignment.MiddleCenter;
            ARCSApprovebtn.TextColor = Color.White;
            ARCSApprovebtn.TooltipText = null;
            ARCSApprovebtn.UseAdvancedRendering = true;
            ARCSApprovebtn.UseParticles = false;
            // 
            // ARCSRejectbtn
            // 
            ARCSRejectbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            ARCSRejectbtn.AccessibleName = "Reject";
            ARCSRejectbtn.AutoSizeBasedOnText = false;
            ARCSRejectbtn.BackColor = Color.Transparent;
            ARCSRejectbtn.BadgeBackColor = Color.Red;
            ARCSRejectbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            ARCSRejectbtn.BadgeValue = 0;
            ARCSRejectbtn.BadgeValueForeColor = Color.White;
            ARCSRejectbtn.BorderColor = Color.Transparent;
            ARCSRejectbtn.BorderWidth = 2;
            ARCSRejectbtn.ButtonBackColor = Color.Green;
            ARCSRejectbtn.ButtonImage = null;
            ARCSRejectbtn.CanBeep = true;
            ARCSRejectbtn.CanGlow = false;
            ARCSRejectbtn.CanShake = true;
            ARCSRejectbtn.ContextMenuStripEx = null;
            ARCSRejectbtn.CornerRadiusBottomLeft = 25;
            ARCSRejectbtn.CornerRadiusBottomRight = 25;
            ARCSRejectbtn.CornerRadiusTopLeft = 25;
            ARCSRejectbtn.CornerRadiusTopRight = 25;
            ARCSRejectbtn.CustomCursor = Cursors.Default;
            ARCSRejectbtn.DisabledTextColor = Color.Gray;
            ARCSRejectbtn.EnableLongPress = false;
            ARCSRejectbtn.EnablePressAnimation = true;
            ARCSRejectbtn.EnableRippleEffect = true;
            ARCSRejectbtn.EnableShadow = false;
            ARCSRejectbtn.EnableTextWrapping = false;
            ARCSRejectbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ARCSRejectbtn.ForeColor = Color.White;
            ARCSRejectbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            ARCSRejectbtn.GlowIntensity = 100;
            ARCSRejectbtn.GlowRadius = 20F;
            ARCSRejectbtn.GradientBackground = false;
            ARCSRejectbtn.GradientColor = Color.FromArgb(114, 168, 255);
            ARCSRejectbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ARCSRejectbtn.HintText = null;
            ARCSRejectbtn.HoverBackColor = Color.SeaGreen;
            ARCSRejectbtn.HoverFontStyle = FontStyle.Regular;
            ARCSRejectbtn.HoverTextColor = Color.White;
            ARCSRejectbtn.HoverTransitionDuration = 250;
            ARCSRejectbtn.ImageAlign = ContentAlignment.MiddleLeft;
            ARCSRejectbtn.ImagePadding = 5;
            ARCSRejectbtn.ImageSize = new Size(16, 16);
            ARCSRejectbtn.IsRadial = true;
            ARCSRejectbtn.IsReadOnly = false;
            ARCSRejectbtn.IsToggleButton = false;
            ARCSRejectbtn.IsToggled = false;
            ARCSRejectbtn.Location = new Point(172, 455);
            ARCSRejectbtn.LongPressDurationMS = 1000;
            ARCSRejectbtn.Margin = new Padding(0);
            ARCSRejectbtn.Name = "ARCSRejectbtn";
            ARCSRejectbtn.NormalFontStyle = FontStyle.Regular;
            ARCSRejectbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            ARCSRejectbtn.ParticleCount = 15;
            ARCSRejectbtn.PressAnimationScale = 0.97F;
            ARCSRejectbtn.PressedBackColor = Color.LightGreen;
            ARCSRejectbtn.PressedFontStyle = FontStyle.Regular;
            ARCSRejectbtn.PressTransitionDuration = 150;
            ARCSRejectbtn.ReadOnlyTextColor = Color.White;
            ARCSRejectbtn.RippleColor = Color.FromArgb(255, 255, 255);
            ARCSRejectbtn.RippleOpacity = 0.3F;
            ARCSRejectbtn.RippleRadiusMultiplier = 0.6F;
            ARCSRejectbtn.ShadowBlur = 5;
            ARCSRejectbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            ARCSRejectbtn.ShadowOffset = new Point(2, 2);
            ARCSRejectbtn.ShakeDuration = 500;
            ARCSRejectbtn.ShakeIntensity = 5;
            ARCSRejectbtn.Size = new Size(125, 55);
            ARCSRejectbtn.TabIndex = 10;
            ARCSRejectbtn.Text = "Reject";
            ARCSRejectbtn.TextAlign = ContentAlignment.MiddleCenter;
            ARCSRejectbtn.TextColor = Color.White;
            ARCSRejectbtn.TooltipText = null;
            ARCSRejectbtn.UseAdvancedRendering = true;
            ARCSRejectbtn.UseParticles = false;
            // 
            // ARCSSubmissionsdgv
            // 
            ARCSSubmissionsdgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            ARCSSubmissionsdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ARCSSubmissionsdgv.Location = new Point(349, 56);
            ARCSSubmissionsdgv.Name = "ARCSSubmissionsdgv";
            ARCSSubmissionsdgv.RowHeadersWidth = 51;
            ARCSSubmissionsdgv.Size = new Size(528, 498);
            ARCSSubmissionsdgv.TabIndex = 6;
            // 
            // ARCSProofImagelbl
            // 
            ARCSProofImagelbl.AutoSize = true;
            ARCSProofImagelbl.BackColor = Color.Transparent;
            ARCSProofImagelbl.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ARCSProofImagelbl.ForeColor = Color.Green;
            ARCSProofImagelbl.Location = new Point(32, 56);
            ARCSProofImagelbl.Margin = new Padding(0);
            ARCSProofImagelbl.Name = "ARCSProofImagelbl";
            ARCSProofImagelbl.Size = new Size(195, 50);
            ARCSProofImagelbl.TabIndex = 0;
            ARCSProofImagelbl.Text = "Proof Image";
            // 
            // ARCSTitle
            // 
            ARCSTitle.AutoSize = true;
            ARCSTitle.BackColor = Color.Transparent;
            ARCSTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ARCSTitle.ForeColor = Color.Green;
            ARCSTitle.Location = new Point(0, 0);
            ARCSTitle.Margin = new Padding(0);
            ARCSTitle.Name = "ARCSTitle";
            ARCSTitle.Size = new Size(500, 53);
            ARCSTitle.TabIndex = 0;
            ARCSTitle.Text = "Review Challenge Submissions";
            // 
            // AdminChallengeSubmissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 595);
            Controls.Add(ARCSMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminChallengeSubmissions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminChallengeSubmissions";
            ARCSMainPanel.ResumeLayout(false);
            ARCSMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ARCSProofImagebx).EndInit();
            ((System.ComponentModel.ISupportInitialize)ARCSSubmissionsdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ARCSMainPanel;
        private SiticoneNetCoreUI.SiticoneButton ARCSRejectbtn;
        private DataGridView ARCSSubmissionsdgv;
        private Label ARCSTitle;
        private PictureBox ARCSProofImagebx;
        private Label ARCSProofImagelbl;
        private SiticoneButton ARCSApprovebtn;
    }
}