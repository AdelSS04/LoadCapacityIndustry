using BEL;
using DAL;
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
	public partial class ManageMachine : MetroFramework.Forms.MetroForm
	{
		public ManageMachine()
		{
			InitializeComponent();
		}

		private void SaveUpdate_Click(object sender, EventArgs e)
		{
			
			
			}
		private void ManageMachine_Load(object sender, EventArgs e)
		{

		}

		

		private void SearchButton_Click(object sender, EventArgs e)
		{
		
		}

		private void MachineIDInput_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{

		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			string st;
			if (bunifuSwitch1.Checked == true)
				st = "Working";
			else
				st = "doesnt work";

			


			try
			{
				Machine ur = new Machine
				{
					MachineName = IlotNameInput.Text,
					MachineRejectedRate = float.Parse(MachineRejection.Text),

					MachineID = IlotIDInput.Text,
					Etat = st,
				};

				MachineDBO.AddMachine(ur);
				MessageBox.Show("done !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void IlotIDInput_ButtonClick(object sender, EventArgs e)
		{
			try
			{
				Machine ur = MachineDBO.GetMachine(IlotIDInput.Text);
				IlotNameInput.Text = ur.MachineName;
				MachineRejection.Text = ur.MachineRejectedRate.ToString();
				if (ur.Etat == "Working")
					bunifuSwitch1.Checked = true;
				else
					bunifuSwitch1.Checked = false;
				AddButton.Enabled = false;
				SaveUpdate.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Upilot_Click(object sender, EventArgs e)
		{
			string st;
			if (bunifuSwitch1.Checked == true)
				st = "Working";
			else
				st = "doesnt work";




			try
			{
				Machine ur = new Machine
				{
					MachineName = IlotNameInput.Text,
					MachineRejectedRate = float.Parse(MachineRejection.Text),
					MachineID = IlotIDInput.Text,
					Etat = st,

				};
				MachineDBO.UpdateMchine(ur);
				MessageBox.Show("done !!");
				SaveUpdate.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
