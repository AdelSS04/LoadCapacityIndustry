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
	public partial class ManOperation : Form
	{
		public ManOperation()
		{
			InitializeComponent();
		}
		int Listitem;
		private void ManOperation_Load(object sender, EventArgs e)
		{
		//	try
			//{
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
				{
					
					IlotIDS.Items.Add(u.IlotID);
				}
				List<Machine> mach = MachineDBO.GetAllMachine();
				foreach (Machine u in mach)
				{
					MachineSelc.Items.Add(u.MachineID);
				}
				List<Operation> op = OperationDBO.GetAllOperationName();
				var DistinctItems = op.Select(x => x.OperationID).Distinct();

				foreach (var opp in DistinctItems)
				{
					InputOperation.Items.Add(opp.ToString());
				}
				Listitem = PRoductIDSelect.Items.Count;
				
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
			//}
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
		//	try
		//	{
				Operation OperationData = OperationDBO.GetOperationData(opname);
			List < ManuelCycleTime > OpAllData= ManuelCycleTimeDBO.GetAllOperationProduct(opname);

				for (int i = 0; i < PRoductIDSelect.Items.Count; i++)
				{
					PRoductIDSelect.SetItemChecked(i, false);

				}

				if (OpAllData.Count.ToString() != "0")
				{
					EffInput.Text = OpAllData[0].ManuelCycleTimeT.ToString();
					

					foreach (ManuelCycleTime op in OpAllData)
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
					////int index = IlotIDS.FindString(Lur[0].IlotID);//show it later
					//IlotIDS.SelectedIndex = index;
					MachineIDInput.Text = InputOperation.SelectedItem.ToString();
					//



					AddButton.Enabled = false;
					
					DelMach.Enabled = true;
					SaveMach.Enabled = true;
					DelAll.Enabled = true;

				}
				else
				{ MessageBox.Show("404 not found"); }

		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
		//	}
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

				OperationDBO.DeletOp(op);
				
				MessageBox.Show("done !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string opname;
			if (MachineIDInput.Text.Length == 0)
				opname = InputOperation.SelectedItem.ToString();
			else
				opname = MachineIDInput.Text;
			try
			{
				Operation operation = new Operation
				{
					OperationID = opname,
					GroupID = metroComboBox1.SelectedItem.ToString(),
				};
				List<ManuelCycleTime> op = new List<ManuelCycleTime>();
				for (int i = 0; i < Listitem; i++)
				{
					
					if (PRoductIDSelect.GetItemChecked(i))
					{

						ManuelCycleTime opp = new ManuelCycleTime
						{
							OperationID = opname,
							
							ManuelCycleTimeT = float.Parse(EffInput.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
							ProductID = PRoductIDSelect.Items[i].ToString(),

						}; op.Add(opp);
					}
				}
				bool azer=false;
				
				

				azer = OperationDBO.AddOperation(operation);//ManuelCycleTimeDBO.AddOperationData(oo) ;


				foreach (ManuelCycleTime cy in op)
				{ 
				ManuelCycleTimeDBO.AddOperationData(cy); }
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
					ToolsID = metroComboBox2.SelectedItem.ToString(),

				};

				if(ToolsOccupationTimeDBO.DeletAllOperationOccTime(op))
					MessageBox.Show("done !!");
				else
					MessageBox.Show("404");


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
					if(ToolsOccupationTimeDBO.UpOccTime(d))
				MessageBox.Show("done !");
				else
						MessageBox.Show("404");
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
				IlotIDS.Items.Clear();
				foreach (Ilot u in il)
				{IlotIDS.Items.Add(u.IlotID);
				}


			}

		}

		private void metroLabel13_Click(object sender, EventArgs e)
		{

			Form formBackground = new Form();
			try
			{
				using (ManagPoste uu = new ManagPoste())
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
				
				metroComboBox1.Items.Clear();
				if (IlotIDS.SelectedIndex > -1)
				{ List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(IlotIDS.SelectedItem.ToString());
					var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
					foreach (var o in DistinctItems)
						metroComboBox1.Items.Add(o.ToString());
				}


			}
			
		}

		private void IlotIDS_SelectedIndexChanged(object sender, EventArgs e)
		{
			metroComboBox1.Items.Clear();
			List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(IlotIDS.SelectedItem.ToString());
			var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
			foreach (var o in DistinctItems)
				metroComboBox1.Items.Add(o.ToString());
		}
		
		private void metroTile1_Click_1(object sender, EventArgs e)
		{
			try
			{
				ManuelCycleTime oppp = new ManuelCycleTime
				{
					OperationID = MachineIDInput.Text,
				

				};
				OperationDBO.DeletAllOperation(oppp);
				List<ManuelCycleTime> op = new List<ManuelCycleTime>();
				for (int i = 0; i < Listitem; i++)
				{

					if (PRoductIDSelect.GetItemChecked(i))
					{

						ManuelCycleTime opp = new ManuelCycleTime
						{
							OperationID = MachineIDInput.Text,
						
							ManuelCycleTimeT = float.Parse(EffInput.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
							ProductID = PRoductIDSelect.Items[i].ToString(),

						}; op.Add(opp);
					}
				}
				foreach (ManuelCycleTime oo in op)
				{

					ManuelCycleTimeDBO.AddOperationData(oo);
					OpGroupeDBO.UpdateOperationGrp(oo.OperationID, metroComboBox1.SelectedItem.ToString());
					
				}
				MessageBox.Show("done !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			ManOperation mm = new ManOperation( );
			mm.Show();
			this.Hide();
		}

		private void ManOperation_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
