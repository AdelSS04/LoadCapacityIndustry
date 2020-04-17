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
			this.panel1 = new System.Windows.Forms.Panel();
			this.UpButton = new System.Windows.Forms.Button();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.IlotID = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.IlotAbs = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.IlotRej = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.IlotCRM = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.IlotEff = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.IlotName = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
			this.groupBox2.Controls.Add(this.checkedListBox1);
			this.groupBox2.Location = new System.Drawing.Point(404, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(226, 180);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Responsable d\'ilot";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(17, 21);
			this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(196, 148);
			this.checkedListBox1.TabIndex = 15;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.IlotID);
			this.groupBox1.Controls.Add(this.IlotAbs);
			this.groupBox1.Controls.Add(this.IlotRej);
			this.groupBox1.Controls.Add(this.IlotCRM);
			this.groupBox1.Controls.Add(this.IlotEff);
			this.groupBox1.Controls.Add(this.IlotName);
			this.groupBox1.Location = new System.Drawing.Point(12, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 366);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Les information de l\'ilot";
			// 
			// IlotID
			// 
			this.IlotID.Depth = 0;
			this.IlotID.Hint = "identifiant  de l\'ilot";
			this.IlotID.Location = new System.Drawing.Point(29, 38);
			this.IlotID.MouseState = MaterialSkin.MouseState.HOVER;
			this.IlotID.Name = "IlotID";
			this.IlotID.PasswordChar = '\0';
			this.IlotID.SelectedText = "";
			this.IlotID.SelectionLength = 0;
			this.IlotID.SelectionStart = 0;
			this.IlotID.Size = new System.Drawing.Size(246, 23);
			this.IlotID.TabIndex = 1;
			this.IlotID.UseSystemPasswordChar = false;
			// 
			// IlotAbs
			// 
			this.IlotAbs.Depth = 0;
			this.IlotAbs.Hint = "Taux dabsence en % : 3";
			this.IlotAbs.Location = new System.Drawing.Point(29, 323);
			this.IlotAbs.MouseState = MaterialSkin.MouseState.HOVER;
			this.IlotAbs.Name = "IlotAbs";
			this.IlotAbs.PasswordChar = '\0';
			this.IlotAbs.SelectedText = "";
			this.IlotAbs.SelectionLength = 0;
			this.IlotAbs.SelectionStart = 0;
			this.IlotAbs.Size = new System.Drawing.Size(246, 23);
			this.IlotAbs.TabIndex = 6;
			this.IlotAbs.UseSystemPasswordChar = false;
			this.IlotAbs.Click += new System.EventHandler(this.IlotAbs_Click);
			this.IlotAbs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IlotAbs_KeyPress);
			// 
			// IlotRej
			// 
			this.IlotRej.Depth = 0;
			this.IlotRej.Hint = "Taux de non qualite en % : 5";
			this.IlotRej.Location = new System.Drawing.Point(29, 259);
			this.IlotRej.MouseState = MaterialSkin.MouseState.HOVER;
			this.IlotRej.Name = "IlotRej";
			this.IlotRej.PasswordChar = '\0';
			this.IlotRej.SelectedText = "";
			this.IlotRej.SelectionLength = 0;
			this.IlotRej.SelectionStart = 0;
			this.IlotRej.Size = new System.Drawing.Size(246, 23);
			this.IlotRej.TabIndex = 5;
			this.IlotRej.UseSystemPasswordChar = false;
			this.IlotRej.Click += new System.EventHandler(this.IlotRej_Click);
			this.IlotRej.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IlotRej_KeyPress);
			// 
			// IlotCRM
			// 
			this.IlotCRM.Depth = 0;
			this.IlotCRM.Hint = "Coefficient de majoration en % : 5";
			this.IlotCRM.Location = new System.Drawing.Point(29, 197);
			this.IlotCRM.MouseState = MaterialSkin.MouseState.HOVER;
			this.IlotCRM.Name = "IlotCRM";
			this.IlotCRM.PasswordChar = '\0';
			this.IlotCRM.SelectedText = "";
			this.IlotCRM.SelectionLength = 0;
			this.IlotCRM.SelectionStart = 0;
			this.IlotCRM.Size = new System.Drawing.Size(246, 23);
			this.IlotCRM.TabIndex = 4;
			this.IlotCRM.UseSystemPasswordChar = false;
			this.IlotCRM.Click += new System.EventHandler(this.IlotCRM_Click);
			this.IlotCRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IlotCRM_KeyPress);
			// 
			// IlotEff
			// 
			this.IlotEff.Depth = 0;
			this.IlotEff.Hint = "Efficience en % : 80";
			this.IlotEff.Location = new System.Drawing.Point(29, 139);
			this.IlotEff.MouseState = MaterialSkin.MouseState.HOVER;
			this.IlotEff.Name = "IlotEff";
			this.IlotEff.PasswordChar = '\0';
			this.IlotEff.SelectedText = "";
			this.IlotEff.SelectionLength = 0;
			this.IlotEff.SelectionStart = 0;
			this.IlotEff.Size = new System.Drawing.Size(246, 23);
			this.IlotEff.TabIndex = 3;
			this.IlotEff.UseSystemPasswordChar = false;
			this.IlotEff.Click += new System.EventHandler(this.IlotEff_Click);
			this.IlotEff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IlotEff_KeyPress);
			// 
			// IlotName
			// 
			this.IlotName.Depth = 0;
			this.IlotName.Hint = "Nom de l\'ilot";
			this.IlotName.Location = new System.Drawing.Point(29, 88);
			this.IlotName.MouseState = MaterialSkin.MouseState.HOVER;
			this.IlotName.Name = "IlotName";
			this.IlotName.PasswordChar = '\0';
			this.IlotName.SelectedText = "";
			this.IlotName.SelectionLength = 0;
			this.IlotName.SelectionStart = 0;
			this.IlotName.Size = new System.Drawing.Size(246, 23);
			this.IlotName.TabIndex = 2;
			this.IlotName.UseSystemPasswordChar = false;
			// 
			// IlotManag
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
			this.Name = "IlotManag";
			this.Text = "IlotManag";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.IlotManag_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button UpButton;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private MaterialSkin.Controls.MaterialSingleLineTextField IlotName;
		private MaterialSkin.Controls.MaterialSingleLineTextField IlotAbs;
		private MaterialSkin.Controls.MaterialSingleLineTextField IlotRej;
		private MaterialSkin.Controls.MaterialSingleLineTextField IlotCRM;
		private MaterialSkin.Controls.MaterialSingleLineTextField IlotEff;
		private MaterialSkin.Controls.MaterialSingleLineTextField IlotID;
	}
}