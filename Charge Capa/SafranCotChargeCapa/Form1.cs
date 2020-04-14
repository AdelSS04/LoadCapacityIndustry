using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			hideSubMenu();

		}
		private void hideSubMenu()
		{
			metroPanel2.Visible = false;
			
		}
		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;

		}
		private Form activeForm = null;
		private void openChildFormInPanel(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			

			childForm.Parent = this;
			childForm.Show();
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			showSubMenu(metroPanel2);
			/*//openChildFormInPanel(new ManOperation());
			Off MyForm = new Off();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = panelChildForm;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = panelChildForm.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();*/
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			Off MyForm = new Off();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = panelChildForm;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = panelChildForm.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{

			ManagPoste MyForm = new ManagPoste();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = panelChildForm;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = panelChildForm.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();
		}
	}
}
