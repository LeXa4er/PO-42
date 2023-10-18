using _3Days.DataBase;
using System;
using System.Windows.Forms;

namespace _3Days.Forms
{
    public partial class AdminPanel3 : Form
    {
        TextBox[] userInfo;

        MainForm _parentForm;

        public AdminPanel3(MainForm form)
        {
            InitializeComponent();
            userInfo = new TextBox[] { userBox1, userBox2, userBox3, userBox4, userBox5 };
            DB.DataView(dataGridView2, "Пользователь");

            _parentForm = form;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DB.AddUser(userInfo[0].Text, userInfo[1].Text, userInfo[2].Text, userInfo[3].Text, userInfo[4].Text, checkBox1.Checked);

                MessageBox.Show("Данные были успешно добавлены.");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            DB.DataView(dataGridView2, "Пользователь");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parentForm.Show();

            Close();
        }
    }
}
