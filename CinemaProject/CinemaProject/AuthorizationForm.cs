using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            Hide();
            if (radioButton1.Checked)
            {
                AdminForm adminForm = new AdminForm();  
                adminForm.ShowDialog();
            }
            else {
                MoviesForm movieForm = new MoviesForm();
                movieForm.ShowDialog();
            }
           


        }
    }
}
