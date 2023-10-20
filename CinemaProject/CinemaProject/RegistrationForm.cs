using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string login = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {

                string filter = $"Username = '{login}'";
                bindingSource1.Filter = filter;

                if (bindingSource1.Count == 0)
                {

                    this.usersTableAdapter.Insert(login, password, false); // Устанавливаем isAdmin в false
                    MessageBox.Show("Вы успешно зарегистрировались");
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }

            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.cinemaDataSet.Users);

        }
    }
}
