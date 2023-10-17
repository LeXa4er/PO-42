using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClassicMusic
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBoxOpen.Visible = true;
            pictureBoxClose.Visible = false;
            textBoxPassword.PasswordChar = '\0';
        }


        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            pictureBoxClose.Visible = true;
            pictureBoxOpen.Visible = false;
            textBoxPassword.PasswordChar = '*';
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonStyle1_Click(object sender, EventArgs e)
        {
             EditorAdmin form = new EditorAdmin();
            form.Show();
            this.Hide();
        }
    }
}
