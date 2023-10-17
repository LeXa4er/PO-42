using System.Collections.Generic;

namespace _3Days.ManeLogic
{
    public class FormDataController
    {
        public readonly MainForm Parent;

        private List<IPageController> _pageControllers;

        public FormDataController(MainForm parent)
        {
            Parent = parent;

            InitializeDictionary();
        }

        public void ShowPage(int pageIndex)
        {
            _pageControllers[pageIndex].TakeInfo();

            _pageControllers[pageIndex].ShowPage();

        }

        private void InitializeDictionary()
        {
            _pageControllers = new List<IPageController>()
            {
                new UpcomingMatchController(Parent.MainPanel),
                new CompletedMatchController(Parent.MainPanel),
                new TeamController(Parent.MainPanel),
                new CoachesController(Parent.MainPanel),
            };
        }
    }
}
