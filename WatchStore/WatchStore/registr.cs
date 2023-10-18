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
    public partial class registr : Form
    {
        public registr()
        {
            InitializeComponent();
        }

        private void registr_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            textBox_login.MaxLength = 20;
            textBox_password.MaxLength = 20;
            bthide.Visible = false;
            this.AcceptButton = btlogin;
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            authorization aut = new authorization();
            aut.Show();
            this.Close();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btshow_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            btshow.Visible = false;
            bthide.Visible = true;
        }

        private void bthide_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            btshow.Visible = true;
            bthide.Visible = false;
        }

        private void backlb_Click(object sender, EventArgs e)
        {
            authorization aut = new authorization();
            aut.Show();
            this.Hide();
        }
    }
}
