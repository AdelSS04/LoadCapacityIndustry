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
	public partial class ManOperation : MetroFramework.Forms.MetroForm
	{
		public ManOperation()
		{
			InitializeComponent();
		}
		int Listitem;
		private void ManOperation_Load(object sender, EventArgs e)
		{
			try
			{
				List<Tools> machh = ToolsDBO.GetAllTools();
				foreach (Tools u in machh)
				{
					metroComboBox2.Items.Add(u.ToolsID);
				};
				List<Product> ur = ProductDBO.GetAllProduct();
				foreach (Product u in ur)
				{ PRoductIDSelect.Items.Add(u.ProductID); }

				List<Ilot> il = IlotDBO.GetAllIlot();
				foreach (Ilot u in il)
				{// MessageBox.Show(u.IlotID);
					
					IlotIDS.Items.Add(u.IlotID);
				}
				List<Machine> mach = MachineDBO.GetAllMachine();
				foreach (Machine u in mach)
				{// MessageBox.Show(u.IlotID);
					MachineSelc.Items.Add(u.MachineID);
				}
				List<Operation> op = OperationDBO.GetAllOperationName();
				var DistinctItems = op.Select(x => x.OperationID).Distinct();

				foreach (var opp in DistinctItems)
				{// MessageBox.Show(u.IlotID);
					InputOperation.Items.Add(opp.ToString());
				}
				Listitem = PRoductIDSelect.Items.Count;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroUserControl1_Load(object sender, EventArgs e)
		{

		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			string opname;
			if (MachineIDInput.Text.Length == 0)
				opname = InputOperation.SelectedItem.ToString();
			else
				opname = MachineIDInput.Text;

			try
			{
				MachineCycleTime op = new MachineCycleTime
				{

					OperationID = opname,
					MachineID = MachineSelc.Text,

				};

				MachineCycleTimeDBO.DeletAllOperationcycleTime(op);
				
				MessageBox.Show("done !!");
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void searchOp(string opname)
		{
			try
			{
				List<Operation> Lur = OperationDBO.GetOperation(opname);
				for (int i = 0; i < PRoductIDSelect.Items.Count; i++)
				{
					PRoductIDSelect.SetItemChecked(i, false);

				}

				if (Lur.Count.ToString() != "0")
				{
					EffInput.Text = Lur[0].ManuelCycleTime.ToString();


					foreach (Operation op in Lur)
					{
						for (int i = 0; i < PRoductIDSelect.Items.Count; i++)
						{
							if (PRoductIDSelect.Items[i].ToString() == op.ProductID)
							{ PRoductIDSelect.SetItemChecked(i, true); }


						}
					}
					List<MachineCycleTime> machineCycleTimesList = MachineCycleTimeDBO.GetMachineCycleTime(opname);
					List<ToolsOccupationTime> ToolsOccupationTimeList = ToolsOccupationTimeDBO.GettoolsOccupationTimes(opname);
					machineCycleList.DataSource = machineCycleTimesList;
					outilsgrid.DataSource = ToolsOccupationTimeList;


					//



					AddButton.Enabled = false;
					SaveUpdate.Enabled = true;
					DelMach.Enabled = true;
					SaveMach.Enabled = true;
					DelAll.Enabled = true;

				}
				else
				{ MessageBox.Show("404 not found"); }

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void RoleInput_SelectedIndexChanged(object sender, EventArgs e)
		{
			searchOp(InputOperation.SelectedItem.ToString());
		}

		private void MachineIDInput_ButtonClick(object sender, EventArgs e)
		{
			searchOp(MachineIDInput.Text);
		}

		private void DelAll_Click(object sender, EventArgs e)
		{
			try
			{
				Operation op = new Operation
				{

					OperationID = MachineIDInput.Text,
				};

				OperationDBO.DeletAllOperation(op);
				MachineCycleTimeDBO.DeletAllOperationTime(op);
				MessageBox.Show("done !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			try
			{
				List<Operation> op = new List<Operation>();
				for (int i = 0; i < Listitem; i++)
				{
					
					if (PRoductIDSelect.GetItemChecked(i))
					{
						
						Operation opp = new Operation
						{
							OperationID = MachineIDInput.Text,
							IlotID = IlotIDS.SelectedItem.ToString(),
							ManuelCycleTime = float.Parse(EffInput.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
							ProductID = PRoductIDSelect.Items[i].ToString(),

						}; op.Add(opp);
					}
				}
				foreach (Operation oo in op)
				{
				
					OperationDBO.AddOperation(oo);
				}
				MessageBox.Show("done !!");
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddMach_Click(object sender, EventArgs e)

		{
			string opname;
			if (MachineIDInput.Text.Length == 0)
				opname = InputOperation.SelectedItem.ToString();
			else
				opname = MachineIDInput.Text;


			try
			{
				MachineCycleTime op = new MachineCycleTime
				{

					OperationID = opname,
					MachineID = MachineSelc.SelectedItem.ToString(),
					CycleTime = float.Parse(MachineCycleTime.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
				};
				
				MachineCycleTimeDBO.AddMachineCycleTime(op);
				
				MessageBox.Show("done !!");
				

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SaveMach_Click(object sender, EventArgs e)
		{
			List<MachineCycleTime> dem = new List<MachineCycleTime>();

			try
			{
				dem = machineCycleList.DataSource as List<MachineCycleTime>;
				foreach (MachineCycleTime d in dem)
					MachineCycleTimeDBO.UpMachineCycleTime(d);
				MessageBox.Show("done !");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void SaveUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string opname;
				if (MachineIDInput.Text.Length == 0)
					opname = InputOperation.SelectedItem.ToString();
				else
					opname = MachineIDInput.Text;
				OperatorsO op = new OperatorsO
				{
					OperationID = opname,
					Yearr = int.Parse(YearSel.Value.ToString()),
					Weekk = int.Parse(WeekSel.Value.ToString()),
					NumberOfOperator = int.Parse(OpSel.Value.ToString()),

				};
				DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
				DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
				Calendar cal = dfi.Calendar;
				for (int i = 0; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
				{
					op.Weekk = i;
					OperatorsODBO.SetOperatingNumber(op);
				}
				MessageBox.Show("Add done !!");
			}
			catch (Exception ex)
			{
				try {
					string opname;
					if (MachineIDInput.Text.Length == 0)
						opname = InputOperation.SelectedItem.ToString();
					else
						opname = MachineIDInput.Text;
					OperatorsO op = new OperatorsO
					{
						OperationID = opname,
						Yearr = int.Parse(YearSel.Value.ToString()),
						Weekk = int.Parse(WeekSel.Value.ToString()),
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

		private void metroTile4_Click(object sender, EventArgs e)
		{
			string opname;
			if (MachineIDInput.Text.Length == 0)
				opname = InputOperation.SelectedItem.ToString();
			else
				opname = MachineIDInput.Text;

			try
			{
				ToolsOccupationTime op = new ToolsOccupationTime
				{

					OperationID = opname,
					ToolsID = MachineSelc.Text,

				};

				ToolsOccupationTimeDBO.DeletAllOperationOccTime(op);

				MessageBox.Show("done !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroTile5_Click(object sender, EventArgs e)
		{
			List<ToolsOccupationTime> dem = new List<ToolsOccupationTime>();

			try
			{
				dem = outilsgrid.DataSource as List<ToolsOccupationTime>;
				foreach (ToolsOccupationTime d in dem)
					ToolsOccupationTimeDBO.UpOccTime(d);
				MessageBox.Show("done !");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroTile6_Click(object sender, EventArgs e)
		{
			string opname;
			if (MachineIDInput.Text.Length == 0)
				opname = InputOperation.SelectedItem.ToString();
			else
				opname = MachineIDInput.Text;


			try
			{
				ToolsOccupationTime op = new ToolsOccupationTime
				{

					OperationID = opname,
					ToolsID = metroComboBox2.SelectedItem.ToString(),
					OccupationTime = float.Parse(metroTextBox2.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
				};

				ToolsOccupationTimeDBO.AddToolsOccTime(op);

				MessageBox.Show("done !!");


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroLabel12_Click(object sender, EventArgs e)
		{
			IlotManag ilot = new IlotManag();
			ilot.Show();

		}

		private void metroLabel13_Click(object sender, EventArgs e)
		{
			IlotManag ilot = new IlotManag();
			ilot.Show();
		}

		private void IlotIDS_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(IlotIDS.SelectedItem.ToString());
			foreach (OpGroupe o in IlotGrpOFOP)
				metroComboBox1.Items.Add(o.GrpName);
		}
	}
}
