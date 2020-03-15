namespace SafranCotChargeCapa
{
	partial class IlotManag
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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.RoleInput = new MetroFramework.Controls.MetroComboBox();
			this.IlotIDInput = new MetroFramework.Controls.MetroTextBox();
			this.IlotNameInput = new MetroFramework.Controls.MetroTextBox();
			this.EffInput = new MetroFramework.Controls.MetroTextBox();
			this.CRMInput = new MetroFramework.Controls.MetroTextBox();
			this.IlotRejection = new MetroFramework.Controls.MetroTextBox();
			this.AbsRate = new MetroFramework.Controls.MetroTextBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.AddButton = new MetroFramework.Controls.MetroTile();
			this.Upilot = new MetroFramework.Controls.MetroTile();
			this.YearSel = new System.Windows.Forms.NumericUpDown();
			this.WeekSel = new System.Windows.Forms.NumericUpDown();
			this.OpSel = new System.Windows.Forms.NumericUpDown();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.YearSel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WeekSel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OpSel)).BeginInit();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel1.Location = new System.Drawing.Point(23, 90);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(71, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "ID de l\'îlot";
			this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel2.Location = new System.Drawing.Point(23, 135);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(87, 19);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "Nom de l\'îlot";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel3.Location = new System.Drawing.Point(23, 178);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(64, 19);
			this.metroLabel3.TabIndex = 2;
			this.metroLabel3.Text = "Efficience";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel4.Location = new System.Drawing.Point(23, 213);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(162, 19);
			this.metroLabel4.TabIndex = 3;
			this.metroLabel4.Text = "Coefficient de majoration";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel5.Location = new System.Drawing.Point(23, 254);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(91, 19);
			this.metroLabel5.TabIndex = 4;
			this.metroLabel5.Text = "Taux de rebut";
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel6.Location = new System.Drawing.Point(23, 295);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(99, 19);
			this.metroLabel6.TabIndex = 5;
			this.metroLabel6.Text = "Taux d\'absence";
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel7.Location = new System.Drawing.Point(621, 90);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(85, 19);
			this.metroLabel7.TabIndex = 6;
			this.metroLabel7.Text = "Responsable";
			// 
			// RoleInput
			// 
			this.RoleInput.FormattingEnabled = true;
			this.RoleInput.ItemHeight = 23;
			this.RoleInput.Location = new System.Drawing.Point(328, 80);
			this.RoleInput.Name = "RoleInput";
			this.RoleInput.Size = new System.Drawing.Size(121, 29);
			this.RoleInput.TabIndex = 7;
			this.RoleInput.UseSelectable = true;
			this.RoleInput.SelectedIndexChanged += new System.EventHandler(this.RoleInput_SelectedIndexChanged);
			// 
			// IlotIDInput
			// 
			// 
			// 
			// 
			this.IlotIDInput.CustomButton.Image = null;
			this.IlotIDInput.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.IlotIDInput.CustomButton.Name = "";
			this.IlotIDInput.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.IlotIDInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.IlotIDInput.CustomButton.TabIndex = 1;
			this.IlotIDInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.IlotIDInput.CustomButton.UseSelectable = true;
			this.IlotIDInput.DisplayIcon = true;
			this.IlotIDInput.Icon = global::SafranCotChargeCapa.Properties.Resources.search_24px;
			this.IlotIDInput.IconRight = true;
			this.IlotIDInput.Lines = new string[0];
			this.IlotIDInput.Location = new System.Drawing.Point(142, 86);
			this.IlotIDInput.MaxLength = 32767;
			this.IlotIDInput.Name = "IlotIDInput";
			this.IlotIDInput.PasswordChar = '\0';
			this.IlotIDInput.PromptText = "Ilot ID";
			this.IlotIDInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.IlotIDInput.SelectedText = "";
			this.IlotIDInput.SelectionLength = 0;
			this.IlotIDInput.SelectionStart = 0;
			this.IlotIDInput.ShortcutsEnabled = true;
			this.IlotIDInput.ShowButton = true;
			this.IlotIDInput.Size = new System.Drawing.Size(145, 23);
			this.IlotIDInput.TabIndex = 8;
			this.IlotIDInput.UseSelectable = true;
			this.IlotIDInput.WaterMark = "Ilot ID";
			this.IlotIDInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.IlotIDInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.IlotIDInput.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.metroTextBox1_ButtonClick);
			// 
			// IlotNameInput
			// 
			// 
			// 
			// 
			this.IlotNameInput.CustomButton.Image = null;
			this.IlotNameInput.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.IlotNameInput.CustomButton.Name = "";
			this.IlotNameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.IlotNameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.IlotNameInput.CustomButton.TabIndex = 1;
			this.IlotNameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.IlotNameInput.CustomButton.UseSelectable = true;
			this.IlotNameInput.CustomButton.Visible = false;
			this.IlotNameInput.Lines = new string[0];
			this.IlotNameInput.Location = new System.Drawing.Point(142, 131);
			this.IlotNameInput.MaxLength = 32767;
			this.IlotNameInput.Name = "IlotNameInput";
			this.IlotNameInput.PasswordChar = '\0';
			this.IlotNameInput.PromptText = "Nom de l\'îlot";
			this.IlotNameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.IlotNameInput.SelectedText = "";
			this.IlotNameInput.SelectionLength = 0;
			this.IlotNameInput.SelectionStart = 0;
			this.IlotNameInput.ShortcutsEnabled = true;
			this.IlotNameInput.Size = new System.Drawing.Size(145, 23);
			this.IlotNameInput.TabIndex = 9;
			this.IlotNameInput.UseSelectable = true;
			this.IlotNameInput.WaterMark = "Nom de l\'îlot";
			this.IlotNameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.IlotNameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// EffInput
			// 
			// 
			// 
			// 
			this.EffInput.CustomButton.Image = null;
			this.EffInput.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.EffInput.CustomButton.Name = "";
			this.EffInput.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.EffInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.EffInput.CustomButton.TabIndex = 1;
			this.EffInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.EffInput.CustomButton.UseSelectable = true;
			this.EffInput.CustomButton.Visible = false;
			this.EffInput.Lines = new string[0];
			this.EffInput.Location = new System.Drawing.Point(142, 174);
			this.EffInput.MaxLength = 32767;
			this.EffInput.Name = "EffInput";
			this.EffInput.PasswordChar = '\0';
			this.EffInput.PromptText = "Efficience en %";
			this.EffInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.EffInput.SelectedText = "";
			this.EffInput.SelectionLength = 0;
			this.EffInput.SelectionStart = 0;
			this.EffInput.ShortcutsEnabled = true;
			this.EffInput.Size = new System.Drawing.Size(145, 23);
			this.EffInput.TabIndex = 10;
			this.EffInput.UseSelectable = true;
			this.EffInput.WaterMark = "Efficience en %";
			this.EffInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.EffInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// CRMInput
			// 
			// 
			// 
			// 
			this.CRMInput.CustomButton.Image = null;
			this.CRMInput.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.CRMInput.CustomButton.Name = "";
			this.CRMInput.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.CRMInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.CRMInput.CustomButton.TabIndex = 1;
			this.CRMInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.CRMInput.CustomButton.UseSelectable = true;
			this.CRMInput.CustomButton.Visible = false;
			this.CRMInput.Lines = new string[0];
			this.CRMInput.Location = new System.Drawing.Point(191, 213);
			this.CRMInput.MaxLength = 32767;
			this.CRMInput.Name = "CRMInput";
			this.CRMInput.PasswordChar = '\0';
			this.CRMInput.PromptText = "CDM en %";
			this.CRMInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.CRMInput.SelectedText = "";
			this.CRMInput.SelectionLength = 0;
			this.CRMInput.SelectionStart = 0;
			this.CRMInput.ShortcutsEnabled = true;
			this.CRMInput.Size = new System.Drawing.Size(145, 23);
			this.CRMInput.TabIndex = 11;
			this.CRMInput.UseSelectable = true;
			this.CRMInput.WaterMark = "CDM en %";
			this.CRMInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.CRMInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// IlotRejection
			// 
			// 
			// 
			// 
			this.IlotRejection.CustomButton.Image = null;
			this.IlotRejection.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.IlotRejection.CustomButton.Name = "";
			this.IlotRejection.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.IlotRejection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.IlotRejection.CustomButton.TabIndex = 1;
			this.IlotRejection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.IlotRejection.CustomButton.UseSelectable = true;
			this.IlotRejection.CustomButton.Visible = false;
			this.IlotRejection.Lines = new string[0];
			this.IlotRejection.Location = new System.Drawing.Point(142, 250);
			this.IlotRejection.MaxLength = 32767;
			this.IlotRejection.Name = "IlotRejection";
			this.IlotRejection.PasswordChar = '\0';
			this.IlotRejection.PromptText = "Taux de rebut en %";
			this.IlotRejection.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.IlotRejection.SelectedText = "";
			this.IlotRejection.SelectionLength = 0;
			this.IlotRejection.SelectionStart = 0;
			this.IlotRejection.ShortcutsEnabled = true;
			this.IlotRejection.Size = new System.Drawing.Size(145, 23);
			this.IlotRejection.TabIndex = 12;
			this.IlotRejection.UseSelectable = true;
			this.IlotRejection.WaterMark = "Taux de rebut en %";
			this.IlotRejection.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.IlotRejection.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AbsRate
			// 
			// 
			// 
			// 
			this.AbsRate.CustomButton.Image = null;
			this.AbsRate.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.AbsRate.CustomButton.Name = "";
			this.AbsRate.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AbsRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AbsRate.CustomButton.TabIndex = 1;
			this.AbsRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AbsRate.CustomButton.UseSelectable = true;
			this.AbsRate.CustomButton.Visible = false;
			this.AbsRate.Lines = new string[0];
			this.AbsRate.Location = new System.Drawing.Point(142, 291);
			this.AbsRate.MaxLength = 32767;
			this.AbsRate.Name = "AbsRate";
			this.AbsRate.PasswordChar = '\0';
			this.AbsRate.PromptText = "Taux d\'absence en %";
			this.AbsRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AbsRate.SelectedText = "";
			this.AbsRate.SelectionLength = 0;
			this.AbsRate.SelectionStart = 0;
			this.AbsRate.ShortcutsEnabled = true;
			this.AbsRate.Size = new System.Drawing.Size(145, 23);
			this.AbsRate.TabIndex = 13;
			this.AbsRate.UseSelectable = true;
			this.AbsRate.WaterMark = "Taux d\'absence en %";
			this.AbsRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AbsRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(621, 112);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
			this.checkedListBox1.TabIndex = 14;
			// 
			// AddButton
			// 
			this.AddButton.ActiveControl = null;
			this.AddButton.Location = new System.Drawing.Point(621, 213);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(112, 38);
			this.AddButton.TabIndex = 15;
			this.AddButton.Text = "Sauvegarde";
			this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddButton.TileImage = global::SafranCotChargeCapa.Properties.Resources.save_26px2;
			this.AddButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.AddButton.UseSelectable = true;
			this.AddButton.UseTileImage = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// Upilot
			// 
			this.Upilot.ActiveControl = null;
			this.Upilot.Enabled = false;
			this.Upilot.Location = new System.Drawing.Point(621, 257);
			this.Upilot.Name = "Upilot";
			this.Upilot.Size = new System.Drawing.Size(112, 38);
			this.Upilot.TabIndex = 16;
			this.Upilot.Text = "Mise à jour";
			this.Upilot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Upilot.TileImage = global::SafranCotChargeCapa.Properties.Resources.refresh_26px;
			this.Upilot.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Upilot.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.Upilot.UseSelectable = true;
			this.Upilot.UseTileImage = true;
			this.Upilot.Click += new System.EventHandler(this.Upilot_Click);
			// 
			// YearSel
			// 
			this.YearSel.Location = new System.Drawing.Point(419, 352);
			this.YearSel.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
			this.YearSel.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
			this.YearSel.Name = "YearSel";
			this.YearSel.Size = new System.Drawing.Size(48, 20);
			this.YearSel.TabIndex = 39;
			this.YearSel.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
			// 
			// WeekSel
			// 
			this.WeekSel.Location = new System.Drawing.Point(298, 353);
			this.WeekSel.Maximum = new decimal(new int[] {
            56,
            0,
            0,
            0});
			this.WeekSel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.WeekSel.Name = "WeekSel";
			this.WeekSel.Size = new System.Drawing.Size(38, 20);
			this.WeekSel.TabIndex = 38;
			this.WeekSel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// OpSel
			// 
			this.OpSel.Location = new System.Drawing.Point(29, 351);
			this.OpSel.Name = "OpSel";
			this.OpSel.Size = new System.Drawing.Size(38, 20);
			this.OpSel.TabIndex = 37;
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel8.Location = new System.Drawing.Point(73, 351);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(207, 19);
			this.metroLabel8.TabIndex = 40;
			this.metroLabel8.Text = "Operateur à partir de la semaine";
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel9.Location = new System.Drawing.Point(342, 352);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(71, 19);
			this.metroLabel9.TabIndex = 41;
			this.metroLabel9.Text = "de l\'année";
			// 
			// IlotManag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroLabel9);
			this.Controls.Add(this.metroLabel8);
			this.Controls.Add(this.YearSel);
			this.Controls.Add(this.WeekSel);
			this.Controls.Add(this.OpSel);
			this.Controls.Add(this.Upilot);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.AbsRate);
			this.Controls.Add(this.IlotRejection);
			this.Controls.Add(this.CRMInput);
			this.Controls.Add(this.EffInput);
			this.Controls.Add(this.IlotNameInput);
			this.Controls.Add(this.IlotIDInput);
			this.Controls.Add(this.RoleInput);
			this.Controls.Add(this.metroLabel7);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Name = "IlotManag";
			this.Text = "IlotManag";
			this.Load += new System.EventHandler(this.IlotManag_Load);
			((System.ComponentModel.ISupportInitialize)(this.YearSel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WeekSel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OpSel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroComboBox RoleInput;
		private MetroFramework.Controls.MetroTextBox IlotIDInput;
		private MetroFramework.Controls.MetroTextBox IlotNameInput;
		private MetroFramework.Controls.MetroTextBox EffInput;
		private MetroFramework.Controls.MetroTextBox CRMInput;
		private MetroFramework.Controls.MetroTextBox IlotRejection;
		private MetroFramework.Controls.MetroTextBox AbsRate;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private MetroFramework.Controls.MetroTile AddButton;
		private MetroFramework.Controls.MetroTile Upilot;
		private System.Windows.Forms.NumericUpDown YearSel;
		private System.Windows.Forms.NumericUpDown WeekSel;
		private System.Windows.Forms.NumericUpDown OpSel;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroLabel metroLabel9;
	}
}