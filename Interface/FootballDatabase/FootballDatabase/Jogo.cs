using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Jogo
    {
        private String _competition;
        private String _date;
        private String _home_team;
        private String _home_goals;
        private String _away_team;
        private String _away_goals;
        private String _stadium;
        private String _referee;
        public Jogo() : base()
        {
        }

        public string Competition { get => _competition; set => _competition = value; }
        public string Date { get => _date; set => _date = value; }
        public string Home_team { get => _home_team; set => _home_team = value; }
        public string Home_goals { get => _home_goals; set => _home_goals = value; }
        public string Away_team { get => _away_team; set => _away_team = value; }
        public string Away_goals { get => _away_goals; set => _away_goals = value; }
        public string Stadium { get => _stadium; set => _stadium = value; }
        public string Referee { get => _referee; set => _referee = value; }

        public override String ToString()
        {
            return _competition + " " + _date + " " + _home_team + " " + _home_goals + " " + _away_team + " " + _away_goals;
        }

    }

}