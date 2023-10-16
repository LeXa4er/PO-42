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
	public partial class Avtorization : Form
	{
		public Avtorization()
		{
			InitializeComponent();
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				TextBoxPass.UseSystemPasswordChar = false;
			}
			else
			{
				TextBoxPass.UseSystemPasswordChar = true;
			}
		}

		private void buttonEnter_Click(object sender, EventArgs e)
		{
			if (textBoxLogin.Text != "" && TextBoxPass.Text != "")
			{
				bindingSourceUsers.Filter = "login = " + textBoxLogin.Text + " and pass = " + TextBoxPass.Text;
				if (bindingSourceUsers.Count > 0)
				{
					User_panel user_Panel = new User_panel();
					this.Hide();
					user_Panel.ShowDialog();
					this.Show();
				}
				else
				{
					MessageBox.Show("Неверный логин или пароль.");
				}
			}
			else
			{
				MessageBox.Show("Поля не заполнены.");
			}
		}

		private void Avtorization_Load(object sender, EventArgs e)
		{
			try
			{
				// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAuction.useres". При необходимости она может быть перемещена или удалена.
				this.useresTableAdapter.Fill(this.dataSetAuction.useres);
				TextBoxPass.UseSystemPasswordChar = true;
			}
			catch (Exception)
			{

				MessageBox.Show("Не удаётся подключиться к базе данные. Программа будет закрыта. Обратитесь к администратору для решения проблемы", "Ошибка подключения" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}
	}
}
