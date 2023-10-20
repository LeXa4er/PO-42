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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "" && guna2TextBox2.Text != "")
            {
                bindingSource1.Filter = "[Username] = '" + guna2TextBox1.Text + "' and [Password] = '" + guna2TextBox2.Text + "'";
                if (bindingSource1.Count > 0)
                {
                    this.Hide();
                    if (((DataRowView)bindingSource1.Current).Row["IsAdmin"].ToString() == "True")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.ShowDialog();
                    }
                    else
                    {
                        MoviesForm movieForm = new MoviesForm();
                        movieForm.ShowDialog();
                    }
                    this.Show();
                }
                else
                    MessageBox.Show("Неверный логин или пароль");
            }
            else
                MessageBox.Show("Заполните все поля");
        }
        
        // Кнопка выход
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Скрыть/показать пароль
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

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.cinemaDataSet.Users);

        }
    }
}
