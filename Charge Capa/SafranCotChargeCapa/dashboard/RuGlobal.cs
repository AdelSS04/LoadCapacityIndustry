using BEL;
using DAL;
using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SafranCotChargeCapa.dashboard
{
	public partial class RuGlobal : Form
	{
		public RuGlobal()
		{
			InitializeComponent();
		}

		private void RuGlobal_Load(object sender, EventArgs e)
		{
			
			DataPick.Items.Add(DateTime.Now.Year);
			DataPick.Items.Add((DateTime.Now.Year + 1));
			DataPick.Items.Add((DateTime.Now.Year + 2));
		}

		
		public void sizeDGV(DataGridView dgv,Panel pan)
		{
			DataGridViewElementStates states = DataGridViewElementStates.None;
		//	dgv.ScrollBars = ScrollBars.None;

			var totalWidth = dgv.Columns.GetColumnsWidth(states);
			dgv.ClientSize = new Size(totalWidth, pan.Height);
			pan.ClientSize = new Size(totalWidth + 20, pan.Height);
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
	
		List<int> xValues = new List<int>();
		List<float> yValues = new List<float>();
		List<float> Capa = new List<float>();
		List<double> PerCV = new List<double>();
		List<double> PerTools = new List<double>();
		List<double> MachCapa = new List<double>();
		List<double> ToolsCapa = new List<double>();
		List<Operators> op;
		List<ManuelCycleTime> OP;
		List<Demande> dmm1;
		Ilot il;
		List<ManuelCycleTime> ChargePo;
		List<MachineCycleTime> OpMach;
		public float GetTC(List<ManuelCycleTime> ChargePo, string id)
		{
			float C = 0;
			foreach (ManuelCycleTime Tc in ChargePo)
			{
				if (Tc.ProductID == id)
					C += Tc.ManuelCycleTimeT;
			}
			return C;
		}
		public void setC(DataGridView dgv)
		{
			foreach (DataGridViewRow row in dgv.Rows)
			{
				if (float.Parse(row.Cells[3].Value.ToString()) >= 0)
					row.Cells[3].Style.BackColor = System.Drawing.Color.Green;
				else
					row.Cells[3].Style.BackColor = System.Drawing.Color.Red;
			}
		}

		List<Charge> chargeRu = new List<Charge>();
		List<Charge> CapaRu = new List<Charge>();
		List<Operators> op1 =  new List<Operators>();
		List<ManuelCycleTime> OP1 = new List<ManuelCycleTime>();

		public void upGraphRU()
		{





			CapaRu.Clear();
			chargeRu.Clear();
			Capa.Clear();
			try
			{
				List<Demande> dmm = new List<Demande>();
				List<String> OpList = new List<string>();
				List<Charge> ChTot = new List<Charge>();
				dmm1 = new List<Demande>();
				op1.Clear(); OP1.Clear();
				List<Ilot> il = IlotDBO.GetAllIlot();
				List<OpGroupe> IlotGrpOFOP = new List<OpGroupe>();
				foreach (Ilot u in il)



				{
					if (u.IlotID != "0706Plym")
					{
						IlotGrpOFOP.Clear();
						IlotGrpOFOP = IlotDBO.IlotOpgrp(u.IlotID);
						var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
						op1.Clear(); OP1.Clear();
						foreach (var GrpOpList in DistinctItems)

						{
							op1.AddRange(OperatorsDBO.GetOperators(GrpOpList.ToString(), int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
							OP1.AddRange(OpGroupeDBO.ListOPParGRP(GrpOpList.ToString()));
							dmm.Clear();
							ChTot.Clear();
							dmm1.Clear();
							foreach (ManuelCycleTime optest in OP1)
							{
								dmm = (DemandeDBO.GetProductDemande(optest.ProductID, int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
								dmm1.AddRange(dmm);

							}

							Charge cr;
							ChargePo = OP1;

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


						}


						var newList =
			(
			from x in ChTot
			select new { annee = x.annee, product = x.product, semaine = x.semaine, ChargT = x.ChargT }
			).Distinct().ToList();
						var query1 = newList.Where(person => person.annee == int.Parse(DataPick.SelectedItem.ToString())).ToList();

						var LL = query1.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value = t.Sum(v => v.ChargT) }).ToList();
						int hh = 0;
						xValues.Clear();
						yValues.Clear();
						; PerCV.Clear();
						Charge charge;
						foreach (var item in LL)
						{
							charge = new Charge
							{
								semaine = item.ID,
								ChargT = (item.Value + (0.05f * item.Value)),
							}; chargeRu.Add(charge);

						}

						var LL1 = op1.GroupBy(t => t.WeekT).Select(t => new { ID = t.Key, Value = t.Max(kk => kk.DayOfWorking), Value1 = t.Sum(kk => kk.NumberOfOperator), value2 = t.Average(kk => kk.WeekT) }).ToList();
						Charge capacite;

						foreach (var opo in LL1)
						{
							capacite = new Charge
							{
								ChargT = (opo.Value1 * 0.8f * 0.95f * 0.95f * 7.67f * 5),
								semaine = (int)Math.Truncate(opo.value2)
							};



							CapaRu.Add(capacite);

						}


					}
				}


				var LL11 = chargeRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();
				var LL12 = CapaRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();
				dataGridView1.DataSource = chargeRu;
				List<float> chrr = new List<float>();
				List<float> cpp = new List<float>();
				List<int> wkk = new List<int>();
				List<int> OpNeed = new List<int>();
				foreach (var cc in LL11)
				{
					chrr.Add(cc.Value1);

					wkk.Add(cc.ID);
					if (cc.Value1 > 0)
						OpNeed.Add((int)Math.Truncate(cc.Value1 / (0.8f * 0.95f * 0.95f * 7.67f * 5)) + 1);
					else
						OpNeed.Add(0);
				}
				foreach (var cc in LL12)
				{
					cpp.Add(cc.Value1);


				}



				List<BesoinOP> br = new List<BesoinOP>();
				BesoinOP brr;

				for (int i = 0; i < chrr.Count; i++)
				{
					if (cpp[i] != 0)
						PerCV.Add(Math.Round(chrr[i] / cpp[i], 2) * 100);
					else
						PerCV.Add(0);

					if (!(OpNeed[i] == 0))
						brr = new BesoinOP
						{
							WeekWork = wkk[i],
							ActualCharge = Math.Round(chrr[i], 2),
							AcutalCapa = Math.Round(cpp[i], 2),
							BesoinH = Math.Round((cpp[i] - chrr[i]), 2),
							NbrOp = (int)Math.Truncate(cpp[i] / (0.8f * 0.95f * 0.95f * 7.67f * 5)),

							OpNeed = OpNeed[i],

						};
					else
						brr = new BesoinOP
						{
							WeekWork = wkk[i],
							ActualCharge = chrr[i],
							AcutalCapa = cpp[i],
							BesoinH = (Math.Round((cpp[i] - chrr[i]), 2)),
							NbrOp = (int)Math.Truncate(cpp[i] / (0.8f * 0.95f * 0.95f * 5)),

							OpNeed = 0,
						};
					br.Add(brr);


				}
				List<IlotOp> ilotOps = IlotOpDBO.GetIlotOPdata(int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
				
				List<int> formation = new List<int>();
				List<int> chomzge = new List<int>();
				List<int> mater = new List<int>();
				foreach (IlotOp ilotOp in ilotOps)
				{ formation.Add(ilotOp.Formation);
					chomzge.Add(ilotOp.Chomage);
					mater.Add(ilotOp.Materneti);

				}

				var serieeff = new Series()
				{
					ChartType = SeriesChartType.StackedColumn,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,

					IsValueShownAsLabel = true,
					Name = "Besoin d'operateur",
					LegendText = "Besoin d'operateur",
					BorderWidth = 3,
					Color = Color.FromArgb(93, 138, 168),
				};
				var serieeforma = new Series()
				{
					ChartType = SeriesChartType.StackedColumn,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					IsValueShownAsLabel = true,

					Name = "operateur en formation",
					LegendText = "operateur en formation",
					BorderWidth = 3,
					Color = Color.FromArgb(120, 15, 0),
				};
				var serieechom = new Series()
				{
					ChartType = SeriesChartType.StackedColumn,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					IsValueShownAsLabel = true,

					Name = "Operateur en chomage",
					LegendText = "Operateur en chomage",
					BorderWidth = 3,
					Color = Color.FromArgb(25, 120, 20),
				};
				var serieeMat = new Series()
				{
					ChartType = SeriesChartType.StackedColumn,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					IsValueShownAsLabel = true,

					Name = "Maternité",
					LegendText = "Maternité",
					BorderWidth = 3,
					Color = Color.FromArgb(158, 185, 41),
				};
				var series = new Series()
				{
					ChartType = SeriesChartType.Column,
					Color = Color.FromArgb(93, 138, 168),
					

					Name = "Charge",
					LegendText = "Charge",

				};
				var series1 = new Series()
				{
					ChartType = SeriesChartType.Spline,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,


					Name = "Capacité",
					LegendText = "Capacité",
					BorderWidth = 3,
					Color = Color.FromArgb(255, 126, 0),
				};
				var seriesEff = new Series()
				{
					ChartType = SeriesChartType.Column,
					Color = Color.FromArgb(93, 138, 168),
					IsVisibleInLegend = true,
					IsValueShownAsLabel = true,
					Name = "Eff",
					LegendText = "Eff",

				};
				var RatioChargeCapa = new Series()
				{
					ChartType = SeriesChartType.Spline,
					Color = Color.FromArgb(93, 138, 168),
					IsVisibleInLegend = true,
					IsValueShownAsLabel = true,
					Name = "RatioChargeCapa",
					LegendText = "RatioChargeCapa",
					BorderWidth = 3,

				};
				chart1.Series.Clear();
				chartStats.Series.Clear();
				chart4.Series.Clear();
				chart4.Series.Add(serieeff); chart4.Series.Add(serieeforma); chart4.Series.Add(serieeMat); chart4.Series.Add(serieechom);
				chart4.ChartAreas[0].AxisX.Interval = 1;
				chart4.Series[0].Points.DataBindXY(wkk, OpNeed);
				chart4.Series[1].Points.DataBindXY(wkk, formation);
				chart4.Series[2].Points.DataBindXY(wkk, mater);
				chart4.Series[3].Points.DataBindXY(wkk, chomzge);
				chart4.Series[0].LabelFormat = "#";
				
				chart4.Series[1].LabelFormat = "#";
				
				chart4.Series[2].LabelFormat = "#";
				
				chart4.Series[3].LabelFormat = "#";
				
				foreach (System.Windows.Forms.DataVisualization.Charting.Series Series in chart4.Series)
				{
					foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in series.Points)
					{
						if (point.YValues.Length > 0 && (double)point.YValues.GetValue(0) == 0)
						{
							point.LegendText = point.AxisLabel;//In case you have legend
							point.AxisLabel = string.Empty;
							point.Label = string.Empty;
						}
					}
				}
				chartStats.Series.Add(series);
				chartStats.Series.Add(series1);

				chartStats.ChartAreas[0].AxisX.Interval = 1;
				chartStats.ChartAreas[0].AxisX.Title = "Semaine";
				chart4.ChartAreas[0].AxisX.Title = "Semaine";
				chart1.ChartAreas[0].AxisX.Title = "Semaine";
				chartStats.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chart4.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chartStats.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chart4.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

				chartStats.ChartAreas[0].AxisY.Title = "Les heure de travail en H";
				chart4.ChartAreas[0].AxisY.Title = "Nombre des operteur";
				chart1.ChartAreas[0].AxisY.Title = "Ration de %";
				chartStats.Series[1].Points.Clear();
				chart1.Series.Add(RatioChargeCapa);
				chart1.Series[0].Points.Clear();
				chart1.ChartAreas[0].AxisX.Interval = 1;

				chart1.Series[0].Points.DataBindXY(wkk, PerCV);
				chartStats.Series[0].Points.DataBindXY(wkk, chrr);
				chartStats.Series[1].Points.DataBindXY(wkk, cpp);
				dataGridView1.DataSource = br;
			
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void upGraph1()
		{





			CapaRu.Clear();
			chargeRu.Clear();
			Capa.Clear();
			try
			{
				List<Demande> dmm = new List<Demande>();
				List<String> OpList = new List<string>();
				List<Charge> ChTot = new List<Charge>();
				dmm1 = new List<Demande>();
				op1.Clear(); OP1.Clear();
				List<Ilot> il = IlotDBO.GetAllIlotAtelier(metroComboBox1.SelectedItem.ToString());
				List<OpGroupe> IlotGrpOFOP= new List<OpGroupe>();
				foreach (Ilot u in il)



				{
					if (u.IlotID != "0706Plym")
					{ 
						IlotGrpOFOP.Clear();
					IlotGrpOFOP = IlotDBO.IlotOpgrp(u.IlotID);
					var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
					op1.Clear(); OP1.Clear();
					foreach (var GrpOpList in DistinctItems)

					{
						op1.AddRange(OperatorsDBO.GetOperators(GrpOpList.ToString(), int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
						OP1.AddRange(OpGroupeDBO.ListOPParGRP(GrpOpList.ToString()));
						dmm.Clear();
						ChTot.Clear();
						dmm1.Clear();
						foreach (ManuelCycleTime optest in OP1)
						{
							dmm = (DemandeDBO.GetProductDemande(optest.ProductID, int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
							dmm1.AddRange(dmm);

						}

						Charge cr;
						ChargePo = OP1;

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


					}


					var newList =
		(
		from x in ChTot
		select new { annee = x.annee, product = x.product, semaine = x.semaine, ChargT = x.ChargT }
		).Distinct().ToList();
					var query1 = newList.Where(person => person.annee == int.Parse(DataPick.SelectedItem.ToString())).ToList();

					var LL = query1.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value = t.Sum(v => v.ChargT) }).ToList();
					int hh = 0;
					xValues.Clear();
					yValues.Clear();
					; PerCV.Clear();
					Charge charge;
					foreach (var item in LL)
					{
						charge = new Charge
						{
							semaine = item.ID,
							ChargT = (item.Value +( 0.05f * item.Value)),
						}; chargeRu.Add(charge);

					}

					var LL1 = op1.GroupBy(t => t.WeekT).Select(t => new { ID = t.Key, Value = t.Max(kk => kk.DayOfWorking), Value1 = t.Sum(kk => kk.NumberOfOperator), value2 = t.Average(kk => kk.WeekT) }).ToList();
					Charge capacite;

					foreach (var opo in LL1)
					{
						capacite = new Charge
						{
							ChargT = (opo.Value1 * 0.8f * 0.95f * 0.95f * 7.67f * 5),
							semaine = (int)Math.Truncate(opo.value2)
						};



						CapaRu.Add(capacite);

					}


				}
				}

				
				var LL11 = chargeRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();
				var LL12 = CapaRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();
				dataGridView1.DataSource = chargeRu;
				List<float> chrr = new List<float>();
				List<float> cpp = new List<float>();
				List<int> wkk = new List<int>();
				List<int> OpNeed = new List<int>();
				foreach ( var cc in LL11)
				{
					chrr.Add(cc.Value1);

					wkk.Add(cc.ID);
					if (cc.Value1 > 0)
						OpNeed.Add((int)Math.Truncate(cc.Value1 / (0.8f * 0.95f * 0.95f * 7.67f * 5)) + 1);
					else
						OpNeed.Add(0);
				}
				foreach (var cc in LL12)
				{
					cpp.Add(cc.Value1);

					
				}



				List<BesoinOP> br = new List<BesoinOP>();
				BesoinOP brr;

				for (int i = 0; i < chrr.Count; i++)
				{
					if (cpp[i] != 0)
						PerCV.Add(Math.Round(chrr[i] / cpp[i], 2) * 100);
					else
						PerCV.Add(0);

					if (!(OpNeed[i] == 0))
						brr = new BesoinOP
						{
							WeekWork = wkk[i],
							ActualCharge = Math.Round(chrr[i], 2),
							AcutalCapa = Math.Round(cpp[i], 2),
							BesoinH = Math.Round((cpp[i] - chrr[i]), 2),
							NbrOp = (int)Math.Truncate(cpp[i] / (0.8f * 0.95f * 0.95f * 7.67f*5)),

							OpNeed = OpNeed[i],

						};
					else
						brr = new BesoinOP
						{
							WeekWork = wkk[i],
							ActualCharge = chrr[i],
							AcutalCapa = cpp[i],
							BesoinH = (Math.Round((cpp[i] - chrr[i]), 2)),
							NbrOp = (int)Math.Truncate(cpp[i]/(0.8f*0.95f*0.95f*5)),

							OpNeed = 0,
						};
					br.Add(brr);
					

				}
				//Stacked
				List<IlotOp> ilotOps = IlotOpDBO.GetIlotOPdataAtelier(int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), metroComboBox1.SelectedItem.ToString());

				List<int> formation = new List<int>();
				List<int> chomzge = new List<int>();
				List<int> mater = new List<int>();
				foreach (IlotOp ilotOp in ilotOps)
				{
					formation.Add(ilotOp.Formation);
					chomzge.Add(ilotOp.Chomage);
					mater.Add(ilotOp.Materneti);

				}


				var serieeff = new Series()
				{
					ChartType = SeriesChartType.StackedColumn,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					IsValueShownAsLabel = true,

					Name = "Besoin d'operateur",
					LegendText = "Besoin d'operateur",
					BorderWidth = 3,
					Color = Color.FromArgb(93, 138, 168),
				};
				var serieeforma = new Series()
				{
					ChartType = SeriesChartType.StackedColumn,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					IsValueShownAsLabel = true,

					Name = "operateur en formation",
					LegendText = "operateur en formation",
					BorderWidth = 3,
					Color = Color.FromArgb(120, 15, 0),
				};
				var serieechom = new Series()
				{
					ChartType = SeriesChartType.StackedColumn,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					IsValueShownAsLabel = true,

					Name = "Operateur en chomage",
					LegendText = "Operateur en chomage",
					BorderWidth = 3,
					Color = Color.FromArgb(25, 120, 20),
				};
				var serieeMat = new Series()
				{
					ChartType = SeriesChartType.StackedColumn,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					IsValueShownAsLabel = true,

					Name = "materneti",
					LegendText = "materneti",
					BorderWidth = 3,
					Color = Color.FromArgb(158, 185, 41),
				};
				//StackedEnd

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
					ChartType = SeriesChartType.Spline,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,
					

					Name = "Capacité",
					LegendText = "Capacité",
					BorderWidth = 3,
					Color = Color.FromArgb(255, 126, 0),
				};
				var seriesEff = new Series()
				{
					ChartType = SeriesChartType.Column,
					Color = Color.FromArgb(93, 138, 168),
					IsVisibleInLegend = true,
					IsValueShownAsLabel = true,
					Name = "Eff",
					LegendText = "Eff",

				};
				var RatioChargeCapa = new Series()
				{
					ChartType = SeriesChartType.Spline,
					Color = Color.FromArgb(93, 138, 168),
					IsVisibleInLegend = true,
					IsValueShownAsLabel = true,
					Name = "RatioChargeCapa",
					LegendText = "RatioChargeCapa",
					BorderWidth = 3,

				};
				chart1.Series.Clear();
				chartStats.Series.Clear();
				chart4.Series.Clear();
			chart4.Series.Add(serieeff); chart4.Series.Add(serieeforma); chart4.Series.Add(serieeMat); chart4.Series.Add(serieechom);
			chart4.ChartAreas[0].AxisX.Interval = 1;
				chart4.Series[0].Points.DataBindXY(wkk, OpNeed); 
				chart4.ChartAreas[0].AxisX.Interval = 1;
				chart4.Series[0].Points.DataBindXY(wkk, OpNeed);
				chart4.Series[1].Points.DataBindXY(wkk, formation);
				chart4.Series[2].Points.DataBindXY(wkk, mater);
				chart4.Series[3].Points.DataBindXY(wkk, chomzge);
				chartStats.Series.Add(series);
				chartStats.Series.Add(series1);
				chart4.Series[0].LabelFormat = "#";

				chart4.Series[1].LabelFormat = "#";

				chart4.Series[2].LabelFormat = "#";

				chart4.Series[3].LabelFormat = "#";

				chartStats.ChartAreas[0].AxisX.Interval = 1;
				
				chartStats.Series[1].Points.Clear();
				chart1.Series.Add(RatioChargeCapa);
				chart1.Series[0].Points.Clear();
				chart1.ChartAreas[0].AxisX.Interval = 1;
				chartStats.ChartAreas[0].AxisX.Title = "Semaine";
				chartStats.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chart4.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chartStats.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chart4.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
				chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

				chartStats.ChartAreas[0].AxisY.Title = "Les heure de travail en H";
				chart4.ChartAreas[0].AxisY.Title = "Nombre des operteur";
				chart1.ChartAreas[0].AxisY.Title = "Ration de %";
				chart1.Series[0].Points.DataBindXY(wkk, PerCV);
				chartStats.Series[0].Points.DataBindXY(wkk, chrr);
				chartStats.Series[1].Points.DataBindXY(wkk, cpp);
				dataGridView1.DataSource = br;
				
			}
			catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		}

		private void DataPick_SelectedIndexChanged(object sender, EventArgs e)
		{
			upGraphRU();
			setC(dataGridView1);
			sizeDGV(dataGridView1, panel3);
		}

		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			upGraph1();
			setC(dataGridView1);
			sizeDGV(dataGridView1, panel3);
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			ManagOpera fr = new ManagOpera();
			fr.Show();
		}
	}
	
	}

