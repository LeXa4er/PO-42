using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WatchStore.Resources
{
    public partial class Opisanie : UserControl
    {
        int idWatch;

        public Opisanie(int idwatch)
        {
            InitializeComponent();
            this.idWatch = idwatch;
            LoadOpisanieWatch();
        }

        private void LoadOpisanieWatch()
        {
            DataBase database = new DataBase();
            database.openConnection();

            // Запрос на получение информации о фильме по его названию
            string query = $"SELECT ID_watch, Model, Manufacturers.Manufacturer, Gender, Cost, image, Country, Opisanie, Warranty FROM Watchs JOIN Types ON Watchs.ID_type = Types.ID_type JOIN Manufacturers ON Watchs.ID_manufacturer = Manufacturers.ID_manufacturer " +
                 $" WHERE ID_watch = @IDWatch";
            SqlCommand command = new SqlCommand(query, database.getConnection());
            command.Parameters.AddWithValue("@IDWatch", idWatch);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Извлечение данных фильма из результата запроса
                int idwatch = reader.GetInt32(0);
                string model = reader.GetString(1);
                string manufact = reader.GetString(2);
                string gender = reader.GetString(3);
                int cost = reader.GetInt32(4);
                string CostString = cost.ToString();
                string img = reader.GetString(5);
                string country = reader.GetString(6);
                string opisanie = reader.GetString(7);
                string warrant = reader.GetString(8);

                // Заполнение элементов формы данными из базы данных
                modellb.Text = model;
                modellb.Text = model;
                manufaclb.Text = manufact;
                genderlb.Text = gender;
                countrylb.Text = country;
                costlb.Text = CostString;
                opisanielb.Text = opisanie;
                warrantylb.Text = warrant;
                imgpb.Image = Image.FromFile(img);
            }

            reader.Close();
            command.Dispose();
            database.closeConnection();
        }
    }
}
