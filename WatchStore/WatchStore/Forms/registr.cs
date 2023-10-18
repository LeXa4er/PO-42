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
using WatchStore.Classes;

namespace WatchStore
{
    public partial class registr : Form
    {
        public registr()
        {
            InitializeComponent();
            var toolTip1 = new ToolTip();
            toolTip1.SetToolTip(textBox_login, "Разрешен ввод только английских букв и цифр");
            toolTip1.SetToolTip(textBox_password, "Разрешен ввод только английских букв и цифр");
            var toolTip2 = new ToolTip();
            toolTip2.SetToolTip(textBox_name, "Разрешен ввод только русских букв");
        }

        private void registr_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            textBox_login.MaxLength = 20;
            textBox_password.MaxLength = 20;
            textBox_name.MaxLength = 20;
            bthide.Visible = false;
            this.AcceptButton = btlogin;
        }

        Connection connection = new Connection();

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (checkUser())
            {
                return;
            }

            var name = textBox_name.Text;
            var login = textBox_login.Text;
            var passwd = textBox_password.Text;

            string query = $"INSERT INTO Clients(Login, Password, Full_name) VALUES('{login}', '{passwd}', '{name}') ";

            SqlCommand sqlCommand = new SqlCommand(query, connection.GetSqlConnection());

            connection.OpenConnection();

            bool checkTextBoxes = !string.IsNullOrEmpty(textBox_login.Text) && !string.IsNullOrEmpty(textBox_password.Text) && !string.IsNullOrEmpty(textBox_name.Text);

            if (sqlCommand.ExecuteNonQuery() == 1 && checkTextBoxes)
            {
                MessageBox.Show("Пользователь создан!", "Сообщение", MessageBoxButtons.OK);
                authorization aut = new authorization();
                aut.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля или такой пользователь уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btmax.Visible = false;
            btmaxed.Location = btmax.Location;
            btmaxed.Visible = true;
        }

        private void btmaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btmaxed.Visible = false;
            btmax.Visible = true;
        }

        private void btshow_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            btshow.Visible = false;
            bthide.Visible = true;
        }

        private void bthide_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            btshow.Visible = true;
            bthide.Visible = false;
        }

        private void backlb_Click(object sender, EventArgs e)
        {
            authorization aut = new authorization();
            aut.Show();
            this.Hide();
        }

        public Boolean checkUser()
        {
            var name = textBox_name.Text;
            var login = textBox_login.Text;
            var passwd = textBox_password.Text;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string query = $"SELECT Login, Password, Full_name FROM Clients WHERE Login='{login}' AND Password='{passwd}' AND Full_name='{name}'";

            SqlCommand sqlCommand = new SqlCommand(query, connection.GetSqlConnection());

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= 'A' && c <= 'Z') || c == 46 || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back);
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= 'A' && c <= 'Z') || c == 46 || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == 'Ё' || c == 'ё' || c == 8 || c == 46 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
