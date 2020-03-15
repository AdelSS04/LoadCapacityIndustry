namespace SafranCotChargeCapa
{
	partial class Follow
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
			this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.IlotInput = new Bunifu.Framework.UI.BunifuDropdown();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.YearSelect = new System.Windows.Forms.DomainUpDown();
			this.SuspendLayout();
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(22, 9);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(68, 24);
			this.bunifuCustomLabel5.TabIndex = 38;
			this.bunifuCustomLabel5.Text = "Year :";
			// 
			// IlotInput
			// 
			this.IlotInput.BackColor = System.Drawing.Color.Transparent;
			this.IlotInput.BorderRadius = 3;
			this.IlotInput.ForeColor = System.Drawing.Color.White;
			this.IlotInput.Items = new string[0];
			this.IlotInput.Location = new System.Drawing.Point(336, 9);
			this.IlotInput.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.IlotInput.Name = "IlotInput";
			this.IlotInput.NomalColor = System.Drawing.SystemColors.WindowFrame;
			this.IlotInput.onHoverColor = System.Drawing.SystemColors.GrayText;
			this.IlotInput.selectedIndex = -1;
			this.IlotInput.Size = new System.Drawing.Size(166, 28);
			this.IlotInput.TabIndex = 37;
			this.IlotInput.onItemSelected += new System.EventHandler(this.IlotInput_onItemSelected);
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(278, 11);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(52, 24);
			this.bunifuCustomLabel1.TabIndex = 40;
			this.bunifuCustomLabel1.Text = "Ilot :";
			// 
			// YearSelect
			// 
			this.YearSelect.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.YearSelect.Items.Add("2020");
			this.YearSelect.Items.Add("2021");
			this.YearSelect.Items.Add("2022");
			this.YearSelect.Location = new System.Drawing.Point(96, 7);
			this.YearSelect.Name = "YearSelect";
			this.YearSelect.ReadOnly = true;
			this.YearSelect.Size = new System.Drawing.Size(160, 30);
			this.YearSelect.TabIndex = 41;
			this.YearSelect.Text = "Year Selection";
			this.YearSelect.SelectedItemChanged += new System.EventHandler(this.YearSelect_SelectedItemChanged);
			// 
			// Follow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 398);
			this.Controls.Add(this.YearSelect);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.IlotInput);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Follow";
			this.Text = "Follow";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
		private Bunifu.Framework.UI.BunifuDropdown IlotInput;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private System.Windows.Forms.DomainUpDown YearSelect;
	}
}

