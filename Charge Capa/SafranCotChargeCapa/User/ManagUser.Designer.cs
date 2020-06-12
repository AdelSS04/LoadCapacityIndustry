namespace SafranCotChargeCapa
{
	partial class ManagUser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.UpButton = new System.Windows.Forms.Button();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.OpenDay = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.Shift = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.YeatT = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
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
			this.UpButton.Location = new System.Drawing.Point(531, 224);
			this.UpButton.Name = "UpButton";
			this.UpButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.UpButton.Size = new System.Drawing.Size(132, 30);
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
			this.metroLabel8.Size = new System.Drawing.Size(248, 25);
			this.metroLabel8.TabIndex = 1;
			this.metroLabel8.Text = "Veuillez remplir tous les champs";
			this.metroLabel8.UseCustomBackColor = true;
			this.metroLabel8.UseCustomForeColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.UpButton);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.metroComboBox1);
			this.groupBox2.Controls.Add(this.OpenDay);
			this.groupBox2.Controls.Add(this.Shift);
			this.groupBox2.Controls.Add(this.YeatT);
			this.groupBox2.Location = new System.Drawing.Point(0, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(922, 280);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ouverture de machine";
			// 
			// OpenDay
			// 
			this.OpenDay.Depth = 0;
			this.OpenDay.Hint = "Mot de passe";
			this.OpenDay.Location = new System.Drawing.Point(17, 140);
			this.OpenDay.MouseState = MaterialSkin.MouseState.HOVER;
			this.OpenDay.Name = "OpenDay";
			this.OpenDay.PasswordChar = '*';
			this.OpenDay.SelectedText = "";
			this.OpenDay.SelectionLength = 0;
			this.OpenDay.SelectionStart = 0;
			this.OpenDay.Size = new System.Drawing.Size(246, 23);
			this.OpenDay.TabIndex = 7;
			this.OpenDay.UseSystemPasswordChar = true;
			// 
			// Shift
			// 
			this.Shift.Depth = 0;
			this.Shift.Hint = "Nom & prénom";
			this.Shift.Location = new System.Drawing.Point(17, 84);
			this.Shift.MouseState = MaterialSkin.MouseState.HOVER;
			this.Shift.Name = "Shift";
			this.Shift.PasswordChar = '\0';
			this.Shift.SelectedText = "";
			this.Shift.SelectionLength = 0;
			this.Shift.SelectionStart = 0;
			this.Shift.Size = new System.Drawing.Size(246, 23);
			this.Shift.TabIndex = 6;
			this.Shift.UseSystemPasswordChar = false;
			// 
			// YeatT
			// 
			this.YeatT.Depth = 0;
			this.YeatT.Hint = "ID";
			this.YeatT.Location = new System.Drawing.Point(17, 35);
			this.YeatT.MouseState = MaterialSkin.MouseState.HOVER;
			this.YeatT.Name = "YeatT";
			this.YeatT.PasswordChar = '\0';
			this.YeatT.SelectedText = "";
			this.YeatT.SelectionLength = 0;
			this.YeatT.SelectionStart = 0;
			this.YeatT.Size = new System.Drawing.Size(246, 23);
			this.YeatT.TabIndex = 5;
			this.YeatT.UseSystemPasswordChar = false;
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
			this.metroComboBox1.Items.AddRange(new object[] {
            "Manager",
            "Planificateur",
            "ResAtelier"});
			this.metroComboBox1.Location = new System.Drawing.Point(17, 180);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(243, 29);
			this.metroComboBox1.TabIndex = 8;
			this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroComboBox1.UseCustomBackColor = true;
			this.metroComboBox1.UseCustomForeColor = true;
			this.metroComboBox1.UseSelectable = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView2);
			this.groupBox1.Location = new System.Drawing.Point(360, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(459, 180);
			this.groupBox1.TabIndex = 43;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Les utilisateurs";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// dataGridView2
			// 
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle20;
			this.dataGridView2.EnableHeadersVisualStyles = false;
			this.dataGridView2.Location = new System.Drawing.Point(3, 17);
			this.dataGridView2.Name = "dataGridView2";
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.Size = new System.Drawing.Size(452, 160);
			this.dataGridView2.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Beige;
			this.button1.Image = global::SafranCotChargeCapa.Properties.Resources.restart_20px;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(200, 224);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(127, 30);
			this.button1.TabIndex = 44;
			this.button1.Text = "Modifier";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ManagUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(934, 435);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ManagUser";
			this.Text = "IlotManag";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.IlotManag_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button UpButton;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private System.Windows.Forms.GroupBox groupBox2;
		private MaterialSkin.Controls.MaterialSingleLineTextField OpenDay;
		private MaterialSkin.Controls.MaterialSingleLineTextField Shift;
		private MaterialSkin.Controls.MaterialSingleLineTextField YeatT;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button button1;
	}
}