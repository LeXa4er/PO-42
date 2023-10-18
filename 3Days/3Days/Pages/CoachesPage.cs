using _3Days.DataBase;
using _3Days.ManeLogic;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _3Days
{
    public partial class CoachesPage : UserControl
    {
        private readonly IEnumerable<Coach> _coaches;

        public CoachesPage(IEnumerable<Coach> coaches)
        {
            _coaches = coaches;

            InitializeComponent();

            ShowCoachesList();
        }

        private void ShowCoachesList()
        {
            foreach (var coach in _coaches)
            {
                var button = CreateCoachButton(coach);

                button.Click += OnCoachSelected;

                CoachesPanel.Controls.Add(button);
            };
        }

        private Button CreateCoachButton(Coach coach)
        {
            Button button = new Button()
            {
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Text = coach.Name,
                Tag = coach,
                Dock = DockStyle.Top,
                Height = 30,
                Margin = new Padding(0, 0, 5, 0),
                Cursor = Cursors.Hand
            };

            return button;
        }

        private void OnCoachSelected(object sender, System.EventArgs e)
        {
            if (sender is Button button && button.Tag is Coach coach)
            {
                if (coach.PhotoPath != null && coach.PhotoPath != "")
                {
                    CoachPhotoBox.ImageLocation = DataWorker.CombinePicturePath(coach.PhotoPath);
                }
                else CoachPhotoBox.ImageLocation = DataWorker.CombinePicturePath("defaultCoach.png");

                List<Team> teams = DB.GetTeams(coach);

                FillTeams(teams);

                BiographyBox.Text = coach.Biography;
            }
        }

        private void FillTeams(IEnumerable<Team> teams)
        {
            TeamsPanel.Controls.Clear();

            int index = 1;

            foreach (var team in teams)
            {
                var label = CreateTeamLabel(team);

                TeamsPanel.Controls.Add(label);

                index++;
            }
        }

        private Label CreateTeamLabel(Team team)
        {
            return new Label()
            {
                Text = team.Name,
                Width = 30,
                Margin = new Padding(0, 0, 5, 0),
                Dock = DockStyle.Top,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White,
            };
        }

        private void CoachPhotoBox_Click(object sender, System.EventArgs e)
        {

        }
    }
}
