using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchStore.Resources
{
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            
            this.clientsTableAdapter.Fill(this.watchStoreDataSet.Clients);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string Fio = FIORtb.Text;
            string password = passwordtb.Text;
            string login = logintb.Text;

            DataRow newRow = this.watchStoreDataSet.Clients.NewRow();
            newRow["Full_name"] = Fio;
            newRow["Password"] = password;
            newRow["Login"] = login;
            this.watchStoreDataSet.Clients.Rows.Add(newRow);
        }

        private void savebt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientsBindingSource.EndEdit();
                this.clientsTableAdapter.Update(this.watchStoreDataSet);
                MessageBox.Show("Изменения сохранены!");

                FIORtb.Text = "";
                passwordtb.Text = "";
                logintb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            clientsBindingSource.RemoveCurrent();
        }

        private void FIORtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ввод цифр запрещен");
            }
        }
    }
}
