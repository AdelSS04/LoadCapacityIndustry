using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;

namespace SafranCotChargeCapa
{
	public partial class Follow : Form
	{
		public Follow()
		{
			InitializeComponent();
		}

		private void IlotInput_onItemSelected(object sender, EventArgs e)
		{
			if (YearSelect.selec > -1)
			{
				List<demande> DemPerPo = IlotDBO.ListDemPerPoste(IlotInput.selectedValue.ToString(), Convert.ToInt32(YearSelect.SelectedItem), CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday));

				dataGridView1.DataSource = DemPerPo;
				List<demande> DemPerPoo = dataGridView1.DataSource as List<demande>;
				List<operation> OpPerPost = IlotDBO.ListeOpePostChar(IlotInput.selectedValue.ToString());
				ChargePo = operationDBO.GetCharge(OpPerPost);

				List<charge> ChTot = new List<charge>();
				charge cr;
				foreach (demande d in DemPerPoo)
				{
					float tc = GetTC(ChargePo, d.idproduit);
					cr = new charge
					{
						annee = d.annee,
						product = d.idproduit,
						semaine = d.semain,
						ChargT = (tc * d.Qte),

					};
					ChTot.Add(cr);

				}
				upch();
			}
		}

		private void YearSelect_ValueChanged(object sender, EventArgs e)
		{
			
		}

		private void YearSelect_SelectedItemChanged(object sender, EventArgs e)
		{
			if (IlotInput.selectedIndex > -1)
			{
				List<demande> DemPerPo = IlotDBO.ListDemPerPoste(IlotInput.selectedValue.ToString(), Convert.ToInt32(YearSelect.SelectedItem), CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday));

				dataGridView1.DataSource = DemPerPo;
				List<demande> DemPerPoo = dataGridView1.DataSource as List<demande>;
				List<operation> OpPerPost = IlotDBO.ListeOpePostChar(IlotInput.selectedValue.ToString());

				ChargePo = operationDBO.GetCharge(OpPerPost);

				List<charge> ChTot = new List<charge>();
				charge cr;
				foreach (demande d in DemPerPoo)
				{
					float tc = GetTC(ChargePo, d.idproduit);
					//MessageBox.Show(tc.ToString());
					cr = new charge
					{
						annee = d.annee,
						product = d.idproduit,
						semaine = d.semain,
						ChargT = (tc * d.Qte),

					};
					ChTot.Add(cr);

				}

				upch();
			}
		}
	}
}