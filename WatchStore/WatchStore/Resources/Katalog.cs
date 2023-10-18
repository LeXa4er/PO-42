using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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
            panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6 };
            foreach (var panel in panels)
            {
                // Добавьте обработчик события Click
                panel.Click += WatchPanel_Click;
            }
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

                // Выбираем строки по частям
                string query = $"SELECT ID_watch, Model, Manufacturers.Manufacturer, Gender, Cost, image FROM Watchs JOIN Types ON Watchs.ID_type = Types.ID_type JOIN Manufacturers ON Watchs.ID_manufacturer = Manufacturers.ID_manufacturer " +
                    $" WHERE (Types.Type = '{selectedType}' OR '{selectedType}' = 'All') AND (Gender = '{selectedGender}' OR '{selectedGender}' = 'All') ORDER BY ID_watch OFFSET {currentRowIndex} ROWS FETCH NEXT 6 ROWS ONLY";
                SqlCommand command = new SqlCommand(query, database.getConnection());
                SqlDataReader reader = command.ExecuteReader();

                for (int i = 0; i < panels.Length; i++)
                {
                    panels[i].Visible = false; // Сначала скрываем все панели
                }

                if (reader.HasRows)
                {
                    int rowIndex = 0;

                    while (reader.Read())
                    {
                        int idwatch = reader.GetInt32(0);
                        string model = reader.GetString(1);
                        string manufact = reader.GetString(2);
                        string gender = reader.GetString(3);
                        int cost = reader.GetInt32(4);
                        string CostString = cost.ToString();
                        string img = reader.GetString(5);

                        // Определите индекс панели, соответствующей этим данным
                        Panel targetPanel = panels[rowIndex];

                        // Заполните элементы формы данными из базы данных для определенной панели
                        Control[] textControls = targetPanel.Controls.Find($"namelb{rowIndex + 1}", true);
                        if (textControls.Length > 0 && textControls[0] is Label namelb)
                        {
                            namelb.Text = model;
                        }

                        Control[] manufacControls = targetPanel.Controls.Find($"manufaclb{rowIndex + 1}", true);
                        if (manufacControls.Length > 0 && manufacControls[0] is Label manufaclb)
                        {
                            manufaclb.Text = manufact;
                        }

                        Control[] genderControls = targetPanel.Controls.Find($"genderlb{rowIndex + 1}", true);
                        if (genderControls.Length > 0 && genderControls[0] is Label genderlb)
                        {
                            genderlb.Text = gender;
                        }

                        Control[] costControls = targetPanel.Controls.Find($"costlb{rowIndex + 1}", true);
                        if (costControls.Length > 0 && costControls[0] is Label costlb)
                        {
                            costlb.Text = CostString;
                        }

                        Control[] imageControls = targetPanel.Controls.Find($"imagepb{rowIndex + 1}", true);
                        if (imageControls.Length > 0 && imageControls[0] is PictureBox imagepb)
                        {
                            imagepb.Image = Image.FromFile(img);
                        }

                        targetPanel.Tag = idwatch; // Обновите значение Tag для определенной панели
                        targetPanel.Visible = true; // Сделайте панель видимой, так как у неё есть данные

                        rowIndex++;
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
                    else
                    {
                        loadMorebt.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к серверу: {ex.Message}", "Ошибка");
            }
        }



        private void WatchPanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel watchPanel)
            {
                // Получите ID_watch из Tag панели
                if (watchPanel.Tag is int idwatch)
                {
                    Opisanie opisan = new Opisanie(idwatch);
                    Mane parentForm = this.ParentForm as Mane;
                    parentForm?.LoadControl(opisan);
                }
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
