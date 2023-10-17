using _3Days.DataBase;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3Days.ManeLogic
{
    internal class CoachesController : IPageController
    {
        private List<Coach> _coachList;
        private Panel _panel;

        public CoachesController(Panel panel)
        {
            _panel = panel;
        }

        public void ShowPage()
        {
            CoachesPage page = new CoachesPage(_coachList)
            {
                Dock = DockStyle.Fill,
            };

            _panel.Controls.Add(page);
        }

        public void TakeInfo()
        {
            _coachList = DB.GetCoaches();
        }
    }
}
