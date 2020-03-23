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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.YearSelect = new System.Windows.Forms.DomainUpDown();
			this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.MachineList = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
			this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
			((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
			this.metroTabControl1.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.metroTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.metroTabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			this.metroTabControl2.SuspendLayout();
			this.metroTabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.metroTabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
			this.SuspendLayout();
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Items.AddRange(new object[] {
            "0706BDLDEC",
            "0706BDLSB"});
			this.metroComboBox1.Location = new System.Drawing.Point(582, 25);
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
			this.YearSelect.Location = new System.Drawing.Point(709, 25);
			this.YearSelect.Name = "YearSelect";
			this.YearSelect.ReadOnly = true;
			this.YearSelect.Size = new System.Drawing.Size(160, 30);
			this.YearSelect.TabIndex = 6;
			this.YearSelect.Text = "Year Selection";
			this.YearSelect.SelectedItemChanged += new System.EventHandler(this.YearSelect_SelectedItemChanged);
			// 
			// chartStats
			// 
			chartArea10.Name = "ChartArea1";
			this.chartStats.ChartAreas.Add(chartArea10);
			legend10.Name = "Legend1";
			this.chartStats.Legends.Add(legend10);
			this.chartStats.Location = new System.Drawing.Point(-1, 3);
			this.chartStats.Name = "chartStats";
			this.chartStats.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series10.ChartArea = "ChartArea1";
			series10.Legend = "Legend1";
			series10.Name = "Series1";
			this.chartStats.Series.Add(series10);
			this.chartStats.Size = new System.Drawing.Size(1053, 300);
			this.chartStats.TabIndex = 7;
			this.chartStats.Text = "chart1";
			// 
			// MachineList
			// 
			this.MachineList.FormattingEnabled = true;
			this.MachineList.ItemHeight = 23;
			this.MachineList.Location = new System.Drawing.Point(150, 420);
			this.MachineList.Name = "MachineList";
			this.MachineList.Size = new System.Drawing.Size(121, 29);
			this.MachineList.TabIndex = 8;
			this.MachineList.UseSelectable = true;
			this.MachineList.SelectedIndexChanged += new System.EventHandler(this.MachineList_SelectedIndexChanged);
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
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Controls.Add(this.metroTabPage3);
			this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 2;
			this.metroTabControl1.Size = new System.Drawing.Size(1014, 354);
			this.metroTabControl1.TabIndex = 10;
			this.metroTabControl1.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.chartStats);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(1006, 312);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "Charge/Capa H";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.Controls.Add(this.chart1);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(1006, 312);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "Charge/Capa %";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 10;
			// 
			// chart1
			// 
			chartArea11.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea11);
			legend11.Name = "Legend1";
			this.chart1.Legends.Add(legend11);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			series11.ChartArea = "ChartArea1";
			series11.Legend = "Legend1";
			series11.Name = "Series1";
			this.chart1.Series.Add(series11);
			this.chart1.Size = new System.Drawing.Size(1041, 300);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";
			// 
			// metroTabPage3
			// 
			this.metroTabPage3.Controls.Add(this.metroGrid1);
			this.metroTabPage3.HorizontalScrollbarBarColor = true;
			this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.HorizontalScrollbarSize = 10;
			this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage3.Name = "metroTabPage3";
			this.metroTabPage3.Size = new System.Drawing.Size(1006, 312);
			this.metroTabPage3.TabIndex = 2;
			this.metroTabPage3.Text = "Analyse des besions";
			this.metroTabPage3.VerticalScrollbarBarColor = true;
			this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.VerticalScrollbarSize = 10;
			// 
			// metroGrid1
			// 
			this.metroGrid1.AllowUserToResizeRows = false;
			this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
			this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle23;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.Location = new System.Drawing.Point(-4, 3);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
			this.metroGrid1.RowHeadersVisible = false;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle25.Format = "N0";
			dataGridViewCellStyle25.NullValue = null;
			dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle25;
			this.metroGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.ShowEditingIcon = false;
			this.metroGrid1.Size = new System.Drawing.Size(1031, 286);
			this.metroGrid1.TabIndex = 2;
			this.metroGrid1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.metroGrid1_CellFormatting);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel2.Location = new System.Drawing.Point(534, 28);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(41, 25);
			this.metroLabel2.TabIndex = 11;
			this.metroLabel2.Text = "Îlot";
			// 
			// metroTabControl2
			// 
			this.metroTabControl2.Controls.Add(this.metroTabPage4);
			this.metroTabControl2.Controls.Add(this.metroTabPage5);
			this.metroTabControl2.Location = new System.Drawing.Point(10, 465);
			this.metroTabControl2.Name = "metroTabControl2";
			this.metroTabControl2.SelectedIndex = 0;
			this.metroTabControl2.Size = new System.Drawing.Size(1043, 400);
			this.metroTabControl2.TabIndex = 12;
			this.metroTabControl2.UseSelectable = true;
			// 
			// metroTabPage4
			// 
			this.metroTabPage4.Controls.Add(this.chart2);
			this.metroTabPage4.HorizontalScrollbarBarColor = true;
			this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage4.HorizontalScrollbarSize = 10;
			this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage4.Name = "metroTabPage4";
			this.metroTabPage4.Size = new System.Drawing.Size(1035, 358);
			this.metroTabPage4.TabIndex = 0;
			this.metroTabPage4.Text = "Charge/Capa H";
			this.metroTabPage4.VerticalScrollbarBarColor = true;
			this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage4.VerticalScrollbarSize = 10;
			// 
			// chart2
			// 
			chartArea12.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea12);
			legend12.Name = "Legend1";
			this.chart2.Legends.Add(legend12);
			this.chart2.Location = new System.Drawing.Point(-15, 13);
			this.chart2.Name = "chart2";
			series12.ChartArea = "ChartArea1";
			series12.Legend = "Legend1";
			series12.Name = "Series1";
			this.chart2.Series.Add(series12);
			this.chart2.Size = new System.Drawing.Size(1050, 300);
			this.chart2.TabIndex = 2;
			this.chart2.Text = "chart2";
			// 
			// metroTabPage5
			// 
			this.metroTabPage5.Controls.Add(this.metroGrid2);
			this.metroTabPage5.HorizontalScrollbarBarColor = true;
			this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage5.HorizontalScrollbarSize = 10;
			this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage5.Name = "metroTabPage5";
			this.metroTabPage5.Size = new System.Drawing.Size(1035, 708);
			this.metroTabPage5.TabIndex = 1;
			this.metroTabPage5.Text = "metroTabPage5";
			this.metroTabPage5.VerticalScrollbarBarColor = true;
			this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage5.VerticalScrollbarSize = 10;
			// 
			// metroGrid2
			// 
			this.metroGrid2.AllowUserToResizeRows = false;
			this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
			this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle27;
			this.metroGrid2.EnableHeadersVisualStyles = false;
			this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid2.Location = new System.Drawing.Point(72, 52);
			this.metroGrid2.Name = "metroGrid2";
			this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
			this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid2.Size = new System.Drawing.Size(478, 150);
			this.metroGrid2.TabIndex = 2;
			// 
			// Off
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1071, 660);
			this.Controls.Add(this.metroTabControl2);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroTabControl1);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.MachineList);
			this.Controls.Add(this.YearSelect);
			this.Controls.Add(this.metroComboBox1);
			this.Name = "Off";
			this.Text = "Off";
			this.Load += new System.EventHandler(this.Off_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
			this.metroTabControl1.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.metroTabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.metroTabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			this.metroTabControl2.ResumeLayout(false);
			this.metroTabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.metroTabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.DomainUpDown YearSelect;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;
		private MetroFramework.Controls.MetroComboBox MachineList;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private MetroFramework.Controls.MetroTabPage metroTabPage3;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTabControl metroTabControl2;
		private MetroFramework.Controls.MetroTabPage metroTabPage4;
		private MetroFramework.Controls.MetroTabPage metroTabPage5;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private MetroFramework.Controls.MetroGrid metroGrid2;
	}
}