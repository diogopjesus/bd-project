using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    public class GameEvent
    {
        private Types _type;
        private int _game;
        private int _gametime;
        private string _team;
        private int _team_id;
        private string _player;
        private Player _player_obj;
        private string _card;
        private string _scorer;
        private string _assistant;
        private Player _scorer_obj;
        private Player _assistant_obj;
        private string _player_in;
        private string _player_out;
        private Player _player_in_obj;
        private Player _player_out_obj;
        private bool _home_team;

        public Types Type { get => _type; set => _type = value; }
        public int Game { get => _game; set => _game = value; }
        public string Player { get => _player; set => _player = value; }
        public int Gametime { get => _gametime; set => _gametime = value; }
        public string Card { get => _card; set => _card = value; }
        public string Scorer { get => _scorer; set => _scorer = value; }
        public string Assistant { get => _assistant; set => _assistant = value; }
        public string Player_in { get => _player_in; set => _player_in = value; }
        public string Player_out { get => _player_out; set => _player_out = value; }
        public string Team { get => _team; set => _team = value; }
        public int Team_id { get => _team_id; set => _team_id = value; }
        public Player Player_obj { get => _player_obj; set => _player_obj = value; }
        public Player Player_in_obj { get => _player_in_obj; set => _player_in_obj = value; }
        public Player Player_out_obj { get => _player_out_obj; set => _player_out_obj = value; }
        public Player Scorer_obj { get => _scorer_obj; set => _scorer_obj = value; }
        public Player Assistant_obj { get => _assistant_obj; set => _assistant_obj = value; }
        public bool Home_team { get => _home_team; set => _home_team = value; }

        public enum Types
        {
            MISCONDUCT,
            GOAL,
            SUBSTITUTION
        }

        public GameEvent()
        {
            Type = Types.MISCONDUCT;
            Game = -1;
            _player = String.Empty;
            Gametime = -1;
            _team = String.Empty;
            _card = String.Empty;
            _scorer = String.Empty;
            _assistant = String.Empty;
            _player_in = String.Empty;
            _player_out = String.Empty;
        }

        public override string? ToString()
        {
            if (Type == Types.MISCONDUCT)
            {
                return Gametime + "' - " + Team + " - " + Card + " - " + Player;
            }
            else if (Type == Types.GOAL)
            {
                return Gametime + "' - " + Team + " - Scorer: " + Scorer + " - Assistant: " + Assistant;
            }
            else if (Type == Types.SUBSTITUTION)
            {
                return Gametime + "' - " + Team + " - Player IN: " + Player_in + " - PLAYER OUT: " + Player_out;
            }
            return null;
        }
    }
}
