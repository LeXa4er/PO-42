using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using yt_DesignUI.Components;
using yt_DesignUI.Controls;
using System.Media;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
 
namespace yt_DesignUI
{
    public partial class MainForm : ShadowedForm
    {
        
        
        public MainForm()
        {
            InitializeComponent();


            Animator.Start();



            FormStyles.fStyle selectedStyle = FormStyle1.FormStyle;
            cmbStyle.DataSource = Enum.GetValues(typeof(FormStyles.fStyle));
            cmbStyle.SelectedItem = selectedStyle;
            
            }


    
        private void contextExitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
     

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormStyle1.FormStyle = (FormStyles.fStyle)cmbStyle.SelectedItem;
        }


        private void yt_Button4_Click_1(object sender, EventArgs e)
        {
            ClassicMusic.Authorization form = new ClassicMusic.Authorization();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Добро пожаловать в программу для музыкальных носителей - ClassicMusic",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.ServiceNotification);



            SoundPlayer sndPlayer = new SoundPlayer(@"Music/jaz.wav");
             
            sndPlayer.Play();
           

        }

        private void toggleSwitchStyle1_CheckedChanged(object sender)
        {
            SoundPlayer sndPlayer = new SoundPlayer(@"Music/jaz.wav");
            if (toggleMusic.Checked)
            {
                 
                sndPlayer.Stop();
            }
            else
            {
                sndPlayer.Play();
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            ClassicMusic.ProgrammInfo form = new ClassicMusic.ProgrammInfo();
            form.Show();
            
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь должна быть справка)))",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1
         );
        }
    }
}
