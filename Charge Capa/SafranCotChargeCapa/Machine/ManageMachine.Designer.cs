namespace SafranCotChargeCapa
{
	partial class ManageMachine
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.openday = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.UpAll = new System.Windows.Forms.Button();
			this.WeekT = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.NumberOfshift = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.UpGrid = new System.Windows.Forms.Button();
			this.DelButton = new System.Windows.Forms.Button();
			this.UpButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
			this.panel1.Controls.Add(this.metroLabel5);
			this.panel1.Controls.Add(this.metroComboBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(889, 47);
			this.panel1.TabIndex = 40;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.metroLabel5.Location = new System.Drawing.Point(0, 9);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(227, 25);
			this.metroLabel5.TabIndex = 1;
			this.metroLabel5.Text = "Veuillez choisir une machine";
			this.metroLabel5.UseCustomBackColor = true;
			this.metroLabel5.UseCustomForeColor = true;
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
			this.metroComboBox1.Location = new System.Drawing.Point(231, 9);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(160, 29);
			this.metroComboBox1.TabIndex = 0;
			this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroComboBox1.UseCustomBackColor = true;
			this.metroComboBox1.UseCustomForeColor = true;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(6, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(535, 180);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information numeriques";
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(3, 17);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(532, 160);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Location = new System.Drawing.Point(3, 251);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(459, 180);
			this.groupBox2.TabIndex = 42;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Information numeriques";
			// 
			// dataGridView2
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView2.EnableHeadersVisualStyles = false;
			this.dataGridView2.Location = new System.Drawing.Point(3, 17);
			this.dataGridView2.Name = "dataGridView2";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.Size = new System.Drawing.Size(452, 160);
			this.dataGridView2.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.openday);
			this.groupBox3.Controls.Add(this.UpAll);
			this.groupBox3.Controls.Add(this.WeekT);
			this.groupBox3.Controls.Add(this.NumberOfshift);
			this.groupBox3.Location = new System.Drawing.Point(530, 251);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(278, 213);
			this.groupBox3.TabIndex = 43;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Modifier une sequance";
			// 
			// openday
			// 
			this.openday.Depth = 0;
			this.openday.Hint = "Combien de jour ouvrable  ?";
			this.openday.Location = new System.Drawing.Point(17, 75);
			this.openday.MouseState = MaterialSkin.MouseState.HOVER;
			this.openday.Name = "openday";
			this.openday.PasswordChar = '\0';
			this.openday.SelectedText = "";
			this.openday.SelectionLength = 0;
			this.openday.SelectionStart = 0;
			this.openday.Size = new System.Drawing.Size(255, 23);
			this.openday.TabIndex = 45;
			this.openday.UseSystemPasswordChar = false;
			// 
			// UpAll
			// 
			this.UpAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
			this.UpAll.Enabled = false;
			this.UpAll.FlatAppearance.BorderSize = 0;
			this.UpAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpAll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpAll.ForeColor = System.Drawing.Color.Beige;
			this.UpAll.Image = global::SafranCotChargeCapa.Properties.Resources.restart_20px;
			this.UpAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UpAll.Location = new System.Drawing.Point(59, 161);
			this.UpAll.Name = "UpAll";
			this.UpAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.UpAll.Size = new System.Drawing.Size(134, 30);
			this.UpAll.TabIndex = 44;
			this.UpAll.Text = "Modifier";
			this.UpAll.UseVisualStyleBackColor = false;
			this.UpAll.Click += new System.EventHandler(this.button1_Click);
			// 
			// WeekT
			// 
			this.WeekT.Depth = 0;
			this.WeekT.Hint = "A partir de quelle semaine ?";
			this.WeekT.Location = new System.Drawing.Point(17, 119);
			this.WeekT.MouseState = MaterialSkin.MouseState.HOVER;
			this.WeekT.Name = "WeekT";
			this.WeekT.PasswordChar = '\0';
			this.WeekT.SelectedText = "";
			this.WeekT.SelectionLength = 0;
			this.WeekT.SelectionStart = 0;
			this.WeekT.Size = new System.Drawing.Size(255, 23);
			this.WeekT.TabIndex = 1;
			this.WeekT.UseSystemPasswordChar = false;
			// 
			// NumberOfshift
			// 
			this.NumberOfshift.Depth = 0;
			this.NumberOfshift.Hint = "Nomber de shift";
			this.NumberOfshift.Location = new System.Drawing.Point(17, 30);
			this.NumberOfshift.MouseState = MaterialSkin.MouseState.HOVER;
			this.NumberOfshift.Name = "NumberOfshift";
			this.NumberOfshift.PasswordChar = '\0';
			this.NumberOfshift.SelectedText = "";
			this.NumberOfshift.SelectionLength = 0;
			this.NumberOfshift.SelectionStart = 0;
			this.NumberOfshift.Size = new System.Drawing.Size(255, 23);
			this.NumberOfshift.TabIndex = 0;
			this.NumberOfshift.UseSystemPasswordChar = false;
			// 
			// UpGrid
			// 
			this.UpGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
			this.UpGrid.Enabled = false;
			this.UpGrid.FlatAppearance.BorderSize = 0;
			this.UpGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpGrid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpGrid.ForeColor = System.Drawing.Color.Beige;
			this.UpGrid.Image = global::SafranCotChargeCapa.Properties.Resources.restart_20px;
			this.UpGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UpGrid.Location = new System.Drawing.Point(134, 453);
			this.UpGrid.Name = "UpGrid";
			this.UpGrid.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.UpGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.UpGrid.Size = new System.Drawing.Size(248, 30);
			this.UpGrid.TabIndex = 44;
			this.UpGrid.Text = "Modifier depuis la tableau";
			this.UpGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UpGrid.UseVisualStyleBackColor = false;
			this.UpGrid.Click += new System.EventHandler(this.button2_Click);
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
			this.DelButton.Location = new System.Drawing.Point(552, 134);
			this.DelButton.Name = "DelButton";
			this.DelButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DelButton.Size = new System.Drawing.Size(193, 30);
			this.DelButton.TabIndex = 18;
			this.DelButton.Text = "Supprimer la machine";
			this.DelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DelButton.UseVisualStyleBackColor = false;
			this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
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
			this.UpButton.Location = new System.Drawing.Point(552, 89);
			this.UpButton.Name = "UpButton";
			this.UpButton.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.UpButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.UpButton.Size = new System.Drawing.Size(193, 30);
			this.UpButton.TabIndex = 19;
			this.UpButton.Text = "Modifier la machine";
			this.UpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UpButton.UseVisualStyleBackColor = false;
			this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// ManageMachine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(889, 500);
			this.Controls.Add(this.UpGrid);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.DelButton);
			this.Controls.Add(this.UpButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ManageMachine";
			this.Text = "Gestion des machines";
			this.Load += new System.EventHandler(this.ManageMachine_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button UpButton;
		private System.Windows.Forms.Button DelButton;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox3;
		private MaterialSkin.Controls.MaterialSingleLineTextField WeekT;
		private MaterialSkin.Controls.MaterialSingleLineTextField NumberOfshift;
		private System.Windows.Forms.Button UpAll;
		private System.Windows.Forms.Button UpGrid;
		private MaterialSkin.Controls.MaterialSingleLineTextField openday;
	}
}