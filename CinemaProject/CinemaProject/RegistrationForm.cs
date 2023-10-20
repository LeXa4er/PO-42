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
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

                if (guna2TextBox1.Text != (bindingSource1.Filter = "[Логин] = '"))
                {
                    if (guna2TextBox1.Text != "" && guna2TextBox2.Text != "" && guna2TextBox2.Text != "")
                    {
                            this.usersTableAdapter.Insert(guna2TextBox1.Text, guna2TextBox2.Text, bool.Parse("0"));
                            MessageBox.Show("Вы успешно зарегистрировались");
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
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
