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
    public partial class EditorAdmin : Form
    {
        public EditorAdmin()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Editor3 form = new Editor3();
            form.Show();
            this.Hide();
        }

        private void buttonStyle1_Click(object sender, EventArgs e)
        {
            Authorization form = new  Authorization();
            form.Show();
            this.Hide();
        }

        private void buttonFurther_Click(object sender, EventArgs e)
        {
            Editor2 form = new Editor2();
            form.Show();
            this.Hide();
        }

        private void buttonStyle1_Click_1(object sender, EventArgs e)
        {
            RecordAdmin form = new RecordAdmin();
            form.Show();
            this.Hide();
        }
    }
}
