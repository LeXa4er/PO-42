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
    public partial class EditorLPs : Form
    {
        public EditorLPs()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            EditorAdmin form = new EditorAdmin();
            form.Show();
            this.Hide();
        }

        private void buttonFurther_Click(object sender, EventArgs e)
        {
            EditorCDs form = new EditorCDs();
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
            RecordLPs form = new RecordLPs();
            form.Show();
            this.Hide();
        }

        private void Editor2_Load(object sender, EventArgs e)
        {
            this.lPsTableAdapter.Fill(this.lPsClassicMusicDataSet.LPs);
            LPsBindingNavigator.BindingSource = lPsBindingSource;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.lPsTableAdapter.Update(this.lPsClassicMusicDataSet.LPs);
            this.lPsTableAdapter.Fill(this.lPsClassicMusicDataSet.LPs);
        }
    }
}
