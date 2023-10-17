using _3Days;
using _3Days.DataBase;
using _3Days.ManeLogic;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ForProject
{
    public partial class AdminPanel1 : Form
    {
        TextBox[] trenerInfo;
        TextBox[] komandaInfo;
        string photo;

        private MainForm _parentForm;

        public AdminPanel1(MainForm form)
        {
            _parentForm = form;

            InitializeComponent();
            trenerInfo = new TextBox[] { trenerBox1, trenerBox2, trenerBox3, trenerBox4 };
            komandaInfo = new TextBox[] { komandaBox1, komandaBox2 };
            DB.DataView(dataGridView1, "Тренер");
            DB.DataView(dataGridView2, "Команда");          
        }

        private void AdminPanel1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB.AddTrener(trenerInfo[0].Text, trenerInfo[1].Text, trenerInfo[2].Text, trenerInfo[3].Text, photo);

                MessageBox.Show("Данные были успешно добавлены.");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DB.AddKomanda(komandaInfo[0].Text, komandaInfo[1].Text);

                MessageBox.Show("Данные были успешно добавлены.");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DB.DataView(dataGridView1, "Тренер");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            DB.DataView(dataGridView2, "Команда");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Выбрать изображение";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(openFile.FileName);
                photo = Path.GetFileName(openFile.FileName);
                string imgPath = DataWorker.CombinePicturePath(photo);
                try
                {
                    File.Copy(openFile.FileName, imgPath);
                }

                catch { MessageBox.Show("Файл с таким именем уже есть, переименуйте его"); }
                
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {    
            this.Close();
        }

        private void AdminPanel1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
    }
}
