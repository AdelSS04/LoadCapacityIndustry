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

namespace SafranCotChargeCapa
{
	public partial class UpdateUser : MetroFramework.Forms.MetroForm
	{
		public UpdateUser()
		{
			InitializeComponent();
		}

		private void UserName_Click(object sender, EventArgs e)
		{

		}

		private void AddUser_Load(object sender, EventArgs e)
		{
			
		}

		

		private void SearchButton_Click(object sender, EventArgs e)
		{
		}

		private void PasswordInput_OnValueChanged(object sender, EventArgs e)
		{
			
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			//SearchButton.Enabled = false;
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			try
			{
				User ur = new User
				{
					UserName = UserNameInput.Text,
					UserID = LoginInput.Text,
					UserPassword = PasswordInput.Text,
					Type = RoleInput.SelectedItem.ToString(),

				};
				UserDBO.UpdateUser(ur);
				MessageBox.Show("done !!");
				SaveUpdate.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroLabel2_Click(object sender, EventArgs e)
		{

		}

		private void LoginInput_ButtonClick(object sender, EventArgs e)
		{
			try
			{
				User ur = UserDBO.GetUSer(LoginInput.Text);
				PasswordInput.Text = ur.UserPassword;
				UserNameInput.Text = ur.UserName;

				if (PasswordInput.Text != "") { PasswordInput.Enabled = true; UserNameInput.Enabled = true; RoleInput.Enabled = true; SaveUpdate.Enabled = true; }

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}