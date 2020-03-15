namespace SafranCotChargeCapa
{
	partial class CalManage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalManage));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.AddButton = new Bunifu.Framework.UI.BunifuImageButton();
			this.SelCal = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.YearSel = new System.Windows.Forms.NumericUpDown();
			this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			((System.ComponentModel.ISupportInitialize)(this.AddButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SelCal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YearSel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.Transparent;
			this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
			this.AddButton.ImageActive = null;
			this.AddButton.Location = new System.Drawing.Point(668, 306);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(71, 71);
			this.AddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.AddButton.TabIndex = 10;
			this.AddButton.TabStop = false;
			this.AddButton.Zoom = 10;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// SelCal
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.SelCal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.SelCal.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.SelCal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SelCal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SelCal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.SelCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SelCal.DoubleBuffered = true;
			this.SelCal.EnableHeadersVisualStyles = false;
			this.SelCal.HeaderBgColor = System.Drawing.Color.SeaGreen;
			this.SelCal.HeaderForeColor = System.Drawing.Color.SeaGreen;
			this.SelCal.Location = new System.Drawing.Point(43, 103);
			this.SelCal.Name = "SelCal";
			this.SelCal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.SelCal.Size = new System.Drawing.Size(621, 150);
			this.SelCal.TabIndex = 11;
			// 
			// YearSel
			// 
			this.YearSel.Location = new System.Drawing.Point(102, 35);
			this.YearSel.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
			this.YearSel.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
			this.YearSel.Name = "YearSel";
			this.YearSel.Size = new System.Drawing.Size(48, 21);
			this.YearSel.TabIndex = 37;
			this.YearSel.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
			this.YearSel.ValueChanged += new System.EventHandler(this.YearSel_ValueChanged);
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(28, 32);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(68, 24);
			this.bunifuCustomLabel5.TabIndex = 38;
			this.bunifuCustomLabel5.Text = "Year :";
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(177, 31);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(34, 35);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 39;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// CalManage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 398);
			this.Controls.Add(this.bunifuImageButton1);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.YearSel);
			this.Controls.Add(this.SelCal);
			this.Controls.Add(this.AddButton);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "CalManage";
			this.Text = "AddUser";
			this.Load += new System.EventHandler(this.AddUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.AddButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SelCal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YearSel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Bunifu.Framework.UI.BunifuImageButton AddButton;
		private Bunifu.Framework.UI.BunifuCustomDataGrid SelCal;
		private System.Windows.Forms.NumericUpDown YearSel;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
	}
}

