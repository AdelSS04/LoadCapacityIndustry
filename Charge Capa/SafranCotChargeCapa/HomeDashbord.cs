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
	public partial class HomeDashbord : Form
	{
		public HomeDashbord()
		{
			InitializeComponent();
			hideSubMenu();
			hideSuSubbMenu();
		}

		private void HomeDashbord_Load(object sender, EventArgs e)
		{

		}
		private void hideSubMenu()
		{
			DashbordPanel.Visible = false;
			MangPanel.Visible = false;

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
		private void hideSuSubbMenu()
		{
			IlotPanel.Visible = false;
			

		}

		private void showSubSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSuSubbMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;

		}
		private void Dashbord_Click(object sender, EventArgs e)
		{
			showSubMenu(DashbordPanel);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			showSubMenu(MangPanel);
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
			FormPanel.Controls.Add(childForm);
			FormPanel.Tag = childForm;
			childForm.BringToFront();


			childForm.Parent = this;
			childForm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			 FormPanel.Controls.Clear();
			//openChildFormInPanel(new Off());
			Off MyForm = new Off();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show(); 
		}

		private void button4_Click(object sender, EventArgs e)
		{
			showSubSubMenu(IlotPanel);
			FormPanel.Controls.Clear();
			IlotUpdate MyForm = new IlotUpdate();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			 FormPanel.Controls.Clear();
			ManOperation MyForm = new ManOperation();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show(); 
		}

		private void button6_Click(object sender, EventArgs e)
		{
			 FormPanel.Controls.Clear();
			IlotManag MyForm = new IlotManag();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show(); 
		}

		private void button7_Click(object sender, EventArgs e)
		{
		 	FormPanel.Controls.Clear();
			ManageMachine MyForm = new ManageMachine();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show(); 
		}

		private void button8_Click(object sender, EventArgs e)
		{ 
			FormPanel.Controls.Clear();
			ManageTools MyForm = new ManageTools();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show(); 
		}

		private void button9_Click(object sender, EventArgs e)
		{/*
			 FormPanel.Controls.Clear();
			Test MyForm = new Test();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show(); */
		}

		private void FormPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			IlotUpdate MyForm = new IlotUpdate();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{

		}
	}
}