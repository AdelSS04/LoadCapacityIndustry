namespace SafranCotChargeCapa
{
	partial class AddPoste
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.UpButton = new System.Windows.Forms.Button();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.OpenDay = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.YeatT = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.MAchID = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
			this.panel1.Controls.Add(this.UpButton);
			this.panel1.Controls.Add(this.metroLabel8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 47);
			this.panel1.TabIndex = 17;
			// 
			// UpButton
			// 
			this.UpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
			this.UpButton.FlatAppearance.BorderSize = 0;
			this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpButton.ForeColor = System.Drawing.Color.Beige;
			this.UpButton.Image = global::SafranCotChargeCapa.Properties.Resources.add_database_20px;
			this.UpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UpButton.Location = new System.Drawing.Point(421, 4);
			this.UpButton.Name = "UpButton";
			this.UpButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.UpButton.Size = new System.Drawing.Size(145, 30);
			this.UpButton.TabIndex = 19;
			this.UpButton.Text = "Ajouter";
			this.UpButton.UseVisualStyleBackColor = false;
			this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.metroLabel8.Location = new System.Drawing.Point(12, 9);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(254, 25);
			this.metroLabel8.TabIndex = 1;
			this.metroLabel8.Text = "Veuillez remplir tous les champs";
			this.metroLabel8.UseCustomBackColor = true;
			this.metroLabel8.UseCustomForeColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.OpenDay);
			this.groupBox2.Controls.Add(this.YeatT);
			this.groupBox2.Location = new System.Drawing.Point(404, 57);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(331, 362);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ouverture de machine";
			// 
			// OpenDay
			// 
			this.OpenDay.Depth = 0;
			this.OpenDay.Hint = "Combien d\'operateur ?";
			this.OpenDay.Location = new System.Drawing.Point(17, 147);
			this.OpenDay.MouseState = MaterialSkin.MouseState.HOVER;
			this.OpenDay.Name = "OpenDay";
			this.OpenDay.PasswordChar = '\0';
			this.OpenDay.SelectedText = "";
			this.OpenDay.SelectionLength = 0;
			this.OpenDay.SelectionStart = 0;
			this.OpenDay.Size = new System.Drawing.Size(246, 23);
			this.OpenDay.TabIndex = 7;
			this.OpenDay.UseSystemPasswordChar = false;
			this.OpenDay.Click += new System.EventHandler(this.OpenDay_Click);
			this.OpenDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OpenDay_KeyPress);
			// 
			// YeatT
			// 
			this.YeatT.Depth = 0;
			this.YeatT.Hint = "Year";
			this.YeatT.Location = new System.Drawing.Point(17, 57);
			this.YeatT.MouseState = MaterialSkin.MouseState.HOVER;
			this.YeatT.Name = "YeatT";
			this.YeatT.PasswordChar = '\0';
			this.YeatT.SelectedText = "";
			this.YeatT.SelectionLength = 0;
			this.YeatT.SelectionStart = 0;
			this.YeatT.Size = new System.Drawing.Size(246, 23);
			this.YeatT.TabIndex = 5;
			this.YeatT.UseSystemPasswordChar = false;
			this.YeatT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YeatT_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.materialLabel1);
			this.groupBox1.Controls.Add(this.metroComboBox1);
			this.groupBox1.Controls.Add(this.MAchID);
			this.groupBox1.Location = new System.Drawing.Point(12, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 366);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Les information de poste";
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(16, 61);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(39, 19);
			this.materialLabel1.TabIndex = 3;
			this.materialLabel1.Text = "Ilot :";
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
			this.metroComboBox1.Location = new System.Drawing.Point(137, 61);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(160, 29);
			this.metroComboBox1.TabIndex = 2;
			this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroComboBox1.UseCustomBackColor = true;
			this.metroComboBox1.UseCustomForeColor = true;
			this.metroComboBox1.UseSelectable = true;
			// 
			// MAchID
			// 
			this.MAchID.Depth = 0;
			this.MAchID.Hint = "identifiant  de machine";
			this.MAchID.Location = new System.Drawing.Point(51, 151);
			this.MAchID.MouseState = MaterialSkin.MouseState.HOVER;
			this.MAchID.Name = "MAchID";
			this.MAchID.PasswordChar = '\0';
			this.MAchID.SelectedText = "";
			this.MAchID.SelectionLength = 0;
			this.MAchID.SelectionStart = 0;
			this.MAchID.Size = new System.Drawing.Size(246, 23);
			this.MAchID.TabIndex = 1;
			this.MAchID.UseSystemPasswordChar = false;
			// 
			// AddPoste
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(934, 435);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddPoste";
			this.Text = "IlotManag";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.IlotManag_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button UpButton;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private MaterialSkin.Controls.MaterialSingleLineTextField YeatT;
		private MaterialSkin.Controls.MaterialSingleLineTextField MAchID;
		private MaterialSkin.Controls.MaterialSingleLineTextField OpenDay;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
	}
}