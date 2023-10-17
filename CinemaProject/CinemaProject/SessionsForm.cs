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
    public partial class SessionsForm : Form
    {
        public SessionsForm()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm =   new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {
            Hide();
            MoviesForm movieForm = new MoviesForm();    
            movieForm.ShowDialog();
        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {
            Hide();
            BookingsForm bookingsForm = new BookingsForm();
            bookingsForm.ShowDialog();
        }
    }
}
