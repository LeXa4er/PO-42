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
            EditorCDs form = new EditorCDs();
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
            EditorLPs form = new EditorLPs();
            form.Show();
            this.Hide();
        }

        private void buttonStyle1_Click_1(object sender, EventArgs e)
        {
            RecordAdmin form = new RecordAdmin();
            form.Show();
            this.Hide();
        }

        private void EditorAdmin_Load(object sender, EventArgs e)
        {
            this.adminsTableAdapter.Fill(this.adminsClassicMusicDataSet.Admins);
            AdminsBindingNavigator.BindingSource = adminsBindingSource;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.adminsTableAdapter.Update(this.adminsClassicMusicDataSet.Admins);
            this.adminsTableAdapter.Fill(this.adminsClassicMusicDataSet.Admins);
        }
    }
}
