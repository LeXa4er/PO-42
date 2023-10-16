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
    public partial class Avtorization : Form
    {
        public Avtorization()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Avtor_Load(object sender, EventArgs e)
        {
            TextBoxPass.UseSystemPasswordChar = true;
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
            if (checkBox1.Checked)
            {
                TextBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                TextBoxPass.UseSystemPasswordChar = true;
            }
        }
	}
}
