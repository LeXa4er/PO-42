using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using yt_DesignUI.Components;
using yt_DesignUI.Controls;
using System.Media;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
 
namespace yt_DesignUI
{
    public partial class MainForm : ShadowedForm
    {

        ClassicMusic.DataBase database = new ClassicMusic.DataBase();
        public static string table = "LPs";
        public static string availability = "Есть";

        public static string nameS;
        public static string articleS;
        public static string genreS;
        public static string yearPubS;

        public MainForm()
        {

            InitializeComponent();


            Animator.Start();



            FormStyles.fStyle selectedStyle = FormStyle1.FormStyle;
            cmbStyle.DataSource = Enum.GetValues(typeof(FormStyles.fStyle));
            cmbStyle.SelectedItem = selectedStyle;
            
            }


    
        private void contextExitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
     

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormStyle1.FormStyle = (FormStyles.fStyle)cmbStyle.SelectedItem;
        }


        private void yt_Button4_Click_1(object sender, EventArgs e)
        {
            ClassicMusic.Authorization form = new ClassicMusic.Authorization();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //    MessageBox.Show(
            //"Добро пожаловать в программу для музыкальных носителей - ClassicMusic",
            //"Сообщение",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information,
            //MessageBoxDefaultButton.Button1,
            //MessageBoxOptions.ServiceNotification);

            ItemsList();

            SoundPlayer sndPlayer = new SoundPlayer(@"Music/jaz.wav");
             
            sndPlayer.Play();

            comboBoxType.SelectedIndex = 0;
        }

        private void toggleSwitchStyle1_CheckedChanged(object sender)
        {
            SoundPlayer sndPlayer = new SoundPlayer(@"Music/jaz.wav");
            if (toggleMusic.Checked)
            {
                 
                sndPlayer.Stop();
            }
            else
            {
                sndPlayer.Play();
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            ClassicMusic.ProgrammInfo form = new ClassicMusic.ProgrammInfo();
            form.Show();
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По всем возникающим вопросам просьба писать сюда:\nelektronniypochtoviyyachik@yandex.ru",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1
         );
        }

        public void ItemsList()
        {
            listBoxInformation1.Items.Clear();
            SqlCommand ItemsCommand = new SqlCommand($"select * from [{table}] where Availability = '" + availability + "'", database.GetConnection());

            try
            {
                database.openConnection();
                SqlDataReader Items = ItemsCommand.ExecuteReader();
                while (Items.Read())
                {
                    listBoxInformation1.Items.Add(Items["Name"]);
                }
                Items.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == "Виниловые пластинки")
                table = "LPs";
            else if (comboBoxType.SelectedItem == "CD-диски")
                table = "CDs";
            Clear();
            ItemsList();
        }

        private void listBoxInformation1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand ItemCommand = new SqlCommand($"select * from [{table}] where Name = '" + listBoxInformation1.SelectedItem + "'", database.GetConnection());
            try
            {
                database.openConnection();
                SqlDataReader Item = ItemCommand.ExecuteReader();
                while (Item.Read())
                {
                    textBoxArticle.Text = Convert.ToString(Item["Article"]);
                    textBoxPerformers.Text = Convert.ToString(Item["Performers"]);
                    textBoxGenre.Text = Convert.ToString(Item["Genre"]);
                    textBoxPublisher.Text = Convert.ToString(Item["Publisher"]);
                    textBoxPackaging.Text = Convert.ToString(Item["Packaging"]);
                    textBoxCost.Text = Convert.ToString(Item["Cost"]);
                    pictureBoxInfo.ImageLocation = Convert.ToString(Item["Image"]);
                }
                Item.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toggleAvailability_CheckedChanged(object sender)
        {
            if (toggleAvailability.Checked)
            {
                availability = "Нет";
                Clear();
                ItemsList();
            }
            else
            {
                availability = "Есть";
                Clear();
                ItemsList();
            }
        }

        public void Clear() 
        {
            textBoxSearch.Text = null;
            textBoxArticleS.Text = null;
            textBoxGenreS.Text = null;
            textBoxYearPubS.Text = null;

            textBoxArticle.Text = null;
            textBoxPerformers.Text = null;
            textBoxGenre.Text = null;
            textBoxPublisher.Text = null;
            textBoxPackaging.Text = null;
            textBoxCost.Text = null;
            pictureBoxInfo.ImageLocation = "..\\..\\Image\\Пластинка.jpg";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text == "") ItemsList();
            else 
            {
                nameS = textBoxSearch.Text;
                articleS = textBoxArticleS.Text;
                genreS = textBoxGenreS.Text;
                yearPubS = textBoxYearPubS.Text;

                listBoxInformation1.Items.Clear();

                SqlCommand ItemCommand = new SqlCommand($"select * from [{table}] where Name like '%" + nameS + "%' and Availability = '" + availability + "'", database.GetConnection());

                database.openConnection();
                SqlDataReader Item = ItemCommand.ExecuteReader();
                while (Item.Read())
                {
                    listBoxInformation1.Items.Add(Item["Name"]);
                }
                Item.Close();
                database.closeConnection();
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
            ItemsList();
        }
    }
}
