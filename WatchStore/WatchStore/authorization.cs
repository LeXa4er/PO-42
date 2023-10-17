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
using WatchStore.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WatchStore
{
    public partial class authorization : Form
    {
        public int clientIndex;
        public int adminIndex;
        public authorization()
        {
            
            InitializeComponent();

        }

        private void authorization_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            textBox_login.MaxLength = 20;
            textBox_password.MaxLength = 20;
            bthide.Visible = false;
            this.AcceptButton = btlogin;
        }


        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btlogin_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataBase dataBase = new DataBase();
                dataBase.openConnection();
                string add_data = "SELECT * FROM [dbo].[Clients] where Login=@Login and Password=@Password";
                SqlCommand cmd = new SqlCommand(add_data, dataBase.getConnection());

                cmd.Parameters.AddWithValue("@Login", textBox_login.Text);
                cmd.Parameters.AddWithValue("@Password", textBox_password.Text);
                cmd.ExecuteNonQuery();
                clientIndex = Convert.ToInt32(cmd.ExecuteScalar());

                if (clientIndex > 0)
                {
                    MessageBox.Show("Вы успешно вошли в систему");
                    Mane mane = new Mane(clientIndex);
                    mane.Show();
                    this.Hide();
                    dataBase.closeConnection();
                }
                else if (clientIndex == 0) {
                    dataBase.openConnection();
                    string add_data2 = "SELECT * FROM [dbo].[Admin] where Login=@Login and Password=@Password";
                    SqlCommand cmd2 = new SqlCommand(add_data2, dataBase.getConnection());
                    cmd2.Parameters.AddWithValue("@Login", textBox_login.Text);
                    cmd2.Parameters.AddWithValue("@Password", textBox_password.Text);
                    cmd2.ExecuteNonQuery();
                    adminIndex = Convert.ToInt32(cmd2.ExecuteScalar());
                    if (adminIndex > 0) {
                        MessageBox.Show("Вы успешно вошли в систему");
                        Mane mane = new Mane(clientIndex);
                        mane.Show();
                        this.Hide();
                        dataBase.closeConnection();
                    }
                    else
                    {
                        MessageBox.Show("Введен невырный логин или пароль");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Отсутсвует подключение к базе данных");
               
            }
        }

        private void registrlb_Click(object sender, EventArgs e)
        {
            registr rg = new registr();
            rg.Show();
            this.Hide();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            o_prog oprg = new o_prog();
            oprg.Show();
        }

    }
}
