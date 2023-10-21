using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class SessionsForm : Form
    {
        public SqlConnection connection;
        public SessionsForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-V7FB61F\\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm =   new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {
            Hide();
            MoviesForm movieForm = new MoviesForm();    
            movieForm.ShowDialog();
        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {
            Hide();
            BookingsForm bookingsForm = new BookingsForm();
            bookingsForm.ShowDialog();
        }

        private void SessionsForm_Load(object sender, EventArgs e)
        {
            LoadSessionsData();
            LoadMoviesIntoComboBox();

        }

        private void LoadMoviesIntoComboBox()
        {
            string query = "SELECT MovieID, Title FROM Movies";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            guna2ComboBox1.DisplayMember = "Title";
            guna2ComboBox1.ValueMember = "MovieID";
            guna2ComboBox1.DataSource = dataTable;
        }
        private int selectedSessionId = -1;

        private void LoadSessionsData()
        {
            // Получение данных из базы данных и заполнение DataGridView
            string query = "SELECT SessionID, MovieID, StartTime FROM Sessions";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable;

            // Заполнение ComboBox данными о фильмах
            query = "SELECT MovieID, Title FROM Movies";
            SqlDataAdapter movieAdapter = new SqlDataAdapter(query, connection);
            DataTable movieDataTable = new DataTable();
            movieAdapter.Fill(movieDataTable);
            guna2ComboBox1.DataSource = movieDataTable;
            guna2ComboBox1.DisplayMember = "Title";
            guna2ComboBox1.ValueMember = "MovieID";
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            // Создание нового сеанса
            int movieId = (int)guna2ComboBox1.SelectedValue;
            DateTime startTime = guna2DateTimePicker1.Value;

            string insertQuery = "INSERT INTO Sessions (MovieID, StartTime) VALUES (@MovieID, @StartTime)";
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@MovieID", movieId);
                command.Parameters.AddWithValue("@StartTime", startTime);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadSessionsData();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            // Изменение выбранного сеанса
            if (selectedSessionId != -1)
            {
                int movieId = (int)guna2ComboBox1.SelectedValue;
                DateTime startTime = guna2DateTimePicker1.Value;

                string updateQuery = "UPDATE Sessions SET MovieID=@MovieID, StartTime=@StartTime WHERE SessionID=@SessionID";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MovieID", movieId);
                    command.Parameters.AddWithValue("@StartTime", startTime);
                    command.Parameters.AddWithValue("@SessionID", selectedSessionId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadSessionsData();
            }
            else
            {
                MessageBox.Show("Выберите сеанс для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            // Отмена выбранного сеанса
            if (selectedSessionId != -1)
            {
                string deleteQuery = "DELETE FROM Sessions WHERE SessionID=@SessionID";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@SessionID", selectedSessionId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadSessionsData();
            }
            else
            {
                MessageBox.Show("Выберите сеанс для отмены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowSessionDetails(int sessionId)
        {
            // Получение данных о сеансе из базы данных и отображение на форме
            string query = "SELECT MovieID, StartTime FROM Sessions WHERE SessionID=@SessionID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SessionID", sessionId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int movieId = Convert.ToInt32(reader["MovieID"]);
                    DateTime startTime = Convert.ToDateTime(reader["StartTime"]);

                    // Отобразите данные о сеансе в guna2HtmlLabel8 и guna2HtmlLabel9
                    guna2HtmlLabel8.Text = $"Название фильма: {GetMovieTitle(movieId)}";
                    guna2HtmlLabel9.Text = $"Дата и время начала сеанса: {startTime}";

                    // Другие данные о сеансе
                }
                connection.Close();
            }
        }

        private string GetMovieTitle(int movieId)
        {
            // Получение названия фильма по его ID из базы данных
            string query = "SELECT Title FROM Movies WHERE MovieID=@MovieID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MovieID", movieId);
                connection.Open();
                string title = command.ExecuteScalar().ToString();
                connection.Close();
                return title;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обработка нажатия на ячейку в DataGridView
            if (e.RowIndex >= 0)
            {
                int sessionId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["SessionID"].Value);
                ShowSessionDetails(sessionId);
            }
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                selectedSessionId = Convert.ToInt32(guna2DataGridView1.Rows[rowIndex].Cells["SessionID"].Value);
                guna2ComboBox1.SelectedValue = guna2DataGridView1.Rows[rowIndex].Cells["MovieID"].Value;
                guna2DateTimePicker1.Value = Convert.ToDateTime(guna2DataGridView1.Rows[rowIndex].Cells["StartTime"].Value);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            // Отображение следующего сеанса
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int currentIndex = guna2DataGridView1.SelectedRows[0].Index;
                if (currentIndex < guna2DataGridView1.Rows.Count - 1)
                {
                    guna2DataGridView1.Rows[currentIndex + 1].Selected = true;
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Отображение предыдущего сеанса
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int currentIndex = guna2DataGridView1.SelectedRows[0].Index;
                if (currentIndex > 0)
                {
                    guna2DataGridView1.Rows[currentIndex - 1].Selected = true;
                }
            }
        }
    }
}
