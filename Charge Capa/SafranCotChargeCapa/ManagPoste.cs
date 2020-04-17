using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
	public partial class ManagPoste : Form //MetroFramework.Forms.MetroForm
	{
		public ManagPoste()
		{
			InitializeComponent();
		}

		private void SaveUpdate_Click(object sender, EventArgs e)
		{


		}
		private void ManageMachine_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource= IlotDBO.GetAllIlot();
			/*List<OpGroupe> mach = OpGroupeDBO.GetPosteName();
			foreach (OpGroupe u in mach)
			{
				metroComboBox2.Items.Add(u.GrpName);
			}*/
			List<Ilot> il = IlotDBO.GetAllIlot();
			foreach (Ilot u in il)
			{

				metroComboBox1.Items.Add(u.IlotID);
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
				OpGroupe ur = new OpGroupe
				{
					GrpName = IlotIDInput.Text,
					IlotID = metroComboBox1.SelectedItem.ToString(),

				};

				OpGroupeDBO.AddNewPosteCharge(ur);
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
		{
			try
			{
				string opname;
				if (IlotIDInput.Text.Length == 0)
					opname = metroComboBox2.SelectedItem.ToString();
				else
					opname = IlotIDInput.Text;
				OperatorsO op = new OperatorsO
				{
					OperationID = opname,
					YearT = int.Parse(YearSel.Value.ToString()),
					WeekT = int.Parse(WeekSel.Value.ToString()),
					NumberOfOperator = int.Parse(OpSel.Value.ToString()),

				};
				DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
				DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
				Calendar cal = dfi.Calendar;
				for (int i = 0; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
				{
					op.WeekT = i;
					OperatorsODBO.SetOperatingNumber(op);
				}
				MessageBox.Show("Add done !!");
			}
			catch (Exception ex)
			{
				try
				{
					string opname;
					if (IlotIDInput.Text.Length == 0)
						opname = metroComboBox2.SelectedItem.ToString();
					else
						opname = IlotIDInput.Text;
					OperatorsO op = new OperatorsO
					{
						OperationID = opname,
						YearT = int.Parse(YearSel.Value.ToString()),
						WeekT = int.Parse(WeekSel.Value.ToString()),
						NumberOfOperator = int.Parse(OpSel.Value.ToString()),

					};
					OperatorsODBO.UpOperatingNumber(op);
					MessageBox.Show("Up done !!");
				}
				catch (Exception exx)
				{
					MessageBox.Show(exx.Message);
				}
			}

		}

		private void metroTile1_Click_1(object sender, EventArgs e)
		{
			List<OperatorsO> dem = new List<OperatorsO>();

			try
			{
				dem = dataGridView1.DataSource as List<OperatorsO>;
				foreach (OperatorsO d in dem)
					OpGroupeDBO.UpOpenDay(d);
				MessageBox.Show("done !");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = null;
			IlotIDInput.Text = metroComboBox2.SelectedItem.ToString();

			MessageBox.Show(metroComboBox2.SelectedItem.ToString() + DateTime.Now.Year + System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));

			dataGridView1.DataSource = OpGroupeDBO.GetAllPosteOpenDay(metroComboBox2.SelectedItem.ToString(), DateTime.Now.Year, System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));

		}

		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			metroComboBox2.Items.Clear();
			List<OpGroupe> mach = OpGroupeDBO.GetOpGroupes(metroComboBox1.SelectedItem.ToString());
			foreach (OpGroupe u in mach)
			{
				metroComboBox2.Items.Add(u.GrpName);
			}
			dataGridView1.DataSource = null;
		}
	}
}
