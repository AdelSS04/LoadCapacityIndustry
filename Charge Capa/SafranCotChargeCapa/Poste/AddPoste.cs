using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
    public partial class AddPoste : Form// MetroFramework.Forms.MetroForm
    {
        public AddPoste()
        {
            InitializeComponent();
        }

        private void IlotManag_Load(object sender, EventArgs e)
        {
            try
            {
                List<Ilot> ilots = IlotDBO.GetAllIlot();
                foreach (Ilot il in ilots)
                    metroComboBox1.Items.Add(il.IlotID);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpGroupe ur = new OpGroupe
                {
                    GrpName = MAchID.Text,
                    IlotID = metroComboBox1.SelectedItem.ToString(),



                };
                if (OpGroupeDBO.AddNewPosteCharge(ur))

                {
                    OperatorsO op = new OperatorsO
                    {
                        OperationID = MAchID.Text,
                        OpenDay = int.Parse(materialSingleLineTextField1.Text),
                        YearT = int.Parse(YeatT.Text),
                        NumberOfOperator = int.Parse(OpenDay.Text),


                    };
                    DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                    DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
                    Calendar cal = dfi.Calendar;
                    for (int i = 1; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
                    {
                        op.WeekT = i;
                        OperatorsODBO.SetOperatingNumber(op);
                    }
                    MessageBox.Show("done !!");
                }
                else
                    MessageBox.Show("error !!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void OpenDay_Click(object sender, EventArgs e)
        {
            if (OpenDay.Text == "only number")
            {
                OpenDay.BackColor = Color.White;
                OpenDay.Text = "";
            }
        }

        private void OpenDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                //MessageBox.Show("hh");
                OpenDay.Text = "only number";
                OpenDay.BackColor = Color.FromArgb(172, 13, 4);

            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (((OpenDay.Text == "only number") && !(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
                && !((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            {
                OpenDay.BackColor = Color.White;
                OpenDay.Text = "";
            }
        }



        private void YeatT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                //MessageBox.Show("hh");
                YeatT.Text = "only number";
                YeatT.BackColor = Color.FromArgb(172, 13, 4);

            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (((YeatT.Text == "only number") && !(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
                && !((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            {
                YeatT.BackColor = Color.White;
                YeatT.Text = "";
            }
        }
    }
}
