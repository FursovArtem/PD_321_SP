namespace TaskManager
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelProcesses = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPagePerformance = new System.Windows.Forms.TabPage();
            this.metroLabelRAM = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabelCPU = new MetroFramework.Controls.MetroLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonCPU = new System.Windows.Forms.Button();
            this.buttonSystemInformation = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.performanceCounterCPU = new System.Diagnostics.PerformanceCounter();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.listViewProcesses = new TaskManager.ListViewNoFlickering();
            this.performanceCounterRAM = new System.Diagnostics.PerformanceCounter();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRAM = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabPagePerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageProcesses);
            this.tabControl.Controls.Add(this.tabPagePerformance);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(797, 432);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.Controls.Add(this.statusStrip);
            this.tabPageProcesses.Controls.Add(this.listViewProcesses);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesses.Size = new System.Drawing.Size(789, 406);
            this.tabPageProcesses.TabIndex = 0;
            this.tabPageProcesses.Text = "Processes";
            this.tabPageProcesses.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelProcesses});
            this.statusStrip.Location = new System.Drawing.Point(3, 381);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(783, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelProcesses
            // 
            this.toolStripStatusLabelProcesses.Name = "toolStripStatusLabelProcesses";
            this.toolStripStatusLabelProcesses.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelProcesses.Text = "toolStripStatusLabel1";
            // 
            // tabPagePerformance
            // 
            this.tabPagePerformance.Controls.Add(this.buttonRAM);
            this.tabPagePerformance.Controls.Add(this.chart);
            this.tabPagePerformance.Controls.Add(this.lblRAM);
            this.tabPagePerformance.Controls.Add(this.lblCPU);
            this.tabPagePerformance.Controls.Add(this.metroLabelRAM);
            this.tabPagePerformance.Controls.Add(this.metroProgressBarRAM);
            this.tabPagePerformance.Controls.Add(this.metroProgressBarCPU);
            this.tabPagePerformance.Controls.Add(this.metroLabelCPU);
            this.tabPagePerformance.Controls.Add(this.richTextBox);
            this.tabPagePerformance.Controls.Add(this.buttonCPU);
            this.tabPagePerformance.Controls.Add(this.buttonSystemInformation);
            this.tabPagePerformance.Location = new System.Drawing.Point(4, 22);
            this.tabPagePerformance.Name = "tabPagePerformance";
            this.tabPagePerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerformance.Size = new System.Drawing.Size(789, 406);
            this.tabPagePerformance.TabIndex = 1;
            this.tabPagePerformance.Text = "Performance";
            this.tabPagePerformance.UseVisualStyleBackColor = true;
            // 
            // metroLabelRAM
            // 
            this.metroLabelRAM.AutoSize = true;
            this.metroLabelRAM.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelRAM.Location = new System.Drawing.Point(6, 31);
            this.metroLabelRAM.Name = "metroLabelRAM";
            this.metroLabelRAM.Size = new System.Drawing.Size(42, 19);
            this.metroLabelRAM.TabIndex = 7;
            this.metroLabelRAM.Text = "RAM:";
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(57, 31);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(662, 19);
            this.metroProgressBarRAM.TabIndex = 6;
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(57, 6);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(662, 19);
            this.metroProgressBarCPU.TabIndex = 6;
            // 
            // metroLabelCPU
            // 
            this.metroLabelCPU.AutoSize = true;
            this.metroLabelCPU.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelCPU.Location = new System.Drawing.Point(9, 6);
            this.metroLabelCPU.Name = "metroLabelCPU";
            this.metroLabelCPU.Size = new System.Drawing.Size(39, 19);
            this.metroLabelCPU.TabIndex = 3;
            this.metroLabelCPU.Text = "CPU:";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(160, 218);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(624, 177);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // buttonCPU
            // 
            this.buttonCPU.Location = new System.Drawing.Point(6, 218);
            this.buttonCPU.Name = "buttonCPU";
            this.buttonCPU.Size = new System.Drawing.Size(148, 67);
            this.buttonCPU.TabIndex = 1;
            this.buttonCPU.Text = "CPU Information";
            this.buttonCPU.UseVisualStyleBackColor = true;
            this.buttonCPU.Click += new System.EventHandler(this.buttonCPU_Click);
            // 
            // buttonSystemInformation
            // 
            this.buttonSystemInformation.Location = new System.Drawing.Point(6, 364);
            this.buttonSystemInformation.Name = "buttonSystemInformation";
            this.buttonSystemInformation.Size = new System.Drawing.Size(148, 31);
            this.buttonSystemInformation.TabIndex = 0;
            this.buttonSystemInformation.Text = "System Information";
            this.buttonSystemInformation.UseVisualStyleBackColor = true;
            this.buttonSystemInformation.Click += new System.EventHandler(this.buttonSystemInformation_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // performanceCounterCPU
            // 
            this.performanceCounterCPU.CategoryName = "Processor";
            this.performanceCounterCPU.CounterName = "% Processor Time";
            this.performanceCounterCPU.InstanceName = "_Total";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCPU.Location = new System.Drawing.Point(725, 6);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(0, 0);
            this.lblCPU.TabIndex = 8;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRAM.Location = new System.Drawing.Point(725, 31);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(0, 0);
            this.lblRAM.TabIndex = 9;
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProcesses.FullRowSelect = true;
            this.listViewProcesses.GridLines = true;
            this.listViewProcesses.HideSelection = false;
            this.listViewProcesses.Location = new System.Drawing.Point(5, 3);
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(783, 375);
            this.listViewProcesses.TabIndex = 0;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            // 
            // performanceCounterRAM
            // 
            this.performanceCounterRAM.CategoryName = "Memory";
            this.performanceCounterRAM.CounterName = "% Committed Bytes In Use";
            // 
            // chart
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.AxisY.Interval = 50D;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(9, 56);
            this.chart.Name = "chart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "CPU";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "RAM";
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(774, 156);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart";
            // 
            // buttonRAM
            // 
            this.buttonRAM.Location = new System.Drawing.Point(6, 291);
            this.buttonRAM.Name = "buttonRAM";
            this.buttonRAM.Size = new System.Drawing.Size(148, 67);
            this.buttonRAM.TabIndex = 11;
            this.buttonRAM.Text = "RAM Information";
            this.buttonRAM.UseVisualStyleBackColor = true;
            this.buttonRAM.Click += new System.EventHandler(this.buttonRAM_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 512);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "My Task manager";
            this.tabControl.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            this.tabPageProcesses.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabPagePerformance.ResumeLayout(false);
            this.tabPagePerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageProcesses;
		private System.Windows.Forms.TabPage tabPagePerformance;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProcesses;
        private ListViewNoFlickering listViewProcesses;
        private System.Windows.Forms.Button buttonSystemInformation;
        private System.Windows.Forms.Button buttonCPU;
        private System.Windows.Forms.RichTextBox richTextBox;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel metroLabelCPU;
        private System.Diagnostics.PerformanceCounter performanceCounterCPU;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel metroLabelRAM;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private System.Diagnostics.PerformanceCounter performanceCounterRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonRAM;
    }
}

