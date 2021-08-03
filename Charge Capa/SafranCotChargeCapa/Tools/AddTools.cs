using BEL;
using DAL;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
    public partial class AddTools : Form// MetroFramework.Forms.MetroForm
    {
        public AddTools()
        {
            InitializeComponent();
        }

        private void IlotManag_Load(object sender, EventArgs e)
        {

        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tools ur = new Tools
                {
                    ToolsID = MAchID.Text,
                    ToolsName = MachName.Text,



                };
                ToolsOpenDay op = new ToolsOpenDay
                {
                    ToolsID = MAchID.Text,
                    YearT = int.Parse(YeatT.Text),

                    OpenDay = int.Parse(OpenDay.Text),


                };
                if (ToolsDBO.AddTools(ur))

                {

                    DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                    DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
                    Calendar cal = dfi.Calendar;
                    for (int i = 1; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
                    {
                        op.WeekT = i;
                        ToolsDBO.SetOpenDay(op);
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





        private void YeatT_Click(object sender, EventArgs e)
        {
            if (YeatT.Text == "only number")
            {
                YeatT.BackColor = Color.White;
                YeatT.Text = "";
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
