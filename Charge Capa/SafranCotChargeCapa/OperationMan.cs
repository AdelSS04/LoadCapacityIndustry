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
	public partial class OperationMan : Form
	{
		public OperationMan()
		{
			InitializeComponent();
		}

		private void SaveUpdate_Click(object sender, EventArgs e)
		{
			
			
			}
		private void ManageMachine_Load(object sender, EventArgs e)
		{
			try
			{
				List<Product> ur = ProductDBO.GetAllProduct();
				foreach (Product u in ur)
				{ PRoductIDSelect.Items.Add(u.ProductID); }
				List<Ilot> il = IlotDBO.GetAllIlot();
				foreach (Ilot u in il)
				{// MessageBox.Show(u.IlotID);
					IlotIDS.AddItem(u.IlotID); 
				}
				List<Machine> mach = MachineDBO.GetAllMachine();
				foreach (Machine u in mach)
				{// MessageBox.Show(u.IlotID);
					MachineSelc.AddItem(u.MachineID);
				}
				List<Operation> op = OperationDBO.GetAllOperationName();
				foreach (Operation opp in op)
				{// MessageBox.Show(u.IlotID);
					InputOperation.AddItem(opp.OperationID);
				}
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
				for (int i = 0; i <= PRoductIDSelect.CheckedItems.Count; i++)
				{
					if (PRoductIDSelect.GetItemChecked(i))
					{
						Operation opp = new Operation
						{
							OperationID = MachineIDInput.Text,
							IlotID = IlotIDS.selectedValue.ToString(),
							ManuelCycleTime = float.Parse(EffInput.Text),
							ProductID = PRoductIDSelect.Items[i].ToString(),

						}; op.Add(opp);
					}
				}
				foreach (Operation oo in op)
				{
					MessageBox.Show(oo.ManuelCycleTime.ToString());
					OperationDBO.AddOperation(oo); 
				}
				MessageBox.Show("done !!");
				AddMach.Enabled = true;SaveMach.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public int GetListID(string name)
		{
			int i = 0;
			foreach(string c in MachineSelc.Items)
			{
				if (c == name)
					return i;
				else
					i++;
			}
			
			return i;
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			
			AddButton.Enabled = false;
			AddMach.Enabled = false;
			SaveMach.Enabled = false;
			DelMach.Enabled = false;

			try
			{
				List<Operation> Lur = OperationDBO.GetOperation(MachineIDInput.Text);
				for (int i = 0; i < PRoductIDSelect.Items.Count; i++)
				{ 
					PRoductIDSelect.SetItemChecked(i, false);

				}
				//IlotNameInput.Text = Lur[0].IlotID;
				//	
				
				if (Lur.Count.ToString() != "0")
				{
					EffInput.Text = Lur[0].ManuelCycleTime.ToString();


					foreach (Operation op in Lur)
					{
						for (int i = 0; i < PRoductIDSelect.Items.Count; i++)
						{
							if (PRoductIDSelect.Items[i].ToString() == op.ProductID)
							{ PRoductIDSelect.SetItemChecked(i, true);  }
							

						}
					}
					MachineCycleTime MaCy = MachineCycleTimeDBO.GetMachineCycleTime(MachineIDInput.Text); HideMach.Text = MaCy.MachineID;
					
					if (MaCy.CycleTime.ToString() != "0")
					{
						SaveMach.Enabled = true;
						DelMach.Enabled = true;
						MachineCycleTime.Text = "";
					}
					if (MaCy.CycleTime.ToString() == "0")
					{
						AddMach.Enabled = true;
						MachineCycleTime.Text = "";
					}
					//


					AddButton.Enabled = false;
					SaveUpdate.Enabled = true;
					DelAll.Enabled = true;
				}
				else
				{ MessageBox.Show("404 not found"); MachineCycleTime.Text = ""; }

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void MachineIDInput_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{

		}

		private void RoleInput_onItemSelected(object sender, EventArgs e)
		{
			MachineIDInput.Text = InputOperation.selectedValue.ToString();
			AddButton.Enabled = false;
			AddMach.Enabled = false;
			SaveMach.Enabled = false;
			DelMach.Enabled = false;

			try
			{
				List<Operation> Lur = OperationDBO.GetOperation(MachineIDInput.Text);
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
					MachineCycleTime MaCy = MachineCycleTimeDBO.GetMachineCycleTime(MachineIDInput.Text); HideMach.Text = MaCy.MachineID + " tc=\n" + MaCy.CycleTime.ToString();

					if (MaCy.CycleTime.ToString() != "0")
					{
						SaveMach.Enabled = true;
						DelMach.Enabled = true;
						MachineCycleTime.Text = "";
					}
					if (MaCy.CycleTime.ToString() == "0")
					{
						AddMach.Enabled = true;
						MachineCycleTime.Text = "";
					}
					//


					AddButton.Enabled = false;
					SaveUpdate.Enabled = true;
					DelAll.Enabled = true;
				}
				else
				{ MessageBox.Show("404 not found"); MachineCycleTime.Text = ""; }

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateWorker_Click(object sender, EventArgs e)
		{
			try
			{
				Operators op = new Operators
				{
					

				};
				
				OperatorsDBO.UpOperatingNumber(op);
				MessageBox.Show("done !!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void MachineID_Click(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void DelAll_Click(object sender, EventArgs e)
		{
			try
			{
				Operation op = new Operation
				{
					
					OperationID = MachineIDInput.Text ,
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

		private void SaveMach_Click(object sender, EventArgs e)
		{
			
		}

		private void DelMach_Click(object sender, EventArgs e)
		{
			try
			{
				MachineCycleTime op = new MachineCycleTime
				{

					OperationID = MachineIDInput.Text,
					
				};

				MachineCycleTimeDBO.DeletAllOperationcycleTime(op);
				//MachineCycleTimeDBO.DeletAllOperationTime(op);
				MessageBox.Show("done !!");
				SaveMach.Enabled = false; AddMach.Enabled = false; DelMach.Enabled = false;
				MachineCycleTime.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddMach_Click(object sender, EventArgs e)
		{
			try
			{
				MachineCycleTime op = new MachineCycleTime
				{

					OperationID = MachineIDInput.Text,
					MachineID = MachineSelc.selectedValue.ToString(),
					CycleTime = float.Parse(MachineCycleTime.Text),
				};

				MachineCycleTimeDBO.AddMachineCycleTime(op);
				//MachineCycleTimeDBO.DeletAllOperationTime(op);
				MessageBox.Show("done !!");
				SaveMach.Enabled = false; AddMach.Enabled = false; DelMach.Enabled = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void IlotIDS_onItemSelected(object sender, EventArgs e)
		{

		}

		private void PRoductIDSelect_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
	}

