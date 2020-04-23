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
	public partial class Off : Form//MetroFramework.Forms.MetroForm
	{
		public Off()
		{
			InitializeComponent();
		}

		private void Off_Load(object sender, EventArgs e)
		{
			this.chartStats.Titles.Add("Charge/Capacité Humain");
			List<Ilot> il = IlotDBO.GetAllIlot();
			foreach (Ilot u in il)
			{// MessageBox.Show(u.IlotID);

				metroComboBox1.Items.Add(u.IlotID);
			}

		}
		public float GetTC(List<ManuelCycleTime> ChargePo, string id)
		{
			float C = 0;
			foreach (ManuelCycleTime Tc in ChargePo)
			{
				if (Tc.ProductID == id)
					 C+=Tc.ManuelCycleTimeT;
			}
			return C;
		}

		public float GetTCmach(List<MachineCycleTime> ChargePo, string id)
		{
			float C = 0;
			foreach (MachineCycleTime Tc in ChargePo)
			{
				if (Tc.OperationID == id)
					C += Tc.CycleTime;
			}
			return C;
		}
		List<ManuelCycleTime> ChargePo;
		List<MachineCycleTime> OpMach;
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (YearSelect.SelectedIndex > -1)
			{
				metroComboBox2.Items.Clear();
				List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(metroComboBox1.SelectedItem.ToString());
				var DistinctItems = IlotGrpOFOP.Select(x => x.GrpName).Distinct();
				foreach (var o in DistinctItems)
					metroComboBox2.Items.Add(o.ToString());

			}

		}
		List<int> xValues = new List<int>();
		List<float> yValues = new List<float>();
		List<float> Capa = new List<float>();
		List<double> PerCV = new List<double>();
		List<double> PerTools = new List<double>();
		List<double> MachCapa = new List<double>();
		List<double>ToolsCapa = new List<double>();
		List<Operators> op;
		List<ManuelCycleTime> OP;
		List<Demande> dmm1;
		Ilot il;
		public void upGraph ()
		{
			try
			{
				 il = IlotDBO.GetIlot(metroComboBox1.SelectedItem.ToString());
				List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(il.IlotID);
	op = OperatorsDBO.GetOperators(metroComboBox2.SelectedItem.ToString(),Convert.ToInt32(YearSelect.SelectedItem), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
				OP = OpGroupeDBO.ListOPParGRP(metroComboBox2.SelectedItem.ToString());
				
				List<Demande> dmm = new List<Demande>();
				dmm1 = new List<Demande>();
				foreach (ManuelCycleTime optest in OP)
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
			chart1.Series.Clear();PerCV.Clear();
				Capa.Clear();
				xValues.Clear();
				yValues.Clear();
				foreach (var item in LL)
				{
					xValues.Add(item.ID);
					yValues.Add(item.Value + ((il.CRM) / 100) *item.Value);
					
				}
				foreach(Operators opo in op)
				{
					Capa.Add(opo.NumberOfOperator * (il.Efficiency/100) * (1 - (il.IlotRejectedRate/100)) * (1 - (il.TruancyRate/100)) * 7.67f * 5);
				
			}
				List<Besoin> br = new List<Besoin>();
				Besoin brr;
				for (int i = 0; i < yValues.Count; i++)
				{ if (Capa[i] != 0)
						PerCV.Add(Math.Round(yValues[i] / Capa[i], 2) * 100);
					else
						PerCV.Add(0);
				
					brr = new Besoin 
					{WeekWork=xValues[i],
					ActualCharge=yValues[i],
					AcutalCapa=Capa[i],
					BesoinH= (Capa[i] - yValues[i]) ,


					};br.Add(brr);
				
				}
				metroLabel8.Text =Math.Round( br.Select(r => r.ActualCharge).Average(),2).ToString() + "H/semaine";
				metroLabel7.Text = Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
				metroLabel9.Text = Math.Round(br.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
			if (br.Select(r => r.BesoinH).Average() > 0)
				metroLabel9.ForeColor = System.Drawing.Color.Green;
			else
				metroLabel9.ForeColor = System.Drawing.Color.Red;
			
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
				//MessageBox.Show(xValues.Count.ToString() + PerCV.Count.ToString());
				/*	for ( int i =0; i< xValues.Count;i++)
					{
						MessageBox.Show("serie 1 xvalue" + xValues[i].ToString() + " percv = " + PerCV[i].ToString());
						MessageBox.Show("------------" + xValues[i].ToString() + " yValues = " + yValues[i].ToString());
					}*/
				
				chart1.Series[0].Points.DataBindXY(xValues, PerCV);
		chartStats.Series[0].Points.DataBindXY(xValues, yValues);
				chartStats.Series[1].Points.DataBindXY(xValues, Capa);
				metroGrid1.DataSource = br;
				setC();
				
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

		public void setC ()
		{
			foreach (DataGridViewRow row in metroGrid1.Rows)
			{
				if (float.Parse(row.Cells[3].Value.ToString()) >= 0)
					row.Cells[3].Style.BackColor = System.Drawing.Color.Green;
				else 
					row.Cells[3].Style.BackColor = System.Drawing.Color.Red;
			}
		}
		public void setB()
		{
			foreach (DataGridViewRow row in metroGrid2.Rows)
			{
				if (float.Parse(row.Cells[3].Value.ToString()) >= 0)
					row.Cells[3].Style.BackColor = System.Drawing.Color.Green;
				else
					row.Cells[3].Style.BackColor = System.Drawing.Color.Red;
			}
		}
		public void setTools()
		{
			foreach (DataGridViewRow row in metroGrid3.Rows)
			{
				if (float.Parse(row.Cells[3].Value.ToString()) >= 0)
					row.Cells[3].Style.BackColor = System.Drawing.Color.Green;
				else
					row.Cells[3].Style.BackColor = System.Drawing.Color.Red;
			}
		}
		private void metroGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			
		}

		private void MachineList_SelectedIndexChanged(object sender, EventArgs e)
		{if (MachineList.SelectedItem.ToString() == "PressePorte1")
				UpPresse1();
			else
			{
				try
				{
					Machine ActMach = MachineDBO.GetMachine(MachineList.SelectedItem.ToString());

					List<DemandeOP> DemO = OperationDBO.GetDemandeOP(MachineList.SelectedItem.ToString(), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
					List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(MachineList.SelectedItem.ToString(),
						System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), Convert.ToInt32(YearSelect.SelectedItem));

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
					metroLabel11.Text = Math.Round(br.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
					metroLabel12.Text = Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
					metroLabel10.Text = Math.Round(br.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
					if (br.Select(r => r.BesoinH).Average() > 0)
						metroLabel10.ForeColor = System.Drawing.Color.Green;
					else
						metroLabel10.ForeColor = System.Drawing.Color.Red;
					metroGrid2.DataSource = br;
					setB();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			upGraph();
			setC();
			
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
			
			setB();
		}

		private void metroLabel1_Click(object sender, EventArgs e)
		{

		}

		private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{ try
			{
				List<Tools> toolsList = ToolsDBO.ListToolsOfGrp(metroComboBox2.SelectedItem.ToString());
				List<DemandeOP> AllDem =new List<DemandeOP>();
				List < DemandeOP > OnlyOneDem = new List<DemandeOP>();
				List<ToolsOpenDay> OneTollsOpen = new List<ToolsOpenDay>();
				List<List<ToolsOpenDay>> AllTollsOpen = new List<List<ToolsOpenDay>>();
				foreach (Tools tools in toolsList)
				{
					OneTollsOpen = ToolsDBO.GetToolsOpenDay(tools.ToolsID, System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), Convert.ToInt32(YearSelect.SelectedItem));
					;

					OnlyOneDem = (ToolsDBO.GetDemandeOPTools(tools.ToolsID, System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)));
					AllDem.AddRange(OnlyOneDem);
					AllTollsOpen.Add(OneTollsOpen);
				}

				var FinaleAllDemande = AllDem.GroupBy(x =>new { x.OperationID, x.WeekDem }).Select(y => y.First());
				var FinaleCharge = FinaleAllDemande.GroupBy(t => t.WeekDem).Select(t => new { ID = t.Key, Value = t.Sum(u => u.CycleTime * u.somm) }).ToList();
				

					
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
				metroLabel17.Text = Math.Round(br.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
				metroLabel18.Text = Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
				metroLabel16.Text = Math.Round(br.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
				if (br.Select(r => r.BesoinH).Average() > 0)
					metroLabel16.ForeColor = System.Drawing.Color.Green;
				else
					metroLabel16.ForeColor = System.Drawing.Color.Red;

				metroGrid3.DataSource = br;
			setTools(); 
				
					
					
				
				
					
					
			}
		catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void UpPresse1 ()
		{
			try
			{
				Machine ActMach = MachineDBO.GetMachine(MachineList.SelectedItem.ToString());

				List<DemandeOP> DemO = OperationDBO.GetDemandeOP(MachineList.SelectedItem.ToString(), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
				MessageBox.Show(DemO[5].CycleTime.ToString());
				List<DemandeOP> Cycle1=new List<DemandeOP>();
				List<DemandeOP> Cycle2= new List<DemandeOP>();
	

				var DrapagePorteA320D = DemO.Where(person => person.OperationID == "DrapagePorteA320D");
				var DrapagePorteA320G = DemO.Where(person => person.OperationID == "DrapagePorteA320G");
				var DrapagePorteOWSA321D = DemO.Where(person => person.OperationID == "DrapagePorteOWSA321D");
				var DrapagePorteOWSA321G = DemO.Where(person => person.OperationID == "DrapagePorteOWSA321G");
				DemandeOP Dem1;
				DemandeOP Dem2;
				int max1;
				int max2;
				for (int i = 0; i < DrapagePorteA320D.ToList().Count; i++)
				{ max1 = Math.Max(DrapagePorteA320D.ToList()[i].somm, DrapagePorteA320G.ToList()[i].somm);
					Dem1 = new DemandeOP
					{ CycleTime = DrapagePorteA320D.ToList()[0].CycleTime ,
					OperationID = "DrapagePorte",
					somm=max1,
					WeekDem= DrapagePorteA320D.ToList()[i].WeekDem
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
				List <MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(MachineList.SelectedItem.ToString(),
					System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), Convert.ToInt32(YearSelect.SelectedItem));
				


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
				for(int i =0; i< Chgarge1.Count;i++)
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
				metroLabel11.Text = Math.Round(br.Select(r => r.ActualCharge).Average(), 2).ToString() + "H/semaine";
				metroLabel12.Text = Math.Round(br.Select(r => r.AcutalCapa).Average(), 2).ToString() + "H/semaine";
				metroLabel10.Text = Math.Round(br.Select(r => r.BesoinH).Average(), 2).ToString() + "H/semaine";
				if (br.Select(r => r.BesoinH).Average() > 0)
					metroLabel10.ForeColor = System.Drawing.Color.Green;
				else
					metroLabel10.ForeColor = System.Drawing.Color.Red;
				metroGrid2.DataSource = br;
				
				setB();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
