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
    public partial class RecordCDs : Form
    {
        public RecordCDs()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            EditorCDs form = new EditorCDs();
            form.Show();
            this.Hide();
        }

        private void buttonFurther_Click(object sender, EventArgs e)
        {
            RecordAdmin form = new RecordAdmin();
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            RecordLPs form = new RecordLPs();
            form.Show();
            this.Hide();
        }
    }
}
