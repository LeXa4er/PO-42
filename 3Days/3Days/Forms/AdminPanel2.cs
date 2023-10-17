using _3Days;
using _3Days.DataBase;
using System;
using System.Windows.Forms;

namespace ForProject
{
    public partial class AdminPanel2 : Form
    {
        TextBox[] matchInfo;

        MainForm _parentForm;

        public AdminPanel2(MainForm form)
        {
            InitializeComponent();
            matchInfo = new TextBox[] { matchBox1, matchBox2, matchBox3, matchBox4 };
            DB.DataView(dataGridView2, "Матчи");

            _parentForm = form;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DB.AddMatch(int.Parse(matchInfo[0].Text), int.Parse(matchInfo[1].Text), dateTimePicker1.Value, matchInfo[2].Text, matchInfo[3].Text);

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
            DB.DataView(dataGridView2, "Матчи");
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            Close();
        }

        private void AdminPanel2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
    }
}
