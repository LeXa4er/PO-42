using System.Drawing;
using System.Windows.Forms;

namespace _3Days.ManeLogic
{
    public static class ControlsCreator
    {
        public static Label CreateLabelForData()
        {
            return new Label()
            {
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Height = 28,
                Dock = DockStyle.Top,
                BackColor = Color.White,
                Margin = new Padding(1, 1, 1, 0),
            };
        }
    }
}
