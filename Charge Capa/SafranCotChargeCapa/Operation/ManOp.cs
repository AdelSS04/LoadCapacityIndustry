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
	public partial class ManOp : Form // MetroFramework.Forms.MetroForm
	{
		public ManOp()
		{
			InitializeComponent();
		}

		private void SaveUpdate_Click(object sender, EventArgs e)
		{


		}
		public void sizeDGV(DataGridView dgv)
		{
			
			DataGridViewElementStates states = DataGridViewElementStates.None;
			dgv.ScrollBars = ScrollBars.None;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			var totalWidth = dgv.Columns.GetColumnsWidth(states);
			
			dgv.ClientSize = new Size(totalWidth, 120);
			
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
				
				List<Product> ur = ProductDBO.GetAllProduct();
				foreach (Product u in ur)
				{ checkedListBox1.Items.Add(u.ProductID); }
				List<Ilot> il = IlotDBO.GetAllIlot();
				foreach (Ilot u in il)
				{
					metroComboBox6.Items.Add(u.IlotID);
					metroComboBox2.Items.Add(u.IlotID);
				}
				List<Machine> mach = MachineDBO.GetAllMachine();
				foreach (Machine u in mach)
				{
					metroComboBox5.Items.Add(u.MachineID);
				}
				List<Tools> machh = ToolsDBO.GetAllTools();
				foreach (Tools u in machh)
				{
					metroComboBox4.Items.Add(u.ToolsID);
				};
			}
			catch (Exception)
			{

				throw;
			}
		}
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Operation OperationData = OperationDBO.GetOperationData(metroComboBox1.SelectedItem.ToString());
				OpGroupe opGroupe = OpGroupeDBO.GetPoste(OperationData.GroupID);
				List<ManuelCycleTime> OpAllData = ManuelCycleTimeDBO.GetAllOperationProduct(metroComboBox1.SelectedItem.ToString());

				for (int i = 0; i < checkedListBox1.Items.Count; i++)
				{
					checkedListBox1.SetItemChecked(i, false);

				}

				if (OpAllData.Count.ToString() != "0")
				{
					TcInput.Text = OpAllData[0].ManuelCycleTimeT.ToString();


					foreach (ManuelCycleTime op in OpAllData)
					{
						for (int i = 0; i < checkedListBox1.Items.Count; i++)
						{
							if (checkedListBox1.Items[i].ToString() == op.ProductID)
							{ checkedListBox1.SetItemChecked(i, true); }


						}
					}
				}
				List<MachineCycleTime> machineCycleTimesList = MachineCycleTimeDBO.GetMachineCycleTime(metroComboBox1.SelectedItem.ToString());
				List<ToolsOccupationTime> ToolsOccupationTimeList = ToolsOccupationTimeDBO.GettoolsOccupationTimes(metroComboBox1.SelectedItem.ToString());

				metroComboBox2.SelectedIndex = metroComboBox2.FindString(opGroupe.IlotID);
				metroComboBox3.Items.Clear();
				List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(metroComboBox2.SelectedItem.ToString());
				var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
				foreach (var o in DistinctItems)
					metroComboBox3.Items.Add(o.ToString());
				metroComboBox3.SelectedIndex = metroComboBox3.FindString(OperationData.GroupID);
				DelButton.Enabled = true;
				List<MachineCycleTime> machineCycleTimesListGrid = MachineCycleTimeDBO.GetMachineCycleTime(metroComboBox1.SelectedItem.ToString());
				List<ToolsOccupationTime> ToolsOccupationTimeListGrid = ToolsOccupationTimeDBO.GettoolsOccupationTimes(metroComboBox1.SelectedItem.ToString());
				MachineGrid.DataSource = machineCycleTimesListGrid;
				ToolGrid.DataSource = ToolsOccupationTimeListGrid;
				sizeDGV(MachineGrid);
				sizeDGV(ToolGrid);
				metroComboBox5.Enabled = true;
				metroComboBox4.Enabled = true;
				//	machineCycleList.DataSource = machineCycleTimesList;
				//	outilsgrid.DataSource = ToolsOccupationTimeList;
				////int index = IlotIDS.FindString(Lur[0].IlotID);//show it later
				//IlotIDS.SelectedIndex = index;
				//	MachineIDInput.Text = InputOperation.SelectedItem.ToString();

				/*	dataGridView1.Columns[0].ReadOnly = true;
					Machine machine = MachineDBO.GetMachine(metroComboBox1.SelectedItem.ToString());
					List<Machine> LMachine = new List<Machine>();
					LMachine.Add(machine);
					dataGridView1.DataSource = LMachine;
					List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(metroComboBox1.SelectedItem.ToString(),
						System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday),DateTime.Now.Year);
					dataGridView2.DataSource = CapaMach;
					dataGridView2.Columns[0].ReadOnly = true;
					dataGridView2.Columns[1].ReadOnly = true;
					dataGridView2.Columns[2].ReadOnly = true;
					sizeDGV(dataGridView2,groupBox2);
					UpButton.Enabled = true;
					DelButton.Enabled = true;
					UpGrid.Enabled = true;
					UpAll.Enabled = true;*/



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
				/*List<MachineOpenDay> machineOpenDays = new List<MachineOpenDay>();
				machineOpenDays = dataGridView2.DataSource as List<MachineOpenDay>;
				bool state= true;
				foreach(MachineOpenDay openDay in machineOpenDays)
				{
					if (!MachineDBO.UpdateMachineOpenDay(openDay))
						state = false;
				}
				if (state)
				{
					MessageBox.Show("done");
					List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(metroComboBox1.SelectedItem.ToString(),
					System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), DateTime.Now.Year);
					dataGridView2.DataSource = CapaMach;
					sizeDGV(dataGridView2, groupBox2);
				}
				else
					MessageBox.Show("error");
					*/
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				metroComboBox3.Items.Clear();
				List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(metroComboBox2.SelectedItem.ToString());
				var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
				foreach (var o in DistinctItems)
					metroComboBox3.Items.Add(o.ToString());

			}
			catch (Exception)
			{

				throw;
			}
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			try
			{
				ManuelCycleTime oppp = new ManuelCycleTime
				{
					OperationID = metroComboBox1.SelectedItem.ToString(),


				};
				OperationDBO.DeletAllOperation(oppp);
				List<ManuelCycleTime> op = new List<ManuelCycleTime>();
				for (int i = 0; i < checkedListBox1.Items.Count; i++)
				{

					if (checkedListBox1.GetItemChecked(i))
					{

						ManuelCycleTime opp = new ManuelCycleTime
						{
							OperationID = metroComboBox1.SelectedItem.ToString(),

							ManuelCycleTimeT = float.Parse(TcInput.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
							ProductID = checkedListBox1.Items[i].ToString(),

						}; op.Add(opp);
					}
				}
				foreach (ManuelCycleTime oo in op)
				{

					ManuelCycleTimeDBO.AddOperationData(oo);
					//OpGroupeDBO.UpdateOperationGrp(oo.OperationID, metroComboBox1.SelectedItem.ToString());

				}
				MessageBox.Show("done !!");
				

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
				Operation op = new Operation
				{

					OperationID = metroComboBox1.SelectedItem.ToString(),
				};

				OperationDBO.DeletOp(op);

				MessageBox.Show("done !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpButton.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form formBackground = new Form();
			try
			{
				using (IlotManag uu = new IlotManag())
				{
					formBackground.StartPosition = FormStartPosition.Manual;
					formBackground.FormBorderStyle = FormBorderStyle.None;
					formBackground.Opacity = .50d;
					formBackground.BackColor = Color.Black;
					formBackground.WindowState = FormWindowState.Maximized;
					formBackground.TopMost = true;
					formBackground.Location = this.Location;
					formBackground.ShowInTaskbar = false;
					formBackground.Show();

					uu.Owner = formBackground;
					uu.ShowDialog();

					formBackground.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{

				formBackground.Dispose();
				List<Ilot> il = IlotDBO.GetAllIlot();
				metroComboBox2.Items.Clear();
				foreach (Ilot u in il)
				{
					metroComboBox2.Items.Add(u.IlotID);
				}


			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Form formBackground = new Form();
			try
			{
				using (AddPoste uu = new AddPoste())
				{
					formBackground.StartPosition = FormStartPosition.Manual;
					formBackground.FormBorderStyle = FormBorderStyle.None;
					formBackground.Opacity = .50d;
					formBackground.BackColor = Color.Black;
					formBackground.WindowState = FormWindowState.Maximized;
					formBackground.TopMost = true;
					formBackground.Location = this.Location;
					formBackground.ShowInTaskbar = false;
					formBackground.Show();

					uu.Owner = formBackground;
					uu.ShowDialog();

					formBackground.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				formBackground.Dispose();

				metroComboBox3.Items.Clear();
				if (metroComboBox2.SelectedIndex > -1)
				{
					List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(metroComboBox2.SelectedItem.ToString());
					var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
					foreach (var o in DistinctItems)
						metroComboBox3.Items.Add(o.ToString());
				}
			}
		}

		private void metroTabPage1_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				MachineCycleTime op = new MachineCycleTime
				{

					OperationID = metroComboBox1.SelectedItem.ToString(),
					MachineID = metroComboBox5.SelectedItem.ToString(),

				};

				if (MachineCycleTimeDBO.DeletAllOperationcycleTime(op))
				{
					List<MachineCycleTime> machineCycleTimesListGrid = MachineCycleTimeDBO.GetMachineCycleTime(metroComboBox1.SelectedItem.ToString());
					MachineGrid.DataSource = machineCycleTimesListGrid;
					sizeDGV(MachineGrid);
					MessageBox.Show("done !!");
				}
				else
					MessageBox.Show("404");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				ToolsOccupationTime op = new ToolsOccupationTime
				{

					OperationID = metroComboBox1.SelectedItem.ToString(),
					ToolsID = metroComboBox4.SelectedItem.ToString(),

				};

				if (ToolsOccupationTimeDBO.DeletAllOperationOccTime(op))
				{
					MessageBox.Show("done !!");
					List<ToolsOccupationTime> ToolsOccupationTimeListGrid = ToolsOccupationTimeDBO.GettoolsOccupationTimes(metroComboBox1.SelectedItem.ToString());
					ToolGrid.DataSource = ToolsOccupationTimeListGrid;
					sizeDGV(ToolGrid);
				}
				else
					MessageBox.Show("404");


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			List<ToolsOccupationTime> dem = new List<ToolsOccupationTime>();

			try
			{
				dem = ToolGrid.DataSource as List<ToolsOccupationTime>;
				foreach (ToolsOccupationTime d in dem)
					if (ToolsOccupationTimeDBO.UpOccTime(d))
						MessageBox.Show("done !");
					else
						MessageBox.Show("404");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{

			List<MachineCycleTime> dem = new List<MachineCycleTime>();

			try
			{
				dem = MachineGrid.DataSource as List<MachineCycleTime>;
				foreach (MachineCycleTime d in dem)
					MachineCycleTimeDBO.UpMachineCycleTime(d);
				MessageBox.Show("done !");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				MachineCycleTime op = new MachineCycleTime
				{

					OperationID = metroComboBox1.SelectedItem.ToString(),
					MachineID = metroComboBox5.SelectedItem.ToString(),
					CycleTime = float.Parse(materialSingleLineTextField2.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
				};

				MachineCycleTimeDBO.AddMachineCycleTime(op);

				MessageBox.Show("done !!");
				List<MachineCycleTime> machineCycleTimesListGrid = MachineCycleTimeDBO.GetMachineCycleTime(metroComboBox1.SelectedItem.ToString());
				MachineGrid.DataSource = machineCycleTimesListGrid;
				sizeDGV(MachineGrid);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				ToolsOccupationTime op = new ToolsOccupationTime
				{

					OperationID = metroComboBox1.SelectedItem.ToString(),
					ToolsID = metroComboBox4.SelectedItem.ToString(),
					OccupationTime = float.Parse(materialSingleLineTextField1.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
				};

				ToolsOccupationTimeDBO.AddToolsOccTime(op);
				List<ToolsOccupationTime> ToolsOccupationTimeListGrid = ToolsOccupationTimeDBO.GettoolsOccupationTimes(metroComboBox1.SelectedItem.ToString());
				ToolGrid.DataSource = ToolsOccupationTimeListGrid;
					sizeDGV(ToolGrid);

				MessageBox.Show("done !!");


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			button3.Enabled = true;
			if (materialSingleLineTextField1.Text !="")
				button5.Enabled = true;
		}

		private void materialSingleLineTextField1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (metroComboBox4.SelectedIndex > -1)
				button5.Enabled = true;
		}

		private void materialSingleLineTextField2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (metroComboBox5.SelectedIndex > -1)
				button6.Enabled = true;
		}

		private void MachineGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			button8.Enabled = true;
			
		}

		private void ToolGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			button4.Enabled = true;
		}

		private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			button7.Enabled = true;
			if (materialSingleLineTextField1.Text != "")
				button6.Enabled = true;
		}

		private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
		{
			metroComboBox7.Items.Clear();
			List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(metroComboBox6.SelectedItem.ToString());
			var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
			foreach (var o in DistinctItems)
				metroComboBox7.Items.Add(o.ToString());
		}

		private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
		{
			metroComboBox1.Items.Clear();
			List<Operation> op = OperationDBO.GetOperationDataGrp(metroComboBox7.SelectedItem.ToString());
			var DistinctItems = op.Select(x => x.OperationID).Distinct();

			foreach (var opp in DistinctItems)
			{
				metroComboBox1.Items.Add(opp.ToString());
			}
		}
	}
}