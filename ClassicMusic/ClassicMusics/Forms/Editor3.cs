using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicMusic
{
    public partial class Editor3 : Form
    {
        public Editor3()
        {
            InitializeComponent();
        }

        private void buttonFurther_Click(object sender, EventArgs e)
        {
            EditorAdmin form = new EditorAdmin();
            form.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Editor2 form = new Editor2();
            form.Show();
            this.Hide();
        }

        private void buttonStyle1_Click(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            form.Show();
            this.Hide();
        }

        private void buttonStyle1_Click_1(object sender, EventArgs e)
        {
            Record3 form = new Record3();
            form.Show();
            this.Hide();
        }
    }
}
