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
			List<Ilot> il = IlotDBO.GetAllIlot();
			foreach (Ilot u in il)
			{// MessageBox.Show(u.IlotID);

				metroComboBox1.Items.Add(u.IlotID);
			}

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
		List<Operation> ChargePo;
		List<MachineCycleTime> OpMach;
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (YearSelect.SelectedIndex > -1)
			{
				metroComboBox2.Items.Clear();
				List<OpGroupe> IlotGrpOFOP = IlotDBO.IlotOpgrp(metroComboBox1.SelectedItem.ToString());
				foreach (OpGroupe o in IlotGrpOFOP)
					metroComboBox2.Items.Add(o.GrpName);

			}

		}
		List<int> xValues = new List<int>();
		List<float> yValues = new List<float>();
		List<float> Capa = new List<float>();
		List<double> PerCV = new List<double>();
		List<double> MachCapa = new List<double>();
		List<Operators> op;
		List<Operation> OP;
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
				{ PerCV.Add(Math.Round(yValues[i] / Capa[i], 2) * 100);
					brr = new Besoin 
					{WeekWork=xValues[i],
					ActualCharge=yValues[i],
					AcutalCapa=Capa[i],
					BesoinH= (Capa[i] - yValues[i]) ,


					};br.Add(brr);
				
				}
				brr = new Besoin
				{
					WeekWork = br[(br.Count)-1].WeekWork+1,
					ActualCharge =br.Select(r=>r.ActualCharge).Average(),
					AcutalCapa = br.Select(r => r.AcutalCapa).Average(),
					BesoinH = br.Select(r => r.BesoinH).Average(),


				}; br.Add(brr);
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
		private void metroGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			
		}

		private void MachineList_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Machine ActMach = MachineDBO.GetMachine(MachineList.SelectedItem.ToString());

				List<DemandeOP> DemO = OperationDBO.GetDemandeOP(MachineList.SelectedItem.ToString());
				List<MachineOpenDay> CapaMach = MachineDBO.GetMachineShiftCalen(MachineList.SelectedItem.ToString(), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), Convert.ToInt32(YearSelect.SelectedItem));

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
					chr.Add(Math.Round((k.Value)  +(((il.CRM) / 100) * k.Value), 1));
					Xval.Add(k.ID);
				}
				MachCapa.Clear();
				foreach (MachineOpenDay k in CapaMach)
				{
					MachCapa.Add(k.NumberOfshift * (il.Efficiency / 100) * (1 - (ActMach.MachineRejectedRate / 100)) * (1 - (il.TruancyRate / 100)) * 7.67f * 3);
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
						BesoinH = float.Parse(MachCapa[i].ToString())- float.Parse(chr[i].ToString()),


					}; br.Add(brr);

				}
				brr = new Besoin
				{
					WeekWork = br[(br.Count) - 1].WeekWork + 1,
					ActualCharge = br.Select(r => r.ActualCharge).Average(),
					AcutalCapa = br.Select(r => r.AcutalCapa).Average(),
					BesoinH = br.Select(r => r.BesoinH).Average(),


				}; br.Add(brr);
				metroGrid2.DataSource = br;
				setB();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
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
			foreach (Operation oper in OP)
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
	}
}
