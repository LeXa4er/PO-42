using _3Days.DataBase;
using System.Windows.Forms;

namespace _3Days.ManeLogic
{
    internal class CompletedMatchController : MatchController
    {
        public CompletedMatchController(Panel panel) : base(panel)
        {
            MatchesType = MatchesType.Complited;
        }

        public override void ShowPage()
        {
            var page = new CompletedMatchesPage(Matches)
            {
                Dock = DockStyle.Fill,
            };

            Panel.Controls.Add(page);
        }
    }
}
