using BEL;
using DAL;
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
				//Thread thread = new Thread(upGraph);thread.Join();

				
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
				if (float.Parse(row.Cells[3].Value.ToString()) >= 0)
					row.Cells[3].Style.BackColor = System.Drawing.Color.Green;
				else
					row.Cells[3].Style.BackColor = System.Drawing.Color.Red;
			}
		}
	
		public async Task upGraph()
		{
			try
			{
				il = IlotDBO.GetIlot(IlotPick.SelectedItem.ToString());
				//List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(il.IlotID);
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
				List<Besoin> br = new List<Besoin>();
				Besoin brr;
				for (int i = 0; i < yValues.Count; i++)
				{
					if (Capa[i] != 0)
						PerCV.Add(Math.Round(yValues[i] / Capa[i], 2) * 100);
					else
						PerCV.Add(0);

					brr = new Besoin
					{
						WeekWork = xValues[i],
						ActualCharge = yValues[i],
						AcutalCapa = Capa[i],
						BesoinH = (Capa[i] - yValues[i]),

						NbrOp = op[i].NumberOfOperator ,
					}; br.Add(brr);

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
					ChartType = SeriesChartType.Spline,
					Color = Color.FromArgb(93, 138, 168),
					IsVisibleInLegend = true,
					IsValueShownAsLabel = true,
					Name = "RatioChargeCapa",
					LegendText = "RatioChargeCapa",
					BorderWidth = 3,

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
		public void upGraph1()
		{
			
			
			try
			{
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
			List<Besoin> br = new List<Besoin>();
			Besoin brr;
			for (int i = 0; i < yValues.Count; i++)
			{
				if (Capa[i] != 0)
					PerCV.Add(Math.Round(yValues[i] / Capa[i], 2) * 100);
				else
					PerCV.Add(0);

					brr = new Besoin
					{
						WeekWork = xValues[i],
						ActualCharge = yValues[i],
						AcutalCapa = Capa[i],
						BesoinH = (Capa[i] - yValues[i]),
						NbrOp = LL1[i].Value1 ,


				}; br.Add(brr);

			}

			label4.Text = Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString() +
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
				ChartType = SeriesChartType.Spline,
				Color = Color.FromArgb(93, 138, 168),
				IsVisibleInLegend = true,
				IsValueShownAsLabel = true,
				Name = "RatioChargeCapa",
				LegendText = "RatioChargeCapa",
				BorderWidth = 3,

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
					List<Besoin> br = new List<Besoin>();
					Besoin brr;
					for (int i = 0; i < chr.Count; i++)
					{
						PerCV.Add(Math.Round(chr[i] / MachCapa[i], 2) * 100);
						brr = new Besoin
						{
							WeekWork = Xval[i],
							ActualCharge = float.Parse(chr[i].ToString()),
							AcutalCapa = float.Parse(MachCapa[i].ToString()),
							BesoinH = float.Parse(MachCapa[i].ToString()) - float.Parse(chr[i].ToString()),


						}; br.Add(brr);

					}
					label9.Text = Math.Round(br.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
					label11.Text = Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
					label7.Text = Math.Round(br.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
						if (br.Select(r => r.BesoinH).Average() > 0)
							label7.ForeColor = System.Drawing.Color.Green;
						else
							label7.ForeColor = System.Drawing.Color.Red;
					dataGridView2.DataSource = br;
					sizeDGV(dataGridView2, panel11);
					setC(dataGridView2);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		public void UpPresse1()
		{
			try
			{
				Machine ActMach = MachineDBO.GetMachine(MachineList.SelectedItem.ToString());

				List<DemandeOP> DemO = OperationDBO.GetDemandeOP(MachineList.SelectedItem.ToString(), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), int.Parse(DataPick.SelectedItem.ToString()));
				MessageBox.Show(DemO[5].CycleTime.ToString());
				List<DemandeOP> Cycle1 = new List<DemandeOP>();
				List<DemandeOP> Cycle2 = new List<DemandeOP>();


				var DrapagePorteA320D = DemO.Where(person => person.OperationID == "DrapagePorteA320D");
				var DrapagePorteA320G = DemO.Where(person => person.OperationID == "DrapagePorteA320G");
				var DrapagePorteOWSA321D = DemO.Where(person => person.OperationID == "DrapagePorteOWSA321D");
				var DrapagePorteOWSA321G = DemO.Where(person => person.OperationID == "DrapagePorteOWSA321G");
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
					//                                            //                         //
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
				List<Besoin> br = new List<Besoin>();
				Besoin brr;
				for (int i = 0; i < chr.Count; i++)
				{
					PerCV.Add(Math.Round(chr[i] / MachCapa[i], 2) * 100);
					brr = new Besoin
					{
						WeekWork = Xval[i],
						ActualCharge = float.Parse(chr[i].ToString()),
						AcutalCapa = float.Parse(MachCapa[i].ToString()),
						BesoinH = float.Parse(MachCapa[i].ToString()) - float.Parse(chr[i].ToString()),


					}; br.Add(brr);

				}
				label9.Text = Math.Round(br.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
				label11.Text = Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
				label7.Text = Math.Round(br.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
				if (br.Select(r => r.BesoinH).Average() > 0)
					label7.ForeColor = System.Drawing.Color.Green;
				else
					label7.ForeColor = System.Drawing.Color.Red;
				dataGridView2.DataSource = br;
				sizeDGV(dataGridView2, panel11);
				setC(dataGridView2);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void materialFlatButton1_Click(object sender, EventArgs e)
		{
			setTools();
		}

		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			setTools();
		}
	}

}