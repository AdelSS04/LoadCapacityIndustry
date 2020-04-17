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
	public partial class AddOp : Form // MetroFramework.Forms.MetroForm
	{
		public AddOp()
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

					metroComboBox2.Items.Add(u.IlotID);
				}
			
			
			}
			catch (Exception)
			{

				throw;
			}
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

		private void button2_Click(object sender, EventArgs e)
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

		private void UpButton_Click(object sender, EventArgs e)
		{
			//try
			//{
				Operation operation = new Operation
				{
					OperationID = materialSingleLineTextField1.Text,
					GroupID = metroComboBox3.SelectedItem.ToString(),
				};
				List<ManuelCycleTime> op = new List<ManuelCycleTime>();
				for (int i = 0; i < checkedListBox1.Items.Count; i++)
				{

					if (checkedListBox1.GetItemChecked(i))
					{

						ManuelCycleTime opp = new ManuelCycleTime
						{
							OperationID = materialSingleLineTextField1.Text,

							ManuelCycleTimeT = float.Parse(TcInput.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-US")),
							ProductID = checkedListBox1.Items[i].ToString(),

						}; op.Add(opp);
					}
				}
				

				if(OperationDBO.AddOperation(operation))

				{
				MessageBox.Show("op ajouté !!");
				foreach (ManuelCycleTime cy in op)
				{
					ManuelCycleTimeDBO.AddOperationData(cy);
				}
				MessageBox.Show("done !!");
				}
			/*}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}*/
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpButton.Enabled = true;
		}
	}
}