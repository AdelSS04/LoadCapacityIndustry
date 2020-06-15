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
	public partial class ManPoste : Form // MetroFramework.Forms.MetroForm
	{
		public ManPoste()
		{
			InitializeComponent();
		}

		private void SaveUpdate_Click(object sender, EventArgs e)
		{
			
			
			}
		public void sizeDGV(DataGridView dgv , GroupBox GRP)
		{
			DataGridViewElementStates states = DataGridViewElementStates.None;
			//dgv.ScrollBars = ScrollBars.None;

			var totalWidth = dgv.Columns.GetColumnsWidth(states);
			dgv.ClientSize = new Size(totalWidth, 180);
			GRP.ClientSize = new Size(totalWidth + 2, 180);
			for (int i = 0; i < dgv.RowCount; i++)
			{
				if (i % 2 == 0)
				{
					dgv.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;

				}
				else
					dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
			}

		}
		private void ManageMachine_Load(object sender, EventArgs e)
		{
			DataPick.Items.Add(DateTime.Now.Year);
			DataPick.Items.Add((DateTime.Now.Year + 1));
			DataPick.Items.Add((DateTime.Now.Year + 2));
			List<Ilot> il = IlotDBO.GetAllIlot();
			foreach (Ilot u in il)
			{

				metroComboBox1.Items.Add(u.IlotID);
				checkedListBox1.Items.Add(u.IlotID);
			}
			List < OpGroupe > opGroupes = OpGroupeDBO.GetPosteName();
			dataGridView1.DataSource = opGroupes;
			sizeDGV(dataGridView1,groupBox1);
		}
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{

				metroComboBox2.Items.Clear();
				List<OpGroupe> mach = OpGroupeDBO.GetOpGroupes(metroComboBox1.SelectedItem.ToString());
				foreach (OpGroupe u in mach)
				{
					metroComboBox2.Items.Add(u.GrpName);
				}
				UpButton.Enabled = false;
				DelButton.Enabled = false;
				UpGrid.Enabled = false;
				UpAll.Enabled = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				List<OperatorsO> machineOpenDays = new List<OperatorsO>();
				machineOpenDays = dataGridView2.DataSource as List<OperatorsO>;
				bool state= true;
				foreach(OperatorsO openDay in machineOpenDays)
				{
					if (!OpGroupeDBO.UpOperatingNumber(openDay))
						state = false;
				}
				if (state)
				{
					MessageBox.Show("done");
					List<OperatorsO> CapaMach = OpGroupeDBO.GetAllPosteOpenDay(metroComboBox2.SelectedItem.ToString(), DateTime.Now.Year,
					System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
					dataGridView2.DataSource = CapaMach;
					sizeDGV(dataGridView2, groupBox2);
				}
				else
					MessageBox.Show("error");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				OperatorsO openDayOp = new OperatorsO
				{
					OperationID = metroComboBox2.SelectedItem.ToString(),
					YearT = int.Parse(DataPick.SelectedItem.ToString()),
					WeekT = int.Parse(WeekT.Text),
					OpenDay=int.Parse(materialSingleLineTextField1.Text),
					NumberOfOperator = int.Parse(openday.Text),
				};

				if (OpGroupeDBO.UpOperatingNumber(openDayOp))
				{
					MessageBox.Show("done");
					List<OperatorsO> CapaMach = OpGroupeDBO.GetAllPosteOpenDay(metroComboBox2.SelectedItem.ToString(), DateTime.Now.Year,
					System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
					dataGridView2.DataSource = CapaMach;
					sizeDGV(dataGridView2, groupBox2);

				}
				else
				{
					DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
					DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
					Calendar cal = dfi.Calendar;
					for (int i = 1; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
					{
						openDayOp.WeekT = i;
						OperatorsODBO.SetOperatingNumber(openDayOp);
					}
					MessageBox.Show("Add done");
					List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(metroComboBox1.SelectedItem.ToString(),
					System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), DateTime.Now.Year);
					dataGridView2.DataSource = CapaMach;
					sizeDGV(dataGridView2, groupBox2);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			try
			{
				OpGroupe opGroupe = new OpGroupe
				{
					GrpName = metroComboBox2.SelectedItem.ToString() ,
					IlotID= checkedListBox1.SelectedItem.ToString(),
				};


				if (OpGroupeDBO.UpdatePoste(opGroupe))
			           	MessageBox.Show("Update !!");
				else
					MessageBox.Show("No Update !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DelButton_Click(object sender, EventArgs e)
		{
			try
			{
				if(OpGroupeDBO.DeletePoste(metroComboBox2.SelectedItem.ToString()))
				{ MessageBox.Show("done");
					checkedListBox1.Items.Clear();
					List<Ilot> il = IlotDBO.GetAllIlot();
					foreach (Ilot u in il)
					{

						metroComboBox1.Items.Add(u.IlotID);
						checkedListBox1.Items.Add(u.IlotID);
					}
					List<OpGroupe> opGroupes = OpGroupeDBO.GetPosteName();
					dataGridView1.DataSource = opGroupes;
					sizeDGV(dataGridView1, groupBox1);
					metroComboBox2.Items.Clear();
					List<OpGroupe> mach = OpGroupeDBO.GetOpGroupes(metroComboBox1.SelectedItem.ToString());
					foreach (OpGroupe u in mach)
					{
						metroComboBox2.Items.Add(u.GrpName);
					}
					UpButton.Enabled = false;
					DelButton.Enabled = false;
					UpGrid.Enabled = false;
					UpAll.Enabled = false;
				}
				else
				{ MessageBox.Show("non"); }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{


			try
			{
				List<OpGroupe> opGroupes = new List<OpGroupe>();
				opGroupes.Add(OpGroupeDBO.GetPoste(metroComboBox2.SelectedItem.ToString()));
				dataGridView1.DataSource = opGroupes;
				List<OpGroupeDBO> GetAllPosteOpenDay = new List<OpGroupeDBO>();
				
				dataGridView2.DataSource = OpGroupeDBO.GetAllPosteOpenDay(metroComboBox2.SelectedItem.ToString(), DateTime.Now.Year,
					System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));


				sizeDGV(dataGridView2, groupBox2);
				UpButton.Enabled = true;
				DelButton.Enabled = true;
				UpGrid.Enabled = true;
				UpAll.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count >= 1)
				e.NewValue = CheckState.Unchecked;
		}
	}
}
