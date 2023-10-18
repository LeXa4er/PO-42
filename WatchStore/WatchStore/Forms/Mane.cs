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

        private void LoadControl(UserControl userControl)
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
