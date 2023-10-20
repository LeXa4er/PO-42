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
    public partial class RecordLPs : Form
    {
        public RecordLPs()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            EditorLPs form = new EditorLPs();
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            RecordAdmin form = new RecordAdmin();
            form.Show();
            this.Hide();
        }

        private void buttonFurther_Click(object sender, EventArgs e)
        {
            RecordCDs form = new RecordCDs();
            form.Show();
            this.Hide();
        }
    }
}
