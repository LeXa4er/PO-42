using System.IO;
using System.Windows.Forms;

namespace _3Days.ManeLogic
{
    public static class DataWorker
    {
        public static string CombinePicturePath(string pictureName)
        => Directory.GetCurrentDirectory() + @"/../../Pictures/" + pictureName;

        public static void Exit()
        {
            var result = MessageBox.Show("Вы точно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
