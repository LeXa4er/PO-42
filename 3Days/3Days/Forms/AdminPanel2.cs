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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void matchBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void matchBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void matchBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void matchBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
