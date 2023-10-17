using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchStore
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
            this.adminTableAdapter.Fill(this.watchStoreDataSet.Admin);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            
            string password = passwordtb.Text;
            string login = logintb.Text;
            
            DataRow newRow = this.watchStoreDataSet.Admin.NewRow();
            
            newRow["Password"] = password;
            newRow["Login"] = login;
            
            this.watchStoreDataSet.Admin.Rows.Add(newRow);

        }

        private void savebt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.adminBindingSource.EndEdit();
                this.adminTableAdapter.Update(this.watchStoreDataSet);
                MessageBox.Show("Изменения сохранены!");

                
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
            adminBindingSource.RemoveCurrent();
        }
    }
}

