namespace SafranCotChargeCapa
{
	partial class Off
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
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.YearSelect = new System.Windows.Forms.DomainUpDown();
			this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
			this.SuspendLayout();
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Items.AddRange(new object[] {
            "0706BDLDEC",
            "0706BDLSB"});
			this.metroComboBox1.Location = new System.Drawing.Point(23, 63);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
			this.metroComboBox1.TabIndex = 0;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
			// 
			// YearSelect
			// 
			this.YearSelect.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.YearSelect.Items.Add("2020");
			this.YearSelect.Items.Add("2021");
			this.YearSelect.Items.Add("2022");
			this.YearSelect.Items.Add("2023");
			this.YearSelect.Items.Add("2024");
			this.YearSelect.Items.Add("2025");
			this.YearSelect.Items.Add("2026");
			this.YearSelect.Items.Add("2027");
			this.YearSelect.Location = new System.Drawing.Point(183, 63);
			this.YearSelect.Name = "YearSelect";
			this.YearSelect.ReadOnly = true;
			this.YearSelect.Size = new System.Drawing.Size(160, 30);
			this.YearSelect.TabIndex = 6;
			this.YearSelect.Text = "Year Selection";
			this.YearSelect.SelectedItemChanged += new System.EventHandler(this.YearSelect_SelectedItemChanged);
			// 
			// chartStats
			// 
			chartArea1.Name = "ChartArea1";
			this.chartStats.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartStats.Legends.Add(legend1);
			this.chartStats.Location = new System.Drawing.Point(-5, 110);
			this.chartStats.Name = "chartStats";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartStats.Series.Add(series1);
			this.chartStats.Size = new System.Drawing.Size(1053, 300);
			this.chartStats.TabIndex = 7;
			this.chartStats.Text = "chart1";
			// 
			// metroComboBox2
			// 
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Location = new System.Drawing.Point(150, 420);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
			this.metroComboBox2.TabIndex = 8;
			this.metroComboBox2.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(67, 420);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(77, 25);
			this.metroLabel1.TabIndex = 9;
			this.metroLabel1.Text = "Machine";
			// 
			// Off
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 562);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroComboBox2);
			this.Controls.Add(this.chartStats);
			this.Controls.Add(this.YearSelect);
			this.Controls.Add(this.metroComboBox1);
			this.Name = "Off";
			this.Text = "Off";
			this.Load += new System.EventHandler(this.Off_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.DomainUpDown YearSelect;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;
		private MetroFramework.Controls.MetroComboBox metroComboBox2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}