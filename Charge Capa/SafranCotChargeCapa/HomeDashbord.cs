using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DAL;

namespace SafranCotChargeCapa
{



	public partial class HomeDashbord : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
						 int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();



		public HomeDashbord()
		{
			InitializeComponent();
			hideSubMenu();
			hideSuSubbMenu();
			IlotPanel.Height = 80;
			MachinePanel.Height = 80;
			ToolsPanel.Height = 80;
			PostePanel.Height = 80;
			OperationPanel.Height = 80;
			sizeDGV(MangPanel);

		}

		private void HomeDashbord_Load(object sender, EventArgs e)
		{
			label2.Text = Util.user.UserName;
			if (Util.user.Type == "Manager")
			{ btn.Enabled = true; Utilisateur.Enabled = true;
					}
			if (Util.user.Type == "ResAtelier")
			{
				button5.Enabled = false;
			}

		}
		private void hideSubMenu()
		{
			
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
			{ subMenu.Visible = false;  }


			}
		private void hideSuSubbMenu()
		{
			IlotPanel.Visible = false;
			MachinePanel.Visible = false;
			ToolsPanel.Visible = false;
			PostePanel.Visible = false;
			OperationPanel.Visible = false;


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
			FormPanel.Controls.Clear();
			//openChildFormInPanel(new Off());
			dashboard.live MyForm = new dashboard.live();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			FormPanel.ClientSize = MyForm.Size;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
			dashboard.live MyForm = new dashboard.live();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			  FormPanel.ClientSize= MyForm.Size;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;


		}

		private void button4_Click(object sender, EventArgs e)
		{
			showSubSubMenu(IlotPanel);
			sizeDGV(MangPanel);
			/*	FormPanel.Controls.Clear();
				IlotUpdate MyForm = new IlotUpdate();
				MyForm.TopLevel = false;
				MyForm.FormBorderStyle = FormBorderStyle.None;
				MyForm.Parent = FormPanel;
				MyForm.Top = 0;
				MyForm.Left = 0;
				MyForm.Size = FormPanel.ClientSize;
				MyForm.Dock = DockStyle.Fill;
				MyForm.BringToFront();
				MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;*/
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
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;this.Width = FormPanel.Width + MangPanel.Width;
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
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width; 
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
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width; 
		}

		private void button8_Click(object sender, EventArgs e)
		{ 
			/*FormPanel.Controls.Clear();
			ManageTools MyForm = new ManageTools();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width; */
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
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width; */
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
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			showSubSubMenu(MachinePanel);
			sizeDGV(MangPanel);
		}

		private void button8_Click_1(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			AddMachine MyForm = new AddMachine();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;
		}

		private void button7_Click_1(object sender, EventArgs e)
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
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			AddTools MyForm = new AddTools();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			ManagTools MyForm = new ManagTools();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;
		}

		private void button9_Click_1(object sender, EventArgs e)
		{
			showSubSubMenu(ToolsPanel);
			sizeDGV(MangPanel);
		}

		private void posteCharge_Click(object sender, EventArgs e)
		{
			showSubSubMenu(PostePanel);
			sizeDGV(MangPanel);
		}

		private void button14_Click(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			AddPoste MyForm = new AddPoste();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;

		}
		public void sizeDGV(Panel dgv)
		{
			
			//dgv.ScrollBars = ScrollBars.None;

			var totalWidth = button4.Height + button9.Height + button10.Height + posteCharge.Height+ OpButton.Height;

			if (IlotPanel.Visible || MachinePanel.Visible || ToolsPanel.Visible || PostePanel.Visible || OperationPanel.Visible)

				totalWidth += IlotPanel.Height;
			dgv.ClientSize = new Size(dgv.Width, totalWidth);

		}
		private void button13_Click(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			ManPoste MyForm = new ManPoste();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;

		}

		private void button15_Click(object sender, EventArgs e)
		{
			showSubSubMenu(OperationPanel);
			sizeDGV(MangPanel);

		}

		private void button16_Click(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			ManOp MyForm = new ManOp();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront();
			MyForm.Show();this.Width = FormPanel.Width + MangPanel.Width;
		}

		private void UpButton_Enter(object sender, EventArgs e)
		{
			UpButton.BackColor = Color.OrangeRed;
		}

		private void UpButton_MouseEnter(object sender, EventArgs e)
		{
			UpButton.BackColor = Color.FromArgb(172, 13, 4);
		}

		private void UpButton_MouseLeave(object sender, EventArgs e)
		{
			UpButton.BackColor = Color.Transparent;
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button15_MouseEnter(object sender, EventArgs e)
		{
			button15.BackColor = Color.FromArgb(252, 252, 252);
		}

		private void UpButton_MouseClick(object sender, MouseEventArgs e)
		{
			UpButton.BackColor = Color.FromArgb(136, 20, 33);
		}

		private void button15_MouseLeave(object sender, EventArgs e)
		{
			button15.BackColor = Color.Transparent;
		}

		private void HomeDashbord_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void Header_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void HomeDashbord_MouseMove(object sender, MouseEventArgs e)
		{
			
		}

		private void FormPanel_MouseMove(object sender, MouseEventArgs e)
		{
			
		}

		private void button15_Click_1(object sender, EventArgs e)
		{
			if (this.WindowState != FormWindowState.Maximized)
				this.WindowState = FormWindowState.Maximized;
			else
				this.WindowState = FormWindowState.Normal;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			AddOp MyForm = new AddOp();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront(); MyForm.Show();
		}

		private void button18_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void FormPanel_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			Test MyForm = new Test();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront(); MyForm.Show();
		}

		private void Utilisateur_Click(object sender, EventArgs e)
		{
			FormPanel.Controls.Clear();
			ManagUser MyForm = new ManagUser();
			MyForm.TopLevel = false;
			MyForm.FormBorderStyle = FormBorderStyle.None;
			MyForm.Parent = FormPanel;
			MyForm.Top = 0;
			MyForm.Left = 0;
			MyForm.Size = FormPanel.ClientSize;
			MyForm.Dock = DockStyle.Fill;
			MyForm.BringToFront(); MyForm.Show();
		}
	}
}