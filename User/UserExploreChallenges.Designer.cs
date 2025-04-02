namespace EcoChallenge.User
{
    partial class UserExploreChallenges
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            UECMainPanel = new Panel();
            UECPersonalChallengesdgv = new DataGridView();
            UECCommunityChallengesdgv = new DataGridView();
            UECRefreshbtn = new SiticoneNetCoreUI.SiticoneButton();
            UECPersonaltxt = new Label();
            UECCommunitytxt = new Label();
            UECDescriptiontbx = new SiticoneNetCoreUI.SiticoneTextArea();
            UECPointstbx = new SiticoneNetCoreUI.SiticoneTextBox();
            UECTitletbx = new SiticoneNetCoreUI.SiticoneTextBox();
            UECJoinbtn = new SiticoneNetCoreUI.SiticoneButton();
            UECTitle = new Label();
            UECMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UECPersonalChallengesdgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UECCommunityChallengesdgv).BeginInit();
            SuspendLayout();
            // 
            // UECMainPanel
            // 
            UECMainPanel.Controls.Add(UECPersonalChallengesdgv);
            UECMainPanel.Controls.Add(UECCommunityChallengesdgv);
            UECMainPanel.Controls.Add(UECRefreshbtn);
            UECMainPanel.Controls.Add(UECPersonaltxt);
            UECMainPanel.Controls.Add(UECCommunitytxt);
            UECMainPanel.Controls.Add(UECDescriptiontbx);
            UECMainPanel.Controls.Add(UECPointstbx);
            UECMainPanel.Controls.Add(UECTitletbx);
            UECMainPanel.Controls.Add(UECJoinbtn);
            UECMainPanel.Controls.Add(UECTitle);
            UECMainPanel.Location = new Point(22, 20);
            UECMainPanel.Margin = new Padding(0);
            UECMainPanel.Name = "UECMainPanel";
            UECMainPanel.Size = new Size(877, 554);
            UECMainPanel.TabIndex = 5;
            // 
            // UECPersonalChallengesdgv
            // 
            UECPersonalChallengesdgv.AllowUserToAddRows = false;
            UECPersonalChallengesdgv.AllowUserToDeleteRows = false;
            UECPersonalChallengesdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UECPersonalChallengesdgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            UECPersonalChallengesdgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Green;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle5.SelectionForeColor = Color.Green;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            UECPersonalChallengesdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            UECPersonalChallengesdgv.ColumnHeadersHeight = 50;
            UECPersonalChallengesdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Green;
            dataGridViewCellStyle6.SelectionBackColor = Color.Green;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            UECPersonalChallengesdgv.DefaultCellStyle = dataGridViewCellStyle6;
            UECPersonalChallengesdgv.EnableHeadersVisualStyles = false;
            UECPersonalChallengesdgv.GridColor = Color.Green;
            UECPersonalChallengesdgv.Location = new Point(349, 336);
            UECPersonalChallengesdgv.Margin = new Padding(0);
            UECPersonalChallengesdgv.MultiSelect = false;
            UECPersonalChallengesdgv.Name = "UECPersonalChallengesdgv";
            UECPersonalChallengesdgv.ReadOnly = true;
            UECPersonalChallengesdgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            UECPersonalChallengesdgv.RowHeadersVisible = false;
            UECPersonalChallengesdgv.RowHeadersWidth = 40;
            UECPersonalChallengesdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            UECPersonalChallengesdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UECPersonalChallengesdgv.Size = new Size(528, 200);
            UECPersonalChallengesdgv.TabIndex = 16;
            // 
            // UECCommunityChallengesdgv
            // 
            UECCommunityChallengesdgv.AllowUserToAddRows = false;
            UECCommunityChallengesdgv.AllowUserToDeleteRows = false;
            UECCommunityChallengesdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UECCommunityChallengesdgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            UECCommunityChallengesdgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Green;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle7.SelectionForeColor = Color.Green;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            UECCommunityChallengesdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            UECCommunityChallengesdgv.ColumnHeadersHeight = 50;
            UECCommunityChallengesdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Green;
            dataGridViewCellStyle8.SelectionBackColor = Color.Green;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            UECCommunityChallengesdgv.DefaultCellStyle = dataGridViewCellStyle8;
            UECCommunityChallengesdgv.EnableHeadersVisualStyles = false;
            UECCommunityChallengesdgv.GridColor = Color.Green;
            UECCommunityChallengesdgv.Location = new Point(349, 92);
            UECCommunityChallengesdgv.Margin = new Padding(0);
            UECCommunityChallengesdgv.MultiSelect = false;
            UECCommunityChallengesdgv.Name = "UECCommunityChallengesdgv";
            UECCommunityChallengesdgv.ReadOnly = true;
            UECCommunityChallengesdgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            UECCommunityChallengesdgv.RowHeadersVisible = false;
            UECCommunityChallengesdgv.RowHeadersWidth = 40;
            UECCommunityChallengesdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            UECCommunityChallengesdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UECCommunityChallengesdgv.Size = new Size(528, 200);
            UECCommunityChallengesdgv.TabIndex = 16;
            // 
            // UECRefreshbtn
            // 
            UECRefreshbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UECRefreshbtn.AccessibleName = "Refresh";
            UECRefreshbtn.AutoSizeBasedOnText = false;
            UECRefreshbtn.BackColor = Color.Transparent;
            UECRefreshbtn.BadgeBackColor = Color.Red;
            UECRefreshbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UECRefreshbtn.BadgeValue = 0;
            UECRefreshbtn.BadgeValueForeColor = Color.White;
            UECRefreshbtn.BorderColor = Color.Transparent;
            UECRefreshbtn.BorderWidth = 2;
            UECRefreshbtn.ButtonBackColor = Color.Green;
            UECRefreshbtn.ButtonImage = null;
            UECRefreshbtn.CanBeep = true;
            UECRefreshbtn.CanGlow = false;
            UECRefreshbtn.CanShake = true;
            UECRefreshbtn.ContextMenuStripEx = null;
            UECRefreshbtn.CornerRadiusBottomLeft = 25;
            UECRefreshbtn.CornerRadiusBottomRight = 25;
            UECRefreshbtn.CornerRadiusTopLeft = 25;
            UECRefreshbtn.CornerRadiusTopRight = 25;
            UECRefreshbtn.CustomCursor = Cursors.Default;
            UECRefreshbtn.DisabledTextColor = Color.Gray;
            UECRefreshbtn.EnableLongPress = false;
            UECRefreshbtn.EnablePressAnimation = true;
            UECRefreshbtn.EnableRippleEffect = true;
            UECRefreshbtn.EnableShadow = false;
            UECRefreshbtn.EnableTextWrapping = false;
            UECRefreshbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UECRefreshbtn.ForeColor = Color.White;
            UECRefreshbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UECRefreshbtn.GlowIntensity = 100;
            UECRefreshbtn.GlowRadius = 20F;
            UECRefreshbtn.GradientBackground = false;
            UECRefreshbtn.GradientColor = Color.FromArgb(114, 168, 255);
            UECRefreshbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UECRefreshbtn.HintText = null;
            UECRefreshbtn.HoverBackColor = Color.SeaGreen;
            UECRefreshbtn.HoverFontStyle = FontStyle.Regular;
            UECRefreshbtn.HoverTextColor = Color.White;
            UECRefreshbtn.HoverTransitionDuration = 250;
            UECRefreshbtn.ImageAlign = ContentAlignment.MiddleLeft;
            UECRefreshbtn.ImagePadding = 5;
            UECRefreshbtn.ImageSize = new Size(16, 16);
            UECRefreshbtn.IsRadial = true;
            UECRefreshbtn.IsReadOnly = false;
            UECRefreshbtn.IsToggleButton = false;
            UECRefreshbtn.IsToggled = false;
            UECRefreshbtn.Location = new Point(191, 478);
            UECRefreshbtn.LongPressDurationMS = 1000;
            UECRefreshbtn.Margin = new Padding(0);
            UECRefreshbtn.Name = "UECRefreshbtn";
            UECRefreshbtn.NormalFontStyle = FontStyle.Regular;
            UECRefreshbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UECRefreshbtn.ParticleCount = 15;
            UECRefreshbtn.PressAnimationScale = 0.97F;
            UECRefreshbtn.PressedBackColor = Color.LightGreen;
            UECRefreshbtn.PressedFontStyle = FontStyle.Regular;
            UECRefreshbtn.PressTransitionDuration = 150;
            UECRefreshbtn.ReadOnlyTextColor = Color.White;
            UECRefreshbtn.RippleColor = Color.FromArgb(255, 255, 255);
            UECRefreshbtn.RippleOpacity = 0.3F;
            UECRefreshbtn.RippleRadiusMultiplier = 0.6F;
            UECRefreshbtn.ShadowBlur = 5;
            UECRefreshbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UECRefreshbtn.ShadowOffset = new Point(2, 2);
            UECRefreshbtn.ShakeDuration = 500;
            UECRefreshbtn.ShakeIntensity = 5;
            UECRefreshbtn.Size = new Size(125, 55);
            UECRefreshbtn.TabIndex = 15;
            UECRefreshbtn.Text = "Refresh";
            UECRefreshbtn.TextAlign = ContentAlignment.MiddleCenter;
            UECRefreshbtn.TextColor = Color.White;
            UECRefreshbtn.TooltipText = null;
            UECRefreshbtn.UseAdvancedRendering = true;
            UECRefreshbtn.UseParticles = false;
            UECRefreshbtn.Click += UECRefreshbtn_Click;
            // 
            // UECPersonaltxt
            // 
            UECPersonaltxt.AutoSize = true;
            UECPersonaltxt.BackColor = Color.Transparent;
            UECPersonaltxt.FlatStyle = FlatStyle.Flat;
            UECPersonaltxt.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UECPersonaltxt.ForeColor = Color.Green;
            UECPersonaltxt.Location = new Point(349, 300);
            UECPersonaltxt.Margin = new Padding(0);
            UECPersonaltxt.Name = "UECPersonaltxt";
            UECPersonaltxt.Size = new Size(105, 36);
            UECPersonaltxt.TabIndex = 13;
            UECPersonaltxt.Text = "Personal";
            // 
            // UECCommunitytxt
            // 
            UECCommunitytxt.AutoSize = true;
            UECCommunitytxt.BackColor = Color.Transparent;
            UECCommunitytxt.FlatStyle = FlatStyle.Flat;
            UECCommunitytxt.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UECCommunitytxt.ForeColor = Color.Green;
            UECCommunitytxt.Location = new Point(349, 56);
            UECCommunitytxt.Margin = new Padding(0);
            UECCommunitytxt.Name = "UECCommunitytxt";
            UECCommunitytxt.Size = new Size(138, 36);
            UECCommunitytxt.TabIndex = 13;
            UECCommunitytxt.Text = "Community";
            // 
            // UECDescriptiontbx
            // 
            UECDescriptiontbx.BackColor = Color.FromArgb(192, 255, 192);
            UECDescriptiontbx.BorderStyle = BorderStyle.None;
            UECDescriptiontbx.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UECDescriptiontbx.ForeColor = Color.FromArgb(0, 64, 0);
            UECDescriptiontbx.Location = new Point(18, 236);
            UECDescriptiontbx.Margin = new Padding(0);
            UECDescriptiontbx.MinimumSize = new Size(100, 100);
            UECDescriptiontbx.Multiline = true;
            UECDescriptiontbx.Name = "UECDescriptiontbx";
            UECDescriptiontbx.PlaceholderText = "Description...";
            UECDescriptiontbx.ReadOnly = true;
            UECDescriptiontbx.ScrollBars = ScrollBars.Vertical;
            UECDescriptiontbx.Size = new Size(321, 174);
            UECDescriptiontbx.TabIndex = 12;
            // 
            // UECPointstbx
            // 
            UECPointstbx.AccessibleDescription = "A customizable text input field.";
            UECPointstbx.AccessibleName = "Text Box";
            UECPointstbx.AccessibleRole = AccessibleRole.Text;
            UECPointstbx.BackColor = Color.Transparent;
            UECPointstbx.BlinkCount = 3;
            UECPointstbx.BlinkShadow = false;
            UECPointstbx.BorderColor1 = Color.Green;
            UECPointstbx.BorderColor2 = Color.Green;
            UECPointstbx.BorderFocusColor1 = Color.Green;
            UECPointstbx.BorderFocusColor2 = Color.Green;
            UECPointstbx.BorderSize = 2;
            UECPointstbx.CanShake = true;
            UECPointstbx.ContinuousBlink = false;
            UECPointstbx.CornerRadiusBottomLeft = 10;
            UECPointstbx.CornerRadiusBottomRight = 10;
            UECPointstbx.CornerRadiusTopLeft = 10;
            UECPointstbx.CornerRadiusTopRight = 10;
            UECPointstbx.CursorBlinkRate = 500;
            UECPointstbx.CursorColor = Color.Black;
            UECPointstbx.CursorHeight = 26;
            UECPointstbx.CursorOffset = 0;
            UECPointstbx.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            UECPointstbx.CursorWidth = 1;
            UECPointstbx.DisabledBackColor = Color.WhiteSmoke;
            UECPointstbx.DisabledBorderColor = Color.LightGray;
            UECPointstbx.DisabledTextColor = Color.Gray;
            UECPointstbx.EnableDropShadow = false;
            UECPointstbx.FillColor1 = Color.White;
            UECPointstbx.FillColor2 = Color.White;
            UECPointstbx.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UECPointstbx.ForeColor = Color.FromArgb(0, 64, 0);
            UECPointstbx.HoverBorderColor1 = Color.Green;
            UECPointstbx.HoverBorderColor2 = Color.Green;
            UECPointstbx.IsEnabled = true;
            UECPointstbx.IsReadOnly = true;
            UECPointstbx.Location = new Point(16, 164);
            UECPointstbx.Margin = new Padding(0);
            UECPointstbx.Name = "UECPointstbx";
            UECPointstbx.PlaceholderColor = Color.Gray;
            UECPointstbx.PlaceholderText = "Points";
            UECPointstbx.ReadOnlyBorderColor1 = Color.FromArgb(0, 64, 0);
            UECPointstbx.ReadOnlyBorderColor2 = Color.FromArgb(0, 64, 0);
            UECPointstbx.ReadOnlyFillColor1 = Color.FromArgb(192, 255, 192);
            UECPointstbx.ReadOnlyFillColor2 = Color.FromArgb(192, 255, 192);
            UECPointstbx.ReadOnlyPlaceholderColor = Color.DarkGray;
            UECPointstbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            UECPointstbx.ShadowAnimationDuration = 1;
            UECPointstbx.ShadowBlur = 10;
            UECPointstbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            UECPointstbx.Size = new Size(300, 50);
            UECPointstbx.SolidBorderColor = Color.Green;
            UECPointstbx.SolidBorderFocusColor = Color.Green;
            UECPointstbx.SolidBorderHoverColor = Color.Green;
            UECPointstbx.SolidFillColor = Color.FromArgb(192, 255, 192);
            UECPointstbx.TabIndex = 11;
            UECPointstbx.TextPadding = new Padding(11, 2, 11, 2);
            UECPointstbx.ValidationErrorMessage = "Invalid input.";
            UECPointstbx.ValidationFunction = null;
            // 
            // UECTitletbx
            // 
            UECTitletbx.AccessibleDescription = "A customizable text input field.";
            UECTitletbx.AccessibleName = "Text Box";
            UECTitletbx.AccessibleRole = AccessibleRole.Text;
            UECTitletbx.BackColor = Color.Transparent;
            UECTitletbx.BlinkCount = 3;
            UECTitletbx.BlinkShadow = false;
            UECTitletbx.BorderColor1 = Color.Green;
            UECTitletbx.BorderColor2 = Color.Green;
            UECTitletbx.BorderFocusColor1 = Color.Green;
            UECTitletbx.BorderFocusColor2 = Color.Green;
            UECTitletbx.BorderSize = 2;
            UECTitletbx.CanShake = true;
            UECTitletbx.ContinuousBlink = false;
            UECTitletbx.CornerRadiusBottomLeft = 10;
            UECTitletbx.CornerRadiusBottomRight = 10;
            UECTitletbx.CornerRadiusTopLeft = 10;
            UECTitletbx.CornerRadiusTopRight = 10;
            UECTitletbx.CursorBlinkRate = 500;
            UECTitletbx.CursorColor = Color.Black;
            UECTitletbx.CursorHeight = 26;
            UECTitletbx.CursorOffset = 0;
            UECTitletbx.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            UECTitletbx.CursorWidth = 1;
            UECTitletbx.DisabledBackColor = Color.WhiteSmoke;
            UECTitletbx.DisabledBorderColor = Color.LightGray;
            UECTitletbx.DisabledTextColor = Color.Gray;
            UECTitletbx.EnableDropShadow = false;
            UECTitletbx.FillColor1 = Color.White;
            UECTitletbx.FillColor2 = Color.White;
            UECTitletbx.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UECTitletbx.ForeColor = Color.FromArgb(0, 64, 0);
            UECTitletbx.HoverBorderColor1 = Color.Green;
            UECTitletbx.HoverBorderColor2 = Color.Green;
            UECTitletbx.IsEnabled = true;
            UECTitletbx.IsReadOnly = true;
            UECTitletbx.Location = new Point(16, 90);
            UECTitletbx.Margin = new Padding(0);
            UECTitletbx.Name = "UECTitletbx";
            UECTitletbx.PlaceholderColor = Color.Gray;
            UECTitletbx.PlaceholderText = "Title";
            UECTitletbx.ReadOnlyBorderColor1 = Color.FromArgb(0, 64, 0);
            UECTitletbx.ReadOnlyBorderColor2 = Color.FromArgb(0, 64, 0);
            UECTitletbx.ReadOnlyFillColor1 = Color.FromArgb(192, 255, 192);
            UECTitletbx.ReadOnlyFillColor2 = Color.FromArgb(192, 255, 192);
            UECTitletbx.ReadOnlyPlaceholderColor = Color.DarkGray;
            UECTitletbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            UECTitletbx.ShadowAnimationDuration = 1;
            UECTitletbx.ShadowBlur = 10;
            UECTitletbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            UECTitletbx.Size = new Size(300, 50);
            UECTitletbx.SolidBorderColor = Color.Green;
            UECTitletbx.SolidBorderFocusColor = Color.Green;
            UECTitletbx.SolidBorderHoverColor = Color.Green;
            UECTitletbx.SolidFillColor = Color.FromArgb(192, 255, 192);
            UECTitletbx.TabIndex = 11;
            UECTitletbx.TextPadding = new Padding(11, 2, 11, 2);
            UECTitletbx.ValidationErrorMessage = "Invalid input.";
            UECTitletbx.ValidationFunction = null;
            // 
            // UECJoinbtn
            // 
            UECJoinbtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            UECJoinbtn.AccessibleName = "Join";
            UECJoinbtn.AutoSizeBasedOnText = false;
            UECJoinbtn.BackColor = Color.Transparent;
            UECJoinbtn.BadgeBackColor = Color.Red;
            UECJoinbtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            UECJoinbtn.BadgeValue = 0;
            UECJoinbtn.BadgeValueForeColor = Color.Transparent;
            UECJoinbtn.BorderColor = Color.Transparent;
            UECJoinbtn.BorderWidth = 2;
            UECJoinbtn.ButtonBackColor = Color.Green;
            UECJoinbtn.ButtonImage = null;
            UECJoinbtn.CanBeep = true;
            UECJoinbtn.CanGlow = false;
            UECJoinbtn.CanShake = true;
            UECJoinbtn.ContextMenuStripEx = null;
            UECJoinbtn.CornerRadiusBottomLeft = 25;
            UECJoinbtn.CornerRadiusBottomRight = 25;
            UECJoinbtn.CornerRadiusTopLeft = 25;
            UECJoinbtn.CornerRadiusTopRight = 25;
            UECJoinbtn.CustomCursor = Cursors.Default;
            UECJoinbtn.DisabledTextColor = Color.Gray;
            UECJoinbtn.EnableLongPress = false;
            UECJoinbtn.EnablePressAnimation = true;
            UECJoinbtn.EnableRippleEffect = true;
            UECJoinbtn.EnableShadow = false;
            UECJoinbtn.EnableTextWrapping = false;
            UECJoinbtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UECJoinbtn.ForeColor = Color.White;
            UECJoinbtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            UECJoinbtn.GlowIntensity = 100;
            UECJoinbtn.GlowRadius = 20F;
            UECJoinbtn.GradientBackground = false;
            UECJoinbtn.GradientColor = Color.FromArgb(114, 168, 255);
            UECJoinbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            UECJoinbtn.HintText = null;
            UECJoinbtn.HoverBackColor = Color.SeaGreen;
            UECJoinbtn.HoverFontStyle = FontStyle.Regular;
            UECJoinbtn.HoverTextColor = Color.White;
            UECJoinbtn.HoverTransitionDuration = 250;
            UECJoinbtn.ImageAlign = ContentAlignment.MiddleLeft;
            UECJoinbtn.ImagePadding = 5;
            UECJoinbtn.ImageSize = new Size(16, 16);
            UECJoinbtn.IsRadial = true;
            UECJoinbtn.IsReadOnly = false;
            UECJoinbtn.IsToggleButton = false;
            UECJoinbtn.IsToggled = false;
            UECJoinbtn.Location = new Point(18, 478);
            UECJoinbtn.LongPressDurationMS = 1000;
            UECJoinbtn.Margin = new Padding(0);
            UECJoinbtn.Name = "UECJoinbtn";
            UECJoinbtn.NormalFontStyle = FontStyle.Regular;
            UECJoinbtn.ParticleColor = Color.FromArgb(200, 200, 200);
            UECJoinbtn.ParticleCount = 15;
            UECJoinbtn.PressAnimationScale = 0.97F;
            UECJoinbtn.PressedBackColor = Color.LightGreen;
            UECJoinbtn.PressedFontStyle = FontStyle.Regular;
            UECJoinbtn.PressTransitionDuration = 150;
            UECJoinbtn.ReadOnlyTextColor = Color.White;
            UECJoinbtn.RippleColor = Color.FromArgb(255, 255, 255);
            UECJoinbtn.RippleOpacity = 0.3F;
            UECJoinbtn.RippleRadiusMultiplier = 0.6F;
            UECJoinbtn.ShadowBlur = 5;
            UECJoinbtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            UECJoinbtn.ShadowOffset = new Point(2, 2);
            UECJoinbtn.ShakeDuration = 500;
            UECJoinbtn.ShakeIntensity = 5;
            UECJoinbtn.Size = new Size(125, 55);
            UECJoinbtn.TabIndex = 10;
            UECJoinbtn.Text = "Join";
            UECJoinbtn.TextAlign = ContentAlignment.MiddleCenter;
            UECJoinbtn.TextColor = Color.White;
            UECJoinbtn.TooltipText = null;
            UECJoinbtn.UseAdvancedRendering = true;
            UECJoinbtn.UseParticles = false;
            UECJoinbtn.Click += UECJoinbtn_Click;
            // 
            // UECTitle
            // 
            UECTitle.AutoSize = true;
            UECTitle.BackColor = Color.Transparent;
            UECTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UECTitle.ForeColor = Color.Green;
            UECTitle.Location = new Point(0, 0);
            UECTitle.Margin = new Padding(0);
            UECTitle.Name = "UECTitle";
            UECTitle.Size = new Size(316, 53);
            UECTitle.TabIndex = 0;
            UECTitle.Text = "Explore Challenges";
            // 
            // UserExploreChallenges
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 595);
            Controls.Add(UECMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserExploreChallenges";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserExploreChallenges";
            UECMainPanel.ResumeLayout(false);
            UECMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UECPersonalChallengesdgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)UECCommunityChallengesdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel UECMainPanel;
        private SiticoneNetCoreUI.SiticoneTextArea UECDescriptiontbx;
        private SiticoneNetCoreUI.SiticoneTextBox UECTitletbx;
        private Label UECTitle;
        private SiticoneNetCoreUI.SiticoneButton UECJoinbtn;
        private Label UECPersonaltxt;
        private Label UECCommunitytxt;
        private SiticoneNetCoreUI.SiticoneTextBox UECPointstbx;
        private SiticoneNetCoreUI.SiticoneButton UECRefreshbtn;
        private DataGridView UECPersonalChallengesdgv;
        private DataGridView UECCommunityChallengesdgv;
    }
}