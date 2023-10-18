using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WatchStore.Resources
{
    internal class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S21HR1A;Initial Catalog=WatchStore;Integrated Security=True");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
