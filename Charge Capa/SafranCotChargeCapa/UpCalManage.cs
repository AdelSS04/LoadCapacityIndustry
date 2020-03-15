using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;
using System.Globalization;

namespace SafranCotChargeCapa
{
	public partial class UpCalManage : Form
	{
		public UpCalManage()
		{
			InitializeComponent();
		}

		private void UserName_Click(object sender, EventArgs e)
		{

		}

		private void AddUser_Load(object sender, EventArgs e)
		{
			YearSel.Value = int.Parse(DateTime.Now.Year.ToString());

		}

		private void AddButton_Click(object sender, EventArgs e)
		{

			
			try
			{
				List<Calendrier> cal = UpCal.DataSource as List<Calendrier>;
				foreach (Calendrier d in cal)
					CalendrierDBO.UpdateCal(d);
				MessageBox.Show("done !");
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void PasswordInput_OnValueChanged(object sender, EventArgs e)
		{
			
		}

		private void PasswordInput_Enter(object sender, EventArgs e)
		{
			//PasswordInput.Text = "";
		}

		private void YearSel_ValueChanged(object sender, EventArgs e)
		{
			

			
		}
		public int GetWeeksInYear(int year)
		{
			DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
			DateTime date1 = new DateTime(year, 12, 31);
			Calendar cal = dfi.Calendar;
			return cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,dfi.FirstDayOfWeek);
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{

			List<Calendrier> Cal = CalendrierDBO.GetAllUSer(int.Parse(YearSel.Value.ToString()));
			UpCal.DataSource = Cal;
			
		}
	}
}