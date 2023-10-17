using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction
{
    public partial class Add_lot : Form
    {
        public Add_lot()
        {
            InitializeComponent();
        }
        string fullPath;
        string imgPath;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.JPG;*.PNG)|*.JPG;*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                fullPath = openFileDialog1.FileName;
                imgPath = "../../source/imgDB/" + openFileDialog1.SafeFileName;

            }
            if (!File.Exists(imgPath) && imgPath != "")
            {
                File.Copy(fullPath, imgPath);
            }
        }

        private void Add_lot_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAuction.salesman". При необходимости она может быть перемещена или удалена.
            this.salesmanTableAdapter.Fill(this.dataSetAuction.salesman);
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panelAddSellMan.Enabled = true;
                panelSelectSell.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                panelAddSellMan.Enabled = false;
                panelSelectSell.Enabled = true;
            }
        }

        private void buttonAddLot_Click(object sender, EventArgs e)
        {
            if (textBoxNameLot.Text == "" && richTextBoxDiscr.Text == "" && imgPath == "")
            {
                MessageBox.Show("неверные данные");
            }
            else
            {
                int idSell = 0;

                SqlConnection conn = new SqlConnection(Properties.Settings.Default.auctionConnectionString);
                conn.Open();
                SqlCommand Comm = conn.CreateCommand();
                if (radioButton1.Checked)
                {
                    Comm.CommandText = "insert into salesman values('" + textboxFio.Text + "','" + textboxPhone.Text + "')";
                    Comm.ExecuteNonQuery();

                    this.salesmanTableAdapter.Fill(this.dataSetAuction.salesman);
                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                }
                idSell = (int)comboBox1.SelectedValue;
                comboBox1.SelectedValue = idSell;
                Comm.CommandText = "insert into product values('" + textBoxNameLot.Text + "','" + numericUpDown1.Value + "','" + richTextBoxDiscr.Text + "','" + comboBox1.SelectedValue + "','" + imgPath + "')";
                Comm.ExecuteNonQuery();
                MessageBox.Show("Лот успешно добавлен!");
            }
        }
    }
}
