using BEL;
using DAL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        List<int> formation = new List<int>();
        List<int> chomzge = new List<int>();
        List<int> mater = new List<int>();

        List<IlotOp> ilotOps = new List<IlotOp>();
        public void sizeDGV(DataGridView dgv, Panel pan)
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
        List<double> ToolsCapa = new List<double>(); List<GetDATA> GetDATA = new List<GetDATA>();
        List<BesoinOP> br = new List<BesoinOP>();
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
                    row.Cells[3].Style.BackColor = System.Drawing.Color.GreenYellow;
                else
                    row.Cells[3].Style.BackColor = System.Drawing.Color.OrangeRed;
            }
        }

        List<Charge> chargeRu = new List<Charge>();
        List<Charge> CapaRu = new List<Charge>();
        List<Operators> op1 = new List<Operators>();
        List<ManuelCycleTime> OP1 = new List<ManuelCycleTime>();

        public void upGraphRU()
        {





            CapaRu.Clear();
            chargeRu.Clear();
            Capa.Clear();
            List<int> nbrop = new List<int>();
            //try
            //{
            List<Demande> dmm = new List<Demande>();
            List<String> OpList = new List<string>();
            List<Charge> ChTot = new List<Charge>();
            dmm1 = new List<Demande>();
            op1.Clear(); OP1.Clear();
            List<Ilot> il = IlotDBO.GetAllIlot();
            List<OpGroupe> IlotGrpOFOP = new List<OpGroupe>();
            foreach (Ilot u in il)



            {
                if (u.IlotID != "07706Plym")
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
                            ChargT = (opo.Value1),
                            semaine = (int)Math.Truncate(opo.value2)
                        };



                        CapaRu.Add(capacite);

                    }


                }
            }


            var LL11 = chargeRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();
            var LL13 = CapaRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();
            // = op1.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();
            var LL12 = CapaRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT * 0.8f * 0.95f * 0.95f * 7.67f * 5) }).ToList();

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



            br.Clear();
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
                        NbrOp = (int)Math.Truncate(LL13[i].Value1),

                        OpNeed = (OpNeed[i]),

                    };
                else
                    brr = new BesoinOP
                    {
                        WeekWork = wkk[i],
                        ActualCharge = Math.Round(chrr[i], 2),
                        AcutalCapa = Math.Round(cpp[i], 2),
                        BesoinH = (Math.Round((cpp[i] - chrr[i]), 2)),
                        NbrOp = (int)Math.Truncate(LL13[i].Value1),

                        OpNeed = 0,
                    };
                br.Add(brr);
            }

            ilotOps.Clear();

            ilotOps = IlotOpDBO.GetIlotOPdata(int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));

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
                Font = new System.Drawing.Font("Times", 16f),
                IsValueShownAsLabel = true,
                Name = "Effectif inscrit",
                LegendText = "Effectif inscrit",
                BorderWidth = 3,
                Color = Color.FromArgb(137, 179, 252),
            };
            var serieeforma = new Series()
            {
                ChartType = SeriesChartType.StackedColumn,
                IsVisibleInLegend = true,
                BorderDashStyle = ChartDashStyle.Solid,
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Times", 16f),
                Name = "Operateur en formation",
                LegendText = "Operateur en formation",
                BorderWidth = 3,
                Color = Color.FromArgb(250, 160, 235),
            };
            var serieechom = new Series()
            {
                ChartType = SeriesChartType.StackedColumn,
                IsVisibleInLegend = true,
                BorderDashStyle = ChartDashStyle.Solid,
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Times", 16f),
                Name = "Operateur en chomage",
                LegendText = "Operateur en chomage",
                BorderWidth = 3,
                Color = Color.FromArgb(252, 206, 137),
            };
            var serieeMat = new Series()
            {
                ChartType = SeriesChartType.StackedColumn,
                IsVisibleInLegend = true,
                BorderDashStyle = ChartDashStyle.Solid,
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Times", 16f),
                Name = "Maternité",
                LegendText = "Maternité",
                BorderWidth = 3,
                Color = Color.FromArgb(236, 255, 119),
            };
            var series = new Series()
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(93, 138, 168),
                Font = new System.Drawing.Font("Times", 16f),

                Name = "Charge",
                LegendText = "Charge",

            };
            var series1 = new Series()
            {
                ChartType = SeriesChartType.Line,
                IsVisibleInLegend = true,
                BorderDashStyle = ChartDashStyle.Solid,
                Font = new System.Drawing.Font("Times", 16f),

                Name = "Capacité",
                LegendText = "Capacité",
                BorderWidth = 3,
                Color = Color.FromArgb(255, 126, 0),
            };
            var seriesEff = new Series()
            {
                Font = new System.Drawing.Font("Times", 16f),
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

            var RatioEff = new Series()
            {
                ChartType = SeriesChartType.Line,
                Color = Color.FromArgb(47, 210, 001),
                IsVisibleInLegend = true,
                Font = new System.Drawing.Font("Times", 16f),

                Name = "Effectifs nécessaires",
                LegendText = "Effectifs nécessaires",
                BorderWidth = 3,

            };
            List<int> EffReel = new List<int>();
            int kj = 0;
            foreach (var op in LL13)
            {


                EffReel.Add((int)Math.Truncate(op.Value1 - formation[kj]));
                kj++;

            }


            chart1.Series.Clear();
            chartStats.Series.Clear();
            chart4.Series.Clear();

            chart4.Series.Add(serieeff); chart4.Series.Add(serieeforma); chart4.Series.Add(serieeMat); chart4.Series.Add(serieechom); chart4.Series.Add(RatioEff);
            chart4.ChartAreas[0].AxisX.Interval = 1;
            chart4.Series[0].Points.DataBindXY(wkk, EffReel); chart4.Series[4].Points.DataBindXY(wkk, OpNeed);
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

            chartStats.ChartAreas[0].AxisY.Title = "Les heures de travail en H";
            chart4.ChartAreas[0].AxisY.Title = "Nombre des operteurs";
            chart1.ChartAreas[0].AxisY.Title = "Ration de %";
            chartStats.Series[1].Points.Clear();
            chart1.Series.Add(RatioChargeCapa);
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.Series[0].Points.DataBindXY(wkk, PerCV);
            chartStats.Series[0].Points.DataBindXY(wkk, chrr);
            chartStats.Series[1].Points.DataBindXY(wkk, cpp);
            dataGridView1.DataSource = br;


            //}
            //catch (Exception ex)
            //{
            //MessageBox.Show(ex.Message);
            //}
        }
        public void upGraph1()
        {





            CapaRu.Clear();
            chargeRu.Clear();
            Capa.Clear();
            //	try
            //{
            List<Demande> dmm = new List<Demande>();
            List<String> OpList = new List<string>();
            List<Charge> ChTot = new List<Charge>();
            dmm1 = new List<Demande>();
            op1.Clear(); OP1.Clear();
            List<Ilot> il = IlotDBO.GetAllIlotAtelier(metroComboBox1.SelectedItem.ToString());
            List<OpGroupe> IlotGrpOFOP = new List<OpGroupe>();
            foreach (Ilot u in il)



            {
                if (u.IlotID != "07006Plym")
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
                            ChargT = (opo.Value1), //* 0.8f * 0.95f * 0.95f * 7.67f * 5
                            semaine = (int)Math.Truncate(opo.value2)
                        };



                        CapaRu.Add(capacite);

                    }


                }
            }


            var LL11 = chargeRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();
            var LL13 = CapaRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT) }).ToList();

            var LL12 = CapaRu.GroupBy(t => t.semaine).Select(t => new { ID = t.Key, Value1 = t.Sum(kk => kk.ChargT * 0.8f * 0.95f * 0.95f * 7.67f * 5) }).ToList();
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



            br.Clear();
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
                        NbrOp = (int)Math.Truncate(LL13[i].Value1),

                        OpNeed = OpNeed[i],

                    };
                else
                    brr = new BesoinOP
                    {
                        WeekWork = wkk[i],
                        ActualCharge = Math.Round(chrr[i], 2),
                        AcutalCapa = Math.Round(cpp[i], 2),
                        BesoinH = (Math.Round((cpp[i] - chrr[i]), 2)),
                        NbrOp = (int)Math.Truncate(LL13[i].Value1),

                        OpNeed = 0,
                    };
                br.Add(brr);


            }
            //Stacked
            ilotOps.Clear();
            ilotOps = IlotOpDBO.GetIlotOPdataAtelier(int.Parse(DataPick.SelectedItem.ToString()), System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday), metroComboBox1.SelectedItem.ToString());

            formation.Clear();
            chomzge.Clear();
            mater.Clear();
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
                Font = new System.Drawing.Font("Times", 16f),
                IsValueShownAsLabel = true,
                Name = "Effectif inscrit",
                LegendText = "Effectif inscrit",
                BorderWidth = 3,
                Color = Color.FromArgb(137, 179, 252),
            };
            var serieeforma = new Series()
            {
                ChartType = SeriesChartType.StackedColumn,
                IsVisibleInLegend = true,
                BorderDashStyle = ChartDashStyle.Solid,
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Times", 16f),
                Name = "Operateur en formation",
                LegendText = "Operateur en formation",
                BorderWidth = 3,
                Color = Color.FromArgb(250, 160, 235),
            };
            var serieechom = new Series()
            {
                ChartType = SeriesChartType.StackedColumn,
                IsVisibleInLegend = true,
                BorderDashStyle = ChartDashStyle.Solid,
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Times", 16f),
                Name = "Operateur en chomage",
                LegendText = "Operateur en chomage",
                BorderWidth = 3,
                Color = Color.FromArgb(252, 206, 137),
            };
            var serieeMat = new Series()
            {
                ChartType = SeriesChartType.StackedColumn,
                IsVisibleInLegend = true,
                BorderDashStyle = ChartDashStyle.Solid,
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Times", 16f),
                Name = "Maternité",
                LegendText = "Maternité",
                BorderWidth = 3,
                Color = Color.FromArgb(236, 255, 119),
            };
            var series = new Series()
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(93, 138, 168),
                Font = new System.Drawing.Font("Times", 16f),

                Name = "Charge",
                LegendText = "Charge",

            };
            var series1 = new Series()
            {
                ChartType = SeriesChartType.Line,
                IsVisibleInLegend = true,
                BorderDashStyle = ChartDashStyle.Solid,
                Font = new System.Drawing.Font("Times", 16f),

                Name = "Capacité",
                LegendText = "Capacité",
                BorderWidth = 3,
                Color = Color.FromArgb(255, 126, 0),
            };
            var seriesEff = new Series()
            {
                Font = new System.Drawing.Font("Times", 16f),
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

            var RatioEff = new Series()
            {
                ChartType = SeriesChartType.Line,
                Color = Color.FromArgb(47, 210, 001),
                IsVisibleInLegend = true,
                Font = new System.Drawing.Font("Times", 16f),

                Name = "Effectifs nécessaires",
                LegendText = "Effectifs nécessaires",
                BorderWidth = 3,

            };
            List<int> EffReel = new List<int>();
            int kj = 0;
            foreach (var op in LL13)
            {


                EffReel.Add((int)Math.Truncate(op.Value1 - formation[kj]));
                kj++;

            }
            chart1.Series.Clear();
            chartStats.Series.Clear();
            chart4.Series.Clear();
            chart4.Series.Add(serieeff); chart4.Series.Add(serieeforma); chart4.Series.Add(serieeMat); chart4.Series.Add(serieechom); chart4.Series.Add(RatioEff);
            chart4.ChartAreas[0].AxisX.Interval = 1;
            chart4.Series[0].Points.DataBindXY(wkk, EffReel);
            chart4.ChartAreas[0].AxisX.Interval = 1;
            chart4.Series[4].Points.DataBindXY(wkk, OpNeed);
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
            chart1.Series[0].Points.Clear();

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chartStats.ChartAreas[0].AxisX.Title = "Semaine";
            chartStats.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chart4.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartStats.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chart4.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chartStats.ChartAreas[0].AxisY.Title = "Les heures de travail en H";
            chart4.ChartAreas[0].AxisY.Title = "Nombre des operteurs";
            chart1.ChartAreas[0].AxisY.Title = "Ration de %";
            chart1.Series[0].Points.DataBindXY(wkk, PerCV);
            chartStats.Series[0].Points.DataBindXY(wkk, chrr);
            chartStats.Series[1].Points.DataBindXY(wkk, cpp);
            dataGridView1.DataSource = br;

            //	}
            //catch (Exception ex)
            //{
            //MessageBox.Show(ex.Message);
            //}
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
            GenerateExcel(ConvertToDataTable(br), ConvertToDataTable(ilotOps), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + input);

        }
    }

}

