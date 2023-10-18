using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchStore.Classes
{
    public class Connection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-P28HUVI;Initial Catalog=WatchStore;Integrated Security=True");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {

                try { sqlConnection.Open(); }
                catch { MessageBox.Show("Не удалось подключиться к базе данных", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Метод getSqlConnection() нужен, чтобы возвращать строку подключения.
        /// </summary>
        /// SqlConnection
        /// <returns>Возвращает строку подключения</returns>

        public SqlConnection GetSqlConnection() { return sqlConnection; }
    }
}
