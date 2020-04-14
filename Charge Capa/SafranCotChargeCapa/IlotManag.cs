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

namespace SafranCotChargeCapa
{
	public partial class IlotManag :Form // MetroFramework.Forms.MetroForm
	{
		public IlotManag()
		{
			InitializeComponent();
		}

		private void IlotManag_Load(object sender, EventArgs e)
		{
			try
			{
				List<User> ur = UserDBO.GetAllUSer();
				foreach (User u in ur)
				{ checkedListBox1.Items.Add(u.UserID); }
				List<Ilot> il = IlotDBO.GetAllIlot();
				foreach (Ilot u in il)
				{
					RoleInput.Items.Add(u.IlotID);
				}
				YearSel.Value = int.Parse(DateTime.Now.Year.ToString());
				WeekSel.Value = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroLabel1_Click(object sender, EventArgs e)
		{

		}

		private void metroTextBox1_ButtonClick(object sender, EventArgs e)
		{
			Upilot.Enabled = true;
			AddButton.Enabled = false;
			try
			{
				Ilot ur = IlotDBO.GetIlot(IlotIDInput.Text);
				IlotNameInput.Text = ur.IlotName;
				EffInput.Text = ur.Efficiency.ToString();
				CRMInput.Text = ur.CRM.ToString();
				AbsRate.Text = ur.TruancyRate.ToString();
				IlotRejection.Text = ur.IlotRejectedRate.ToString();

				for (int i = 0; i < checkedListBox1.Items.Count; i++)
				{
					if (checkedListBox1.Items[i].ToString() == ur.UserID)
					{ checkedListBox1.SetItemChecked(i, true); }
					else
					{ checkedListBox1.SetItemChecked(i, false); }

				}
				AddButton.Enabled = false;
				AddButton.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void RoleInput_SelectedIndexChanged(object sender, EventArgs e)
		{
			Upilot.Enabled = true;
			AddButton.Enabled = false;
			try
			{
				Ilot ur = IlotDBO.GetIlot(RoleInput.SelectedItem.ToString());
				IlotNameInput.Text = ur.IlotName;
				EffInput.Text = ur.Efficiency.ToString();
				CRMInput.Text = ur.CRM.ToString();
				AbsRate.Text = ur.TruancyRate.ToString();
				IlotRejection.Text = ur.IlotRejectedRate.ToString();


				for (int i = 0; i < checkedListBox1.Items.Count; i++)
				{
					if (checkedListBox1.Items[i].ToString() == ur.UserID)
					{ checkedListBox1.SetItemChecked(i, true); }
					else
					{ checkedListBox1.SetItemChecked(i, false); }

				}
				AddButton.Enabled = false;
				Upilot.Enabled = true;
				IlotIDInput.Text = RoleInput.SelectedItem.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			try
			{
				Ilot ur = new Ilot
				{
					IlotName = IlotNameInput.Text,
					IlotRejectedRate = float.Parse(IlotRejection.Text),
					IlotID = IlotIDInput.Text,
					TruancyRate = float.Parse(AbsRate.Text),
					Efficiency = float.Parse(EffInput.Text),
					CRM = float.Parse(CRMInput.Text),
					UserID = checkedListBox1.SelectedItem.ToString()


				};

				IlotDBO.AddIlot(ur);
				MessageBox.Show("done !!");
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Upilot_Click(object sender, EventArgs e)
		{
			try
			{
				Ilot ur = new Ilot
				{
					IlotName = IlotNameInput.Text,
					IlotRejectedRate = float.Parse(IlotRejection.Text),
					IlotID = IlotIDInput.Text,
					TruancyRate = float.Parse(AbsRate.Text),
					Efficiency = float.Parse(EffInput.Text),
					CRM = float.Parse(CRMInput.Text),
					UserID = checkedListBox1.SelectedItem.ToString()


				};
				Operators op = new Operators
				{
					IlotID = IlotIDInput.Text,
					YearT = int.Parse(YearSel.Value.ToString()),
					WeekT = int.Parse(WeekSel.Value.ToString()),
					NumberOfOperator = int.Parse(OpSel.Value.ToString()),

				};
				IlotDBO.UpdateIlot(ur);
				OperatorsDBO.UpOperatingNumber(op);
				MessageBox.Show("done !!");
				Upilot.Enabled = false;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
