using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction
{
    public partial class User_reg : Form
    {
        public User_reg()
        {
            InitializeComponent();
        }

        private void User_reg_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAuction.useres". При необходимости она может быть перемещена или удалена.
                this.useresTableAdapter.Fill(this.dataSetAuction.useres);
            }
            catch
            {
                MessageBox.Show("Не удаётся подключиться к базе данные. Программа будет закрыта. Обратитесь к администратору для решения проблемы", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }


        }

        private void vhodbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPass.Text != "" && textboxLogin.Text != "" )
                {
                    dataSetAuction.useres.AdduseresRow(textboxLogin.Text, textBoxPass.Text);
                    useresBindingSource.EndEdit();
                    useresTableAdapter.Update(this.dataSetAuction);
                    this.useresTableAdapter.Fill(this.dataSetAuction.useres);
                }
                else
                    MessageBox.Show(" неверные данные ");
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                useresBindingSource.EndEdit();
                useresTableAdapter.Update(this.dataSetAuction);
                this.useresTableAdapter.Fill(this.dataSetAuction.useres);
            }
            catch { }
        }
    }
}
