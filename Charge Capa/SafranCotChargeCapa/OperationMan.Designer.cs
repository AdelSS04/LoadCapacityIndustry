namespace SafranCotChargeCapa
{
	partial class OperationMan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationMan));
			this.SaveUpdate = new Bunifu.Framework.UI.BunifuImageButton();
			this.SearchButton = new Bunifu.Framework.UI.BunifuImageButton();
			this.EffInput = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.MachineIDInput = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.Produ = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.ManuelCycleTime = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.MachineName = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.MachineID = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.AddButton = new Bunifu.Framework.UI.BunifuImageButton();
			this.PRoductIDSelect = new System.Windows.Forms.CheckedListBox();
			this.InputOperation = new Bunifu.Framework.UI.BunifuDropdown();
			this.IlotIDS = new Bunifu.Framework.UI.BunifuDropdown();
			this.DelAll = new Bunifu.Framework.UI.BunifuImageButton();
			this.MachineSelc = new Bunifu.Framework.UI.BunifuDropdown();
			this.MachineCycleTime = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.DelMach = new Bunifu.Framework.UI.BunifuImageButton();
			this.AddMach = new Bunifu.Framework.UI.BunifuImageButton();
			this.SaveMach = new Bunifu.Framework.UI.BunifuImageButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.HideMach = new System.Windows.Forms.Label();
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.HideTools = new System.Windows.Forms.Label();
			this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
			((System.ComponentModel.ISupportInitialize)(this.SaveUpdate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DelAll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DelMach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddMach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SaveMach)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// SaveUpdate
			// 
			this.SaveUpdate.BackColor = System.Drawing.Color.Transparent;
			this.SaveUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SaveUpdate.Enabled = false;
			this.SaveUpdate.Image = ((System.Drawing.Image)(resources.GetObject("SaveUpdate.Image")));
			this.SaveUpdate.ImageActive = null;
			this.SaveUpdate.Location = new System.Drawing.Point(775, 75);
			this.SaveUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SaveUpdate.Name = "SaveUpdate";
			this.SaveUpdate.Size = new System.Drawing.Size(43, 43);
			this.SaveUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SaveUpdate.TabIndex = 20;
			this.SaveUpdate.TabStop = false;
			this.SaveUpdate.Zoom = 10;
			this.SaveUpdate.Click += new System.EventHandler(this.SaveUpdate_Click);
			// 
			// SearchButton
			// 
			this.SearchButton.BackColor = System.Drawing.Color.Transparent;
			this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
			this.SearchButton.ImageActive = null;
			this.SearchButton.Location = new System.Drawing.Point(775, 27);
			this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(43, 43);
			this.SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SearchButton.TabIndex = 19;
			this.SearchButton.TabStop = false;
			this.SearchButton.Zoom = 10;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// EffInput
			// 
			this.EffInput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.EffInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.EffInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.EffInput.HintForeColor = System.Drawing.Color.Empty;
			this.EffInput.HintText = "";
			this.EffInput.isPassword = true;
			this.EffInput.LineFocusedColor = System.Drawing.Color.Blue;
			this.EffInput.LineIdleColor = System.Drawing.Color.Gray;
			this.EffInput.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.EffInput.LineThickness = 3;
			this.EffInput.Location = new System.Drawing.Point(284, 142);
			this.EffInput.Margin = new System.Windows.Forms.Padding(5);
			this.EffInput.Name = "EffInput";
			this.EffInput.Size = new System.Drawing.Size(71, 54);
			this.EffInput.TabIndex = 17;
			this.EffInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// MachineIDInput
			// 
			this.MachineIDInput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.MachineIDInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.MachineIDInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.MachineIDInput.HintForeColor = System.Drawing.Color.Empty;
			this.MachineIDInput.HintText = "";
			this.MachineIDInput.isPassword = false;
			this.MachineIDInput.LineFocusedColor = System.Drawing.Color.Blue;
			this.MachineIDInput.LineIdleColor = System.Drawing.Color.Gray;
			this.MachineIDInput.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.MachineIDInput.LineThickness = 3;
			this.MachineIDInput.Location = new System.Drawing.Point(249, 19);
			this.MachineIDInput.Margin = new System.Windows.Forms.Padding(5);
			this.MachineIDInput.Name = "MachineIDInput";
			this.MachineIDInput.Size = new System.Drawing.Size(150, 54);
			this.MachineIDInput.TabIndex = 15;
			this.MachineIDInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.MachineIDInput.OnValueChanged += new System.EventHandler(this.MachineIDInput_OnValueChanged);
			// 
			// Produ
			// 
			this.Produ.AutoSize = true;
			this.Produ.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Produ.Location = new System.Drawing.Point(433, 120);
			this.Produ.Name = "Produ";
			this.Produ.Size = new System.Drawing.Size(128, 24);
			this.Produ.TabIndex = 14;
			this.Produ.Text = "Product ID :";
			// 
			// ManuelCycleTime
			// 
			this.ManuelCycleTime.AutoSize = true;
			this.ManuelCycleTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ManuelCycleTime.Location = new System.Drawing.Point(12, 169);
			this.ManuelCycleTime.Name = "ManuelCycleTime";
			this.ManuelCycleTime.Size = new System.Drawing.Size(212, 24);
			this.ManuelCycleTime.TabIndex = 13;
			this.ManuelCycleTime.Text = "Manuel Cycle Time:";
			// 
			// MachineName
			// 
			this.MachineName.AutoSize = true;
			this.MachineName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MachineName.Location = new System.Drawing.Point(10, 105);
			this.MachineName.Name = "MachineName";
			this.MachineName.Size = new System.Drawing.Size(79, 24);
			this.MachineName.TabIndex = 12;
			this.MachineName.Text = "Ilot ID :";
			// 
			// MachineID
			// 
			this.MachineID.AutoSize = true;
			this.MachineID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MachineID.Location = new System.Drawing.Point(12, 46);
			this.MachineID.Name = "MachineID";
			this.MachineID.Size = new System.Drawing.Size(159, 24);
			this.MachineID.TabIndex = 11;
			this.MachineID.Text = "Operations ID :";
			this.MachineID.Click += new System.EventHandler(this.MachineID_Click);
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.Transparent;
			this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
			this.AddButton.ImageActive = null;
			this.AddButton.Location = new System.Drawing.Point(775, 121);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(43, 43);
			this.AddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.AddButton.TabIndex = 22;
			this.AddButton.TabStop = false;
			this.AddButton.Zoom = 10;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// PRoductIDSelect
			// 
			this.PRoductIDSelect.CausesValidation = false;
			this.PRoductIDSelect.CheckOnClick = true;
			this.PRoductIDSelect.FormattingEnabled = true;
			this.PRoductIDSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.PRoductIDSelect.Location = new System.Drawing.Point(612, 120);
			this.PRoductIDSelect.Name = "PRoductIDSelect";
			this.PRoductIDSelect.Size = new System.Drawing.Size(120, 68);
			this.PRoductIDSelect.TabIndex = 28;
			this.PRoductIDSelect.SelectedIndexChanged += new System.EventHandler(this.PRoductIDSelect_SelectedIndexChanged);
			// 
			// InputOperation
			// 
			this.InputOperation.BackColor = System.Drawing.Color.Transparent;
			this.InputOperation.BorderRadius = 3;
			this.InputOperation.ForeColor = System.Drawing.Color.White;
			this.InputOperation.Items = new string[0];
			this.InputOperation.Location = new System.Drawing.Point(437, 37);
			this.InputOperation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.InputOperation.Name = "InputOperation";
			this.InputOperation.NomalColor = System.Drawing.SystemColors.WindowFrame;
			this.InputOperation.onHoverColor = System.Drawing.SystemColors.GrayText;
			this.InputOperation.selectedIndex = -1;
			this.InputOperation.Size = new System.Drawing.Size(213, 36);
			this.InputOperation.TabIndex = 30;
			this.InputOperation.onItemSelected += new System.EventHandler(this.RoleInput_onItemSelected);
			// 
			// IlotIDS
			// 
			this.IlotIDS.BackColor = System.Drawing.Color.Transparent;
			this.IlotIDS.BorderRadius = 3;
			this.IlotIDS.ForeColor = System.Drawing.Color.White;
			this.IlotIDS.Items = new string[0];
			this.IlotIDS.Location = new System.Drawing.Point(157, 100);
			this.IlotIDS.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.IlotIDS.Name = "IlotIDS";
			this.IlotIDS.NomalColor = System.Drawing.SystemColors.WindowFrame;
			this.IlotIDS.onHoverColor = System.Drawing.SystemColors.GrayText;
			this.IlotIDS.selectedIndex = -1;
			this.IlotIDS.Size = new System.Drawing.Size(209, 44);
			this.IlotIDS.TabIndex = 37;
			this.IlotIDS.onItemSelected += new System.EventHandler(this.IlotIDS_onItemSelected);
			// 
			// DelAll
			// 
			this.DelAll.BackColor = System.Drawing.Color.Transparent;
			this.DelAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DelAll.Enabled = false;
			this.DelAll.Image = ((System.Drawing.Image)(resources.GetObject("DelAll.Image")));
			this.DelAll.ImageActive = null;
			this.DelAll.Location = new System.Drawing.Point(775, 170);
			this.DelAll.Name = "DelAll";
			this.DelAll.Size = new System.Drawing.Size(43, 43);
			this.DelAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DelAll.TabIndex = 39;
			this.DelAll.TabStop = false;
			this.DelAll.Zoom = 10;
			this.DelAll.Click += new System.EventHandler(this.DelAll_Click);
			// 
			// MachineSelc
			// 
			this.MachineSelc.BackColor = System.Drawing.Color.Transparent;
			this.MachineSelc.BorderRadius = 3;
			this.MachineSelc.ForeColor = System.Drawing.Color.White;
			this.MachineSelc.Items = new string[0];
			this.MachineSelc.Location = new System.Drawing.Point(206, 263);
			this.MachineSelc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.MachineSelc.Name = "MachineSelc";
			this.MachineSelc.NomalColor = System.Drawing.SystemColors.WindowFrame;
			this.MachineSelc.onHoverColor = System.Drawing.SystemColors.GrayText;
			this.MachineSelc.selectedIndex = -1;
			this.MachineSelc.Size = new System.Drawing.Size(209, 44);
			this.MachineSelc.TabIndex = 40;
			// 
			// MachineCycleTime
			// 
			this.MachineCycleTime.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.MachineCycleTime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.MachineCycleTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.MachineCycleTime.HintForeColor = System.Drawing.Color.Empty;
			this.MachineCycleTime.HintText = "";
			this.MachineCycleTime.isPassword = true;
			this.MachineCycleTime.LineFocusedColor = System.Drawing.Color.Blue;
			this.MachineCycleTime.LineIdleColor = System.Drawing.Color.Gray;
			this.MachineCycleTime.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.MachineCycleTime.LineThickness = 3;
			this.MachineCycleTime.Location = new System.Drawing.Point(284, 318);
			this.MachineCycleTime.Margin = new System.Windows.Forms.Padding(5);
			this.MachineCycleTime.Name = "MachineCycleTime";
			this.MachineCycleTime.Size = new System.Drawing.Size(71, 54);
			this.MachineCycleTime.TabIndex = 41;
			this.MachineCycleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 272);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(138, 24);
			this.bunifuCustomLabel1.TabIndex = 42;
			this.bunifuCustomLabel1.Text = "Machine ID :";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 327);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(230, 24);
			this.bunifuCustomLabel2.TabIndex = 43;
			this.bunifuCustomLabel2.Text = "Machine Cycle Time :";
			// 
			// DelMach
			// 
			this.DelMach.BackColor = System.Drawing.Color.Transparent;
			this.DelMach.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DelMach.Enabled = false;
			this.DelMach.Image = ((System.Drawing.Image)(resources.GetObject("DelMach.Image")));
			this.DelMach.ImageActive = null;
			this.DelMach.Location = new System.Drawing.Point(167, 408);
			this.DelMach.Name = "DelMach";
			this.DelMach.Size = new System.Drawing.Size(43, 43);
			this.DelMach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DelMach.TabIndex = 46;
			this.DelMach.TabStop = false;
			this.DelMach.Zoom = 10;
			this.DelMach.Click += new System.EventHandler(this.DelMach_Click);
			// 
			// AddMach
			// 
			this.AddMach.BackColor = System.Drawing.Color.Transparent;
			this.AddMach.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddMach.Enabled = false;
			this.AddMach.Image = ((System.Drawing.Image)(resources.GetObject("AddMach.Image")));
			this.AddMach.ImageActive = null;
			this.AddMach.Location = new System.Drawing.Point(107, 408);
			this.AddMach.Name = "AddMach";
			this.AddMach.Size = new System.Drawing.Size(43, 43);
			this.AddMach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.AddMach.TabIndex = 45;
			this.AddMach.TabStop = false;
			this.AddMach.Zoom = 10;
			this.AddMach.Click += new System.EventHandler(this.AddMach_Click);
			// 
			// SaveMach
			// 
			this.SaveMach.BackColor = System.Drawing.Color.Transparent;
			this.SaveMach.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SaveMach.Enabled = false;
			this.SaveMach.Image = ((System.Drawing.Image)(resources.GetObject("SaveMach.Image")));
			this.SaveMach.ImageActive = null;
			this.SaveMach.Location = new System.Drawing.Point(46, 408);
			this.SaveMach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SaveMach.Name = "SaveMach";
			this.SaveMach.Size = new System.Drawing.Size(43, 43);
			this.SaveMach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SaveMach.TabIndex = 44;
			this.SaveMach.TabStop = false;
			this.SaveMach.Zoom = 10;
			this.SaveMach.Click += new System.EventHandler(this.SaveMach_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.HideMach);
			this.groupBox1.Location = new System.Drawing.Point(0, 251);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(433, 224);
			this.groupBox1.TabIndex = 47;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Machine Section";
			// 
			// HideMach
			// 
			this.HideMach.AutoSize = true;
			this.HideMach.Location = new System.Drawing.Point(302, 184);
			this.HideMach.Name = "HideMach";
			this.HideMach.Size = new System.Drawing.Size(0, 16);
			this.HideMach.TabIndex = 0;
			// 
			// bunifuImageButton5
			// 
			this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton5.Enabled = false;
			this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new System.Drawing.Point(311, 157);
			this.bunifuImageButton5.Name = "bunifuImageButton5";
			this.bunifuImageButton5.Size = new System.Drawing.Size(43, 43);
			this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton5.TabIndex = 54;
			this.bunifuImageButton5.TabStop = false;
			this.bunifuImageButton5.Zoom = 10;
			// 
			// bunifuImageButton6
			// 
			this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton6.Enabled = false;
			this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
			this.bunifuImageButton6.ImageActive = null;
			this.bunifuImageButton6.Location = new System.Drawing.Point(262, 157);
			this.bunifuImageButton6.Name = "bunifuImageButton6";
			this.bunifuImageButton6.Size = new System.Drawing.Size(43, 43);
			this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton6.TabIndex = 53;
			this.bunifuImageButton6.TabStop = false;
			this.bunifuImageButton6.Zoom = 10;
			// 
			// bunifuImageButton7
			// 
			this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton7.Enabled = false;
			this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
			this.bunifuImageButton7.ImageActive = null;
			this.bunifuImageButton7.Location = new System.Drawing.Point(213, 157);
			this.bunifuImageButton7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bunifuImageButton7.Name = "bunifuImageButton7";
			this.bunifuImageButton7.Size = new System.Drawing.Size(43, 43);
			this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton7.TabIndex = 52;
			this.bunifuImageButton7.TabStop = false;
			this.bunifuImageButton7.Zoom = 10;
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(5, 86);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(238, 24);
			this.bunifuCustomLabel3.TabIndex = 51;
			this.bunifuCustomLabel3.Text = "Tools Ocupation Time :";
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.AutoSize = true;
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(6, 32);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(97, 24);
			this.bunifuCustomLabel4.TabIndex = 50;
			this.bunifuCustomLabel4.Text = "Tools ID :";
			// 
			// bunifuMaterialTextbox2
			// 
			this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox2.HintText = "";
			this.bunifuMaterialTextbox2.isPassword = true;
			this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue;
			this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(274, 67);
			this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(5);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(71, 45);
			this.bunifuMaterialTextbox2.TabIndex = 49;
			this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.HideTools);
			this.groupBox2.Controls.Add(this.bunifuDropdown2);
			this.groupBox2.Controls.Add(this.bunifuImageButton7);
			this.groupBox2.Controls.Add(this.bunifuImageButton6);
			this.groupBox2.Controls.Add(this.bunifuImageButton5);
			this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
			this.groupBox2.Controls.Add(this.bunifuMaterialTextbox2);
			this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
			this.groupBox2.Location = new System.Drawing.Point(438, 251);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(433, 224);
			this.groupBox2.TabIndex = 55;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Machine Section";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// HideTools
			// 
			this.HideTools.AutoSize = true;
			this.HideTools.Location = new System.Drawing.Point(62, 184);
			this.HideTools.Name = "HideTools";
			this.HideTools.Size = new System.Drawing.Size(0, 16);
			this.HideTools.TabIndex = 1;
			// 
			// bunifuDropdown2
			// 
			this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuDropdown2.BorderRadius = 3;
			this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
			this.bunifuDropdown2.Items = new string[0];
			this.bunifuDropdown2.Location = new System.Drawing.Point(172, 24);
			this.bunifuDropdown2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
			this.bunifuDropdown2.Name = "bunifuDropdown2";
			this.bunifuDropdown2.NomalColor = System.Drawing.SystemColors.WindowFrame;
			this.bunifuDropdown2.onHoverColor = System.Drawing.SystemColors.GrayText;
			this.bunifuDropdown2.selectedIndex = -1;
			this.bunifuDropdown2.Size = new System.Drawing.Size(173, 34);
			this.bunifuDropdown2.TabIndex = 56;
			// 
			// OperationMan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 474);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.DelMach);
			this.Controls.Add(this.AddMach);
			this.Controls.Add(this.SaveMach);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.MachineCycleTime);
			this.Controls.Add(this.MachineSelc);
			this.Controls.Add(this.DelAll);
			this.Controls.Add(this.IlotIDS);
			this.Controls.Add(this.InputOperation);
			this.Controls.Add(this.PRoductIDSelect);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.SaveUpdate);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.EffInput);
			this.Controls.Add(this.MachineIDInput);
			this.Controls.Add(this.Produ);
			this.Controls.Add(this.ManuelCycleTime);
			this.Controls.Add(this.MachineName);
			this.Controls.Add(this.MachineID);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "OperationMan";
			this.Text = "ManageMachine";
			this.Load += new System.EventHandler(this.ManageMachine_Load);
			((System.ComponentModel.ISupportInitialize)(this.SaveUpdate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DelAll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DelMach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddMach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SaveMach)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuImageButton SaveUpdate;
		private Bunifu.Framework.UI.BunifuImageButton SearchButton;
		private Bunifu.Framework.UI.BunifuMaterialTextbox EffInput;
		private Bunifu.Framework.UI.BunifuMaterialTextbox MachineIDInput;
		private Bunifu.Framework.UI.BunifuCustomLabel Produ;
		private Bunifu.Framework.UI.BunifuCustomLabel ManuelCycleTime;
		private Bunifu.Framework.UI.BunifuCustomLabel MachineName;
		private Bunifu.Framework.UI.BunifuCustomLabel MachineID;
		private Bunifu.Framework.UI.BunifuImageButton AddButton;
		private System.Windows.Forms.CheckedListBox PRoductIDSelect;
		private Bunifu.Framework.UI.BunifuDropdown InputOperation;
		private Bunifu.Framework.UI.BunifuDropdown IlotIDS;
		private Bunifu.Framework.UI.BunifuImageButton DelAll;
		private Bunifu.Framework.UI.BunifuDropdown MachineSelc;
		private Bunifu.Framework.UI.BunifuMaterialTextbox MachineCycleTime;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuImageButton DelMach;
		private Bunifu.Framework.UI.BunifuImageButton AddMach;
		private Bunifu.Framework.UI.BunifuImageButton SaveMach;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
		private System.Windows.Forms.Label HideMach;
		private System.Windows.Forms.Label HideTools;
	}
}