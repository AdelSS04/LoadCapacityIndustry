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
	public partial class Off : MetroFramework.Forms.MetroForm
	{
		public Off()
		{
			InitializeComponent();
		}

		private void Off_Load(object sender, EventArgs e)
		{

		}
		public float GetTC(List<Operation> ChargePo, string id)
		{
			float C = 0;
			foreach (Operation Tc in ChargePo)
			{
				if (Tc.ProductID == id)
					C += Tc.ManuelCycleTime;
			}
			return C;
		}
		List<Operation> ChargePo;
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{//try
			//{
				MessageBox.Show(metroComboBox1.SelectedItem.ToString());
				List<Operation> OP = IlotDBO.ListeOpePostChar(metroComboBox1.SelectedItem.ToString());
				metroGrid1.DataSource = OP;
				MessageBox.Show("zz");
				//	OP = OP.GroupBy(x => x.ProductID).Select(x => x.First()).ToList();
				metroGrid1.DataSource = OP;
				List<Demande> dmm = new List<Demande>();
				List<Demande> dmm1 = new List<Demande>(); int i = 0;
				foreach (Operation optest in OP)
				{
					//MessageBox.Show(optest.ProductID);
					int yrr = 2020; int wkk = 11; dmm = (DemandeDBO.GetProductDemande(optest.ProductID, yrr, wkk));
					dmm1.AddRange(dmm);
					i++;
				}
				metroGrid2.DataSource = dmm1;
				List<Charge> ChTot = new List<Charge>();
				Charge cr;
			ChargePo = OP;
				foreach (Demande d in dmm1)
				{
					float tc = GetTC(ChargePo, d.ProductID);
					cr = new Charge
					{
						annee = d.YearDem,
						product = d.ProductID,
						semaine = d.WeekDem,
						ChargT = (tc * d.DemandeQTE),

					};
					ChTot.Add(cr);

				}
				MessageBox.Show("trr");
				metroGrid3.DataSource = ChTot;

			//}
			//catch (Exception ex)
			//{
				//MessageBox.Show(ex.Message);
			//}
}

		private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
