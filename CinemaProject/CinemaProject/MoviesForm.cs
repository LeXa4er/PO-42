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

namespace CinemaProject
{
    public partial class MoviesForm : Form
    {
        public class Movie
        {
            public int MovieID { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public decimal Rating { get; set; }
            public int Duration { get; set; }
            public byte[] Poster { get; set; }
    
        }
        private List<Movie> moviesList = new List<Movie>();
        public SqlConnection connection;
        private int selectedMovieId = -1;
        public MoviesForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-V7FB61F\\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;
            string rating = numericUpDownRating.Text;
            int duration = trackBarDuration.Value;

            if (decimal.TryParse(rating, out decimal ratingValue) && ratingValue >= 0.0M && ratingValue <= 10.0M)
            {
                // Введенное значение прошло проверку
                decimal ratingResult = ratingValue;
                // Теперь вы можете использовать значение "ratingResult" в вашем коде.
            }
            else
            {
                MessageBox.Show("Введите корректное значение рейтинга от 0.0 до 10.0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Пользователь ввел некорректное значение рейтинга.
            }

            // Получение изображения из PictureBox
            byte[] poster = null;
            if (pictureBoxPoster.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxPoster.Image.Save(ms, pictureBoxPoster.Image.RawFormat);
                    poster = ms.ToArray();
                }
            }

            // Добавление нового фильма в базу данных
            string insertQuery = "INSERT INTO Movies (Title, Description, Rating, Duration, Poster) VALUES (@Title, @Description, @Rating, @Duration, @Poster)";
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Rating", rating);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Poster", poster);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            // После добавления обновляем отображаемые данные
            LoadMoviesData();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == -1)
            {
                MessageBox.Show("Выберите фильм для обновления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;
            string rating = numericUpDownRating.Text;
            int duration = trackBarDuration.Value;

            if (decimal.TryParse(rating, out decimal ratingValue) && ratingValue >= 0.0M && ratingValue <= 10.0M)
            {
                // Введенное значение прошло проверку
                decimal ratingResult = ratingValue;
                // Теперь вы можете использовать значение "ratingResult" в вашем коде.
            }
            else
            {
                MessageBox.Show("Введите корректное значение рейтинга от 0.0 до 10.0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Пользователь ввел некорректное значение рейтинга.
            }

            // Получение изображения из PictureBox
            byte[] poster = null;
            if (pictureBoxPoster.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxPoster.Image.Save(ms, pictureBoxPoster.Image.RawFormat);
                    poster = ms.ToArray();
                }
            }

            // Обновление данных фильма в базе данных
            string updateQuery = "UPDATE Movies SET Title=@Title, Description=@Description, Rating=@Rating, Duration=@Duration, Poster=@Poster WHERE MovieID=@MovieID";
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Rating", rating);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Poster", poster);
                command.Parameters.AddWithValue("@MovieID", selectedMovieId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            // После обновления обновляем отображаемые данные
            LoadMoviesData();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == -1)
            {
                MessageBox.Show("Выберите фильм для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Удаление выбранного фильма из базы данных
            string deleteQuery = "DELETE FROM Movies WHERE MovieID=@MovieID";
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@MovieID", selectedMovieId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            // После удаления обновляем отображаемые данные
            LoadMoviesData();
        }

        private void guna2HtmlLabel22_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {
            Hide();
            SessionsForm sessionsForm = new SessionsForm();
            sessionsForm.ShowDialog();
        }

       

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            LoadMoviesData();
        }

        private void LoadMoviesData()
        {
            string query = "SELECT MovieID, Title, Description, Rating, Duration, Poster FROM Movies";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Очистка списка перед заполнением новыми данными
            moviesList.Clear();

            // Заполнение moviesList данными из базы данных
            foreach (DataRow row in dataTable.Rows)
            {
                Movie movie = new Movie
                {
                    MovieID = Convert.ToInt32(row["MovieID"]),
                    Title = row["Title"].ToString(),
                    Description = row["Description"].ToString(),
                    Rating = Convert.ToDecimal(row["Rating"]),
                    Duration = Convert.ToInt32(row["Duration"]),
                    Poster = row["Poster"] as byte[]
                };

                moviesList.Add(movie);
            }

            // Устанавливаем источник данных для DataGridView
            dataGridViewMovies.DataSource = dataTable;
        }
        private void dataGridViewMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMovies.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewMovies.SelectedRows[0].Index;
                selectedMovieId = Convert.ToInt32(dataGridViewMovies.Rows[rowIndex].Cells["MovieID"].Value);
                textBoxTitle.Text = dataGridViewMovies.Rows[rowIndex].Cells["Title"].Value.ToString();
                textBoxDescription.Text = dataGridViewMovies.Rows[rowIndex].Cells["Description"].Value.ToString();
                numericUpDownRating.Text = dataGridViewMovies.Rows[rowIndex].Cells["Rating"].Value.ToString(); // Здесь используем Text вместо Value
                trackBarDuration.Value = Convert.ToInt32(dataGridViewMovies.Rows[rowIndex].Cells["Duration"].Value);

                // Отображение изображения в PictureBox
                byte[] posterData = (byte[])dataGridViewMovies.Rows[rowIndex].Cells["Poster"].Value;
                if (posterData != null && posterData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(posterData))
                    {
                        pictureBoxPoster.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxPoster.Image = null;
                }
            }
        }

        private void pictureBoxPoster_Click(object sender, EventArgs e)
        {
            // Выбор изображения для постера фильма
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPoster.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        private int currentMovieIndex = 0;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (currentMovieIndex < moviesList.Count - 1)
            {
                currentMovieIndex++; // Увеличиваем индекс
                ShowMovieByIndex(currentMovieIndex);
            }
        }
        private void ShowMovieByIndex(int index)
        {
            if (index >= 0 && index < moviesList.Count)
            {
                Movie movie = moviesList[index]; // Получаем фильм из списка или базы данных
                pictureBox3.Image = LoadMoviePoster(movie.Poster); // Загружаем постер фильма
                guna2HtmlLabel1.Text = movie.Title;
                guna2HtmlLabel4.Text = movie.Rating.ToString();
                guna2HtmlLabel5.Text = movie.Duration.ToString() + " мин";
                guna2HtmlLabel21.Text = movie.Description;
            }
        }
        private Image LoadMoviePoster(byte[] posterData)
        {
            if (posterData != null && posterData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(posterData))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string searchKeyword = guna2TextBox1.Text;
            int foundIndex = FindMovieIndex(searchKeyword);

            if (foundIndex != -1)
            {
                currentMovieIndex = foundIndex;
                ShowMovieByIndex(currentMovieIndex);
            }
            else
            {
                MessageBox.Show("Фильм не найден.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private int FindMovieIndex(string keyword)
        {
            for (int i = 0; i < moviesList.Count; i++)
            {
                if (moviesList[i].Title.ToLower().Contains(keyword.ToLower()))
                {
                    return i; // Найден фильм с соответствующим названием
                }
            }
            return -1; // Фильм не найден
        }

    }
}
