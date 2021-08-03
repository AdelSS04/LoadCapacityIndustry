using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
    public partial class ManagOpera : Form // MetroFramework.Forms.MetroForm
    {
        public ManagOpera()
        {
            InitializeComponent();
        }

        private void ManagOpera_Load(object sender, EventArgs e)
        {
            List<Ilot> ilots = IlotDBO.GetAllIlot();
            foreach (Ilot il in ilots)
                metroComboBox1.Items.Add(il.IlotID);
            metroComboBox2.Items.Add(DateTime.Now.Year);
            metroComboBox2.Items.Add((DateTime.Now.Year + 1));
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IlotOp> ilotOps = IlotOpDBO.GetIlotOP(metroComboBox1.SelectedItem.ToString(), DateTime.Now.Year,
                System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
            dataGridView1.DataSource = ilotOps;
            if (ilotOps.Count == 0)
                UpButton.Enabled = true;
            else
                button1.Enabled = true;

            sizeDGV(dataGridView1, groupBox1);

        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            try
            {

                IlotOp openDay = new IlotOp
                {
                    Formation = 0,
                    IlotID = metroComboBox1.SelectedItem.ToString(),
                    WeekT = 0,
                    Chomage = 0,
                    Materneti = 0,

                    YearT = int.Parse(metroComboBox2.SelectedItem.ToString()),
                };
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
                Calendar cal = dfi.Calendar;
                for (int i = 1; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
                {
                    openDay.WeekT = i;
                    IlotOpDBO.SetOpenDay(openDay);
                }
                List<IlotOp> CapaMach = IlotOpDBO.GetIlotOP(metroComboBox1.SelectedItem.ToString(), DateTime.Now.Year,
            System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
                dataGridView1.DataSource = CapaMach;
                sizeDGV(dataGridView1, groupBox1);
                button1.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        public void sizeDGV(DataGridView dgv, GroupBox GRP)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            //dgv.ScrollBars = ScrollBars.None;

            var totalWidth = dgv.Columns.GetColumnsWidth(states);
            dgv.ClientSize = new Size(totalWidth, 180);
            GRP.ClientSize = new Size(totalWidth + 2, 180);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<IlotOp> machineOpenDays = new List<IlotOp>();
                machineOpenDays = dataGridView1.DataSource as List<IlotOp>;
                bool state = true;
                foreach (IlotOp openDay in machineOpenDays)
                {
                    if (!IlotOpDBO.UpOperatingNumber(openDay))
                        state = false;
                }
                if (state)
                {
                    MessageBox.Show("done");
                    List<IlotOp> CapaMach = IlotOpDBO.GetIlotOP(metroComboBox1.SelectedItem.ToString(), DateTime.Now.Year,
                System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday));
                    dataGridView1.DataSource = CapaMach;
                    sizeDGV(dataGridView1, groupBox1);
                }
                else
                    MessageBox.Show("error");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
