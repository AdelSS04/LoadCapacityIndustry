using BEL;
using DAL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SafranCotChargeCapa.dashboard
{
	public partial class live : Form
	{
		public live()
		{
			InitializeComponent();
		}

		private void live_Load(object sender, EventArgs e)
		{
			List<Ilot> il = IlotDBO.GetAllIlot();
			foreach (Ilot u in il)
			{

				IlotPick.Items.Add(u.IlotID);
			}
			DataPick.Items.Add(DateTime.Now.Year);
			DataPick.Items.Add((DateTime.Now.Year + 1));
			DataPick.Items.Add((DateTime.Now.Year + 2));
		}

		private void IlotPick_SelectedIndexChanged(object sender, EventArgs e)
		{
			 GrpPick.Items.Clear();
			
			List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(IlotPick.SelectedItem.ToString());
			var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
			foreach (var o in DistinctItems)
				GrpPick.Items.Add(o.ToString());

			upGraph1();
			setC(dataGridView1);
			sizeDGV(dataGridView1, panel3);
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
		private async void GrpPick_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DataPick.SelectedIndex > -1)
			{
				

				await upGraph();
                setC(dataGridView1);
				sizeDGV(dataGridView1,panel3);
				OpMach = new List<MachineCycleTime>();
				List<Machine> MachInfo = new List<Machine>();
				foreach (ManuelCycleTime oper in OP)
				{
					OpMach.AddRange(MachineCycleTimeDBO.GetOpALLmach(oper.OperationID));


				}
				foreach (MachineCycleTime oper in OpMach)
				{
					MachInfo.AddRange(MachineDBO.GetAllOpMachine(oper.MachineID));
				}
				var DistinctItems = MachInfo.GroupBy(x => x.MachineID).Select(y => y.First());
				MachineList.Items.Clear();
				foreach (var machine in DistinctItems)
				{
					MachineList.Items.Add(machine.MachineID);
				}
				metroComboBox1.Items.Clear();
				List<Operation> IlotGrpOFOP = OperationDBO.GetOperationDataGrp(GrpPick.SelectedItem.ToString());
				foreach (Operation c in IlotGrpOFOP)
					metroComboBox1.Items.Add(c.OperationID);
			}
			else
				MessageBox.Show("select a year");
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
				if (float.Parse(row.Cells[3].Value.ToString()) > 0)
					row.Cells[3].Style.BackColor = System.Drawing.Color.GreenYellow;
				else if (float.Parse(row.Cells[3].Value.ToString()) < 0)
					row.Cells[3].Style.BackColor = System.Drawing.Color.OrangeRed;
			}
		}

		public async Task upGraph()
		{
			try
			{
				il = IlotDBO.GetIlot(IlotPick.SelectedItem.ToString());
				
				op = OperatorsDBO.GetOperators(GrpPick.SelectedItem.ToString(), int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
				OP = OpGroupeDBO.ListOPParGRP(GrpPick.SelectedItem.ToString());

				List<Demande> dmm = new List<Demande>();
				dmm1 = new List<Demande>();
				foreach (ManuelCycleTime optest in OP)
				{
					dmm = (DemandeDBO.GetProductDemande(optest.ProductID, int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
					dmm1.AddRange(dmm);

				}

				List<Charge> ChTot = new List<Charge>();
				Charge cr;
				ChargePo = OP;
				dataGridView1.DataSource = OP;
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
				var newList =
		(
		from x in ChTot
		select new { annee = x.annee, product = x.product, semaine = x.semaine,ChargT=x.ChargT }
		).Distinct().ToList();

				
				//	dataGridView1.newList = ChTot;
				var query1 = newList.Where(person => person.annee == int.Parse(DataPick.SelectedItem.ToString())).ToList();
				
				var LL = query1.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value = t.Sum(u => u.ChargT) }).ToList();
				chartStats.Series.Clear();
				chart1.Series.Clear(); PerCV.Clear();
				Capa.Clear();
				xValues.Clear();
				yValues.Clear();
				foreach (var item in LL)
				{
					xValues.Add(item.ID);
					yValues.Add(item.Value + ((il.CRM) / 100) * item.Value);

				}
				foreach (Operators opo in op)
				{
					Capa.Add(opo.NumberOfOperator * (il.Efficiency / 100) * (1 - (il.IlotRejectedRate / 100)) * (1 - (il.TruancyRate / 100)) * 7.67f *opo.DayOfWorking);

				}
				List<BesoinOP> br = new List<BesoinOP>();
				BesoinOP brr; List<int> NbrEff = new List<int>();
				NbrEff.Clear();
			
				for (int i = 0; i < yValues.Count; i++)
				{
					if (Capa[i] != 0)
						PerCV.Add(Math.Round(yValues[i] / Capa[i], 2) * 100);
					else
						PerCV.Add(0);
					if (!(op[i].NumberOfOperator == 0) || yValues[i] != 0)
						brr = new BesoinOP
						{
							WeekWork = xValues[i],
							ActualCharge = Math.Round(yValues[i], 2),
							AcutalCapa = Math.Round(Capa[i], 2),
							BesoinH = Math.Round((Capa[i] - yValues[i]), 2),
							NbrOp = op[i].NumberOfOperator,

							OpNeed = Math.Round(yValues[i] / (op[i].DayOfWorking * (il.Efficiency / 100) * (1 - (il.IlotRejectedRate / 100)) * (1 - (il.TruancyRate / 100)) * 7.67f), 2),

						};
					else
						brr = new BesoinOP
						{
							WeekWork = xValues[i],
							ActualCharge = yValues[i],
							AcutalCapa = Capa[i],
							BesoinH = (Math.Round((Capa[i] - yValues[i]), 2)),
							NbrOp = op[i].NumberOfOperator,

							OpNeed = 0,
						};


					br.Add(brr);
					if (brr.OpNeed <= 0)
						NbrEff.Add(0);

					else if (brr.OpNeed > 0)
						NbrEff.Add((int)Math.Truncate(brr.OpNeed) + 1);
					else
						NbrEff.Add(0);

				}

				label4.Text =  Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString()+
					" H/semaine";
				label2.Text = Math.Round(br.Select(r => r.ActualCharge).Average(), 2).ToString() + " H/semaine";
				label5.Text = Math.Round(br.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
					if (br.Select(r => r.BesoinH).Average() > 0)
						label5.ForeColor = System.Drawing.Color.Green;
					else
						label5.ForeColor = System.Drawing.Color.Red;

				var series = new Series()
				{
					ChartType = SeriesChartType.Column,
					Color = Color.FromArgb(93, 138, 168),
					IsVisibleInLegend = true,

					Name = "Charge",
					LegendText = "Charge",

				};
				var RatioChargeCapa = new Series()
				{
					ChartType = SeriesChartType.Line,
					Color = Color.FromArgb(93, 138, 168),
					IsVisibleInLegend = true,
					IsValueShownAsLabel = true,
					Name = "RatioChargeCapa",
					LegendText = "RatioChargeCapa",
					BorderWidth = 3,

				};
				var series1 = new Series()
				{
					ChartType = SeriesChartType.Line,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,

					Name = "Capa",
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
				chart4.Series.Clear();
				chart4.Series.Add(seriesEff);
				chart4.Series[0].Points.DataBindXY(xValues, NbrEff);

				chartStats.Series.Add(series);
				chartStats.Series.Add(series1);
				chart1.Series.Add(RatioChargeCapa);
				chart1.Series[0].Points.Clear();
				chart1.ChartAreas[0].AxisX.Interval = 1;
				chartStats.ChartAreas[0].AxisX.Interval = 1;
				chartStats.Series[1].Points.Clear();
			

				chart1.Series[0].Points.DataBindXY(xValues, PerCV);
				chartStats.Series[0].Points.DataBindXY(xValues, yValues);
				chartStats.Series[1].Points.DataBindXY(xValues, Capa);
				dataGridView1.DataSource = br;
				//setC();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		List<Operators> op1 =  new List<Operators>();
		List<ManuelCycleTime> OP1 = new List<ManuelCycleTime>();
		List<BesoinOP> brtotal = new List<BesoinOP>();
		public void upGraph1()
		{
			
			
			try
			{
				brtotal.Clear();
				List<Demande> dmm = new List<Demande>();
				List<String> OpList = new List<string>();
			List<Charge> ChTot = new List<Charge>();
			dmm1 = new List<Demande>();
			op1.Clear();OP1.Clear();
				il = IlotDBO.GetIlot(IlotPick.SelectedItem.ToString());
				foreach (string ccname in GrpPick.Items)

				{
					op1.AddRange( OperatorsDBO.GetOperators(ccname, int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
					OP1.AddRange(OpGroupeDBO.ListOPParGRP(ccname));
					dmm.Clear();
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

			var LL = query1.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value = t.Sum(u => u.ChargT) }).ToList();
			int hh = 0;
			xValues.Clear();
			yValues.Clear();
			chartStats.Series.Clear();
			chart1.Series.Clear(); PerCV.Clear();
			foreach (var item in LL)
			{
				xValues.Add(item.ID);
				yValues.Add(item.Value + ((il.CRM) / 100) * item.Value);
				
			}

			Capa.Clear();

			var LL1 = op1.GroupBy(t => t.WeekT).Select(t => new { ID = t.Key, Value = t.Max(u => u.DayOfWorking), Value1 = t.Sum(u => u.NumberOfOperator) }).ToList();
			foreach (var opo in LL1)
			{
				Capa.Add(opo.Value1 * (il.Efficiency / 100) * (1 - (il.IlotRejectedRate / 100)) * (1 - (il.TruancyRate / 100)) * 7.67f * opo.Value);

			}
			
			BesoinOP brr;
				List<int> NbrEff = new List<int>();
				NbrEff.Clear();
				
			for (int i = 0; i < yValues.Count; i++)
			{
				if (Capa[i] != 0)
					PerCV.Add(Math.Round(yValues[i] / Capa[i], 2) * 100);
				else
					PerCV.Add(0);
				if (!(LL1[i].Value==0 ))
					brr = new BesoinOP
					{
						WeekWork = xValues[i],
						ActualCharge = Math.Round(yValues[i],2),
						AcutalCapa = Math.Round(Capa[i],2),
						BesoinH = Math.Round((Capa[i] - yValues[i]),2),
						NbrOp = LL1[i].Value1 ,
						
						OpNeed = Math.Round(yValues[i] / (LL1[i].Value * (il.Efficiency / 100) * (1 - (il.IlotRejectedRate / 100)) * (1 - (il.TruancyRate / 100)) * 7.67f),2)

					};
					else
						brr = new BesoinOP
						{
							WeekWork = xValues[i],
							ActualCharge = yValues[i],
							AcutalCapa = Capa[i],
							BesoinH = (Math.Round((Capa[i] - yValues[i]),2)),
							NbrOp = LL1[i].Value1,

							OpNeed =0,
						};
					brtotal.Add(brr);
					if (brr.OpNeed <= 0)
						NbrEff.Add(0);

					else if (brr.OpNeed > 0)
						NbrEff.Add((int)Math.Truncate(brr.OpNeed) + 1);
					else
						NbrEff.Add(0);

				}

			label4.Text = Math.Round(brtotal.Select(r => r.AcutalCapa).Average(), 2).ToString() +
				" H/semaine";
			label2.Text = Math.Round(brtotal.Select(r => r.ActualCharge).Average(), 2).ToString() + " H/semaine";
			label5.Text = Math.Round(brtotal.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
			if (brtotal.Select(r => r.BesoinH).Average() > 0)
				label5.ForeColor = System.Drawing.Color.Green;
			else
				label5.ForeColor = System.Drawing.Color.Red;

			var series = new Series()
			{
				ChartType = SeriesChartType.Column,
				Color = Color.FromArgb(93, 138, 168),
				IsVisibleInLegend = true,

				Name = "Charge",
				LegendText = "Charge",

			};
				chart4.Series.Clear();
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
				ChartType = SeriesChartType.Line,
				Color = Color.FromArgb(93, 138, 168),
				IsVisibleInLegend = true,
				IsValueShownAsLabel = true,
				Name = "RatioChargeCapa",
				LegendText = "RatioChargeCapa",
				BorderWidth = 3,

			};
			var series1 = new Series()
			{
				ChartType = SeriesChartType.FastLine,
				IsVisibleInLegend = true,
				BorderDashStyle = ChartDashStyle.Solid,
				
				Name = "Capa",
				LegendText = "Capacité",
				BorderWidth = 3,
				Color = Color.FromArgb(255, 126, 0),
			};


			chartStats.Series.Add(series);
			chartStats.Series.Add(series1);
			chart1.Series.Add(RatioChargeCapa);
				chart4.Series.Add(seriesEff);
			chart1.Series[0].Points.Clear();
			chart1.ChartAreas[0].AxisX.Interval = 1;
			chartStats.ChartAreas[0].AxisX.Interval = 1;
			chartStats.Series[1].Points.Clear();
				chart4.ChartAreas[0].AxisX.Interval = 1;
				chart4.Series[0].Points.DataBindXY(xValues, NbrEff);
				chart1.Series[0].Points.DataBindXY(xValues, PerCV);
			chartStats.Series[0].Points.DataBindXY(xValues, yValues);
			chartStats.Series[1].Points.DataBindXY(xValues, Capa);
			dataGridView1.DataSource = brtotal;

				
			}
			catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		}

		public void setTools ()
		{
			try
			{
				List<Tools> toolsList = ToolsDBO.ListToolsOfGrp(metroComboBox1.SelectedItem.ToString());
				List<DemandeOP> AllDem = new List<DemandeOP>();
				List<DemandeOP> OnlyOneDem = new List<DemandeOP>();
				List<ToolsOpenDay> OneTollsOpen = new List<ToolsOpenDay>();
				List<List<ToolsOpenDay>> AllTollsOpen = new List<List<ToolsOpenDay>>();
				foreach (Tools tools in toolsList)
				{
					OneTollsOpen = ToolsDBO.GetToolsOpenDay(tools.ToolsID, System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), int.Parse(DataPick.SelectedItem.ToString()));
					;

					OnlyOneDem = (ToolsDBO.GetDemandeOPTools(tools.ToolsID, System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
					AllDem.AddRange(OnlyOneDem);
					AllTollsOpen.Add(OneTollsOpen);
				}
				dataGridView3.DataSource = AllDem;
				sizeDGV(dataGridView3, panel18);
				//MessageBox.Show("ok");
				var FinaleAllDemande = AllDem.GroupBy(x => new { x.OperationID, x.WeekDem }).Select(y => y.First());
				dataGridView3.DataSource = FinaleAllDemande.ToList();
				sizeDGV(dataGridView3, panel18);
			//	MessageBox.Show("ok");
				var FinaleCharge = FinaleAllDemande.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
				dataGridView3.DataSource = FinaleCharge;
				sizeDGV(dataGridView3, panel18);

				
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
					ChartType = SeriesChartType.FastLine,
					IsVisibleInLegend = true,
					BorderDashStyle = ChartDashStyle.Solid,

					Name = "Capa",
					LegendText = "Capacité",
					BorderWidth = 3,
					Color = Color.FromArgb(255, 126, 0),
				};
				List<int> Xval = new List<int>();
				List<double> chr = new List<double>();
				foreach (var k in FinaleCharge)
				{
					chr.Add(Math.Round((k.Value) + (((il.CRM) / 100) * k.Value), 1));
					Xval.Add(k.ID);
				}
				MachCapa.Clear();
				List<int> inn = new List<int>();
				int longeurList = AllTollsOpen.Count();
				int longeurelement = AllTollsOpen[0].Count();
				ToolsCapa.Clear();
				for (int k = 0; k < longeurelement; k++)
				{
					inn.Clear();
					for (int i = 0; i < longeurList; i++)
					{
						inn.Add(AllTollsOpen[i][k].OpenDay);
					}
					ToolsCapa.Add(inn.Sum() * 24);

				}

				chart3.Series.Clear();
				chart3.Series.Add(series);
				chart3.Series.Add(series1);
				chart3.Series[0].Points.Clear(); chart3.Series[1].Points.Clear();
				chart3.ChartAreas[0].AxisX.Interval = 1;

				chart3.Series[0].Points.DataBindXY(Xval, chr);
				chart3.Series[1].Points.DataBindXY(Xval, ToolsCapa);
				List<Besoin> br = new List<Besoin>();
				Besoin brr;
				for (int i = 0; i < chr.Count; i++)
				{
					PerTools.Add(Math.Round(chr[i] / ToolsCapa[i], 2) * 100);
					brr = new Besoin
					{
						WeekWork = Xval[i],
						ActualCharge = float.Parse(chr[i].ToString()),
						AcutalCapa = float.Parse(ToolsCapa[i].ToString()),
						BesoinH = float.Parse(ToolsCapa[i].ToString()) - float.Parse(chr[i].ToString()),


					}; br.Add(brr);

				}
				label15.Text = Math.Round(br.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
				label17.Text = Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
				label13.Text = Math.Round(br.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
				if (br.Select(r => r.BesoinH).Average() > 0)
					label13.ForeColor = System.Drawing.Color.Green;
				else
					label13.ForeColor = System.Drawing.Color.Red;

				dataGridView3.DataSource = br;
				sizeDGV(dataGridView3, panel18);
				setC(dataGridView3);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void MachineList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (MachineList.SelectedItem.ToString() == "PressePorte1")
				UpPresse1();
			//if (MachineList.SelectedItem.ToString() == "AutoT4")

				//////UpPlym();
			else
			{
				try
				{
					Machine ActMach = MachineDBO.GetMachine(MachineList.SelectedItem.ToString());

					List<DemandeOP> DemO = OperationDBO.GetDemandeOP(MachineList.SelectedItem.ToString(), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), int.Parse(DataPick.SelectedItem.ToString()));
					List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(MachineList.SelectedItem.ToString(),
						System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), int.Parse(DataPick.SelectedItem.ToString()));

					var LL = DemO.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();

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
						BorderWidth = 3,
						Color = Color.FromArgb(255, 126, 0),
					};
					List<int> Xval = new List<int>();
					List<double> chr = new List<double>();
					foreach (var k in LL)
					{
						chr.Add(Math.Round((k.Value) + (((il.CRM) / 100) * k.Value), 1));
						Xval.Add(k.ID);
					}
					MachCapa.Clear();
					foreach (MachineOpenDay k in CapaMach)
					{
						MachCapa.Add(k.NumberOfshift * (1 - (ActMach.MachineRejectedRate / 100)) * 7.67f * k.OpenDay);
					}
					chart2.Series.Clear();
					chart2.Series.Add(series);
					chart2.Series.Add(series1);
					chart2.Series[0].Points.Clear(); chart2.Series[1].Points.Clear();
					chart2.ChartAreas[0].AxisX.Interval = 1;

					chart2.Series[0].Points.DataBindXY(Xval, chr);
					chart2.Series[1].Points.DataBindXY(Xval, MachCapa);
					brMach.Clear();
					BesoinM brr;
					 
					for (int i = 0; i < chr.Count; i++)
					{
						PerCV.Add(Math.Round(chr[i] / MachCapa[i], 2) * 100);
						brr = new BesoinM
						{
							WeekWork = Xval[i],
							ActualCharge = Math.Round(float.Parse(chr[i].ToString()), 2),
							AcutalCapa = Math.Round(float.Parse(MachCapa[i].ToString()), 2),
							BesoinH = Math.Round(float.Parse(MachCapa[i].ToString()) - float.Parse(chr[i].ToString()), 2), Shift = CapaMach[i].NumberOfshift ,OpenDay= CapaMach[i].OpenDay


						}; brMach.Add(brr);

					}
					label9.Text = Math.Round(brMach.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
					label11.Text = Math.Round(brMach.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
					label7.Text = Math.Round(brMach.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
					if (brMach.Select(r => r.BesoinH).Average() > 0)
						label7.ForeColor = System.Drawing.Color.Green;
					else
						label7.ForeColor = System.Drawing.Color.Red;
					dataGridView2.DataSource = brMach;
					sizeDGV(dataGridView2, panel11);
					setC(dataGridView2);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		List<BesoinM> brMach = new List<BesoinM>();
		public void UpPresse1()
		{
			
				Machine ActMach = MachineDBO.GetMachine(MachineList.SelectedItem.ToString());

				List<DemandeOP> DemO = OperationDBO.GetDemandeOP(MachineList.SelectedItem.ToString(), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), int.Parse(DataPick.SelectedItem.ToString()));
				
				List<DemandeOP> Cycle1 = new List<DemandeOP>();
				List<DemandeOP> Cycle2 = new List<DemandeOP>();
			dataGridView2.DataSource = DemO;
			

				var DrapagePorteA320D = DemO.Where(person => person.OperationID == "PolymPorteA320G");
				var DrapagePorteA320G = DemO.Where(person => person.OperationID == "PolymPorteA320D");
				var DrapagePorteOWSA321D = DemO.Where(person => person.OperationID == "PolymPorteOWSD");
				var DrapagePorteOWSA321G = DemO.Where(person => person.OperationID == "PolymPorteOWSG");
				DemandeOP Dem1;
				DemandeOP Dem2;
				int max1;
				int max2;
				for (int i = 0; i < DrapagePorteA320D.ToList().Count; i++)
				{
					max1 = Math.Max(DrapagePorteA320D.ToList()[i].somm, DrapagePorteA320G.ToList()[i].somm);
					Dem1 = new DemandeOP
					{
						CycleTime = DrapagePorteA320D.ToList()[0].CycleTime,
						OperationID = "DrapagePorte",
						somm = max1,
						WeekDem = DrapagePorteA320D.ToList()[i].WeekDem
					}; Cycle1.Add(Dem1);

					max2 = Math.Max(DrapagePorteOWSA321D.ToList()[i].somm, DrapagePorteOWSA321G.ToList()[i].somm);
					Dem2 = new DemandeOP
					{
						CycleTime = DrapagePorteOWSA321G.ToList()[0].CycleTime,
						OperationID = "DrapagePorteOWS",
						somm = max2,
						WeekDem = DrapagePorteOWSA321G.ToList()[i].WeekDem
					}; Cycle2.Add(Dem2);



				}
				List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(MachineList.SelectedItem.ToString(),
					System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday),int.Parse(DataPick.SelectedItem.ToString()));



				var Chgarge1 = Cycle1.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
				var Chgarge2 = Cycle2.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();

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
					BorderWidth = 3,
					Color = Color.FromArgb(255, 126, 0),
				};
				List<int> Xval = new List<int>();
				List<double> chr = new List<double>();
				int ind = 0;
				for (int i = 0; i < Chgarge1.Count; i++)
				{
					chr.Add(Math.Round(((Chgarge1[i].Value) + (Chgarge2[i].Value)) + (((il.CRM) / 100) * ((Chgarge1[i].Value) + (Chgarge2[i].Value))), 1));
					Xval.Add(Chgarge2[i].ID);

				}

				MachCapa.Clear();
				foreach (MachineOpenDay k in CapaMach)
				{
					MachCapa.Add(k.NumberOfshift * (1 - (ActMach.MachineRejectedRate / 100)) * 7.67f * k.OpenDay);
				}
				chart2.Series.Clear();
				chart2.Series.Add(series);
				chart2.Series.Add(series1);
				chart2.Series[0].Points.Clear(); chart2.Series[1].Points.Clear();
				chart2.ChartAreas[0].AxisX.Interval = 1;

				chart2.Series[0].Points.DataBindXY(Xval, chr);
				chart2.Series[1].Points.DataBindXY(Xval, MachCapa);
				List<Besoin> brt = new List<Besoin>();
				Besoin brr;
				for (int i = 0; i < chr.Count; i++)
				{
					PerCV.Add(Math.Round(chr[i] / MachCapa[i], 2) * 100);
					brr = new Besoin
					{
						WeekWork = Xval[i],
						ActualCharge =Math.Round( float.Parse(chr[i].ToString()),2),
						AcutalCapa = Math.Round(float.Parse(MachCapa[i].ToString()),2),
						BesoinH = Math.Round(float.Parse(MachCapa[i].ToString()) - float.Parse(chr[i].ToString()),2)


					}; brt.Add(brr);

				}
				label9.Text = Math.Round(brt.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
				label11.Text = Math.Round(brt.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
				label7.Text = Math.Round(brt.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
				if (brt.Select(r => r.BesoinH).Average() > 0)
					label7.ForeColor = System.Drawing.Color.Green;
				else
					label7.ForeColor = System.Drawing.Color.Red;
				dataGridView2.DataSource = brt;
				sizeDGV(dataGridView2, panel11);
				setC(dataGridView2);
		


		}
		/*
		public void UpPlym()
		{

			Machine ActMach = MachineDBO.GetMachine(MachineList.SelectedItem.ToString());

			List<DemandeOP> DemO = OperationDBO.GetDemandeOP(MachineList.SelectedItem.ToString(), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), int.Parse(DataPick.SelectedItem.ToString()));

			List<DemandeOP> CycleNH = new List<DemandeOP>();
			List<DemandeOP> CycleFLT = new List<DemandeOP>();
			List<DemandeOP> CycleA320 = new List<DemandeOP>();
			List<DemandeOP> CycleD3 = new List<DemandeOP>();
			List<DemandeOP> CycleDeco = new List<DemandeOP>();
			List<DemandeOP> Cycleows = new List<DemandeOP>();
			List<DemandeOP> CycleEncS = new List<DemandeOP>();
			List<DemandeOP> CycleEAFT = new List<DemandeOP>();
			List<DemandeOP> CycleH160 = new List<DemandeOP>();
			List<DemandeOP> CycleEC = new List<DemandeOP>();
			dataGridView2.DataSource = DemO;

			
			var NH9044 = DemO.Where(person => person.OperationID == "PlymFlootaNH90AV144");
			var NH9045 = DemO.Where(person => person.OperationID == "PlymFlootaNH90AV145");
			var FlotaARD = DemO.Where(person => person.OperationID == "PlymFlottaARD");
			var FlotaARG = DemO.Where(person =>person.OperationID == "PlymFlottaARG");
			var A320 = DemO.Where(person => person.OperationID == "PolymA320G");
			var A320D = DemO.Where(person =>  person.OperationID == "PolymA320D");
			var D3 = DemO.Where(person => person.OperationID == "PolymD3");
			var DEco26 = DemO.Where(person => person.OperationID == "PolymDeco2+6" );

			var DEco15 = DemO.Where(person => person.OperationID  == "PolymDeco1+5" );
			var DEco37 = DemO.Where(person => person.OperationID == "PolymDeco3+7+11");

			var DEco48 = DemO.Where(person => person.OperationID  == "PolymDeco4+8+10+12");
			var OWS = DemO.Where(person => person.OperationID == "PolymOWSD");
			var OWSG = DemO.Where(person => person.OperationID == "PolymOWSG");
			var EncSerie = DemO.Where(person => person.OperationID == "PolymEncSeries");
			var EAFT6 = DemO.Where(person => person.OperationID == "PolymEAFTAileron106");
			var EAFT7 = DemO.Where(person => person.OperationID == "PolymEAFTAileron107");
			var H160AV = DemO.Where(person => person.OperationID == "PolymH160AV");
			var H160AR = DemO.Where(person => person.OperationID == "PolymH160AR");
			var EC17 = DemO.Where(person => person.OperationID == "PolymEC175_217");
			var EC16 = DemO.Where(person => person.OperationID == "PolymEC175_216");
			var EC15 = DemO.Where(person => person.OperationID == "PolymEC175_215");
			var EC14 = DemO.Where(person => person.OperationID == "PolymEC175_214");
			var EC13 = DemO.Where(person => person.OperationID == "PolymEC175_213");
			MessageBox.Show(EAFT6.ToList().Count.ToString() + "//" + EAFT7.ToList().Count.ToString());
			DemandeOP DemNH44_45;
			DemandeOP DemFLTAR;
			DemandeOP A320Dem;
			DemandeOP D3Dem;
			DemandeOP Deco;
			DemandeOP OWSDem;
			DemandeOP EncSer; DemandeOP EAFTop; DemandeOP H160dem; DemandeOP ECdem;
			int max1;
			int max2;
			for (int i = 0; i < NH9044.ToList().Count; i++)
			{
				max1 = Math.Max(NH9044.ToList()[i].somm, NH9045.ToList()[i].somm);
				DemNH44_45 = new DemandeOP
				{
					CycleTime = NH9044.ToList()[0].CycleTime,
					OperationID = "DrapagePorte",
					somm = max1,
					WeekDem = NH9044.ToList()[i].WeekDem
				}; CycleNH.Add(DemNH44_45);


				max2 = Math.Max(EAFT6.ToList()[i].somm, EAFT7.ToList()[i].somm);
				EAFTop = new DemandeOP
				{
					CycleTime = EAFT6.ToList()[0].CycleTime,
					OperationID = "DrapagePorteOWS",
					somm = max2,
					WeekDem = EAFT6.ToList()[i].WeekDem
				}; CycleEAFT.Add(EAFTop);


				max2 = Math.Max(FlotaARD.ToList()[i].somm, FlotaARG.ToList()[i].somm);
				DemFLTAR = new DemandeOP
				{
					CycleTime = FlotaARD.ToList()[0].CycleTime,
					OperationID = "DrapagePorteOWS",
					somm = max2,
					WeekDem = FlotaARD.ToList()[i].WeekDem
				}; CycleFLT.Add(DemFLTAR);
			/*	max2 = Math.Max(A320.ToList()[i].somm, A320D.ToList()[i].somm);
				A320Dem = new DemandeOP
				{
					CycleTime = A320.ToList()[0].CycleTime,
					OperationID = "DrapageA320",
					somm = max2,
					WeekDem = A320.ToList()[i].WeekDem
				}; CycleA320.Add(A320Dem);
				max2 = (DEco15.ToList()[i].somm + DEco26.ToList()[i].somm + DEco48.ToList()[i].somm);
				Deco = new DemandeOP
				{
					CycleTime = DEco15.ToList()[0].CycleTime,
					
					OperationID = "deco",
					somm = (int)Math.Truncate(max2 * 0.25f+1),
					WeekDem = DEco15.ToList()[i].WeekDem
				}; CycleDeco.Add(Deco);

				max2 = (EC13.ToList()[i].somm + EC14.ToList()[i].somm + EC15.ToList()[i].somm + EC16.ToList()[i].somm + EC17.ToList()[i].somm);
				ECdem = new DemandeOP
				{
					CycleTime = EC13.ToList()[0].CycleTime,

					OperationID = "deco",
					somm = max2,
					WeekDem = EC13.ToList()[i].WeekDem
				}; CycleEC.Add(ECdem);


				max2 = (OWS.ToList()[i].somm + OWSG.ToList()[i].somm);
				OWSDem = new DemandeOP
				{
					CycleTime = OWS.ToList()[0].CycleTime,

					OperationID = "ows",
					somm = (int)Math.Truncate(max2 * 0.25f + 1),
					WeekDem = OWS.ToList()[i].WeekDem
				}; Cycleows.Add(OWSDem);

				max2 = (H160AR.ToList()[i].somm + H160AV.ToList()[i].somm);
				H160dem = new DemandeOP
				{
					CycleTime = H160AR.ToList()[0].CycleTime,

					OperationID = "h160",
					somm = (int)Math.Truncate(max2 * 0.5f + 1),
					WeekDem = H160AR.ToList()[i].WeekDem
				}; CycleH160.Add(H160dem);

				D3Dem = new DemandeOP
				{
					CycleTime = D3.ToList()[0].CycleTime,
					OperationID = "DrapageA320",
					somm = D3.ToList()[0].somm,
					WeekDem = D3.ToList()[i].WeekDem
				}; CycleD3.Add(D3Dem);
			/*	EncSer = new DemandeOP
				{
					CycleTime = EncSerie.ToList()[0].CycleTime,
					OperationID = "encserie",
					somm = (int)Math.Truncate(EncSerie.ToList()[0].somm * 0.25f + 1),
					
					WeekDem = EncSerie.ToList()[i].WeekDem
				}; CycleEncS.Add(EncSer);

			}
			List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(MachineList.SelectedItem.ToString(),
				System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), int.Parse(DataPick.SelectedItem.ToString()));



			var Chgarge1 = CycleNH.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			var Chgarge2 = CycleFLT.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			//var Chgarge3 = CycleA320.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			var Chgarge4 = CycleD3.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			var Chgarge5 = CycleDeco.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			var Chgarge6 = Cycleows.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			//var Chgarge7 = CycleEncS.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			var Chgarge8 = CycleEAFT.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			var Chgarge9 = CycleH160.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
			var Chgarge10 = CycleEC.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();

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

				Name = "Capa",
				LegendText = "Capacité",
				BorderWidth = 3,
				Color = Color.FromArgb(255, 126, 0),
			};
			List<int> Xval = new List<int>();
			List<double> chr = new List<double>();
			int ind = 0;
			for (int i = 0; i < Chgarge1.Count; i++)
			{
				chr.Add(Math.Round(((Chgarge1[i].Value)+ /*(Chgarge7[i].Value)+ (Chgarge10[i].Value) + (Chgarge9[i].Value) + (Chgarge8[i].Value) + (Chgarge5[i].Value)+ (Chgarge6[i].Value)+(Chgarge4[i].Value) + (Chgarge2[i].Value) ) + (((il.CRM) / 100) * ( + (Chgarge9[i].Value)+(Chgarge8[i].Value) + (Chgarge6[i].Value)+(Chgarge5[i].Value) + (Chgarge10[i].Value) +  (Chgarge4[i].Value) + (Chgarge1[i].Value) + (Chgarge2[i].Value))), 1));
				Xval.Add(Chgarge2[i].ID);

			}

			MachCapa.Clear();
			foreach (MachineOpenDay k in CapaMach)
			{
				MachCapa.Add(k.NumberOfshift * (1 - (ActMach.MachineRejectedRate / 100)) * 7.67f * k.OpenDay);
			}
			chart2.Series.Clear();
			chart2.Series.Add(series);
			chart2.Series.Add(series1);
			chart2.Series[0].Points.Clear(); chart2.Series[1].Points.Clear();
			chart2.ChartAreas[0].AxisX.Interval = 1;

			chart2.Series[0].Points.DataBindXY(Xval, chr);
			chart2.Series[1].Points.DataBindXY(Xval, MachCapa);
			List<Besoin> brt = new List<Besoin>();
			Besoin brr;
			for (int i = 0; i < chr.Count; i++)
			{
				PerCV.Add(Math.Round(chr[i] / MachCapa[i], 2) * 100);
				brr = new Besoin
				{
					WeekWork = Xval[i],
					ActualCharge = Math.Round(float.Parse(chr[i].ToString()), 2),
					AcutalCapa = Math.Round(float.Parse(MachCapa[i].ToString()), 2),
					BesoinH = Math.Round(float.Parse(MachCapa[i].ToString()) - float.Parse(chr[i].ToString()), 2)


				}; brt.Add(brr);

			}
			label9.Text = Math.Round(brt.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
			label11.Text = Math.Round(brt.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
			label7.Text = Math.Round(brt.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
			if (brt.Select(r => r.BesoinH).Average() > 0)
				label7.ForeColor = System.Drawing.Color.Green;
			else
				label7.ForeColor = System.Drawing.Color.Red;
			dataGridView2.DataSource = brt;
			sizeDGV(dataGridView2, panel11);
			setC(dataGridView2);

	

		}
	
		*/
		private void materialFlatButton1_Click(object sender, EventArgs e)
		{
			setTools();
		}

		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			setTools();
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{/*
			Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
			// creating new WorkBook within Excel application  
			Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
			// creating new Excelsheet in workbook  
			Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
			// see the excel sheet behind the program  
			app.Visible = true;
			// get the reference of first sheet. By default its name is Sheet1.  
			// store its reference to worksheet  
			worksheet = workbook.Sheets["Sheet1"];
			worksheet = workbook.ActiveSheet;
			// changing the name of active sheet  
			worksheet.Name = "Exported from gridview";
			// storing header part in Excel  
			for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
			{
				worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
			}
			// storing Each row and column value to excel sheet  
			for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
			{
				for (int j = 0; j < dataGridView1.Columns.Count; j++)
				{
					worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
				}
			}
			// save the application  
			workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			// Exit from the application  
		*/}

		public static void GenerateExcel(DataTable dataTable, DataTable dataTable1, string path)
		{
			DataSet dataSet = new DataSet(); DataSet dataSet1 = new DataSet();
			dataSet.Tables.Add(dataTable);
			dataSet1.Tables.Add(dataTable1);

			// create a excel app along side with workbook and worksheet and give a name to it
			Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
			Microsoft.Office.Interop.Excel.Workbook excelWorkBook = excelApp.Workbooks.Add();
			Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = excelWorkBook.Sheets[1];
			Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
			foreach (DataTable table in dataSet.Tables)
			{
				//Add a new worksheet to workbook with the Datatable name
				Microsoft.Office.Interop.Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
				excelWorkSheet.Name = table.TableName;

				// add all the columns
				for (int i = 1; i < table.Columns.Count + 1; i++)
				{
					excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
				}

				// add all the rows
				for (int j = 0; j < table.Rows.Count; j++)
				{
					for (int k = 0; k < table.Columns.Count; k++)
					{
						excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
					}
				}
			}
			foreach (DataTable table in dataSet1.Tables)
			{
				//Add a new worksheet to workbook with the Datatable name
				Microsoft.Office.Interop.Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
				excelWorkSheet.Name = table.TableName;

				// add all the columns
				for (int i = 1; i < table.Columns.Count + 1; i++)
				{
					excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
				}

				// add all the rows
				for (int j = 0; j < table.Rows.Count; j++)
				{
					for (int k = 0; k < table.Columns.Count; k++)
					{
						excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
					}
				}
			}
			excelWorkBook.SaveAs(path);
			excelWorkBook.Close();
			excelApp.Quit();
		}

		static DataTable ConvertToDataTable<T>(List<T> models)
		{
			DataTable dataTable = new DataTable(typeof(T).Name);

			//Get all the properties
			PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

			// Loop through all the properties            
			// Adding Column to our datatable
			foreach (PropertyInfo prop in Props)
			{
				//Setting column names as Property names  
				dataTable.Columns.Add(prop.Name);
			}
			// Adding Row
			foreach (T item in models)
			{
				var values = new object[Props.Length];
				for (int i = 0; i < Props.Length; i++)
				{
					//inserting property values to datatable rows  
					values[i] = Props[i].GetValue(item, null);
				}
				// Finally add value to datatable  
				dataTable.Rows.Add(values);
			}
			return dataTable;
		}
		

		private void button1_Click(object sender, EventArgs e)
		{
			string input =
	 Interaction.InputBox("File name ?",
												 "The Title",
												 "Desired Default",
												 -1, -1);
			GenerateExcel(ConvertToDataTable(brtotal), ConvertToDataTable(ChargePo), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + input);

		}

		private void button2_Click(object sender, EventArgs e)
		{
		
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			string input =
	 Interaction.InputBox("File name ?",
												 "The Title",
												 "Desired Default",
												 -1, -1);
			GenerateExcel(ConvertToDataTable(brMach), ConvertToDataTable(ChargePo), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + input);
		}
	}

}