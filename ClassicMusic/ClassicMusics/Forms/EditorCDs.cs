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
    public partial class EditorCDs : Form
    {
        public EditorCDs()
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
            EditorLPs form = new EditorLPs();
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
            RecordCDs form = new RecordCDs();
            form.Show();
            this.Hide();
        }

        private void EditorCDs_Load(object sender, EventArgs e)
        {
            this.cDsTableAdapter.Fill(this.cDsClassicMusicDataSet.CDs);
            CDsBindingNavigator.BindingSource = cDsBindingSource;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.cDsTableAdapter.Update(this.cDsClassicMusicDataSet.CDs);
            this.cDsTableAdapter.Fill(this.cDsClassicMusicDataSet.CDs);
        }
    }
}
