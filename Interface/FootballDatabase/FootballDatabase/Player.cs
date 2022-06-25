using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Player
    {
        private int _team_id;
        private string _team;
        private int _player_id;
        private string _name;
        private string _position;
        private string _position_abv;
        private string _birth_date;
        private string _continent;
        private string _country;
        private int _shirt_number;
        private string _preferred_foot;
        private int _height;
        private decimal _weight;

        public Player()
        {
        }

        public int Team_id { get => _team_id; set => _team_id = value; }
        public string Team { get => _team; set => _team = value; }
        public int Player_id { get => _player_id; set => _player_id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Position { get => _position; set => _position = value; }
        public string Position_abv { get => _position_abv; set => _position_abv = value; }
        public string Birth_date { get => _birth_date; set => _birth_date = value; }
        public string Continent { get => _continent; set => _continent = value; }
        public string Country { get => _country; set => _country = value; }
        public int Shirt_number { get => _shirt_number; set => _shirt_number = value; }
        public string Preferred_foot { get => _preferred_foot; set => _preferred_foot = value; }
        public int Height { get => _height; set => _height = value; }
        public decimal Weight { get => _weight; set => _weight = value; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
