using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    public class PlayerStat
    {
        private Player _player;
        private int _game;
        private int _player_id;
        private int _time_played;
        private int _goals;
        private int _assists;
        private int _touches;
        private int _passes;
        private int _shots;
        private int _tackles;
        private bool _home_team;
        private bool _starter;

        public PlayerStat()
        {
            _player = new Player();
            Game = -1;
            Player_id = -1;
            Time_played = -1;
            Goals = -1;
            Assists = -1;
            Touches = -1;
            Passes = -1;
            Shots = -1;
            Tackles = -1;
            Home_team = false;
            Starter = false;
        }

        public int Game { get => _game; set => _game = value; }
        public int Player_id { get => _player_id; set => _player_id = value; }
        public int Time_played { get => _time_played; set => _time_played = value; }
        public int Goals { get => _goals; set => _goals = value; }
        public int Assists { get => _assists; set => _assists = value; }
        public int Touches { get => _touches; set => _touches = value; }
        public int Passes { get => _passes; set => _passes = value; }
        public int Shots { get => _shots; set => _shots = value; }
        public int Tackles { get => _tackles; set => _tackles = value; }
        public bool Home_team { get => _home_team; set => _home_team = value; }
        public bool Starter { get => _starter; set => _starter = value; }
        public Player Player { get => _player; set => _player = value; }

        public override string? ToString()
        {
            return Player.ToString();
        }
    }
}
