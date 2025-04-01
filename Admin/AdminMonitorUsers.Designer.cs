namespace EcoChallenge.Admin
{
    partial class AdminMonitorUsers
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
            AMUMainPanel = new Panel();
            AMUTitle = new Label();
            AMUChallengeUpdatesListbx = new ListBox();
            AMUChallengeUpdateslbl = new Label();
            AMUCompletedChallengeslbl = new Label();
            AMUCompletedChallengestxt = new ListBox();
            AMULeaderboardPanel = new SiticoneNetCoreUI.SiticonePanel();
            AMUFifthPlaceNumber = new Label();
            AMUFourthPlaceNumber = new Label();
            AMUThirdPlaceNumber = new Label();
            AMUSecondPlaceNumber = new Label();
            AMUFirstPlaceNumber = new Label();
            AMUFifthPlacelbl = new Label();
            AMUFourthPlacelbl = new Label();
            AMUThirdPlacelbl = new Label();
            AMUSecondPlacelbl = new Label();
            AMUFirstPlacelbl = new Label();
            AMULeaderboardTitle = new Label();
            AMURedeembtn = new SiticoneNetCoreUI.SiticoneButton();
            AMUPointstbx = new SiticoneNetCoreUI.SiticoneTextBox();
            AMUMainPanel.SuspendLayout();
            AMULeaderboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AMUMainPanel
            // 
            AMUMainPanel.Controls.Add(AMUPointstbx);
            AMUMainPanel.Controls.Add(AMURedeembtn);
            AMUMainPanel.Controls.Add(AMULeaderboardPanel);
            AMUMainPanel.Controls.Add(AMUCompletedChallengestxt);
            AMUMainPanel.Controls.Add(AMUChallengeUpdatesListbx);
            AMUMainPanel.Controls.Add(AMUTitle);
            AMUMainPanel.Controls.Add(AMUCompletedChallengeslbl);
            AMUMainPanel.Controls.Add(AMUChallengeUpdateslbl);
            AMUMainPanel.Location = new Point(22, 20);
            AMUMainPanel.Name = "AMUMainPanel";
            AMUMainPanel.Size = new Size(877, 554);
            AMUMainPanel.TabIndex = 4;
            // 
            // AMUTitle
            // 
            AMUTitle.AutoSize = true;
            AMUTitle.BackColor = Color.Transparent;
            AMUTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUTitle.ForeColor = Color.Green;
            AMUTitle.Location = new Point(2, 0);
            AMUTitle.Margin = new Padding(0);
            AMUTitle.Name = "AMUTitle";
            AMUTitle.Size = new Size(235, 53);
            AMUTitle.TabIndex = 0;
            AMUTitle.Text = "Monitor Users";
            AMUTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AMUChallengeUpdatesListbx
            // 
            AMUChallengeUpdatesListbx.BackColor = Color.FromArgb(192, 255, 192);
            AMUChallengeUpdatesListbx.BorderStyle = BorderStyle.FixedSingle;
            AMUChallengeUpdatesListbx.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUChallengeUpdatesListbx.ForeColor = Color.FromArgb(0, 64, 0);
            AMUChallengeUpdatesListbx.FormattingEnabled = true;
            AMUChallengeUpdatesListbx.HorizontalScrollbar = true;
            AMUChallengeUpdatesListbx.ItemHeight = 30;
            AMUChallengeUpdatesListbx.Location = new Point(15, 89);
            AMUChallengeUpdatesListbx.Margin = new Padding(0);
            AMUChallengeUpdatesListbx.Name = "AMUChallengeUpdatesListbx";
            AMUChallengeUpdatesListbx.Size = new Size(587, 122);
            AMUChallengeUpdatesListbx.TabIndex = 7;
            // 
            // AMUChallengeUpdateslbl
            // 
            AMUChallengeUpdateslbl.AutoSize = true;
            AMUChallengeUpdateslbl.BackColor = Color.Transparent;
            AMUChallengeUpdateslbl.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUChallengeUpdateslbl.ForeColor = Color.Green;
            AMUChallengeUpdateslbl.Location = new Point(15, 53);
            AMUChallengeUpdateslbl.Margin = new Padding(0);
            AMUChallengeUpdateslbl.Name = "AMUChallengeUpdateslbl";
            AMUChallengeUpdateslbl.Size = new Size(211, 36);
            AMUChallengeUpdateslbl.TabIndex = 0;
            AMUChallengeUpdateslbl.Text = "Challenge Updates";
            AMUChallengeUpdateslbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AMUCompletedChallengeslbl
            // 
            AMUCompletedChallengeslbl.AutoSize = true;
            AMUCompletedChallengeslbl.BackColor = Color.Transparent;
            AMUCompletedChallengeslbl.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUCompletedChallengeslbl.ForeColor = Color.Green;
            AMUCompletedChallengeslbl.Location = new Point(15, 230);
            AMUCompletedChallengeslbl.Margin = new Padding(0);
            AMUCompletedChallengeslbl.Name = "AMUCompletedChallengeslbl";
            AMUCompletedChallengeslbl.Size = new Size(211, 36);
            AMUCompletedChallengeslbl.TabIndex = 0;
            AMUCompletedChallengeslbl.Text = "Challenge Updates";
            AMUCompletedChallengeslbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AMUCompletedChallengestxt
            // 
            AMUCompletedChallengestxt.BackColor = Color.FromArgb(192, 255, 192);
            AMUCompletedChallengestxt.BorderStyle = BorderStyle.FixedSingle;
            AMUCompletedChallengestxt.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUCompletedChallengestxt.ForeColor = Color.FromArgb(0, 64, 0);
            AMUCompletedChallengestxt.FormattingEnabled = true;
            AMUCompletedChallengestxt.HorizontalScrollbar = true;
            AMUCompletedChallengestxt.ItemHeight = 30;
            AMUCompletedChallengestxt.Location = new Point(15, 266);
            AMUCompletedChallengestxt.Margin = new Padding(0);
            AMUCompletedChallengestxt.Name = "AMUCompletedChallengestxt";
            AMUCompletedChallengestxt.Size = new Size(587, 122);
            AMUCompletedChallengestxt.TabIndex = 7;
            // 
            // AMULeaderboardPanel
            // 
            AMULeaderboardPanel.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            AMULeaderboardPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AMULeaderboardPanel.BackColor = Color.Transparent;
            AMULeaderboardPanel.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            AMULeaderboardPanel.BorderDashPattern = null;
            AMULeaderboardPanel.BorderGradientEndColor = Color.Green;
            AMULeaderboardPanel.BorderGradientStartColor = Color.Green;
            AMULeaderboardPanel.BorderThickness = 5F;
            AMULeaderboardPanel.Controls.Add(AMUFifthPlaceNumber);
            AMULeaderboardPanel.Controls.Add(AMUFourthPlaceNumber);
            AMULeaderboardPanel.Controls.Add(AMUThirdPlaceNumber);
            AMULeaderboardPanel.Controls.Add(AMUSecondPlaceNumber);
            AMULeaderboardPanel.Controls.Add(AMUFirstPlaceNumber);
            AMULeaderboardPanel.Controls.Add(AMUFifthPlacelbl);
            AMULeaderboardPanel.Controls.Add(AMUFourthPlacelbl);
            AMULeaderboardPanel.Controls.Add(AMUThirdPlacelbl);
            AMULeaderboardPanel.Controls.Add(AMUSecondPlacelbl);
            AMULeaderboardPanel.Controls.Add(AMUFirstPlacelbl);
            AMULeaderboardPanel.Controls.Add(AMULeaderboardTitle);
            AMULeaderboardPanel.CornerRadiusBottomLeft = 10F;
            AMULeaderboardPanel.CornerRadiusBottomRight = 10F;
            AMULeaderboardPanel.CornerRadiusTopLeft = 10F;
            AMULeaderboardPanel.CornerRadiusTopRight = 10F;
            AMULeaderboardPanel.EnableAcrylicEffect = false;
            AMULeaderboardPanel.EnableMicaEffect = false;
            AMULeaderboardPanel.EnableRippleEffect = false;
            AMULeaderboardPanel.FillColor = Color.Honeydew;
            AMULeaderboardPanel.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            AMULeaderboardPanel.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            AMULeaderboardPanel.Location = new Point(630, 0);
            AMULeaderboardPanel.Margin = new Padding(0);
            AMULeaderboardPanel.Name = "AMULeaderboardPanel";
            AMULeaderboardPanel.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            AMULeaderboardPanel.RippleAlpha = 50;
            AMULeaderboardPanel.RippleAlphaDecrement = 3;
            AMULeaderboardPanel.RippleColor = Color.FromArgb(50, 255, 255, 255);
            AMULeaderboardPanel.RippleMaxSize = 600F;
            AMULeaderboardPanel.RippleSpeed = 15F;
            AMULeaderboardPanel.ShowBorder = true;
            AMULeaderboardPanel.Size = new Size(247, 554);
            AMULeaderboardPanel.TabIndex = 13;
            AMULeaderboardPanel.TabStop = true;
            AMULeaderboardPanel.UseBorderGradient = true;
            AMULeaderboardPanel.UseMultiGradient = false;
            AMULeaderboardPanel.UsePatternTexture = false;
            AMULeaderboardPanel.UseRadialGradient = false;
            // 
            // AMUFifthPlaceNumber
            // 
            AMUFifthPlaceNumber.AutoSize = true;
            AMUFifthPlaceNumber.BackColor = Color.Transparent;
            AMUFifthPlaceNumber.FlatStyle = FlatStyle.Flat;
            AMUFifthPlaceNumber.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUFifthPlaceNumber.ForeColor = Color.Green;
            AMUFifthPlaceNumber.Location = new Point(5, 345);
            AMUFifthPlaceNumber.Margin = new Padding(0);
            AMUFifthPlaceNumber.Name = "AMUFifthPlaceNumber";
            AMUFifthPlaceNumber.Size = new Size(50, 53);
            AMUFifthPlaceNumber.TabIndex = 3;
            AMUFifthPlaceNumber.Text = "5.";
            // 
            // AMUFourthPlaceNumber
            // 
            AMUFourthPlaceNumber.AutoSize = true;
            AMUFourthPlaceNumber.BackColor = Color.Transparent;
            AMUFourthPlaceNumber.FlatStyle = FlatStyle.Flat;
            AMUFourthPlaceNumber.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUFourthPlaceNumber.ForeColor = Color.Green;
            AMUFourthPlaceNumber.Location = new Point(13, 278);
            AMUFourthPlaceNumber.Margin = new Padding(0);
            AMUFourthPlaceNumber.Name = "AMUFourthPlaceNumber";
            AMUFourthPlaceNumber.Size = new Size(51, 53);
            AMUFourthPlaceNumber.TabIndex = 3;
            AMUFourthPlaceNumber.Text = "4.";
            // 
            // AMUThirdPlaceNumber
            // 
            AMUThirdPlaceNumber.AutoSize = true;
            AMUThirdPlaceNumber.BackColor = Color.Transparent;
            AMUThirdPlaceNumber.FlatStyle = FlatStyle.Flat;
            AMUThirdPlaceNumber.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUThirdPlaceNumber.ForeColor = Color.Green;
            AMUThirdPlaceNumber.Location = new Point(13, 213);
            AMUThirdPlaceNumber.Margin = new Padding(0);
            AMUThirdPlaceNumber.Name = "AMUThirdPlaceNumber";
            AMUThirdPlaceNumber.Size = new Size(49, 53);
            AMUThirdPlaceNumber.TabIndex = 3;
            AMUThirdPlaceNumber.Text = "3.";
            // 
            // AMUSecondPlaceNumber
            // 
            AMUSecondPlaceNumber.AutoSize = true;
            AMUSecondPlaceNumber.BackColor = Color.Transparent;
            AMUSecondPlaceNumber.FlatStyle = FlatStyle.Flat;
            AMUSecondPlaceNumber.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUSecondPlaceNumber.ForeColor = Color.Green;
            AMUSecondPlaceNumber.Location = new Point(13, 144);
            AMUSecondPlaceNumber.Margin = new Padding(0);
            AMUSecondPlaceNumber.Name = "AMUSecondPlaceNumber";
            AMUSecondPlaceNumber.Size = new Size(48, 53);
            AMUSecondPlaceNumber.TabIndex = 3;
            AMUSecondPlaceNumber.Text = "2.";
            // 
            // AMUFirstPlaceNumber
            // 
            AMUFirstPlaceNumber.AutoSize = true;
            AMUFirstPlaceNumber.BackColor = Color.Transparent;
            AMUFirstPlaceNumber.FlatStyle = FlatStyle.Flat;
            AMUFirstPlaceNumber.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUFirstPlaceNumber.ForeColor = Color.Green;
            AMUFirstPlaceNumber.Location = new Point(13, 78);
            AMUFirstPlaceNumber.Margin = new Padding(0);
            AMUFirstPlaceNumber.Name = "AMUFirstPlaceNumber";
            AMUFirstPlaceNumber.Size = new Size(42, 53);
            AMUFirstPlaceNumber.TabIndex = 3;
            AMUFirstPlaceNumber.Text = "1.";
            // 
            // AMUFifthPlacelbl
            // 
            AMUFifthPlacelbl.AutoSize = true;
            AMUFifthPlacelbl.BackColor = Color.Transparent;
            AMUFifthPlacelbl.FlatStyle = FlatStyle.Flat;
            AMUFifthPlacelbl.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUFifthPlacelbl.ForeColor = Color.Green;
            AMUFifthPlacelbl.Location = new Point(55, 345);
            AMUFifthPlacelbl.Margin = new Padding(0);
            AMUFifthPlacelbl.Name = "AMUFifthPlacelbl";
            AMUFifthPlacelbl.Size = new Size(116, 53);
            AMUFifthPlacelbl.TabIndex = 3;
            AMUFifthPlacelbl.Text = "Name";
            // 
            // AMUFourthPlacelbl
            // 
            AMUFourthPlacelbl.AutoSize = true;
            AMUFourthPlacelbl.BackColor = Color.Transparent;
            AMUFourthPlacelbl.FlatStyle = FlatStyle.Flat;
            AMUFourthPlacelbl.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUFourthPlacelbl.ForeColor = Color.Green;
            AMUFourthPlacelbl.Location = new Point(55, 278);
            AMUFourthPlacelbl.Margin = new Padding(0);
            AMUFourthPlacelbl.Name = "AMUFourthPlacelbl";
            AMUFourthPlacelbl.Size = new Size(116, 53);
            AMUFourthPlacelbl.TabIndex = 3;
            AMUFourthPlacelbl.Text = "Name";
            // 
            // AMUThirdPlacelbl
            // 
            AMUThirdPlacelbl.AutoSize = true;
            AMUThirdPlacelbl.BackColor = Color.Transparent;
            AMUThirdPlacelbl.FlatStyle = FlatStyle.Flat;
            AMUThirdPlacelbl.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUThirdPlacelbl.ForeColor = Color.Green;
            AMUThirdPlacelbl.Location = new Point(55, 213);
            AMUThirdPlacelbl.Margin = new Padding(0);
            AMUThirdPlacelbl.Name = "AMUThirdPlacelbl";
            AMUThirdPlacelbl.Size = new Size(116, 53);
            AMUThirdPlacelbl.TabIndex = 3;
            AMUThirdPlacelbl.Text = "Name";
            // 
            // AMUSecondPlacelbl
            // 
            AMUSecondPlacelbl.AutoSize = true;
            AMUSecondPlacelbl.BackColor = Color.Transparent;
            AMUSecondPlacelbl.FlatStyle = FlatStyle.Flat;
            AMUSecondPlacelbl.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUSecondPlacelbl.ForeColor = Color.Green;
            AMUSecondPlacelbl.Location = new Point(55, 144);
            AMUSecondPlacelbl.Margin = new Padding(0);
            AMUSecondPlacelbl.Name = "AMUSecondPlacelbl";
            AMUSecondPlacelbl.Size = new Size(116, 53);
            AMUSecondPlacelbl.TabIndex = 3;
            AMUSecondPlacelbl.Text = "Name";
            // 
            // AMUFirstPlacelbl
            // 
            AMUFirstPlacelbl.AutoSize = true;
            AMUFirstPlacelbl.BackColor = Color.Transparent;
            AMUFirstPlacelbl.FlatStyle = FlatStyle.Flat;
            AMUFirstPlacelbl.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMUFirstPlacelbl.ForeColor = Color.Green;
            AMUFirstPlacelbl.Location = new Point(55, 78);
            AMUFirstPlacelbl.Margin = new Padding(0);
            AMUFirstPlacelbl.Name = "AMUFirstPlacelbl";
            AMUFirstPlacelbl.Size = new Size(116, 53);
            AMUFirstPlacelbl.TabIndex = 3;
            AMUFirstPlacelbl.Text = "Name";
            // 
            // AMULeaderboardTitle
            // 
            AMULeaderboardTitle.AutoSize = true;
            AMULeaderboardTitle.BackColor = Color.Transparent;
            AMULeaderboardTitle.FlatStyle = FlatStyle.Flat;
            AMULeaderboardTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMULeaderboardTitle.ForeColor = Color.Green;
            AMULeaderboardTitle.Location = new Point(13, 13);
            AMULeaderboardTitle.Margin = new Padding(0);
            AMULeaderboardTitle.Name = "AMULeaderboardTitle";
            AMULeaderboardTitle.Size = new Size(218, 53);
            AMULeaderboardTitle.TabIndex = 3;
            AMULeaderboardTitle.Text = "Leaderboard";
            // 
            // AMURedeembtn
            // 
            AMURedeembtn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            AMURedeembtn.AccessibleName = "Point";
            AMURedeembtn.AutoSizeBasedOnText = false;
            AMURedeembtn.BackColor = Color.Transparent;
            AMURedeembtn.BadgeBackColor = Color.Red;
            AMURedeembtn.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            AMURedeembtn.BadgeValue = 0;
            AMURedeembtn.BadgeValueForeColor = Color.Transparent;
            AMURedeembtn.BorderColor = Color.Transparent;
            AMURedeembtn.BorderWidth = 2;
            AMURedeembtn.ButtonBackColor = Color.Green;
            AMURedeembtn.ButtonImage = null;
            AMURedeembtn.CanBeep = true;
            AMURedeembtn.CanGlow = false;
            AMURedeembtn.CanShake = true;
            AMURedeembtn.ContextMenuStripEx = null;
            AMURedeembtn.CornerRadiusBottomLeft = 25;
            AMURedeembtn.CornerRadiusBottomRight = 25;
            AMURedeembtn.CornerRadiusTopLeft = 25;
            AMURedeembtn.CornerRadiusTopRight = 25;
            AMURedeembtn.CustomCursor = Cursors.Default;
            AMURedeembtn.DisabledTextColor = Color.Gray;
            AMURedeembtn.EnableLongPress = false;
            AMURedeembtn.EnablePressAnimation = true;
            AMURedeembtn.EnableRippleEffect = true;
            AMURedeembtn.EnableShadow = false;
            AMURedeembtn.EnableTextWrapping = false;
            AMURedeembtn.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMURedeembtn.ForeColor = Color.White;
            AMURedeembtn.GlowColor = Color.FromArgb(100, 255, 255, 255);
            AMURedeembtn.GlowIntensity = 100;
            AMURedeembtn.GlowRadius = 20F;
            AMURedeembtn.GradientBackground = false;
            AMURedeembtn.GradientColor = Color.FromArgb(114, 168, 255);
            AMURedeembtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            AMURedeembtn.HintText = null;
            AMURedeembtn.HoverBackColor = Color.SeaGreen;
            AMURedeembtn.HoverFontStyle = FontStyle.Regular;
            AMURedeembtn.HoverTextColor = Color.White;
            AMURedeembtn.HoverTransitionDuration = 250;
            AMURedeembtn.ImageAlign = ContentAlignment.MiddleLeft;
            AMURedeembtn.ImagePadding = 5;
            AMURedeembtn.ImageSize = new Size(16, 16);
            AMURedeembtn.IsRadial = true;
            AMURedeembtn.IsReadOnly = false;
            AMURedeembtn.IsToggleButton = false;
            AMURedeembtn.IsToggled = false;
            AMURedeembtn.Location = new Point(15, 499);
            AMURedeembtn.LongPressDurationMS = 1000;
            AMURedeembtn.Margin = new Padding(0);
            AMURedeembtn.Name = "AMURedeembtn";
            AMURedeembtn.NormalFontStyle = FontStyle.Regular;
            AMURedeembtn.ParticleColor = Color.FromArgb(200, 200, 200);
            AMURedeembtn.ParticleCount = 15;
            AMURedeembtn.PressAnimationScale = 0.97F;
            AMURedeembtn.PressedBackColor = Color.LightGreen;
            AMURedeembtn.PressedFontStyle = FontStyle.Regular;
            AMURedeembtn.PressTransitionDuration = 150;
            AMURedeembtn.ReadOnlyTextColor = Color.White;
            AMURedeembtn.RippleColor = Color.FromArgb(255, 255, 255);
            AMURedeembtn.RippleOpacity = 0.3F;
            AMURedeembtn.RippleRadiusMultiplier = 0.6F;
            AMURedeembtn.ShadowBlur = 5;
            AMURedeembtn.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            AMURedeembtn.ShadowOffset = new Point(2, 2);
            AMURedeembtn.ShakeDuration = 500;
            AMURedeembtn.ShakeIntensity = 5;
            AMURedeembtn.Size = new Size(125, 55);
            AMURedeembtn.TabIndex = 14;
            AMURedeembtn.Text = "Point";
            AMURedeembtn.TextAlign = ContentAlignment.MiddleCenter;
            AMURedeembtn.TextColor = Color.White;
            AMURedeembtn.TooltipText = null;
            AMURedeembtn.UseAdvancedRendering = true;
            AMURedeembtn.UseParticles = false;
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
            AMUPointstbx.Location = new Point(15, 419);
            AMUPointstbx.Margin = new Padding(0);
            AMUPointstbx.Name = "AMUPointstbx";
            AMUPointstbx.PlaceholderColor = Color.Gray;
            AMUPointstbx.PlaceholderText = "0";
            AMUPointstbx.ReadOnlyBorderColor1 = Color.LightGray;
            AMUPointstbx.ReadOnlyBorderColor2 = Color.LightGray;
            AMUPointstbx.ReadOnlyFillColor1 = Color.WhiteSmoke;
            AMUPointstbx.ReadOnlyFillColor2 = Color.WhiteSmoke;
            AMUPointstbx.ReadOnlyPlaceholderColor = Color.DarkGray;
            AMUPointstbx.SelectionBackColor = Color.FromArgb(77, 77, 255);
            AMUPointstbx.ShadowAnimationDuration = 1;
            AMUPointstbx.ShadowBlur = 10;
            AMUPointstbx.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            AMUPointstbx.Size = new Size(222, 50);
            AMUPointstbx.SolidBorderColor = Color.Green;
            AMUPointstbx.SolidBorderFocusColor = Color.Green;
            AMUPointstbx.SolidBorderHoverColor = Color.Green;
            AMUPointstbx.SolidFillColor = Color.FromArgb(192, 255, 192);
            AMUPointstbx.TabIndex = 15;
            AMUPointstbx.TextPadding = new Padding(11, 2, 11, 2);
            AMUPointstbx.ValidationErrorMessage = "Invalid input.";
            AMUPointstbx.ValidationFunction = null;
            // 
            // AdminMonitorUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 595);
            Controls.Add(AMUMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMonitorUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMonitorUsers";
            AMUMainPanel.ResumeLayout(false);
            AMUMainPanel.PerformLayout();
            AMULeaderboardPanel.ResumeLayout(false);
            AMULeaderboardPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AMUMainPanel;
        private ListBox AMUCompletedChallengestxt;
        private ListBox AMUChallengeUpdatesListbx;
        private Label AMUTitle;
        private Label AMUCompletedChallengeslbl;
        private Label AMUChallengeUpdateslbl;
        private SiticoneNetCoreUI.SiticonePanel AMULeaderboardPanel;
        private Label AMUFifthPlaceNumber;
        private Label AMUFourthPlaceNumber;
        private Label AMUThirdPlaceNumber;
        private Label AMUSecondPlaceNumber;
        private Label AMUFirstPlaceNumber;
        private Label AMUFifthPlacelbl;
        private Label AMUFourthPlacelbl;
        private Label AMUThirdPlacelbl;
        private Label AMUSecondPlacelbl;
        private Label AMUFirstPlacelbl;
        private Label AMULeaderboardTitle;
        private SiticoneNetCoreUI.SiticoneButton AMURedeembtn;
        private SiticoneNetCoreUI.SiticoneTextBox AMUPointstbx;
    }
}