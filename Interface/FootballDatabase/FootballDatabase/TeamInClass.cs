using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class TeamInClass
    {
        private int _pos;
        private Team _team;
        private int _points;
        private int _wins;
        private int _draws;
        private int _losses;
        private int _gs;
        private int _gc;
        private int _gd;

        public TeamInClass()
        {
            _pos = -1;
            _team = new Team();
            _points = -1;
            _wins = -1;
            _draws = -1;
            _losses = -1;
            _gs = -1;
            _gc = -1;
            _gd = -1;
        }

        public int Pos { get => _pos; set => _pos = value; }
        public int Points { get => _points; set => _points = value; }
        public int Gs { get => _gs; set => _gs = value; }
        public int Gc { get => _gc; set => _gc = value; }
        public int Gd { get => _gd; set => _gd = value; }
        public int Wins { get => _wins; set => _wins = value; }
        public int Draws { get => _draws; set => _draws = value; }
        public int Losses { get => _losses; set => _losses = value; }
        public Team Team { get => _team; set => _team = value; }
    }
}
