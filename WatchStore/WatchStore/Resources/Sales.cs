using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WatchStore.Resources
{
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "realty_PR11DataSet1.saler". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.watchStoreDataSet.Sales);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string client = clientCB.Text;
            string watch = watchCB.Text;
            DateTime localTime = DateTime.Now;

            DataRow newRow = this.watchStoreDataSet.Sales.NewRow();

            newRow["ID_watch"] = watch;
            newRow["ID_clients"] = client ;
            newRow["Date_sale"] = localTime ;

            this.watchStoreDataSet.Sales.Rows.Add(newRow);
        }

        private void savebt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.salesBindingSource.EndEdit();
                this.salesTableAdapter.Update(this.watchStoreDataSet);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            salesBindingSource.RemoveCurrent();
        }
    }


}

