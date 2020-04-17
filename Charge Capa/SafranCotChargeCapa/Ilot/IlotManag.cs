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
namespace SafranCotChargeCapa
{
	public partial class IlotManag :Form// MetroFramework.Forms.MetroForm
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
			
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroLabel1_Click(object sender, EventArgs e)
		{

		}

		
	
		

	

		private void UpButton_Click(object sender, EventArgs e)
		{
			try
			{
				Ilot ur = new Ilot
				{
					IlotName = IlotName.Text,
					IlotRejectedRate = float.Parse(IlotRej.Text),
					IlotID = IlotID.Text,
					TruancyRate = float.Parse(IlotAbs.Text),
					Efficiency = float.Parse(IlotEff.Text),
					CRM = float.Parse(IlotCRM.Text),
					UserID = checkedListBox1.SelectedItem.ToString()


				};
				if(IlotDBO.AddIlot(ur))
				MessageBox.Show("done !!");
				else
					MessageBox.Show("error !!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count >= 1)
				e.NewValue = CheckState.Unchecked;
		}

		private void IlotEff_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
				//MessageBox.Show("hh");
				IlotEff.Text = "only number";
				IlotEff.BackColor = Color.FromArgb(172, 13, 4);
				
			}

			// If you want, you can allow decimal (float) numbers
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
			if (((IlotEff.Text == "only number") && !(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))) 
				&& !((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
			{
				IlotEff.BackColor = Color.White;
				IlotEff.Text = "";
			}

		}

	
		private void IlotEff_Click(object sender, EventArgs e)
		{if (IlotEff.Text == "only number")
			{ IlotEff.BackColor = Color.White;
				IlotEff.Text = ""; }
		}

		private void IlotCRM_Click(object sender, EventArgs e)
		{
			if (IlotCRM.Text == "only number")
			{
				IlotCRM.BackColor = Color.White;
				IlotCRM.Text = "";
			}
		}

		private void IlotRej_Click(object sender, EventArgs e)
		{
			if (IlotRej.Text == "only number")
			{
				IlotRej.BackColor = Color.White;
				IlotRej.Text = "";
			}
		}

		private void IlotAbs_Click(object sender, EventArgs e)
		{
			if (IlotAbs.Text == "only number")
			{
				IlotAbs.BackColor = Color.White;
				IlotAbs.Text = "";
			}
		}

		private void IlotAbs_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
				//MessageBox.Show("hh");
				IlotAbs.Text = "only number";
				IlotAbs.BackColor = Color.FromArgb(172, 13, 4);

			}

			// If you want, you can allow decimal (float) numbers
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
			if (((IlotAbs.Text == "only number") && !(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
				&& !((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
			{
				IlotAbs.BackColor = Color.White;
				IlotAbs.Text = "";
			}
		}

		private void IlotRej_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
				//MessageBox.Show("hh");
				IlotRej.Text = "only number";
				IlotRej.BackColor = Color.FromArgb(172, 13, 4);

			}

			// If you want, you can allow decimal (float) numbers
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
			if (((IlotRej.Text == "only number") && !(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
				&& !((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
			{
				IlotRej.BackColor = Color.White;
				IlotRej.Text = "";
			}
		}

		private void IlotCRM_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
				//MessageBox.Show("hh");
				IlotCRM.Text = "only number";
				IlotCRM.BackColor = Color.FromArgb(172, 13, 4);

			}

			// If you want, you can allow decimal (float) numbers
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
			if (((IlotCRM.Text == "only number") && !(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
				&& !((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
			{
				IlotCRM.BackColor = Color.White;
				IlotCRM.Text = "";
			}
		}
	}
}
