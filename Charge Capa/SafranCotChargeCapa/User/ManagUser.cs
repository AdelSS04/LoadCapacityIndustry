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
	public partial class ManagUser : Form// MetroFramework.Forms.MetroForm
	{
		public ManagUser()
		{
			InitializeComponent();
		}

		private void IlotManag_Load(object sender, EventArgs e)
		{
			List<User> users = UserDBO.GetAllUSer();
			dataGridView2.DataSource = users;
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			try
			{
				User ur = new User
				{
					UserID=YeatT.Text,
					UserPassword= OpenDay.Text,
					Type= metroComboBox1.SelectedItem.ToString(),
					UserName= Shift.Text


				};
				UserDBO.Insert_client(ur);
				MessageBox.Show("done");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void MachQua_Click(object sender, EventArgs e)
		{
			
		}

		private void MachQua_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void YeatT_Click(object sender, EventArgs e)
		{
			
		}

		private void Shift_Click(object sender, EventArgs e)
		{
		
		}

		private void OpenDay_Click(object sender, EventArgs e)
		{
			
		}

		private void OpenDay_KeyPress(object sender, KeyPressEventArgs e)
		{
		
		}

		private void Shift_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void YeatT_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				User ur = new User
				{
					UserID = YeatT.Text,
					UserPassword = OpenDay.Text,
					Type = metroComboBox1.SelectedItem.ToString(),
					UserName = Shift.Text


				};
				UserDBO.UpdateUser(ur);
				MessageBox.Show("done");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
