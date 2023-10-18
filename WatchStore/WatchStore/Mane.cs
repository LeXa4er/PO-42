using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchStore.Resources;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WatchStore
{
    public partial class Mane : Form
    {
        

        public Mane()
        {
            InitializeComponent();
        }

        private void Mane_Load(object sender, EventArgs e)
        {
            Katalog katal = new Katalog();
            LoadControl(katal);
        }

        public void LoadControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;  
            panelMane.Controls.Clear();
            panelMane.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btKatalog_Click(object sender, EventArgs e)
        {
            Katalog katal = new Katalog();
            LoadControl(katal);
        }

        private void btWatch_Click(object sender, EventArgs e)
        {
            Watchadd wat = new Watchadd();
            LoadControl(wat);
        }

        private void btSales_Click(object sender, EventArgs e)
        {
            Sales sel = new Sales();
            LoadControl(sel);
        }

        private void btClients_Click(object sender, EventArgs e)
        {

            Clients clt = new Clients();
            LoadControl(clt);
        }

        private void btAdmins_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            LoadControl(ad);
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            authorization aut = new authorization();
            aut.Show();
            this.Hide();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btmax.Visible = false;
            btmaxed.Location = btmax.Location;
            btmaxed.Visible = true;
        }

        private void btmaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btmaxed.Visible = false;
            btmax.Visible = true;
        }


    }
}
