using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Match
    {
        private int _id;
        private String _competition;
        private String _date;
        private int _home_id;
        private String _home_team;
        private String _home_abv;
        private int _home_goals;
        private int _away_id;
        private String _away_team;
        private String _away_abv;
        private int _away_goals;
        private String _stadium;
        private String _referee;

        public Match()
        {
            _id = -1;
            _competition = String.Empty;
            _date = String.Empty;
            _home_id = -1;
            _home_team = String.Empty;
            _home_abv = String.Empty;
            _home_goals = -1;
            _away_id = -1;
            _away_team = String.Empty;
            _away_abv = String.Empty;
            _away_goals = -1;
            _stadium = String.Empty;
            _referee = String.Empty;
        }

        public int Id { get => _id; set => _id = value; }
        public string Competition { get => _competition; set => _competition = value; }
        public string Date { get => _date; set => _date = value; }
        public int Home_id { get => _home_id; set => _home_id = value; }
        public string Home_team { get => _home_team; set => _home_team = value; }
        public int Home_goals { get => _home_goals; set => _home_goals = value; }
        public int Away_id { get => _away_id; set => _away_id = value; }
        public string Away_team { get => _away_team; set => _away_team = value; }
        public int Away_goals { get => _away_goals; set => _away_goals = value; }
        public string Stadium { get => _stadium; set => _stadium = value; }
        public string Referee { get => _referee; set => _referee = value; }
        public string Home_abv { get => _home_abv; set => _home_abv = value; }
        public string Away_abv { get => _away_abv; set => _away_abv = value; }

        public override string? ToString()
        {
            return Home_team + " " + Home_goals + " - " + Away_goals + " " + Away_team;
        }
    }
}
