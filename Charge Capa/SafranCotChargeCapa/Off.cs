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
using System.Windows.Forms.DataVisualization.Charting;

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
			this.chartStats.Titles.Add("Charge/Capacité Humain");

		}
		public float GetTC(List<Operation> ChargePo, string id)
		{
			float C = 0;
			foreach (Operation Tc in ChargePo)
			{
				if (Tc.ProductID == id)
					 C+=Tc.ManuelCycleTime;
			}
			return C;
		}
		List<Operation> ChargePo;
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (YearSelect.SelectedIndex > -1)
			{
				upGraph();
			}



			/*	try
			{
				
				List<Operation> OP = IlotDBO.ListeOpePostChar(metroComboBox1.SelectedItem.ToString());
			List<Demande> dmm = new List<Demande>();
				List<Demande> dmm1 = new List<Demande>(); int i = 0;
				foreach (Operation optest in OP)
				{
					int yrr = 2020; int wkk = 11; dmm = (DemandeDBO.GetProductDemande(optest.ProductID, yrr, wkk));
					dmm1.AddRange(dmm);
					i++;
				}
				
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
			var query1 = ChTot.Where(person => person.annee == 2020).ToList();
			var LL = query1.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value = t.Sum(u => u.ChargT) }).ToList();
			chartStats.Series.Clear();
			Capa.Clear();
			xValues.Clear();
			yValues.Clear();
			foreach (var item in LL)
			{
				xValues.Add(item.ID);
				yValues.Add(item.Value);
				Capa.Add(480);
			}
			var series = new Series()
			{
				ChartType = SeriesChartType.Column,
				Color = Color.FromArgb(93, 138, 168),
				IsVisibleInLegend = true,
				Name = "Charge",
				LegendText = "Charge",

			};
			var series1 = new Series()
			{
				ChartType = SeriesChartType.Line,
				IsVisibleInLegend = true,
				BorderDashStyle = ChartDashStyle.Solid,
				Name = "Capa",
				LegendText = "Capacité",
				BorderWidth = 5,
				Color = Color.FromArgb(255, 126, 0),
			};


			chartStats.Series.Add(series);
			chartStats.Series.Add(series1);
			chartStats.Series[1].Points.Clear();
			chartStats.Series[0].Points.DataBindXY(xValues, yValues);
			chartStats.Series[1].Points.DataBindXY(xValues, Capa);
			/*
						var OnlyOpName = ChTot.GroupBy(x => x.product).Select(x => x.First()).ToList();

						var query1 = ChTot.Where(person => person.annee == 2020).ToList();


						var LL = query1.GroupBy(t => t.product).Select(t => new { ID = t.Key, Value = t.Sum(u => u.ChargT) }).ToList();
						int ii = 0;
						foreach( var d in OnlyOpName)
						{
							MessageBox.Show(d.product);
							var quer1 = ChTot.Where(person => person.product == d.product);

							foreach( var dd in quer1)
							{
								xValues.Add(dd.semaine);
								yValues.Add(dd.ChargT);
								chartStats.Series[dd.product].Points.AddXY(dd.semaine, dd.ChargT);
							}

						}



						/*	
							var series = new Series()
							{
								ChartType = SeriesChartType.StackedColumn,
								Color = Color.FromArgb(93, 138, 168),
								IsVisibleInLegend = true,
								Name = "",
								LegendText = "",

							};
							var series1 = new Series()
							{
								ChartType = SeriesChartType.Line,
								IsVisibleInLegend = true,
								BorderDashStyle = ChartDashStyle.Solid,
								Name = "Capa",
								LegendText = "Capacité",
								BorderWidth = 5,
								Color = Color.FromArgb(255, 126, 0),
							};


							chartStats.Series.Add(series);
							chartStats.Series.Add(series1);
							chartStats.Series[1].Points.Clear();
							chartStats.Series[0].Points.DataBindXY(xValues, yValues);
							chartStats.Series[1].Points.DataBindXY(xValues, Capa);

			}
			catch (Exception ex)
			{
			MessageBox.Show(ex.Message);
			}*/
		}
		List<decimal> xValues = new List<decimal>();
		List<float> yValues = new List<float>();
		List<double> Capa = new List<double>();
		

		public void upGraph ()
		{
			try
			{
				Ilot il = IlotDBO.GetIlot(metroComboBox1.SelectedItem.ToString());
				List <Operators> op = OperatorsDBO.GetOperators(metroComboBox1.SelectedItem.ToString(),Convert.ToInt32(YearSelect.SelectedItem), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
				List<Operation> OP = IlotDBO.ListeOpePostChar(metroComboBox1.SelectedItem.ToString());
				List<Demande> dmm = new List<Demande>();
				List<Demande> dmm1 = new List<Demande>();
				foreach (Operation optest in OP)
				{
					dmm = (DemandeDBO.GetProductDemande(optest.ProductID, Convert.ToInt32(YearSelect.SelectedItem), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
					dmm1.AddRange(dmm);
					
				}

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
				var query1 = ChTot.Where(person => person.annee == Convert.ToInt32(YearSelect.SelectedItem)).ToList();
				var LL = query1.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value = t.Sum(u => u.ChargT) }).ToList();
				chartStats.Series.Clear();
				Capa.Clear();
				xValues.Clear();
				yValues.Clear();
				foreach (var item in LL)
				{
					xValues.Add(item.ID);
					yValues.Add(item.Value);
					
				}
				foreach(Operators opo in op)
				{
					Capa.Add(opo.NumberOfOperator * (il.CRM/100) * (il.Efficiency/100) * (1 - (il.IlotRejectedRate/100)) * (1 - (il.TruancyRate/100)) * 7.67 * 5);
				}
				var series = new Series()
				{
					ChartType = SeriesChartType.Column,
					Color = Color.FromArgb(93, 138, 168),
					IsVisibleInLegend = true,
					Name = "Charge",
					LegendText = "Charge",

				};
				var series1 = new Series()
				{
					ChartType = SeriesChartType.Line,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					Name = "Capa",
					LegendText = "Capacité",
					BorderWidth = 5,
					Color = Color.FromArgb(255, 126, 0),
				};


				chartStats.Series.Add(series);
				chartStats.Series.Add(series1);
				chartStats.Series[1].Points.Clear();
				chartStats.Series[0].Points.DataBindXY(xValues, yValues);
				chartStats.Series[1].Points.DataBindXY(xValues, Capa);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void YearSelect_SelectedItemChanged(object sender, EventArgs e)
		{
			if (metroComboBox1.SelectedIndex > -1)
			{
				upGraph();
			}
			}
	}
}
