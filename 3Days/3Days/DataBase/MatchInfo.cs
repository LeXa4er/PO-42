using System;

namespace _3Days.DataBase
{
    public class MatchInfo
    {
        public int Id;
        public string Score;

        public DateTime Date;
        public string Description;

        public int FirstTeamId;
        public int SecondTeamId;

        public Team Team1;
        public Team Team2;
    }
}
