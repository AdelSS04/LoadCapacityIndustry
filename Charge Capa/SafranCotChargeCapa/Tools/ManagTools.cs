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
	public partial class ManagTools : Form // MetroFramework.Forms.MetroForm
	{
		public ManagTools()
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
			try
			{
				List<Tools> mach = ToolsDBO.GetAllTools();
				foreach (Tools u in mach)
				{ metroComboBox1.Items.Add(u.ToolsID); }
				dataGridView1.DataSource = mach;
				sizeDGV(dataGridView1, groupBox1);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}




		}
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
			
				dataGridView1.Columns[0].ReadOnly = true;
				Tools machine = ToolsDBO.GetTools(metroComboBox1.SelectedItem.ToString());
				List<Tools> LMachine = new List<Tools>();
				LMachine.Add(machine);
				dataGridView1.DataSource = LMachine;
				List<ToolsOpenDay> CapaMach1 = ToolsDBO.GetAllToolsOpenDay(metroComboBox1.SelectedItem.ToString(), DateTime.Now.Year,
				System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
				dataGridView2.DataSource = CapaMach1;
				sizeDGV(dataGridView2, groupBox2);
				dataGridView2.Columns[0].ReadOnly = true;
				dataGridView2.Columns[1].ReadOnly = true;
				dataGridView2.Columns[2].ReadOnly = true;
				sizeDGV(dataGridView2,groupBox2);
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

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				List<ToolsOpenDay> machineOpenDays = new List<ToolsOpenDay>();
				machineOpenDays = dataGridView2.DataSource as List<ToolsOpenDay>;
				bool state= true;
				foreach(ToolsOpenDay openDay in machineOpenDays)
				{
					if (!ToolsDBO.UpOperatingNumber(openDay))
						state = false;
				}
				if (state)
				{
					MessageBox.Show("done");
					List<ToolsOpenDay> CapaMach = ToolsDBO.GetAllToolsOpenDay(metroComboBox1.SelectedItem.ToString(), DateTime.Now.Year,
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
				ToolsOpenDay openDay = new ToolsOpenDay
				{
					ToolsID = metroComboBox1.SelectedItem.ToString(),
					YearT = DateTime.Now.Year,
					WeekT = int.Parse(WeekT.Text),
					
					OpenDay=int.Parse(openday.Text),
				};
				bool state = true;

				if (ToolsDBO.UpAllOperatingNumber(openDay))
				{
					MessageBox.Show("done");
					List<ToolsOpenDay> CapaMach = ToolsDBO.GetAllToolsOpenDay(metroComboBox1.SelectedItem.ToString(), DateTime.Now.Year,
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

		private void UpButton_Click(object sender, EventArgs e)
		{
			try
			{
				List<Tools> machines = new List<Tools>();
				machines = dataGridView1.DataSource as List<Tools>;
				
				if (ToolsDBO.UpdateTools(machines[0]))
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
				if(ToolsDBO.DeletTools(metroComboBox1.SelectedItem.ToString()))
				{ MessageBox.Show("done");
					List<Tools> machines = ToolsDBO.GetAllTools();
					dataGridView1.DataSource = machines;
					metroComboBox1.Items.Clear();
					foreach (Tools u in machines)
					{ metroComboBox1.Items.Add(u.ToolsID); }
					dataGridView2.DataSource = null;


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
	}
}
