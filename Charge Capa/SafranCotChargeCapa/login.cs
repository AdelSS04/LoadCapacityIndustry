using BEL;
using DAL;
using System;
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
#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone. Utilisez l'opérateur 'await' pour attendre les appels d'API non bloquants ou 'await Task.Run(…)' pour effectuer un travail utilisant le processeur sur un thread d'arrière-plan.
        public async Task LoginT()
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone. Utilisez l'opérateur 'await' pour attendre les appels d'API non bloquants ou 'await Task.Run(…)' pour effectuer un travail utilisant le processeur sur un thread d'arrière-plan.
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
