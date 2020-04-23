namespace SafranCotChargeCapa
{
	partial class ManOp
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DelButton = new System.Windows.Forms.Button();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.UpButton = new System.Windows.Forms.Button();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.TcInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
			this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroComboBox5 = new MetroFramework.Controls.MetroComboBox();
			this.MachineGrid = new System.Windows.Forms.DataGridView();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.button8 = new System.Windows.Forms.Button();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
			this.ToolGrid = new System.Windows.Forms.DataGridView();
			this.button5 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.button4 = new System.Windows.Forms.Button();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.metroTabControl1.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MachineGrid)).BeginInit();
			this.metroTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ToolGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
			this.panel1.Controls.Add(this.DelButton);
			this.panel1.Controls.Add(this.metroLabel5);
			this.panel1.Controls.Add(this.UpButton);
			this.panel1.Controls.Add(this.metroComboBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(889, 47);
			this.panel1.TabIndex = 40;
			// 
			// DelButton
			// 
			this.DelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
			this.DelButton.Enabled = false;
			this.DelButton.FlatAppearance.BorderSize = 0;
			this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DelButton.ForeColor = System.Drawing.Color.Beige;
			this.DelButton.Image = global::SafranCotChargeCapa.Properties.Resources.delete_trash_20px;
			this.DelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DelButton.Location = new System.Drawing.Point(691, 8);
			this.DelButton.Name = "DelButton";
			this.DelButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DelButton.Size = new System.Drawing.Size(193, 30);
			this.DelButton.TabIndex = 18;
			this.DelButton.Text = "Supprimer l\'opération";
			this.DelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DelButton.UseVisualStyleBackColor = false;
			this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.metroLabel5.Location = new System.Drawing.Point(0, 9);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(235, 25);
			this.metroLabel5.TabIndex = 1;
			this.metroLabel5.Text = "Veuillez choisir une opération";
			this.metroLabel5.UseCustomBackColor = true;
			this.metroLabel5.UseCustomForeColor = true;
			// 
			// UpButton
			// 
			this.UpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
			this.UpButton.Enabled = false;
			this.UpButton.FlatAppearance.BorderSize = 0;
			this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpButton.ForeColor = System.Drawing.Color.Beige;
			this.UpButton.Image = global::SafranCotChargeCapa.Properties.Resources.restart_20px;
			this.UpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UpButton.Location = new System.Drawing.Point(488, 8);
			this.UpButton.Name = "UpButton";
			this.UpButton.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.UpButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.UpButton.Size = new System.Drawing.Size(193, 30);
			this.UpButton.TabIndex = 19;
			this.UpButton.Text = "Modifier l\'opération";
			this.UpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UpButton.UseVisualStyleBackColor = false;
			this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.metroComboBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.metroComboBox1.DisplayFocus = true;
			this.metroComboBox1.DropDownHeight = 210;
			this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.metroComboBox1.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.metroComboBox1.ForeColor = System.Drawing.Color.Red;
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.metroComboBox1.IntegralHeight = false;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Location = new System.Drawing.Point(237, 9);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(240, 29);
			this.metroComboBox1.TabIndex = 0;
			this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroComboBox1.UseCustomBackColor = true;
			this.metroComboBox1.UseCustomForeColor = true;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkedListBox1);
			this.groupBox2.Location = new System.Drawing.Point(490, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(226, 180);
			this.groupBox2.TabIndex = 42;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Produits";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(17, 21);
			this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(196, 148);
			this.checkedListBox1.TabIndex = 15;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.White;
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.materialLabel1);
			this.groupBox3.Controls.Add(this.TcInput);
			this.groupBox3.Controls.Add(this.metroComboBox2);
			this.groupBox3.Controls.Add(this.metroComboBox3);
			this.groupBox3.Location = new System.Drawing.Point(12, 53);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(445, 180);
			this.groupBox3.TabIndex = 43;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Information de l\'operation";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(213)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Beige;
			this.button2.Image = global::SafranCotChargeCapa.Properties.Resources.add_new_32px;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(302, 68);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button2.Size = new System.Drawing.Size(41, 29);
			this.button2.TabIndex = 24;
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(213)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Beige;
			this.button1.Image = global::SafranCotChargeCapa.Properties.Resources.add_new_32px;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(302, 21);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(41, 29);
			this.button1.TabIndex = 20;
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(26, 31);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(39, 19);
			this.materialLabel1.TabIndex = 23;
			this.materialLabel1.Text = "Ilot :";
			// 
			// TcInput
			// 
			this.TcInput.Depth = 0;
			this.TcInput.Hint = "Temps de cycle";
			this.TcInput.Location = new System.Drawing.Point(50, 128);
			this.TcInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.TcInput.Name = "TcInput";
			this.TcInput.PasswordChar = '\0';
			this.TcInput.SelectedText = "";
			this.TcInput.SelectionLength = 0;
			this.TcInput.SelectionStart = 0;
			this.TcInput.Size = new System.Drawing.Size(246, 23);
			this.TcInput.TabIndex = 22;
			this.TcInput.UseSystemPasswordChar = false;
			// 
			// metroComboBox2
			// 
			this.metroComboBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.metroComboBox2.Cursor = System.Windows.Forms.Cursors.Default;
			this.metroComboBox2.DisplayFocus = true;
			this.metroComboBox2.DropDownHeight = 210;
			this.metroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.metroComboBox2.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.metroComboBox2.ForeColor = System.Drawing.Color.Red;
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.metroComboBox2.IntegralHeight = false;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Location = new System.Drawing.Point(136, 21);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.Size = new System.Drawing.Size(160, 29);
			this.metroComboBox2.TabIndex = 20;
			this.metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroComboBox2.UseCustomBackColor = true;
			this.metroComboBox2.UseCustomForeColor = true;
			this.metroComboBox2.UseSelectable = true;
			this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
			// 
			// metroComboBox3
			// 
			this.metroComboBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.metroComboBox3.Cursor = System.Windows.Forms.Cursors.Default;
			this.metroComboBox3.DisplayFocus = true;
			this.metroComboBox3.DropDownHeight = 210;
			this.metroComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.metroComboBox3.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.metroComboBox3.ForeColor = System.Drawing.Color.Red;
			this.metroComboBox3.FormattingEnabled = true;
			this.metroComboBox3.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.metroComboBox3.IntegralHeight = false;
			this.metroComboBox3.ItemHeight = 23;
			this.metroComboBox3.Location = new System.Drawing.Point(136, 68);
			this.metroComboBox3.Name = "metroComboBox3";
			this.metroComboBox3.Size = new System.Drawing.Size(160, 29);
			this.metroComboBox3.TabIndex = 21;
			this.metroComboBox3.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroComboBox3.UseCustomBackColor = true;
			this.metroComboBox3.UseCustomForeColor = true;
			this.metroComboBox3.UseSelectable = true;
			this.metroComboBox3.SelectedIndexChanged += new System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Location = new System.Drawing.Point(12, 249);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(865, 224);
			this.metroTabControl1.TabIndex = 63;
			this.metroTabControl1.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.metroComboBox5);
			this.metroTabPage1.Controls.Add(this.MachineGrid);
			this.metroTabPage1.Controls.Add(this.button6);
			this.metroTabPage1.Controls.Add(this.button7);
			this.metroTabPage1.Controls.Add(this.materialSingleLineTextField2);
			this.metroTabPage1.Controls.Add(this.button8);
			this.metroTabPage1.Controls.Add(this.materialLabel3);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 6;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(857, 182);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "Machines";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 8;
			this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
			// 
			// metroComboBox5
			// 
			this.metroComboBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.metroComboBox5.Cursor = System.Windows.Forms.Cursors.Default;
			this.metroComboBox5.DisplayFocus = true;
			this.metroComboBox5.DropDownHeight = 210;
			this.metroComboBox5.Enabled = false;
			this.metroComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.metroComboBox5.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.metroComboBox5.ForeColor = System.Drawing.Color.Red;
			this.metroComboBox5.FormattingEnabled = true;
			this.metroComboBox5.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.metroComboBox5.IntegralHeight = false;
			this.metroComboBox5.ItemHeight = 23;
			this.metroComboBox5.Location = new System.Drawing.Point(580, 9);
			this.metroComboBox5.Name = "metroComboBox5";
			this.metroComboBox5.Size = new System.Drawing.Size(192, 29);
			this.metroComboBox5.TabIndex = 20;
			this.metroComboBox5.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroComboBox5.UseCustomBackColor = true;
			this.metroComboBox5.UseCustomForeColor = true;
			this.metroComboBox5.UseSelectable = true;
			this.metroComboBox5.SelectedIndexChanged += new System.EventHandler(this.metroComboBox5_SelectedIndexChanged);
			// 
			// MachineGrid
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.MachineGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.MachineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.MachineGrid.DefaultCellStyle = dataGridViewCellStyle8;
			this.MachineGrid.EnableHeadersVisualStyles = false;
			this.MachineGrid.Location = new System.Drawing.Point(2, 3);
			this.MachineGrid.Name = "MachineGrid";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.MachineGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.MachineGrid.RowHeadersVisible = false;
			this.MachineGrid.Size = new System.Drawing.Size(391, 160);
			this.MachineGrid.TabIndex = 73;
			this.MachineGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.MachineGrid_CellBeginEdit);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(213)))));
			this.button6.Enabled = false;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Beige;
			this.button6.Image = global::SafranCotChargeCapa.Properties.Resources.add_new_32px;
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Location = new System.Drawing.Point(448, 115);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button6.Size = new System.Drawing.Size(192, 30);
			this.button6.TabIndex = 72;
			this.button6.Text = "Ajouter la machine";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
			this.button7.Enabled = false;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Beige;
			this.button7.Image = global::SafranCotChargeCapa.Properties.Resources.delete_trash_20px;
			this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Location = new System.Drawing.Point(646, 137);
			this.button7.Name = "button7";
			this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button7.Size = new System.Drawing.Size(180, 30);
			this.button7.TabIndex = 66;
			this.button7.Text = "Supprimer le temps";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// materialSingleLineTextField2
			// 
			this.materialSingleLineTextField2.BackColor = System.Drawing.Color.White;
			this.materialSingleLineTextField2.Depth = 0;
			this.materialSingleLineTextField2.Hint = "Temps de cycle";
			this.materialSingleLineTextField2.Location = new System.Drawing.Point(580, 52);
			this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
			this.materialSingleLineTextField2.PasswordChar = '\0';
			this.materialSingleLineTextField2.SelectedText = "";
			this.materialSingleLineTextField2.SelectionLength = 0;
			this.materialSingleLineTextField2.SelectionStart = 0;
			this.materialSingleLineTextField2.Size = new System.Drawing.Size(246, 23);
			this.materialSingleLineTextField2.TabIndex = 68;
			this.materialSingleLineTextField2.UseSystemPasswordChar = false;
			this.materialSingleLineTextField2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialSingleLineTextField2_KeyPress);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
			this.button8.Enabled = false;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.Beige;
			this.button8.Image = global::SafranCotChargeCapa.Properties.Resources.restart_20px;
			this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.Location = new System.Drawing.Point(646, 90);
			this.button8.Name = "button8";
			this.button8.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button8.Size = new System.Drawing.Size(180, 30);
			this.button8.TabIndex = 67;
			this.button8.Text = "Modifier le temps";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// materialLabel3
			// 
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.BackColor = System.Drawing.Color.White;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(490, 14);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(74, 19);
			this.materialLabel3.TabIndex = 69;
			this.materialLabel3.Text = "Machine :";
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.Controls.Add(this.metroComboBox4);
			this.metroTabPage2.Controls.Add(this.ToolGrid);
			this.metroTabPage2.Controls.Add(this.button5);
			this.metroTabPage2.Controls.Add(this.button3);
			this.metroTabPage2.Controls.Add(this.materialSingleLineTextField1);
			this.metroTabPage2.Controls.Add(this.button4);
			this.metroTabPage2.Controls.Add(this.materialLabel2);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 6;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(857, 182);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "Outils";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 8;
			// 
			// metroComboBox4
			// 
			this.metroComboBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.metroComboBox4.Cursor = System.Windows.Forms.Cursors.Default;
			this.metroComboBox4.DisplayFocus = true;
			this.metroComboBox4.DropDownHeight = 210;
			this.metroComboBox4.Enabled = false;
			this.metroComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.metroComboBox4.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
			this.metroComboBox4.ForeColor = System.Drawing.Color.Red;
			this.metroComboBox4.FormattingEnabled = true;
			this.metroComboBox4.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.metroComboBox4.IntegralHeight = false;
			this.metroComboBox4.ItemHeight = 23;
			this.metroComboBox4.Location = new System.Drawing.Point(580, 9);
			this.metroComboBox4.Name = "metroComboBox4";
			this.metroComboBox4.Size = new System.Drawing.Size(192, 29);
			this.metroComboBox4.TabIndex = 20;
			this.metroComboBox4.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroComboBox4.UseCustomBackColor = true;
			this.metroComboBox4.UseCustomForeColor = true;
			this.metroComboBox4.UseSelectable = true;
			this.metroComboBox4.SelectedIndexChanged += new System.EventHandler(this.metroComboBox4_SelectedIndexChanged);
			// 
			// ToolGrid
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ToolGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.ToolGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ToolGrid.DefaultCellStyle = dataGridViewCellStyle11;
			this.ToolGrid.EnableHeadersVisualStyles = false;
			this.ToolGrid.Location = new System.Drawing.Point(2, 3);
			this.ToolGrid.Name = "ToolGrid";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ToolGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.ToolGrid.RowHeadersVisible = false;
			this.ToolGrid.Size = new System.Drawing.Size(391, 160);
			this.ToolGrid.TabIndex = 66;
			this.ToolGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ToolGrid_CellBeginEdit);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(213)))));
			this.button5.Enabled = false;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Beige;
			this.button5.Image = global::SafranCotChargeCapa.Properties.Resources.add_new_32px;
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(460, 115);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button5.Size = new System.Drawing.Size(180, 30);
			this.button5.TabIndex = 65;
			this.button5.Text = "Ajouter l\'outils";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
			this.button3.Enabled = false;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Beige;
			this.button3.Image = global::SafranCotChargeCapa.Properties.Resources.delete_trash_20px;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(646, 137);
			this.button3.Name = "button3";
			this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button3.Size = new System.Drawing.Size(180, 30);
			this.button3.TabIndex = 20;
			this.button3.Text = "Supprimer le temps";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// materialSingleLineTextField1
			// 
			this.materialSingleLineTextField1.BackColor = System.Drawing.Color.White;
			this.materialSingleLineTextField1.Depth = 0;
			this.materialSingleLineTextField1.Hint = "Temps de cycle";
			this.materialSingleLineTextField1.Location = new System.Drawing.Point(580, 52);
			this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.PasswordChar = '\0';
			this.materialSingleLineTextField1.SelectedText = "";
			this.materialSingleLineTextField1.SelectionLength = 0;
			this.materialSingleLineTextField1.SelectionStart = 0;
			this.materialSingleLineTextField1.Size = new System.Drawing.Size(246, 23);
			this.materialSingleLineTextField1.TabIndex = 25;
			this.materialSingleLineTextField1.UseSystemPasswordChar = false;
			this.materialSingleLineTextField1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialSingleLineTextField1_KeyPress);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
			this.button4.Enabled = false;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Beige;
			this.button4.Image = global::SafranCotChargeCapa.Properties.Resources.restart_20px;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(646, 90);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button4.Size = new System.Drawing.Size(180, 30);
			this.button4.TabIndex = 21;
			this.button4.Text = "Modifier le temps";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.BackColor = System.Drawing.Color.White;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(503, 15);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(56, 19);
			this.materialLabel2.TabIndex = 25;
			this.materialLabel2.Text = "Outils :";
			// 
			// ManOp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(889, 500);
			this.Controls.Add(this.metroTabControl1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ManOp";
			this.Text = "Gestion des machines";
			this.Load += new System.EventHandler(this.ManageMachine_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.metroTabControl1.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.metroTabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MachineGrid)).EndInit();
			this.metroTabPage2.ResumeLayout(false);
			this.metroTabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ToolGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button UpButton;
		private System.Windows.Forms.Button DelButton;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private MetroFramework.Controls.MetroComboBox metroComboBox2;
		private MetroFramework.Controls.MetroComboBox metroComboBox3;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialSingleLineTextField TcInput;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
		private System.Windows.Forms.Button button8;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridView MachineGrid;
		private System.Windows.Forms.DataGridView ToolGrid;
		private MetroFramework.Controls.MetroComboBox metroComboBox5;
		private MetroFramework.Controls.MetroComboBox metroComboBox4;
	}
}