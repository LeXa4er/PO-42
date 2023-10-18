using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WatchStore
{
    public partial class Watchadd : UserControl
    {
        public Watchadd()
        {
            InitializeComponent();
        }

        private void Watchadd_Load(object sender, EventArgs e)
        {
            this.watchsTableAdapter.Fill(this.watchStoreDataSet.Watchs);
            this.manufacturersTableAdapter.Fill(this.watchStoreDataSet.Manufacturers);
            this.typesTableAdapter.Fill(this.watchStoreDataSet.Types);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string creator = watchCB.Text;
            string model = logintb.Text;
            string type = comboBox1.Text;
            string gender = comboBox2.Text;
            string Country = textBox1.Text;
            string price = dolzhnosttb.Text;
            string waranty = textBox2.Text;
            string image = textBox_image.Text;
            string opisanie = FIORtb.Text;


            DataRow newRow = this.watchStoreDataSet.Watchs.NewRow();
            newRow["ID_manufacturer"] = creator;
            newRow["Model"] = model;
            newRow["ID_type"] = type;
            newRow["Cost"] = price;
            newRow["Warranty"] = waranty;
            newRow["image"] = image;
            newRow["Opisanie"] = opisanie;
            newRow["Gender"] = gender;
            newRow["Country"] = Country;
            this.watchStoreDataSet.Watchs.Rows.Add(newRow);
        }

        private void savebt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.watchsBindingSource.EndEdit();
                this.watchsTableAdapter.Update(this.watchStoreDataSet);
                MessageBox.Show("Изменения сохранены!");

                watchCB.Text = "";
                logintb.Text = "";
                logintb.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dolzhnosttb.Text = "";
                textBox2.Text = "";
                textBox_image.Text = "";
                FIORtb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            watchsBindingSource.RemoveCurrent();
        }

        private void opimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_image.Text = @"../../Resources/Watch/" + openFileDialog.SafeFileName;
                if (!File.Exists(textBox_image.Text))
                {
                    File.Copy(openFileDialog.FileName, textBox_image.Text);
                }
            }
        }

        private void logintb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ввод цифр запрещен");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && Char.ToLower(e.KeyChar) >= 'a' && Char.ToLower(e.KeyChar) <= 'z')
            {
                
                e.Handled = true;
                MessageBox.Show("Ввод латинских букв запрещен");
            }
        }
    }
}