using _3Days.DataBase;
using _3Days.Forms;
using _3Days.ManeLogic;
using ForProject;
using System;
using System.IO;
using System.Windows.Forms;

namespace _3Days
{
    public partial class MainForm : Form
    {
        private readonly FormDataController _dataController;
        private readonly LoginForm _loginForm;

        public MainForm(User user, LoginForm form)
        {
            InitializeComponent();

            PrepareControls(user);

            _dataController = new FormDataController(this);

            _loginForm = form;
        }

        private void OnManeFormLoad(object sender, EventArgs e)
        {
            SelectedPageCaption.Text = "Предстоящие матчи";

            ChangePage(0);
        }

        private void OnUpcomingMatchesClick(object sender, EventArgs e)
        {
            SelectedPageCaption.Text = "Предстоящие матчи";

            ChangePage(0);
        }

        private void OnCompletedMatchesButtonClick(object sender, EventArgs e)
        {
            SelectedPageCaption.Text = "Прошедшие матчи";

            ChangePage(1);
        }

        private void OnTeamsButtonClick(object sender, EventArgs e)
        {
            SelectedPageCaption.Text = "Команды";

            ChangePage(2);
        }

        private void OnCoachesButtonClick(object sender, EventArgs e)
        {
            SelectedPageCaption.Text = "Тренеры";

            ChangePage(3);
        }

        private void ChangePage(int index)
        {
            MainPanel.Controls.Clear();

            _dataController.ShowPage(index);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DataWorker.Exit();
        }

        private void OnOpenAdminPanel1Click(object sender, EventArgs e)
        {
            new AdminPanel1(this).Show();

            Hide();
        }

        private void OnOpenAdminPanel2Click(object sender, EventArgs e)
        {
            new AdminPanel2(this).Show();

            Hide();
        }

        private void PrepareControls(User user)
        {
            UsernameLabel.Text = user.Name;

            if (user.Type != UserType.Admin)
            {

                OpenAdminPanel2.Visible = false;
                OpenAdminPanel1.Visible = false;
                AddUsersButton.Visible = false;
            }
        }

        private void OnCertificateButtonClick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _loginForm.Show();

            Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminPanel3(this).Show();

            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() +  @"\..\..\Forms\helpProject.chm");
        }
    }
}
