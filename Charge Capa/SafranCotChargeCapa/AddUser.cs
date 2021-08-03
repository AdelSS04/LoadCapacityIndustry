using BEL;
using DAL;
using System;
using System.Windows.Forms;

namespace SafranCotChargeCapa
{
    public partial class AddUser : MetroFramework.Forms.MetroForm
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }



        private void PasswordInput_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void PasswordInput_Enter(object sender, EventArgs e)
        {
            PasswordInput.Text = "";
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
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
                UserDBO.Insert_client(ur);
                MessageBox.Show("done !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}