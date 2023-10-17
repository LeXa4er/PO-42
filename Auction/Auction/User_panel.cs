using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction
{
    public partial class User_panel : Form
    {
        public User_panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_reg user_Reg = new User_reg();
            this.Hide();
            user_Reg.ShowDialog();
            this.Show();
        }

        private void lotbtn_Click(object sender, EventArgs e)
        {
            Add_lot add_Lot = new Add_lot();
            this.Hide();
            add_Lot.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auction_results auction_Results = new Auction_results();
            this.Hide();
            auction_Results.ShowDialog();
            this.Show();
        }
    }
}
