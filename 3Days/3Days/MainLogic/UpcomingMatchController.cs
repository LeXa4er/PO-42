using _3Days.DataBase;
using System.Windows.Forms;

namespace _3Days.ManeLogic
{
    internal class UpcomingMatchController : MatchController
    {
        public UpcomingMatchController(Panel panel) : base(panel)
        {
            MatchesType = MatchesType.Upcoming;
        }

        public override void ShowPage()
        {
            var page = new UpcomingMatchesPage(Matches)
            {
                Dock = DockStyle.Fill,
            };

            Panel.Controls.Add(page);
        }
    }
}
