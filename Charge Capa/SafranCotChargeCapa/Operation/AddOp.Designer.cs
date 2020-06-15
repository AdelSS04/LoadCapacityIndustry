namespace SafranCotChargeCapa
{
	partial class AddOp
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
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.UpButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.TcInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
			this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
			this.panel1.Controls.Add(this.metroLabel5);
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
			this.metroLabel5.Size = new System.Drawing.Size(248, 25);
			this.metroLabel5.TabIndex = 1;
			this.metroLabel5.Text = "Veuillez remplir tous les champs";
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
			this.UpButton.Location = new System.Drawing.Point(136, 235);
			this.UpButton.Name = "UpButton";
			this.UpButton.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.UpButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.UpButton.Size = new System.Drawing.Size(193, 30);
			this.UpButton.TabIndex = 19;
			this.UpButton.Text = "Ajouter l\'opération";
			this.UpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UpButton.UseVisualStyleBackColor = false;
			this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkedListBox1);
			this.groupBox2.Location = new System.Drawing.Point(490, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(226, 293);
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
			this.checkedListBox1.Size = new System.Drawing.Size(196, 244);
			this.checkedListBox1.TabIndex = 15;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.White;
			this.groupBox3.Controls.Add(this.materialSingleLineTextField1);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.UpButton);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.materialLabel1);
			this.groupBox3.Controls.Add(this.TcInput);
			this.groupBox3.Controls.Add(this.metroComboBox2);
			this.groupBox3.Controls.Add(this.metroComboBox3);
			this.groupBox3.Location = new System.Drawing.Point(12, 53);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(445, 293);
			this.groupBox3.TabIndex = 43;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Information de l\'operation";
			// 
			// materialSingleLineTextField1
			// 
			this.materialSingleLineTextField1.Depth = 0;
			this.materialSingleLineTextField1.Hint = "OperationID";
			this.materialSingleLineTextField1.Location = new System.Drawing.Point(50, 182);
			this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.PasswordChar = '\0';
			this.materialSingleLineTextField1.SelectedText = "";
			this.materialSingleLineTextField1.SelectionLength = 0;
			this.materialSingleLineTextField1.SelectionStart = 0;
			this.materialSingleLineTextField1.Size = new System.Drawing.Size(246, 23);
			this.materialSingleLineTextField1.TabIndex = 25;
			this.materialSingleLineTextField1.UseSystemPasswordChar = false;
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
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			// 
			// AddOp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(889, 500);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "AddOp";
			this.Text = "Gestion des machines";
			this.Load += new System.EventHandler(this.ManageMachine_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button UpButton;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private MetroFramework.Controls.MetroComboBox metroComboBox2;
		private MetroFramework.Controls.MetroComboBox metroComboBox3;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialSingleLineTextField TcInput;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
	}
}