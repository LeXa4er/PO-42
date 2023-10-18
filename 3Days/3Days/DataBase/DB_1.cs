using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _3Days.DataBase
{
    internal static partial class DB
    {
        private static string _connectionString = "Data Source=RIINNOTEBOOK\\SQLEXPRESS01;Initial Catalog=Football;Integrated Security=True";

        public static SqlConnection GetNewOpenConnection()
        {
            
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        private static void ShowError(string message)
        {
            MessageBox.Show("Не удалось выполнить запрос. " + message, "Приложение не может продолжать работу"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }

        public static Coach GetCoach(int id)
        {
            string queryText = $"SELECT {COACH_SURNAME}, {COACH_NAME}, {COACH_PATRONYMIC}, " +
                $"{COACH_BIOGRAPHY} FROM {COACHES_TABLE} WHERE {COACH_ID} = @coachId";

            try
            {
                using (SqlConnection connection = GetNewOpenConnection())
                {
                    SqlCommand command = new SqlCommand(queryText, connection);

                    command.Parameters.AddWithValue("coachId", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Coach()
                        {
                            ID = id,
                            Name = $" {reader.GetString(0)} {reader.GetString(1)} {reader.GetString(2)}",
                            Biography = reader.GetString(3)
                        };
                    };
                }
            }
            catch
            {
                ShowError("Не удалось выполнить выборку с базы данных");
            }
            return null;
        }

        public static List<Coach> GetCoaches()
        {
            string queryText = $"SELECT {COACH_ID}, {COACH_SURNAME}, {COACH_NAME}, " +
                $"{COACH_PATRONYMIC}, {COACH_BIOGRAPHY}, {COACH_PHOTO} FROM {COACHES_TABLE}";

            List<Coach> coaches = new List<Coach>();

            try
            {
                using (SqlConnection connection = GetNewOpenConnection())
                {
                    SqlCommand command = new SqlCommand(queryText, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var coach = new Coach()
                        {
                            ID = reader.GetInt32(0),
                            Name = $" {reader.GetString(1)} {reader.GetString(2)} {reader.GetString(3)}",
                        };

                        if (!reader.IsDBNull(4))
                            coach.Biography = reader.GetString(4);

                        if (!reader.IsDBNull(5))
                            coach.PhotoPath = reader.GetString(5);

                        coaches.Add(coach);
                    };
                }
            }
            catch
            {
                ShowError("Не удалось выполнить выборку с базы данных");
            }

            return coaches;
        }

        public static Team GetTeam(int id)
        {
            string queryText = $"SELECT {TEAM_NAME}, {TEAM_COACH} FROM {TEAMS_TABLE} WHERE {TEAM_ID} = @teamId";

            try
            {
                using (SqlConnection connection = GetNewOpenConnection())
                {
                    SqlCommand command = new SqlCommand(queryText, connection);

                    command.Parameters.AddWithValue("teamId", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Team()
                        {
                            ID = id,
                            Name = reader.GetString(0),
                            CoachId = reader.GetInt32(1),
                        };
                    };
                }
            }
            catch
            {
                ShowError("Не удалось выполнить выборку с базы данных");
            }
            return null;
        }


        public static List<Team> GetTeams()
        {
            string queryText = $"SELECT {TEAM_ID}, {TEAM_NAME}, {TEAM_COACH} FROM {TEAMS_TABLE}";

            return GetTeams(queryText);
        }

        public static List<Team> GetTeams(Coach coach)
        {
            string queryText = $"SELECT {TEAM_ID}, {TEAM_NAME}, {TEAM_COACH} FROM {TEAMS_TABLE} " +
                $"WHERE {TEAM_COACH} = {coach.ID}";

            return GetTeams(queryText);
        }

        private static List<Team> GetTeams(string queryText)
        {
            List<Team> teams = new List<Team>();

            try
            {
                using (SqlConnection connection = GetNewOpenConnection())
                {
                    SqlCommand command = new SqlCommand(queryText, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Team team = new Team()
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            CoachId = reader.GetInt32(2),
                        };

                        teams.Add(team);
                    };
                }

            }
            catch
            {
                ShowError("Не удалось выполнить выборку с базы данных");
            }

            return teams;
        }

        public static List<MatchInfo> GetMatches(MatchesType type)
        {
            DateTime currentDate = DateTime.Now;

            string query =
                $"SELECT {MATCH_ID}, {MATCH_COMMAND1}, {MATCH_COMMAND2}, " +
                $"{MATCH_DESCRIPTION}, {MATCH_DATE}, {MATCH_RESULT} FROM {MATCHES_TABLE} ";

            switch (type)
            {
                case MatchesType.Upcoming:
                    query += $"WHERE {MATCH_DATE} > '{currentDate:yyyy-MM-dd HH:mm:ss}'";
                    break;
                case MatchesType.Complited:
                    query += $"WHERE {MATCH_DATE} <= '{currentDate:yyyy-MM-dd HH:mm:ss}'";
                    break;
            }

            List<MatchInfo> matches = new List<MatchInfo>();

            try
            {
                using (SqlConnection connection = GetNewOpenConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MatchInfo matchInfo = new MatchInfo()
                        {
                            Id = reader.GetInt32(0),
                            FirstTeamId = reader.GetInt32(1),
                            SecondTeamId = reader.GetInt32(2),
                            Date = reader.GetDateTime(4)
                        };

                        string description = "";
                        string score = "";

                        if (!reader.IsDBNull(3)) description = reader.GetString(3);
                        if (!reader.IsDBNull(5)) score = reader.GetString(5);

                        matchInfo.Description = description;
                        matchInfo.Score = score;

                        matches.Add(matchInfo);
                    };

                    return matches;
                }
            }
            catch
            {
                ShowError("Не удалось выполнить выборку с базы данных");
            }
            return null;
        }

        public static List<MatchInfo> GetMatches(Team team)
        {
            string query =
                $"SELECT {MATCH_ID}, {MATCH_COMMAND1}, {MATCH_COMMAND2}, " +
                $"{MATCH_DATE}, {MATCH_RESULT}, t1.{TEAM_NAME}, t2.{TEAM_NAME} " +
                $"FROM {MATCHES_TABLE} M " +
                $"JOIN {TEAMS_TABLE} t1 ON m.{MATCH_COMMAND1} = t1.{TEAM_ID} " +
                $"JOIN {TEAMS_TABLE} t2 ON m.{MATCH_COMMAND2} = t2.{TEAM_ID} " +
                $"WHERE {MATCH_COMMAND1} = '{team.ID}' OR {MATCH_COMMAND2} = '{team.ID}'";

            List<MatchInfo> matches = new List<MatchInfo>();

            try
            {
                using (SqlConnection connection = GetNewOpenConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MatchInfo matchInfo = new MatchInfo()
                        {
                            Id = reader.GetInt32(0),
                            FirstTeamId = reader.GetInt32(1),
                            SecondTeamId = reader.GetInt32(2),
                            Date = reader.GetDateTime(3),

                            Team1 = new Team()
                            {
                                Name = reader.GetString(5)
                            },

                            Team2 = new Team()
                            {
                                Name = reader.GetString(6)
                            }
                        };

                        string score = "";
                        if (!reader.IsDBNull(4)) score = reader.GetString(4);

                        matchInfo.Score = score;

                        matches.Add(matchInfo);

                    };

                    return matches;
                }
            }
            catch
            {
                ShowError("Не удалось выполнить выборку с базы данных");
            }
            return null;
        }

        public static bool TryTakeUser(string login, string password, out User user)
        {
            string queryText = $"SELECT {USER_NAME}, {USER_SURNAME}, {USER_IS_ADMIN} FROM {USER_TABLE} " +
                $"WHERE {USER_LOGIN} = '{login}' AND {USER_PASSWORD} = '{password}'";

            user = new User();

            try
            {
                using (SqlConnection connection = GetNewOpenConnection())
                {
                    SqlCommand command = new SqlCommand(queryText, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            user.Name = reader.GetString(0) + " ";

                            if (!reader.IsDBNull(1))
                            {
                                user.Name += reader.GetString(1);
                            }
                        }
                        

                        bool isAdmin = reader.GetBoolean(2);

                        if (isAdmin) user.Type = UserType.Admin;
                        else user.Type = UserType.User;

                        return true;
                    }
                }
            }

            catch
            {
                ShowError("Не удалось выполнить выборку с базы данных");
            }

            return false;
        }

        //Ниже код Антона Браславского

        public static void AddTrener(string fam, string name, string otchestvo, string bio, string photo)
        {
            string addRequest = $"INSERT INTO {COACHES_TABLE} VALUES ('{fam}','{name}','{otchestvo}','{bio}','{photo}');";
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(addRequest, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddKomanda(string name, string id)
        {
            string addRequest = $"INSERT INTO {TEAMS_TABLE} VALUES ('{name}','{id}');";
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(addRequest, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddMatch(int ID_1, int ID_2, DateTime date, string result, string descr)
        {
            string addRequest = $"INSERT INTO {MATCHES_TABLE} VALUES ({ID_1},{ID_2},'{date}','{result}','{descr}');";
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(addRequest, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddUser(string fam, string name, string otchestvo, string login, string password, bool admin)
        {
            byte status = 0;
            if(admin) { status = 1; }

            string addRequest = $"INSERT INTO {USER_TABLE} VALUES ('{fam}','{name}','{otchestvo}','{login}','{password}', {status});";
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(addRequest, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static void DataView(DataGridView data, string nameTable)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            string cmd = $"SELECT * FROM {nameTable}";
            SqlCommand createCommand = new SqlCommand(cmd, conn);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable($"{nameTable}");
            dataAdp.Fill(dt);
            data.DataSource = dt.DefaultView;
            conn.Close();
        }
    }
}
