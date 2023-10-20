using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicMusic
{
    internal class DataBase
    {
        static readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UVRE81G;Initial Catalog=ClassicMusic;Integrated Security=True;MultipleActiveResultSets=true;");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            { con.Open(); }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            { con.Close(); }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }

        public static SqlConnection GetOpenConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UVRE81G;Initial Catalog=ClassicMusic;Integrated Security=True;MultipleActiveResultSets=true;");
            con.Open();
            return con;
        }
    }
}
