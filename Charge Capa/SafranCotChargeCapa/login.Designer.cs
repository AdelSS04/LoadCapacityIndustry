namespace SafranCotChargeCapa
{
	partial class login
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.button18 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.userN = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.UpButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
			this.panel2.Controls.Add(this.button18);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(353, 152);
			this.panel2.TabIndex = 1;
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Transparent;
			this.button18.FlatAppearance.BorderSize = 0;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button18.ForeColor = System.Drawing.Color.Beige;
			this.button18.Image = global::SafranCotChargeCapa.Properties.Resources.info_32px;
			this.button18.Location = new System.Drawing.Point(286, 3);
			this.button18.Name = "button18";
			this.button18.Padding = new System.Windows.Forms.Padding(1, 0, 2, 0);
			this.button18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button18.Size = new System.Drawing.Size(32, 32);
			this.button18.TabIndex = 24;
			this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button18.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Image = global::SafranCotChargeCapa.Properties.Resources.close_window_32px;
			this.button1.Location = new System.Drawing.Point(318, 3);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(1, 0, 2, 0);
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(32, 32);
			this.button1.TabIndex = 23;
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(121, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "User Login";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Image = global::SafranCotChargeCapa.Properties.Resources.user_120px;
			this.pictureBox1.Location = new System.Drawing.Point(113, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// userN
			// 
			this.userN.Depth = 0;
			this.userN.Hint = "Username";
			this.userN.Location = new System.Drawing.Point(28, 244);
			this.userN.MouseState = MaterialSkin.MouseState.HOVER;
			this.userN.Name = "userN";
			this.userN.PasswordChar = '\0';
			this.userN.SelectedText = "";
			this.userN.SelectionLength = 0;
			this.userN.SelectionStart = 0;
			this.userN.Size = new System.Drawing.Size(289, 23);
			this.userN.TabIndex = 2;
			this.userN.Tag = "username";
			this.userN.UseSystemPasswordChar = false;
			// 
			// pass
			// 
			this.pass.Depth = 0;
			this.pass.Hint = "Password";
			this.pass.Location = new System.Drawing.Point(28, 319);
			this.pass.MouseState = MaterialSkin.MouseState.HOVER;
			this.pass.Name = "pass";
			this.pass.PasswordChar = '*';
			this.pass.SelectedText = "";
			this.pass.SelectionLength = 0;
			this.pass.SelectionStart = 0;
			this.pass.Size = new System.Drawing.Size(289, 23);
			this.pass.TabIndex = 3;
			this.pass.Tag = "Password";
			this.pass.UseSystemPasswordChar = true;
			// 
			// UpButton
			// 
			this.UpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
			this.UpButton.FlatAppearance.BorderSize = 0;
			this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpButton.ForeColor = System.Drawing.Color.Beige;
			this.UpButton.Image = global::SafranCotChargeCapa.Properties.Resources.login_20px;
			this.UpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UpButton.Location = new System.Drawing.Point(97, 375);
			this.UpButton.Name = "UpButton";
			this.UpButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.UpButton.Size = new System.Drawing.Size(145, 30);
			this.UpButton.TabIndex = 20;
			this.UpButton.Text = "Login";
			this.UpButton.UseVisualStyleBackColor = false;
			this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(169, 428);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Safran Composite Tunisie © 2020";
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.ClientSize = new System.Drawing.Size(353, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UpButton);
			this.Controls.Add(this.pass);
			this.Controls.Add(this.userN);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "login";
			this.Text = "login";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private MaterialSkin.Controls.MaterialSingleLineTextField userN;
		private MaterialSkin.Controls.MaterialSingleLineTextField pass;
		private System.Windows.Forms.Button UpButton;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
	}
}