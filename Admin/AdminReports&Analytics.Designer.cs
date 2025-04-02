namespace EcoChallenge.Admin
{
    partial class AdminReports_Analytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            ARAMainPanel = new Panel();
            ARADateTimebx = new ComboBox();
            ARABrgyCategorybx = new ComboBox();
            ARAChallengesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ARABrgyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ARATitle = new Label();
            ARAMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ARAChallengesChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ARABrgyChart).BeginInit();
            SuspendLayout();
            // 
            // ARAMainPanel
            // 
            ARAMainPanel.Controls.Add(ARADateTimebx);
            ARAMainPanel.Controls.Add(ARABrgyCategorybx);
            ARAMainPanel.Controls.Add(ARAChallengesChart);
            ARAMainPanel.Controls.Add(ARABrgyChart);
            ARAMainPanel.Controls.Add(ARATitle);
            ARAMainPanel.Location = new Point(22, 20);
            ARAMainPanel.Name = "ARAMainPanel";
            ARAMainPanel.Size = new Size(877, 554);
            ARAMainPanel.TabIndex = 7;
            // 
            // ARADateTimebx
            // 
            ARADateTimebx.BackColor = Color.FromArgb(192, 255, 192);
            ARADateTimebx.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ARADateTimebx.ForeColor = Color.FromArgb(0, 64, 0);
            ARADateTimebx.FormattingEnabled = true;
            ARADateTimebx.Location = new Point(605, 72);
            ARADateTimebx.Margin = new Padding(0);
            ARADateTimebx.Name = "ARADateTimebx";
            ARADateTimebx.Size = new Size(241, 38);
            ARADateTimebx.TabIndex = 13;
            // 
            // ARABrgyCategorybx
            // 
            ARABrgyCategorybx.BackColor = Color.FromArgb(192, 255, 192);
            ARABrgyCategorybx.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ARABrgyCategorybx.ForeColor = Color.FromArgb(0, 64, 0);
            ARABrgyCategorybx.FormattingEnabled = true;
            ARABrgyCategorybx.Location = new Point(156, 72);
            ARABrgyCategorybx.Margin = new Padding(0);
            ARABrgyCategorybx.Name = "ARABrgyCategorybx";
            ARABrgyCategorybx.Size = new Size(241, 38);
            ARABrgyCategorybx.TabIndex = 13;
            // 
            // ARAChallengesChart
            // 
            ARAChallengesChart.BackColor = Color.Honeydew;
            chartArea1.Name = "ChartArea1";
            ARAChallengesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ARAChallengesChart.Legends.Add(legend1);
            ARAChallengesChart.Location = new Point(471, 162);
            ARAChallengesChart.Name = "ARAChallengesChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ARAChallengesChart.Series.Add(series1);
            ARAChallengesChart.Size = new Size(375, 375);
            ARAChallengesChart.TabIndex = 12;
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.ForeColor = Color.Green;
            title1.Name = "Title1";
            title1.Text = "Popular Challenges";
            ARAChallengesChart.Titles.Add(title1);
            // 
            // ARABrgyChart
            // 
            ARABrgyChart.BackColor = Color.Honeydew;
            chartArea2.Name = "ChartArea1";
            ARABrgyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ARABrgyChart.Legends.Add(legend2);
            ARABrgyChart.Location = new Point(22, 162);
            ARABrgyChart.Name = "ARABrgyChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ARABrgyChart.Series.Add(series2);
            ARABrgyChart.Size = new Size(375, 375);
            ARABrgyChart.TabIndex = 11;
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2.ForeColor = Color.Green;
            title2.Name = "Title1";
            title2.Text = "Popular Barangays";
            ARABrgyChart.Titles.Add(title2);
            // 
            // ARATitle
            // 
            ARATitle.AutoSize = true;
            ARATitle.BackColor = Color.Transparent;
            ARATitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ARATitle.ForeColor = Color.Green;
            ARATitle.Location = new Point(0, 0);
            ARATitle.Margin = new Padding(0);
            ARATitle.Name = "ARATitle";
            ARATitle.Size = new Size(360, 53);
            ARATitle.TabIndex = 0;
            ARATitle.Text = "Reports and Analytics";
            // 
            // AdminReports_Analytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 595);
            Controls.Add(ARAMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminReports_Analytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminReports_Analytics";
            ARAMainPanel.ResumeLayout(false);
            ARAMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ARAChallengesChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)ARABrgyChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ARAMainPanel;
        private PictureBox ARCSProofImagebx;
        private DataGridView ARCSSubmissionsdgv;
        private Label ARCSProofImagelbl;
        private Label ARATitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart ARABrgyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ARAChallengesChart;
        private ComboBox ARADateTimebx;
        private ComboBox ARABrgyCategorybx;
    }
}