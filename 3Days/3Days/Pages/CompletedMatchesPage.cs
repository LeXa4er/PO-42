using _3Days.DataBase;
using _3Days.ManeLogic;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _3Days
{
    public partial class CompletedMatchesPage : UserControl
    {
        public CompletedMatchesPage()
        {
            InitializeComponent();
        }

        public CompletedMatchesPage(IEnumerable<MatchInfo> matches)
        {
            InitializeComponent();

            RefillTable(matches);
        }

        private void RefillTable(IEnumerable<MatchInfo> matches)
        {
            int rowNumber = 0;

            MatchesPanel.Controls.Clear();

            if (matches != null)
            {
                MatchesPanel.SuspendLayout();

                foreach (var match in matches)
                {
                    Label date = ControlsCreator.CreateLabelForData();
                    date.Text = match.Date.ToString();
                    date.TextAlign = ContentAlignment.MiddleCenter;

                    Label teams = ControlsCreator.CreateLabelForData();
                    teams.Text = match.Team1 + " - " + match.Team2;
                    teams.TextAlign = ContentAlignment.MiddleCenter;

                    Label score = ControlsCreator.CreateLabelForData();
                    score.Text = match.Score;
                    score.TextAlign = ContentAlignment.MiddleCenter;

                    Label description = ControlsCreator.CreateLabelForData();
                    description.Text = match.Description;
                    description.TextAlign = ContentAlignment.MiddleLeft;

                    Label[] labels = new Label[]
                    {
                        date, teams,score, description
                    };

                    AddRow(labels, rowNumber);

                    rowNumber++;
                }

                MatchesPanel.ResumeLayout();
            }
        }

        protected virtual void AddRow(Label[] labels, int rowIndex)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                MatchesPanel.Controls.Add(labels[i], i, rowIndex);
            }
        }
    }
}
