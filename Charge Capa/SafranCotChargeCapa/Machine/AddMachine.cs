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
using MaterialSkin.Controls;
using System.Globalization;

namespace SafranCotChargeCapa
{
	public partial class AddMachine : Form// MetroFramework.Forms.MetroForm
	{
		public AddMachine()
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
				Machine ur = new Machine
				{
					MachineID = MAchID.Text,
					MachineName = MachName.Text,
					Etat = status.Text ,
					MachineRejectedRate = int.Parse(MachQua.Text),


				};
				if (MachineDBO.AddMachine(ur))

				{
					MachineOpenDay op = new MachineOpenDay
					{
						MachineID = MAchID.Text,
						YearT = int.Parse(YeatT.Text),
						
						OpenDay = int.Parse(OpenDay.Text),
						NumberOfshift = int.Parse(Shift.Text),

					};
					DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
					DateTime date1 = new DateTime(DateTime.Now.Year, 12, 31);
					Calendar cal = dfi.Calendar;
					for (int i = 1; i <= cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, DayOfWeek.Monday); i++)
					{
						op.WeekT = i;
						MachineDBO.SetOpenDay(op);
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

		private void MachQua_Click(object sender, EventArgs e)
		{
			if (MachQua.Text == "only number")
			{
				MachQua.BackColor = Color.White;
				MachQua.Text = "";
			}
		}

		private void MachQua_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
				//MessageBox.Show("hh");
				MachQua.Text = "only number";
				MachQua.BackColor = Color.FromArgb(172, 13, 4);

			}

			// If you want, you can allow decimal (float) numbers
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
			if (((MachQua.Text == "only number") && !(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
				&& !((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
			{
				MachQua.BackColor = Color.White;
				MachQua.Text = "";
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

		private void Shift_Click(object sender, EventArgs e)
		{
			if (Shift.Text == "only number")
			{
				Shift.BackColor = Color.White;
				Shift.Text = "";
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

		private void Shift_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
				//MessageBox.Show("hh");
				Shift.Text = "only number";
				Shift.BackColor = Color.FromArgb(172, 13, 4);

			}

			// If you want, you can allow decimal (float) numbers
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
			if (((Shift.Text == "only number") && !(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
				&& !((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
			{
				Shift.BackColor = Color.White;
				Shift.Text = "";
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
