using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class RegistrationForm : Form
    {
        public SqlConnection connection;
        public RegistrationForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
            string connectionString = "Data Source=DESKTOP-V7FB61F\\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Проверка, что поля логина и пароля не пустые
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Добавление нового пользователя в базу данных с флагом IsAdmin=false
            string insertQuery = "INSERT INTO Users (Username, Password, IsAdmin) VALUES (@Username, @Password, 0)";
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Учетная запись успешно создана. Пожалуйста, войдите, используя свои учетные данные.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Переход на форму авторизации после успешной регистрации
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
            this.Hide(); // Скрываем форму регистрации
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
