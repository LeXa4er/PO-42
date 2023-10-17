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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel22_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {
            Hide();
            SessionsForm sessionsForm = new SessionsForm();
            sessionsForm.ShowDialog();
        }

        private void guna2HtmlLabel18_Click(object sender, EventArgs e)
        {
            Hide();
            BookingsForm bookingsForm = new BookingsForm();
            bookingsForm.ShowDialog();
        }
    }
}
