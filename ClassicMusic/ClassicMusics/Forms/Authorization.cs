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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClassicMusic
{
    public partial class Authorization : Form
    {
        ClassicMusic.DataBase database = new DataBase();
        public Authorization()
        {
            InitializeComponent();
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBoxOpen.Visible = true;
            pictureBoxClose.Visible = false;
            textBoxPassword.PasswordChar = '\0';
        }


        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            pictureBoxClose.Visible = true;
            pictureBoxOpen.Visible = false;
            textBoxPassword.PasswordChar = '*';
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            SqlDataAdapter adapterLog = new SqlDataAdapter();
            DataTable tableLog = new DataTable();

            string loginString = $"select * from Admins where Login = '{login}' and Password = '{password}'";

            SqlCommand commandLog = new SqlCommand(loginString, database.GetConnection());
            try
            {
                adapterLog.SelectCommand = commandLog;
                adapterLog.Fill(tableLog);

                if (tableLog.Rows.Count == 1)
                {
                    EditorAdmin form = new EditorAdmin();
                    form.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Такого пользователя не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
