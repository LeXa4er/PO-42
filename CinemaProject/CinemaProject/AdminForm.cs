using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;


namespace CinemaProject
{
    public partial class AdminForm : Form
    {
        private SqlConnection connection;

        public AdminForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-V7FB61F\\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
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

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadAdminsData();
        }

        private void LoadAdminsData()
        {
            string query = "SELECT UserID, Username FROM Users WHERE IsAdmin = 1";
            System.Data.DataTable dataTable = new System.Data.DataTable(); // Указываем полное имя типа здесь
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataTable);

            guna2DataGridView1.DataSource = dataTable;
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                int userId = Convert.ToInt32(guna2DataGridView1.Rows[rowIndex].Cells["UserID"].Value);
                string username = guna2DataGridView1.Rows[rowIndex].Cells["Username"].Value.ToString();

                guna2TextBox2.Text = username;
            }
        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            string username = guna2TextBox2.Text;
            string password = guna2TextBox1.Text; // Пароль, не забудьте обеспечить его безопасность, например, хеширование.

            string insertQuery = "INSERT INTO Users (Username, Password, IsAdmin) VALUES (@Username, @Password, 1)";
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password); // Обеспечьте безопасность пароля!
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadAdminsData();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                int userId = Convert.ToInt32(guna2DataGridView1.Rows[rowIndex].Cells["UserID"].Value);
                string newUsername = guna2TextBox2.Text;
                string newPassword = guna2TextBox1.Text; // Пароль, не забудьте обеспечить его безопасность, например, хеширование.

                string updateQuery = "UPDATE Users SET Username=@Username, Password=@Password WHERE UserID=@UserID";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", newUsername);
                    command.Parameters.AddWithValue("@Password", newPassword); // Обеспечьте безопасность пароля!
                    command.Parameters.AddWithValue("@UserID", userId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadAdminsData();
            }
            else
            {
                MessageBox.Show("Выберите администратора для обновления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                int userId = Convert.ToInt32(guna2DataGridView1.Rows[rowIndex].Cells["UserID"].Value);

                string deleteQuery = "DELETE FROM Users WHERE UserID=@UserID";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadAdminsData();
            }
            else
            {
                MessageBox.Show("Выберите администратора для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Отчет_{timestamp}.docx");

            // Создание нового документа Word и добавление временной метки
            dynamic wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;

            dynamic doc = wordApp.Documents.Add();
            dynamic paragraph = doc.Paragraphs.Add();
            paragraph.Range.Text = "Отчет о времени открытия программы: " + timestamp;
            paragraph.Range.InsertParagraphAfter();

            // Сохранение файла в корне проекта
            doc.SaveAs2(fileName);

            // Освобождаем ресурсы
            doc.Close();
            Marshal.ReleaseComObject(paragraph);
            Marshal.ReleaseComObject(doc);
            Marshal.ReleaseComObject(wordApp);

            // Открытие сохраненного документа Word
            if (File.Exists(fileName))
            {
                wordApp.Documents.Open(fileName);
            }
            else
            {
                MessageBox.Show("Не удалось найти файл отчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}