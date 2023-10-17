using _3Days.DataBase;
using System;
using System.Windows.Forms;

namespace _3Days.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeamsButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            User user;

            bool isRegistered = DB.TryTakeUser(login, password, out user);

            if (isRegistered)
            {
                new MainForm(user,this).Show();

                Hide();
            }

            else
            {
                MessageBox.Show("Не удалось найти пользователя с такими данными");
            }
        }

        private void PassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = PassCheckBox.Checked;
        }
    }
}
