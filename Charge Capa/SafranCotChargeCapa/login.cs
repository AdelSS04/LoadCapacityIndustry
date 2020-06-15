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
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public async Task LoginT()
		{
			User user = UserDBO.Login(userN.Text, pass.Text);
			if (user.UserID != null)
			{
				Util.user = user;
				HomeDashbord MyForm = new HomeDashbord();
				MyForm.Show();

			}

			else
				MessageBox.Show("nnnn");
		}
		private async void UpButton_Click(object sender, EventArgs e)
		{
			await LoginT();
		}
	}
}
