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

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            TextBoxPass.UseSystemPasswordChar = false;
            ShowBtn.Visible = false;
            HideBtn.Visible = true;
        }

        private void HideBtn_Click(object sender, EventArgs e)
        {
            TextBoxPass.UseSystemPasswordChar = true;
            ShowBtn.Visible = true;
            HideBtn.Visible = false;
        }

        private void Avtor_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxLogin, "Если вы забыли свой логин, то обратитесь к администратору.");
            toolTip2.SetToolTip(TextBoxPass, "Если вы забыли свой пароль, то обратитесь к администратору.");
        }

        private void vhodbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
