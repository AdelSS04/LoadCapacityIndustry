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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.MachineRejection = new MetroFramework.Controls.MetroTextBox();
			this.IlotNameInput = new MetroFramework.Controls.MetroTextBox();
			this.IlotIDInput = new MetroFramework.Controls.MetroTextBox();
			this.bunifuSwitch1 = new MetroFramework.Controls.MetroToggle();
			this.SaveUpdate = new MetroFramework.Controls.MetroTile();
			this.AddButton = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel1.Location = new System.Drawing.Point(24, 57);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(97, 19);
			this.metroLabel1.TabIndex = 30;
			this.metroLabel1.Text = "ID de machine";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel2.Location = new System.Drawing.Point(23, 103);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(113, 19);
			this.metroLabel2.TabIndex = 31;
			this.metroLabel2.Text = "Nom de machine";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel3.Location = new System.Drawing.Point(23, 153);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(91, 19);
			this.metroLabel3.TabIndex = 32;
			this.metroLabel3.Text = "Taux de rebut";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel4.Location = new System.Drawing.Point(24, 206);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(33, 19);
			this.metroLabel4.TabIndex = 33;
			this.metroLabel4.Text = "Etat";
			// 
			// MachineRejection
			// 
			// 
			// 
			// 
			this.MachineRejection.CustomButton.Image = null;
			this.MachineRejection.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.MachineRejection.CustomButton.Name = "";
			this.MachineRejection.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.MachineRejection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.MachineRejection.CustomButton.TabIndex = 1;
			this.MachineRejection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.MachineRejection.CustomButton.UseSelectable = true;
			this.MachineRejection.CustomButton.Visible = false;
			this.MachineRejection.Lines = new string[0];
			this.MachineRejection.Location = new System.Drawing.Point(175, 153);
			this.MachineRejection.MaxLength = 32767;
			this.MachineRejection.Name = "MachineRejection";
			this.MachineRejection.PasswordChar = '\0';
			this.MachineRejection.PromptText = "Taux de rebut en %";
			this.MachineRejection.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.MachineRejection.SelectedText = "";
			this.MachineRejection.SelectionLength = 0;
			this.MachineRejection.SelectionStart = 0;
			this.MachineRejection.ShortcutsEnabled = true;
			this.MachineRejection.Size = new System.Drawing.Size(145, 23);
			this.MachineRejection.TabIndex = 36;
			this.MachineRejection.UseSelectable = true;
			this.MachineRejection.WaterMark = "Taux de rebut en %";
			this.MachineRejection.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.MachineRejection.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
			this.IlotNameInput.Location = new System.Drawing.Point(175, 98);
			this.IlotNameInput.MaxLength = 32767;
			this.IlotNameInput.Name = "IlotNameInput";
			this.IlotNameInput.PasswordChar = '\0';
			this.IlotNameInput.PromptText = "Nom de machine";
			this.IlotNameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.IlotNameInput.SelectedText = "";
			this.IlotNameInput.SelectionLength = 0;
			this.IlotNameInput.SelectionStart = 0;
			this.IlotNameInput.ShortcutsEnabled = true;
			this.IlotNameInput.Size = new System.Drawing.Size(145, 23);
			this.IlotNameInput.TabIndex = 35;
			this.IlotNameInput.UseSelectable = true;
			this.IlotNameInput.WaterMark = "Nom de machine";
			this.IlotNameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.IlotNameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
			this.IlotIDInput.Location = new System.Drawing.Point(175, 53);
			this.IlotIDInput.MaxLength = 32767;
			this.IlotIDInput.Name = "IlotIDInput";
			this.IlotIDInput.PasswordChar = '\0';
			this.IlotIDInput.PromptText = "machine ID";
			this.IlotIDInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.IlotIDInput.SelectedText = "";
			this.IlotIDInput.SelectionLength = 0;
			this.IlotIDInput.SelectionStart = 0;
			this.IlotIDInput.ShortcutsEnabled = true;
			this.IlotIDInput.ShowButton = true;
			this.IlotIDInput.Size = new System.Drawing.Size(145, 23);
			this.IlotIDInput.TabIndex = 34;
			this.IlotIDInput.UseSelectable = true;
			this.IlotIDInput.WaterMark = "machine ID";
			this.IlotIDInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.IlotIDInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.IlotIDInput.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.IlotIDInput_ButtonClick);
			// 
			// bunifuSwitch1
			// 
			this.bunifuSwitch1.AutoSize = true;
			this.bunifuSwitch1.Location = new System.Drawing.Point(196, 205);
			this.bunifuSwitch1.Name = "bunifuSwitch1";
			this.bunifuSwitch1.Size = new System.Drawing.Size(80, 20);
			this.bunifuSwitch1.TabIndex = 37;
			this.bunifuSwitch1.Text = "Off";
			this.bunifuSwitch1.UseSelectable = true;
			// 
			// SaveUpdate
			// 
			this.SaveUpdate.ActiveControl = null;
			this.SaveUpdate.Enabled = false;
			this.SaveUpdate.Location = new System.Drawing.Point(175, 266);
			this.SaveUpdate.Name = "SaveUpdate";
			this.SaveUpdate.Size = new System.Drawing.Size(112, 38);
			this.SaveUpdate.TabIndex = 39;
			this.SaveUpdate.Text = "Mise à jour";
			this.SaveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SaveUpdate.TileImage = global::SafranCotChargeCapa.Properties.Resources.refresh_26px;
			this.SaveUpdate.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SaveUpdate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.SaveUpdate.UseSelectable = true;
			this.SaveUpdate.UseTileImage = true;
			this.SaveUpdate.Click += new System.EventHandler(this.Upilot_Click);
			// 
			// AddButton
			// 
			this.AddButton.ActiveControl = null;
			this.AddButton.Location = new System.Drawing.Point(39, 266);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(112, 38);
			this.AddButton.TabIndex = 38;
			this.AddButton.Text = "Sauvegarde";
			this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddButton.TileImage = global::SafranCotChargeCapa.Properties.Resources.save_26px2;
			this.AddButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.AddButton.UseSelectable = true;
			this.AddButton.UseTileImage = true;
			this.AddButton.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// ManageMachine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(665, 385);
			this.Controls.Add(this.SaveUpdate);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.bunifuSwitch1);
			this.Controls.Add(this.MachineRejection);
			this.Controls.Add(this.IlotNameInput);
			this.Controls.Add(this.IlotIDInput);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ManageMachine";
			this.Text = "Gestion des machines";
			this.Load += new System.EventHandler(this.ManageMachine_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroTextBox MachineRejection;
		private MetroFramework.Controls.MetroTextBox IlotNameInput;
		private MetroFramework.Controls.MetroTextBox IlotIDInput;
		private MetroFramework.Controls.MetroToggle bunifuSwitch1;
		private MetroFramework.Controls.MetroTile SaveUpdate;
		private MetroFramework.Controls.MetroTile AddButton;
	}
}