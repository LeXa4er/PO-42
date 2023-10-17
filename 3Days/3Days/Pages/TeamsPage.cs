using _3Days.DataBase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _3Days
{
    public partial class TeamsPage : UserControl
    {
        public IEnumerable<Team> Teams;

        public TeamsPage()
        {
            InitializeComponent();
        }

        public TeamsPage(IEnumerable<Team> teams)
        {
            Teams = teams;

            InitializeComponent();

            DrawGroupList();
        }

        private void DrawGroupList()
        {
            TeamsPanel.Controls.Clear();

            foreach (var team in Teams)
            {
                var button = CreateTeamButton(team);

                TeamsPanel.Controls.Add(button);
            };
        }

        private Button CreateTeamButton(Team team)
        {
            Button button = new Button()
            {
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Text = team.Name,
                Tag = team,
                Dock = DockStyle.Top,
                Height = 30,
                Margin = new Padding(0, 0, 5, 0),
                Cursor = Cursors.Hand
            };

            button.Click += OnTeamSelected;

            return button;
        }

        private void OnTeamSelected(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Team team)
            {
                Coach coach = DB.GetCoach(team.CoachId);
                List<MatchInfo> matches = DB.GetMatches(team);


                CoachTextBox.Text = coach.Name;

                FillDataGrid(matches);
            }
        }

        private void FillDataGrid(List<MatchInfo> matches)
        {
            MatchesGrid.Rows.Clear();

            if (matches.Count == 0)
            {

            }

            foreach (MatchInfo match in matches)
            {
                var row = CreateMatchRow(match);
                MatchesGrid.Rows.Add(row);
            }
        }

        private DataGridViewRow CreateMatchRow(MatchInfo match)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewCell cell1 = new DataGridViewTextBoxCell()
            {
                Value = match.Date
            };

            DataGridViewCell cell2 = new DataGridViewTextBoxCell()
            {
                Value = match.Team1 + " - " + match.Team2
            };

            DataGridViewCell cell3 = new DataGridViewTextBoxCell()
            {
                Value = match.Score
            };

            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);

            return row;

        }
    }
}
