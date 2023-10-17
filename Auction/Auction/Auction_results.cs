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

namespace Auction
{
    public partial class Auction_results : Form
    {
        public Auction_results()
        {
            InitializeComponent();
        }

        private void Auction_results_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAuction.buyer". При необходимости она может быть перемещена или удалена.
            this.buyerTableAdapter.Fill(this.dataSetAuction.buyer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAuction.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.dataSetAuction.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAuction.SelectAllAuction". При необходимости она может быть перемещена или удалена.
            this.selectAllAuctionTableAdapter.Fill(this.dataSetAuction.SelectAllAuction);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAuction.SelectAllAuction". При необходимости она может быть перемещена или удалена.
            this.selectAllAuctionTableAdapter.Fill(this.dataSetAuction.SelectAllAuction);
            radioButton1.Checked = true;

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panelAddBuy.Enabled = true;
                panelSelectBuy.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                panelAddBuy.Enabled = false;
                panelSelectBuy.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int idSell = 0;

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.auctionConnectionString);
            conn.Open();
            SqlCommand Comm = conn.CreateCommand();
            if (radioButton1.Checked)
            {
                Comm.CommandText = "insert into buyer values('" + textboxFio.Text + "','" + textboxPhone.Text + "')";
                Comm.ExecuteNonQuery();

                this.buyerTableAdapter.Fill(this.dataSetAuction.buyer);
                comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
            }
            idSell = (int)comboBox2.SelectedValue;
            comboBox2.SelectedValue = idSell;
            Comm.CommandText = "insert into auction values('" + comboBox2.SelectedValue + "','" + numericUpDownPrice.Value + "','" + dateTimePicker1.CustomFormat + "','" + comboBoxLots.SelectedValue + "')";
            Comm.ExecuteNonQuery();
            MessageBox.Show("Лот успешно добавлен!");
        }
    }
}
