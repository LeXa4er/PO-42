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
    public partial class AuthorizationForm : Form
    {
        public SqlConnection connection;

        public AuthorizationForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
            string connectionString = "Data Source=DESKTOP-V7FB61F\\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            bool isAdmin = false;

            // Проверка аутентификации в базе данных
            string query = "SELECT IsAdmin FROM Users WHERE Username=@Username AND Password=@Password";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isAdmin = reader.GetBoolean(0);
                }
                connection.Close();
            }

            if (isAdmin)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else
            {
                MoviesForm moviesForm = new MoviesForm();
                moviesForm.Show();
            }

            this.Hide();
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
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Users". При необходимости она может быть перемещена или удалена.
            

        }
    }
}
