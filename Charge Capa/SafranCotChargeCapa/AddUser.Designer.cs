namespace SafranCotChargeCapa
{
	partial class AddUser
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.LoginInput = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.RoleInput = new MetroFramework.Controls.MetroComboBox();
			this.PasswordInput = new MetroFramework.Controls.MetroTextBox();
			this.UserNameInput = new MetroFramework.Controls.MetroTextBox();
			this.AddButton = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// LoginInput
			// 
			// 
			// 
			// 
			this.LoginInput.CustomButton.Image = null;
			this.LoginInput.CustomButton.Location = new System.Drawing.Point(321, 1);
			this.LoginInput.CustomButton.Name = "";
			this.LoginInput.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.LoginInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.LoginInput.CustomButton.TabIndex = 1;
			this.LoginInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.LoginInput.CustomButton.UseSelectable = true;
			this.LoginInput.Icon = global::SafranCotChargeCapa.Properties.Resources.search_24px;
			this.LoginInput.IconRight = true;
			this.LoginInput.Lines = new string[0];
			this.LoginInput.Location = new System.Drawing.Point(189, 85);
			this.LoginInput.MaxLength = 32767;
			this.LoginInput.Name = "LoginInput";
			this.LoginInput.PasswordChar = '\0';
			this.LoginInput.PromptText = "Login";
			this.LoginInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.LoginInput.SelectedText = "";
			this.LoginInput.SelectionLength = 0;
			this.LoginInput.SelectionStart = 0;
			this.LoginInput.ShortcutsEnabled = false;
			this.LoginInput.Size = new System.Drawing.Size(273, 23);
			this.LoginInput.TabIndex = 23;
			this.LoginInput.Theme = MetroFramework.MetroThemeStyle.Light;
			this.LoginInput.UseSelectable = true;
			this.LoginInput.WaterMark = "Login";
			this.LoginInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.LoginInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel4.Location = new System.Drawing.Point(36, 252);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(45, 25);
			this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
			this.metroLabel4.TabIndex = 30;
			this.metroLabel4.Text = "Role";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.Location = new System.Drawing.Point(36, 202);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(113, 25);
			this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
			this.metroLabel3.TabIndex = 29;
			this.metroLabel3.Text = "Mot de passe";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.Location = new System.Drawing.Point(36, 142);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(170, 25);
			this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
			this.metroLabel2.TabIndex = 28;
			this.metroLabel2.Text = "Nom de responsable";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(36, 85);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(54, 25);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
			this.metroLabel1.TabIndex = 27;
			this.metroLabel1.Text = "Login";
			// 
			// RoleInput
			// 
			this.RoleInput.FormattingEnabled = true;
			this.RoleInput.ItemHeight = 23;
			this.RoleInput.Items.AddRange(new object[] {
            "admin",
            "user"});
			this.RoleInput.Location = new System.Drawing.Point(159, 248);
			this.RoleInput.Name = "RoleInput";
			this.RoleInput.Size = new System.Drawing.Size(217, 29);
			this.RoleInput.TabIndex = 26;
			this.RoleInput.UseSelectable = true;
			// 
			// PasswordInput
			// 
			// 
			// 
			// 
			this.PasswordInput.CustomButton.Image = null;
			this.PasswordInput.CustomButton.Location = new System.Drawing.Point(263, 1);
			this.PasswordInput.CustomButton.Name = "";
			this.PasswordInput.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.PasswordInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.PasswordInput.CustomButton.TabIndex = 1;
			this.PasswordInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.PasswordInput.CustomButton.UseSelectable = true;
			this.PasswordInput.CustomButton.Visible = false;
			this.PasswordInput.Icon = global::SafranCotChargeCapa.Properties.Resources.save_50px;
			this.PasswordInput.IconRight = true;
			this.PasswordInput.Lines = new string[] {
        "Login :"};
			this.PasswordInput.Location = new System.Drawing.Point(189, 204);
			this.PasswordInput.MaxLength = 32767;
			this.PasswordInput.Name = "PasswordInput";
			this.PasswordInput.PasswordChar = '●';
			this.PasswordInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.PasswordInput.SelectedText = "";
			this.PasswordInput.SelectionLength = 0;
			this.PasswordInput.SelectionStart = 0;
			this.PasswordInput.ShortcutsEnabled = true;
			this.PasswordInput.ShowClearButton = true;
			this.PasswordInput.Size = new System.Drawing.Size(285, 23);
			this.PasswordInput.TabIndex = 25;
			this.PasswordInput.Text = "Login :";
			this.PasswordInput.UseCustomBackColor = true;
			this.PasswordInput.UseCustomForeColor = true;
			this.PasswordInput.UseSelectable = true;
			this.PasswordInput.UseStyleColors = true;
			this.PasswordInput.UseSystemPasswordChar = true;
			this.PasswordInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.PasswordInput.WaterMarkFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// UserNameInput
			// 
			// 
			// 
			// 
			this.UserNameInput.CustomButton.Image = null;
			this.UserNameInput.CustomButton.Location = new System.Drawing.Point(263, 1);
			this.UserNameInput.CustomButton.Name = "";
			this.UserNameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.UserNameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.UserNameInput.CustomButton.TabIndex = 1;
			this.UserNameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.UserNameInput.CustomButton.UseSelectable = true;
			this.UserNameInput.CustomButton.Visible = false;
			this.UserNameInput.Icon = global::SafranCotChargeCapa.Properties.Resources.save_50px;
			this.UserNameInput.IconRight = true;
			this.UserNameInput.Lines = new string[0];
			this.UserNameInput.Location = new System.Drawing.Point(223, 144);
			this.UserNameInput.MaxLength = 32767;
			this.UserNameInput.Name = "UserNameInput";
			this.UserNameInput.PasswordChar = '\0';
			this.UserNameInput.PromptText = "UserName";
			this.UserNameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.UserNameInput.SelectedText = "";
			this.UserNameInput.SelectionLength = 0;
			this.UserNameInput.SelectionStart = 0;
			this.UserNameInput.ShortcutsEnabled = true;
			this.UserNameInput.ShowClearButton = true;
			this.UserNameInput.Size = new System.Drawing.Size(285, 23);
			this.UserNameInput.TabIndex = 24;
			this.UserNameInput.UseCustomBackColor = true;
			this.UserNameInput.UseCustomForeColor = true;
			this.UserNameInput.UseSelectable = true;
			this.UserNameInput.UseStyleColors = true;
			this.UserNameInput.WaterMark = "UserName";
			this.UserNameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.UserNameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// AddButton
			// 
			this.AddButton.ActiveControl = null;
			this.AddButton.Location = new System.Drawing.Point(223, 314);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(112, 38);
			this.AddButton.TabIndex = 22;
			this.AddButton.Text = "Sauvegarde";
			this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddButton.TileImage = global::SafranCotChargeCapa.Properties.Resources.save_26px2;
			this.AddButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.AddButton.UseSelectable = true;
			this.AddButton.UseTileImage = true;
			this.AddButton.Click += new System.EventHandler(this.SaveUpdate_Click);
			// 
			// AddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 417);
			this.Controls.Add(this.LoginInput);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.RoleInput);
			this.Controls.Add(this.PasswordInput);
			this.Controls.Add(this.UserNameInput);
			this.Controls.Add(this.AddButton);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "AddUser";
			this.Text = "Ajouter un utilisateur";
			this.Load += new System.EventHandler(this.AddUser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroTextBox LoginInput;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox RoleInput;
		private MetroFramework.Controls.MetroTextBox PasswordInput;
		private MetroFramework.Controls.MetroTextBox UserNameInput;
		private MetroFramework.Controls.MetroTile AddButton;
	}
}

