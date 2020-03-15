namespace SafranCotChargeCapa
{
	partial class ManOperation
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
			this.EffInput = new MetroFramework.Controls.MetroTextBox();
			this.InputOperation = new MetroFramework.Controls.MetroComboBox();
			this.PRoductIDSelect = new System.Windows.Forms.CheckedListBox();
			this.DelAll = new MetroFramework.Controls.MetroTile();
			this.SaveUpdate = new MetroFramework.Controls.MetroTile();
			this.AddButton = new MetroFramework.Controls.MetroTile();
			this.MachineIDInput = new MetroFramework.Controls.MetroTextBox();
			this.IlotIDS = new MetroFramework.Controls.MetroComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DelMach = new MetroFramework.Controls.MetroTile();
			this.SaveMach = new MetroFramework.Controls.MetroTile();
			this.AddMach = new MetroFramework.Controls.MetroTile();
			this.MachineSelc = new MetroFramework.Controls.MetroComboBox();
			this.HideMach = new System.Windows.Forms.Label();
			this.MachineCycleTime = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
			this.metroTile5 = new MetroFramework.Controls.MetroTile();
			this.metroTile6 = new MetroFramework.Controls.MetroTile();
			this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
			this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel1.Location = new System.Drawing.Point(23, 84);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(145, 25);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "ID de l\'operation";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel2.Location = new System.Drawing.Point(23, 123);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(93, 25);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "ID de l\'îlot";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel3.Location = new System.Drawing.Point(24, 161);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(194, 25);
			this.metroLabel3.TabIndex = 2;
			this.metroLabel3.Text = "Temps de cycle manuel";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel4.Location = new System.Drawing.Point(439, 121);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(118, 25);
			this.metroLabel4.TabIndex = 3;
			this.metroLabel4.Text = "ID de Produit";
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
			this.EffInput.Location = new System.Drawing.Point(236, 162);
			this.EffInput.MaxLength = 32767;
			this.EffInput.Name = "EffInput";
			this.EffInput.PasswordChar = '\0';
			this.EffInput.PromptText = "temps de cycle en H";
			this.EffInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.EffInput.SelectedText = "";
			this.EffInput.SelectionLength = 0;
			this.EffInput.SelectionStart = 0;
			this.EffInput.ShortcutsEnabled = true;
			this.EffInput.Size = new System.Drawing.Size(145, 23);
			this.EffInput.TabIndex = 14;
			this.EffInput.UseSelectable = true;
			this.EffInput.WaterMark = "temps de cycle en H";
			this.EffInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.EffInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// InputOperation
			// 
			this.InputOperation.FormattingEnabled = true;
			this.InputOperation.ItemHeight = 23;
			this.InputOperation.Location = new System.Drawing.Point(429, 80);
			this.InputOperation.Name = "InputOperation";
			this.InputOperation.Size = new System.Drawing.Size(121, 29);
			this.InputOperation.TabIndex = 11;
			this.InputOperation.UseSelectable = true;
			this.InputOperation.SelectedIndexChanged += new System.EventHandler(this.RoleInput_SelectedIndexChanged);
			// 
			// PRoductIDSelect
			// 
			this.PRoductIDSelect.FormattingEnabled = true;
			this.PRoductIDSelect.Location = new System.Drawing.Point(439, 159);
			this.PRoductIDSelect.Name = "PRoductIDSelect";
			this.PRoductIDSelect.Size = new System.Drawing.Size(334, 79);
			this.PRoductIDSelect.TabIndex = 15;
			// 
			// DelAll
			// 
			this.DelAll.ActiveControl = null;
			this.DelAll.Enabled = false;
			this.DelAll.Location = new System.Drawing.Point(661, 121);
			this.DelAll.Name = "DelAll";
			this.DelAll.Size = new System.Drawing.Size(112, 38);
			this.DelAll.Style = MetroFramework.MetroColorStyle.Red;
			this.DelAll.TabIndex = 42;
			this.DelAll.Text = "Supprimer";
			this.DelAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DelAll.TileImage = global::SafranCotChargeCapa.Properties.Resources.trash_26px;
			this.DelAll.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DelAll.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.DelAll.UseSelectable = true;
			this.DelAll.UseTileImage = true;
			this.DelAll.Click += new System.EventHandler(this.DelAll_Click);
			// 
			// SaveUpdate
			// 
			this.SaveUpdate.ActiveControl = null;
			this.SaveUpdate.Enabled = false;
			this.SaveUpdate.Location = new System.Drawing.Point(661, 71);
			this.SaveUpdate.Name = "SaveUpdate";
			this.SaveUpdate.Size = new System.Drawing.Size(112, 38);
			this.SaveUpdate.TabIndex = 41;
			this.SaveUpdate.Text = "Mise à jour";
			this.SaveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SaveUpdate.TileImage = global::SafranCotChargeCapa.Properties.Resources.refresh_26px;
			this.SaveUpdate.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SaveUpdate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.SaveUpdate.UseSelectable = true;
			this.SaveUpdate.UseTileImage = true;
			// 
			// AddButton
			// 
			this.AddButton.ActiveControl = null;
			this.AddButton.Location = new System.Drawing.Point(661, 22);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(112, 38);
			this.AddButton.TabIndex = 40;
			this.AddButton.Text = "Sauvegarde";
			this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddButton.TileImage = global::SafranCotChargeCapa.Properties.Resources.save_26px2;
			this.AddButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.AddButton.UseSelectable = true;
			this.AddButton.UseTileImage = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// MachineIDInput
			// 
			// 
			// 
			// 
			this.MachineIDInput.CustomButton.Image = null;
			this.MachineIDInput.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.MachineIDInput.CustomButton.Name = "";
			this.MachineIDInput.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.MachineIDInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.MachineIDInput.CustomButton.TabIndex = 1;
			this.MachineIDInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.MachineIDInput.CustomButton.UseSelectable = true;
			this.MachineIDInput.DisplayIcon = true;
			this.MachineIDInput.Icon = global::SafranCotChargeCapa.Properties.Resources.search_24px;
			this.MachineIDInput.IconRight = true;
			this.MachineIDInput.Lines = new string[0];
			this.MachineIDInput.Location = new System.Drawing.Point(205, 86);
			this.MachineIDInput.MaxLength = 32767;
			this.MachineIDInput.Name = "MachineIDInput";
			this.MachineIDInput.PasswordChar = '\0';
			this.MachineIDInput.PromptText = "Operation ID";
			this.MachineIDInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.MachineIDInput.SelectedText = "";
			this.MachineIDInput.SelectionLength = 0;
			this.MachineIDInput.SelectionStart = 0;
			this.MachineIDInput.ShortcutsEnabled = true;
			this.MachineIDInput.ShowButton = true;
			this.MachineIDInput.Size = new System.Drawing.Size(145, 23);
			this.MachineIDInput.TabIndex = 12;
			this.MachineIDInput.UseSelectable = true;
			this.MachineIDInput.WaterMark = "Operation ID";
			this.MachineIDInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.MachineIDInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.MachineIDInput.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.MachineIDInput_ButtonClick);
			// 
			// IlotIDS
			// 
			this.IlotIDS.FormattingEnabled = true;
			this.IlotIDS.ItemHeight = 23;
			this.IlotIDS.Location = new System.Drawing.Point(215, 123);
			this.IlotIDS.Name = "IlotIDS";
			this.IlotIDS.Size = new System.Drawing.Size(121, 29);
			this.IlotIDS.TabIndex = 43;
			this.IlotIDS.UseSelectable = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DelMach);
			this.groupBox1.Controls.Add(this.SaveMach);
			this.groupBox1.Controls.Add(this.AddMach);
			this.groupBox1.Controls.Add(this.MachineSelc);
			this.groupBox1.Controls.Add(this.HideMach);
			this.groupBox1.Controls.Add(this.MachineCycleTime);
			this.groupBox1.Controls.Add(this.metroLabel6);
			this.groupBox1.Controls.Add(this.metroLabel5);
			this.groupBox1.Location = new System.Drawing.Point(4, 249);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(387, 224);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Machine Section";
			// 
			// DelMach
			// 
			this.DelMach.ActiveControl = null;
			this.DelMach.Enabled = false;
			this.DelMach.Location = new System.Drawing.Point(265, 125);
			this.DelMach.Name = "DelMach";
			this.DelMach.Size = new System.Drawing.Size(112, 38);
			this.DelMach.Style = MetroFramework.MetroColorStyle.Red;
			this.DelMach.TabIndex = 55;
			this.DelMach.Text = "Supprimer";
			this.DelMach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DelMach.TileImage = global::SafranCotChargeCapa.Properties.Resources.trash_26px;
			this.DelMach.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DelMach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.DelMach.UseSelectable = true;
			this.DelMach.UseTileImage = true;
			this.DelMach.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// SaveMach
			// 
			this.SaveMach.ActiveControl = null;
			this.SaveMach.Enabled = false;
			this.SaveMach.Location = new System.Drawing.Point(147, 125);
			this.SaveMach.Name = "SaveMach";
			this.SaveMach.Size = new System.Drawing.Size(112, 38);
			this.SaveMach.TabIndex = 54;
			this.SaveMach.Text = "Mise à jour";
			this.SaveMach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SaveMach.TileImage = global::SafranCotChargeCapa.Properties.Resources.refresh_26px;
			this.SaveMach.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SaveMach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.SaveMach.UseSelectable = true;
			this.SaveMach.UseTileImage = true;
			this.SaveMach.Click += new System.EventHandler(this.SaveMach_Click);
			// 
			// AddMach
			// 
			this.AddMach.ActiveControl = null;
			this.AddMach.Location = new System.Drawing.Point(20, 125);
			this.AddMach.Name = "AddMach";
			this.AddMach.Size = new System.Drawing.Size(112, 38);
			this.AddMach.TabIndex = 53;
			this.AddMach.Text = "Sauvegarde";
			this.AddMach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddMach.TileImage = global::SafranCotChargeCapa.Properties.Resources.save_26px2;
			this.AddMach.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddMach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.AddMach.UseSelectable = true;
			this.AddMach.UseTileImage = true;
			this.AddMach.Click += new System.EventHandler(this.AddMach_Click);
			// 
			// MachineSelc
			// 
			this.MachineSelc.FormattingEnabled = true;
			this.MachineSelc.ItemHeight = 23;
			this.MachineSelc.Location = new System.Drawing.Point(211, 33);
			this.MachineSelc.Name = "MachineSelc";
			this.MachineSelc.Size = new System.Drawing.Size(121, 29);
			this.MachineSelc.TabIndex = 52;
			this.MachineSelc.UseSelectable = true;
			// 
			// HideMach
			// 
			this.HideMach.AutoSize = true;
			this.HideMach.Location = new System.Drawing.Point(302, 184);
			this.HideMach.Name = "HideMach";
			this.HideMach.Size = new System.Drawing.Size(0, 13);
			this.HideMach.TabIndex = 0;
			// 
			// MachineCycleTime
			// 
			// 
			// 
			// 
			this.MachineCycleTime.CustomButton.Image = null;
			this.MachineCycleTime.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.MachineCycleTime.CustomButton.Name = "";
			this.MachineCycleTime.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.MachineCycleTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.MachineCycleTime.CustomButton.TabIndex = 1;
			this.MachineCycleTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.MachineCycleTime.CustomButton.UseSelectable = true;
			this.MachineCycleTime.CustomButton.Visible = false;
			this.MachineCycleTime.Lines = new string[0];
			this.MachineCycleTime.Location = new System.Drawing.Point(232, 72);
			this.MachineCycleTime.MaxLength = 32767;
			this.MachineCycleTime.Name = "MachineCycleTime";
			this.MachineCycleTime.PasswordChar = '\0';
			this.MachineCycleTime.PromptText = "temps de cycle en H";
			this.MachineCycleTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.MachineCycleTime.SelectedText = "";
			this.MachineCycleTime.SelectionLength = 0;
			this.MachineCycleTime.SelectionStart = 0;
			this.MachineCycleTime.ShortcutsEnabled = true;
			this.MachineCycleTime.Size = new System.Drawing.Size(145, 23);
			this.MachineCycleTime.TabIndex = 51;
			this.MachineCycleTime.UseSelectable = true;
			this.MachineCycleTime.WaterMark = "temps de cycle en H";
			this.MachineCycleTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.MachineCycleTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel6.Location = new System.Drawing.Point(19, 33);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(126, 25);
			this.metroLabel6.TabIndex = 49;
			this.metroLabel6.Text = "ID de Machine";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel5.Location = new System.Drawing.Point(20, 71);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(136, 25);
			this.metroLabel5.TabIndex = 50;
			this.metroLabel5.Text = "Temps de cycle ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.metroTile4);
			this.groupBox2.Controls.Add(this.metroTile5);
			this.groupBox2.Controls.Add(this.metroTile6);
			this.groupBox2.Controls.Add(this.metroComboBox2);
			this.groupBox2.Controls.Add(this.metroTextBox2);
			this.groupBox2.Controls.Add(this.metroLabel7);
			this.groupBox2.Controls.Add(this.metroLabel8);
			this.groupBox2.Location = new System.Drawing.Point(397, 249);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(411, 224);
			this.groupBox2.TabIndex = 56;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Machine Section";
			// 
			// metroTile4
			// 
			this.metroTile4.ActiveControl = null;
			this.metroTile4.Enabled = false;
			this.metroTile4.Location = new System.Drawing.Point(272, 122);
			this.metroTile4.Name = "metroTile4";
			this.metroTile4.Size = new System.Drawing.Size(112, 38);
			this.metroTile4.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile4.TabIndex = 62;
			this.metroTile4.Text = "Supprimer";
			this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroTile4.TileImage = global::SafranCotChargeCapa.Properties.Resources.trash_26px;
			this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile4.UseSelectable = true;
			this.metroTile4.UseTileImage = true;
			// 
			// metroTile5
			// 
			this.metroTile5.ActiveControl = null;
			this.metroTile5.Enabled = false;
			this.metroTile5.Location = new System.Drawing.Point(154, 122);
			this.metroTile5.Name = "metroTile5";
			this.metroTile5.Size = new System.Drawing.Size(112, 38);
			this.metroTile5.TabIndex = 61;
			this.metroTile5.Text = "Mise à jour";
			this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroTile5.TileImage = global::SafranCotChargeCapa.Properties.Resources.refresh_26px;
			this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile5.UseSelectable = true;
			this.metroTile5.UseTileImage = true;
			// 
			// metroTile6
			// 
			this.metroTile6.ActiveControl = null;
			this.metroTile6.Location = new System.Drawing.Point(27, 122);
			this.metroTile6.Name = "metroTile6";
			this.metroTile6.Size = new System.Drawing.Size(112, 38);
			this.metroTile6.TabIndex = 60;
			this.metroTile6.Text = "Sauvegarde";
			this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroTile6.TileImage = global::SafranCotChargeCapa.Properties.Resources.save_26px2;
			this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile6.UseSelectable = true;
			this.metroTile6.UseTileImage = true;
			// 
			// metroComboBox2
			// 
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Location = new System.Drawing.Point(208, 33);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
			this.metroComboBox2.TabIndex = 59;
			this.metroComboBox2.UseSelectable = true;
			// 
			// metroTextBox2
			// 
			// 
			// 
			// 
			this.metroTextBox2.CustomButton.Image = null;
			this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.metroTextBox2.CustomButton.Name = "";
			this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox2.CustomButton.TabIndex = 1;
			this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox2.CustomButton.UseSelectable = true;
			this.metroTextBox2.CustomButton.Visible = false;
			this.metroTextBox2.Lines = new string[0];
			this.metroTextBox2.Location = new System.Drawing.Point(229, 72);
			this.metroTextBox2.MaxLength = 32767;
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.PasswordChar = '\0';
			this.metroTextBox2.PromptText = "temps de cycle en H";
			this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox2.SelectedText = "";
			this.metroTextBox2.SelectionLength = 0;
			this.metroTextBox2.SelectionStart = 0;
			this.metroTextBox2.ShortcutsEnabled = true;
			this.metroTextBox2.Size = new System.Drawing.Size(145, 23);
			this.metroTextBox2.TabIndex = 58;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.WaterMark = "temps de cycle en H";
			this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel7.Location = new System.Drawing.Point(16, 33);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(103, 25);
			this.metroLabel7.TabIndex = 56;
			this.metroLabel7.Text = "ID de l\'outil";
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel8.Location = new System.Drawing.Point(17, 71);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(136, 25);
			this.metroLabel8.TabIndex = 57;
			this.metroLabel8.Text = "Temps de cycle ";
			// 
			// ManOperation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 477);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.IlotIDS);
			this.Controls.Add(this.DelAll);
			this.Controls.Add(this.SaveUpdate);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.PRoductIDSelect);
			this.Controls.Add(this.EffInput);
			this.Controls.Add(this.MachineIDInput);
			this.Controls.Add(this.InputOperation);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Name = "ManOperation";
			this.Text = "Gestion des operations";
			this.Load += new System.EventHandler(this.ManOperation_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroTextBox EffInput;
		private MetroFramework.Controls.MetroTextBox MachineIDInput;
		private MetroFramework.Controls.MetroComboBox InputOperation;
		private System.Windows.Forms.CheckedListBox PRoductIDSelect;
		private MetroFramework.Controls.MetroTile SaveUpdate;
		private MetroFramework.Controls.MetroTile AddButton;
		private MetroFramework.Controls.MetroTile DelAll;
		private MetroFramework.Controls.MetroComboBox IlotIDS;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label HideMach;
		private MetroFramework.Controls.MetroComboBox MachineSelc;
		private MetroFramework.Controls.MetroTextBox MachineCycleTime;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTile DelMach;
		private MetroFramework.Controls.MetroTile SaveMach;
		private MetroFramework.Controls.MetroTile AddMach;
		private System.Windows.Forms.GroupBox groupBox2;
		private MetroFramework.Controls.MetroTile metroTile4;
		private MetroFramework.Controls.MetroTile metroTile5;
		private MetroFramework.Controls.MetroTile metroTile6;
		private MetroFramework.Controls.MetroComboBox metroComboBox2;
		private MetroFramework.Controls.MetroTextBox metroTextBox2;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroLabel metroLabel8;
	}
}