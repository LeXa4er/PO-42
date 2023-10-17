using _3Days.DataBase;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3Days.ManeLogic
{
    internal abstract class MatchController : IPageController
    {
        public List<MatchInfo> Matches = new List<MatchInfo>();

        protected MatchesType MatchesType;

        protected Panel Panel;

        public MatchController(Panel panel)
        {
            Panel = panel;
        }

        public void TakeInfo()
        {
            Matches = DB.GetMatches(MatchesType);

            foreach (var match in Matches)
            {
                match.Team1 = DB.GetTeam(match.FirstTeamId);
                match.Team2 = DB.GetTeam(match.SecondTeamId);
            }
        }

        public abstract void ShowPage();
    }
}
