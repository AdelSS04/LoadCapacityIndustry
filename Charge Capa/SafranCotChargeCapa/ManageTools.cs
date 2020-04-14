using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
	public partial class ManageTools : Form//MetroFramework.Forms.MetroForm
	{
		public ManageTools()
		{
			InitializeComponent();
		}

		private void SaveUpdate_Click(object sender, EventArgs e)
		{
			
			
			}
		private void ManageMachine_Load(object sender, EventArgs e)
		{
			List<Tools> mach = ToolsDBO.GetAllTools();
			foreach (Tools u in mach)
			{
				metroComboBox2.Items.Add(u.ToolsID);
			}
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
			try
			{
				Tools ur = new Tools
				{
					ToolsName = IlotNameInput.Text,
					

					ToolsID = IlotIDInput.Text,
					
				};

				ToolsDBO.AddTools(ur);
				MessageBox.Show("done !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void IlotIDInput_ButtonClick(object sender, EventArgs e)
		{
		}

		private void Upilot_Click(object sender, EventArgs e)
		{try
			{

				string opname;
				if (IlotIDInput.Text.Length == 0)
					opname = metroComboBox2.SelectedItem.ToString();
				else
					opname = IlotIDInput.Text;
				ToolsOpenDay op = new ToolsOpenDay
				{
					ToolsID = opname,
					YearT = int.Parse(YearSel.Value.ToString()),
					WeekT = int.Parse(WeekSel.Value.ToString()),
					OpenDay = int.Parse(OpSel.Value.ToString()),

				};
				DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
				DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
				Calendar cal = dfi.Calendar;
				for (int i = 0; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
				{
					op.WeekT = i;
					ToolsDBO.SetOpenDay(op);
				}
				MessageBox.Show("Add done !!");
			}
			catch (Exception exx)
			{try
			{
				string opname;
				if (IlotIDInput.Text.Length == 0)
					opname = metroComboBox2.SelectedItem.ToString();
				else
					opname = IlotIDInput.Text;
				ToolsOpenDay op = new ToolsOpenDay
				{
					ToolsID = opname,
					YearT = int.Parse(YearSel.Value.ToString()),
					WeekT = int.Parse(WeekSel.Value.ToString()),
					OpenDay = int.Parse(OpSel.Value.ToString()),

				};
				ToolsDBO.UpOperatingNumber(op);
				MessageBox.Show("Updone !!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			}
		}

		private void metroTile1_Click_1(object sender, EventArgs e)
		{
			List<ToolsOpenDay> dem = new List<ToolsOpenDay>();

			try
			{
				dem = outilsgrid.DataSource as List<ToolsOpenDay>;
				foreach (ToolsOpenDay d in dem)
					ToolsDBO.UpOpenDay(d);
				MessageBox.Show("done !");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			IlotNameInput.Text = ToolsDBO.GetTools(metroComboBox2.SelectedItem.ToString()).ToolsName;
			SaveUpdate.Enabled = true;
			outilsgrid.DataSource = ToolsDBO.GetAllToolsOpenDay(metroComboBox2.SelectedItem.ToString(), DateTime.Now.Year, System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
			metroTile1.Enabled = true;
		}
	}
}
