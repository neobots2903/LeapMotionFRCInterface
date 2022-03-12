namespace Leap_Motion_FRC_Interface
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeapLog = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.LeapValChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LeapFingerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LeapRotateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChkBoxViewData = new System.Windows.Forms.CheckBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTeamNum = new System.Windows.Forms.TextBox();
            this.TeamNumLabel = new System.Windows.Forms.Label();
            this.BtnTeamNum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeapValChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeapFingerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeapRotateChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LeapLog
            // 
            this.LeapLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeapLog.Enabled = false;
            this.LeapLog.Location = new System.Drawing.Point(12, 25);
            this.LeapLog.Multiline = true;
            this.LeapLog.Name = "LeapLog";
            this.LeapLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LeapLog.Size = new System.Drawing.Size(259, 378);
            this.LeapLog.TabIndex = 1;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(12, 9);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(28, 13);
            this.LogLabel.TabIndex = 2;
            this.LogLabel.Text = "Log:";
            // 
            // LeapValChart
            // 
            chartArea1.Name = "ChartArea1";
            this.LeapValChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LeapValChart.Legends.Add(legend1);
            this.LeapValChart.Location = new System.Drawing.Point(277, 234);
            this.LeapValChart.Name = "LeapValChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.LeapValChart.Series.Add(series1);
            this.LeapValChart.Size = new System.Drawing.Size(292, 195);
            this.LeapValChart.TabIndex = 4;
            this.LeapValChart.Text = "chart1";
            // 
            // LeapFingerChart
            // 
            chartArea2.Name = "ChartArea1";
            this.LeapFingerChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.LeapFingerChart.Legends.Add(legend2);
            this.LeapFingerChart.Location = new System.Drawing.Point(575, 25);
            this.LeapFingerChart.Name = "LeapFingerChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.LeapFingerChart.Series.Add(series2);
            this.LeapFingerChart.Size = new System.Drawing.Size(273, 203);
            this.LeapFingerChart.TabIndex = 5;
            this.LeapFingerChart.Text = "chart1";
            // 
            // LeapRotateChart
            // 
            chartArea3.Name = "ChartArea1";
            this.LeapRotateChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.LeapRotateChart.Legends.Add(legend3);
            this.LeapRotateChart.Location = new System.Drawing.Point(575, 234);
            this.LeapRotateChart.Name = "LeapRotateChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.LeapRotateChart.Series.Add(series3);
            this.LeapRotateChart.Size = new System.Drawing.Size(273, 195);
            this.LeapRotateChart.TabIndex = 6;
            this.LeapRotateChart.Text = "chart1";
            // 
            // ChkBoxViewData
            // 
            this.ChkBoxViewData.AutoSize = true;
            this.ChkBoxViewData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChkBoxViewData.Location = new System.Drawing.Point(191, 5);
            this.ChkBoxViewData.Name = "ChkBoxViewData";
            this.ChkBoxViewData.Size = new System.Drawing.Size(75, 17);
            this.ChkBoxViewData.TabIndex = 7;
            this.ChkBoxViewData.Text = "View Data";
            this.ChkBoxViewData.UseVisualStyleBackColor = true;
            this.ChkBoxViewData.CheckedChanged += new System.EventHandler(this.ChkBoxViewData_CheckedChanged);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(278, 25);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(291, 203);
            this.txtData.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTeamNum
            // 
            this.txtTeamNum.Location = new System.Drawing.Point(95, 409);
            this.txtTeamNum.MaxLength = 6;
            this.txtTeamNum.Name = "txtTeamNum";
            this.txtTeamNum.Size = new System.Drawing.Size(125, 20);
            this.txtTeamNum.TabIndex = 9;
            // 
            // TeamNumLabel
            // 
            this.TeamNumLabel.AutoSize = true;
            this.TeamNumLabel.Location = new System.Drawing.Point(12, 412);
            this.TeamNumLabel.Name = "TeamNumLabel";
            this.TeamNumLabel.Size = new System.Drawing.Size(77, 13);
            this.TeamNumLabel.TabIndex = 10;
            this.TeamNumLabel.Text = "Team Number:";
            // 
            // BtnTeamNum
            // 
            this.BtnTeamNum.Location = new System.Drawing.Point(226, 407);
            this.BtnTeamNum.Name = "BtnTeamNum";
            this.BtnTeamNum.Size = new System.Drawing.Size(45, 23);
            this.BtnTeamNum.TabIndex = 11;
            this.BtnTeamNum.Text = "Set";
            this.BtnTeamNum.UseVisualStyleBackColor = true;
            this.BtnTeamNum.Click += new System.EventHandler(this.BtnTeamNum_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 441);
            this.Controls.Add(this.BtnTeamNum);
            this.Controls.Add(this.TeamNumLabel);
            this.Controls.Add(this.txtTeamNum);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.ChkBoxViewData);
            this.Controls.Add(this.LeapRotateChart);
            this.Controls.Add(this.LeapFingerChart);
            this.Controls.Add(this.LeapValChart);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.LeapLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Leap Motion FRC Interface";
            ((System.ComponentModel.ISupportInitialize)(this.LeapValChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeapFingerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeapRotateChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LeapLog;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart LeapValChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LeapFingerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LeapRotateChart;
        private System.Windows.Forms.CheckBox ChkBoxViewData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTeamNum;
        private System.Windows.Forms.Label TeamNumLabel;
        private System.Windows.Forms.Button BtnTeamNum;
    }
}

