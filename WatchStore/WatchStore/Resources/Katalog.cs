using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WatchStore.Resources
{
    public partial class Katalog : UserControl
    {
        DataBase database = new DataBase();
        Panel[] panels;
        private int currentRowIndex = 0;
        private string selectedType = "All";
        private string selectedGender = "All";

        public Katalog()
        {
            InitializeComponent();
            LoadComboBox();
            panels = new Panel[] {panel1, panel2, panel3, panel4, panel5, panel6};
            LoadWatch();
        }

        private void LoadWatch()
        {
            try
            {
                database.openConnection();
                // Подсчитываем количество строк в таблице
                string countQuery = $"SELECT COUNT(*) FROM Watchs JOIN Types ON Watchs.ID_type = Types.ID_type" +
                    $" WHERE (Types.Type = '{selectedType}' OR '{selectedType}' = 'All') AND (Gender = '{selectedGender}' OR '{selectedGender}' = 'All')";
                SqlCommand countCommand = new SqlCommand(countQuery, database.getConnection());
                int totalWatch = (int)countCommand.ExecuteScalar();

                // Определяем, сколько задач осталось для загрузки
                int remainingWatch = totalWatch - currentRowIndex;

                // Скрываем панели, если нет больше задач для отображения
                for (int i = 0; i < panels.Length; i++)
                {
                    if (i < remainingWatch)
                    {
                        panels[i].Visible = true;
                    }
                    else
                    {
                        panels[i].Visible = false;
                    }
                }

                // Выбираем строки по частям
                string query = $"SELECT Model, Manufacturers.Manufacturer, Gender, Cost, image FROM Watchs JOIN Types ON Watchs.ID_type = Types.ID_type JOIN Manufacturers ON Watchs.ID_manufacturer = Manufacturers.ID_manufacturer " +
                    $" WHERE (Types.Type = '{selectedType}' OR '{selectedType}' = 'All') AND (Gender = '{selectedGender}' OR '{selectedGender}' = 'All') ORDER BY ID_watch OFFSET {currentRowIndex} ROWS FETCH NEXT 6 ROWS ONLY";
                SqlCommand command = new SqlCommand(query, database.getConnection());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int rowIndex = 1;

                    while (reader.Read())
                    {
                        string model = reader.GetString(0);
                        string manufact = reader.GetString(1);
                        string gender = reader.GetString(2);
                        int cost = reader.GetInt32(3);
                        string CostString = cost.ToString();
                        string img = reader.GetString(4);

                        // Заполняем элементы формы данными из базы данных
                        foreach (var panel in panels)
                        {
                            Control[] textControls = panel.Controls.Find($"namelb{rowIndex}", true);
                            if (textControls.Length > 0 && textControls[0] is Label namelb)
                            {
                                namelb.Text = model;
                            }

                            Control[] manufacControls = panel.Controls.Find($"manufaclb{rowIndex}", true);
                            if (manufacControls.Length > 0 && manufacControls[0] is Label manufaclb)
                            {
                                manufaclb.Text = manufact;
                            }

                            Control[] genderControls = panel.Controls.Find($"genderlb{rowIndex}", true);
                            if (genderControls.Length > 0 && genderControls[0] is Label genderlb)
                            {
                                genderlb.Text = gender;
                            }

                            Control[] costControls = panel.Controls.Find($"costlb{rowIndex}", true);
                            if (costControls.Length > 0 && costControls[0] is Label costlb)
                            {
                                costlb.Text = CostString;
                            }

                            Control[] imageControls = panel.Controls.Find($"imagepb{rowIndex}", true);
                            if (imageControls.Length > 0 && imageControls[0] is PictureBox imagepb)
                            {
                                imagepb.Image = Image.FromFile(img);
                            }

                        }
                        rowIndex += 1;
                    }

                    reader.Close();
                    countCommand.Dispose();
                    command.Dispose();
                    database.closeConnection();

                    //Скрытие кнопки назад
                    loadBackbt.Visible = currentRowIndex > 0;

                    //Скрытие кнопки загрузить ещё
                    if (currentRowIndex + 6 >= totalWatch)
                    {
                        loadMorebt.Visible = false;
                    }
                    else loadMorebt.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к серверу: {ex.Message}", "Ошибка");
            }

        }

        private void LoadComboBox()
        {
            database.openConnection();
            string queryType = "SELECT * FROM Types";
            SqlCommand commandType = new SqlCommand(queryType, database.getConnection());
            SqlDataReader readerType = commandType.ExecuteReader();
            if (readerType.HasRows)
            {
                while (readerType.Read())
                {
                    typeCb.Items.Add(readerType["Type"]);
                }
            }
            readerType.Close();
            commandType.Dispose();
            database.closeConnection();
        }

        private void dtSerch_Click(object sender, EventArgs e)
        {
            currentRowIndex = 0;
            selectedType = string.IsNullOrEmpty(typeCb.Text) ? "All" : typeCb.Text;
            selectedGender = string.IsNullOrEmpty(genderCb.Text) ? "All" : genderCb.Text;
            LoadWatch();
        }

        private void resetFilter_Click(object sender, EventArgs e)
        {
            currentRowIndex = 0;
            typeCb.Text = string.Empty;
            genderCb.Text = string.Empty;
            selectedType = "All";
            selectedGender = "All";
            LoadWatch();
        }

        private void loadBackbt_Click(object sender, EventArgs e)
        {
            currentRowIndex -= 6;
            LoadWatch();
        }

        private void loadMorebt_Click(object sender, EventArgs e)
        {
            currentRowIndex += 6;
            LoadWatch();
        }
    }
}
