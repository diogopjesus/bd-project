using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Jogo
    {
        private String _gameDate;
        private String _stadium;
        private String _homeTeam;
        private String _awayTeam;
        public String GameDate
        {
            get { return _gameDate; }
            set { _gameDate = value; }
        }
        public String Stadium
        {
            get { return _stadium; }
            set { _stadium = value; }
        }
        public String HomeTeam
        {
            get { return _homeTeam; }
            set { _homeTeam = value; }
        }
        public String AwayTeam
        {
            get { return _awayTeam; }
            set { _awayTeam = value; }
        }

        public Jogo() : base() { 
        }

    }

}
