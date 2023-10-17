using _3Days.DataBase;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3Days.ManeLogic
{
    internal class TeamController : IPageController
    {
        private Panel _panel;
        private List<Team> _teams;

        public TeamController(Panel panel)
        {
            _panel = panel;
        }

        public void ShowPage()
        {
            TeamsPage teamsPage = new TeamsPage(_teams)
            {
                Dock = DockStyle.Fill,
            };

            _panel.Controls.Add(teamsPage);
        }

        public void TakeInfo()
        {
            _teams = DB.GetTeams();
        }
    }
}
