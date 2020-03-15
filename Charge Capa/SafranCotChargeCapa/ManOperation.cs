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
	public partial class ManOperation : MetroFramework.Forms.MetroForm
	{
		public ManOperation()
		{
			InitializeComponent();
		}

		private void ManOperation_Load(object sender, EventArgs e)
		{
			try
			{
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

		private void RoleInput_SelectedIndexChanged(object sender, EventArgs e)
		{
			MachineIDInput.Text = InputOperation.SelectedItem.ToString();
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

		private void MachineIDInput_ButtonClick(object sender, EventArgs e)
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
							{ PRoductIDSelect.SetItemChecked(i, true); }


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
				for (int i = 0; i <= PRoductIDSelect.CheckedItems.Count; i++)
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
					MessageBox.Show(oo.ManuelCycleTime.ToString());
					OperationDBO.AddOperation(oo);
				}
				MessageBox.Show("done !!");
				AddMach.Enabled = true; SaveMach.Enabled = true;
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
					MachineID = MachineSelc.SelectedItem.ToString(),
					CycleTime = float.Parse(MachineCycleTime.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
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

		private void SaveMach_Click(object sender, EventArgs e)
		{
			try
			{
				MachineCycleTime op = new MachineCycleTime
				{

					OperationID = MachineIDInput.Text,
					MachineID = MachineSelc.SelectedItem.ToString(),
					CycleTime = float.Parse(MachineCycleTime.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
				};

				MachineCycleTimeDBO.UpMachineCycleTime(op);
				//MachineCycleTimeDBO.DeletAllOperationTime(op);
				MessageBox.Show("done !!");
				SaveMach.Enabled = false; AddMach.Enabled = false; DelMach.Enabled = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
