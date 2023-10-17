namespace _3Days.DataBase
{
    internal static partial class DB
    {
        public const string

            TEAMS_TABLE = "Команда",
            TEAM_ID = "ID_команды",
            TEAM_NAME = "Название",
            TEAM_COACH = "ID_тренера",

            MATCHES_TABLE = "Матчи",
            MATCH_ID = "ID_матча",
            MATCH_COMMAND1 = "ID_команды_1",
            MATCH_COMMAND2 = "ID_команды_2",
            MATCH_DATE = "Дата",
            MATCH_RESULT = "Результат",
            MATCH_DESCRIPTION = "Описание",

            USER_TABLE = "Пользователь",
            USER_ID = "ID_пользователя",
            USER_SURNAME = "Фамилия",
            USER_NAME = "Имя",
            USER_PATRONYMIC = "Отчество",
            USER_LOGIN = "Логин",
            USER_PASSWORD = "Пароль",
            USER_IS_ADMIN = "Админ",

            COACHES_TABLE = "Тренер",
            COACH_ID = "ID_тренера",
            COACH_SURNAME = "Фамилия",
            COACH_NAME = "Имя",
            COACH_PATRONYMIC = "Отчество",
            COACH_BIOGRAPHY = "Биография",
            COACH_PHOTO = "Фото";

    }

    enum MatchesType
    {
        Complited,
        Upcoming
    }
}
