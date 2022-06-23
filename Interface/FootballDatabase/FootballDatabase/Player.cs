using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FootballDatabase
{
    [Serializable()]
    public class Player
    {
        private String _teamID;
        private String _team;
        private String _playerID;
        private String _name;
        private String _position;
        private String _position_abv;
        private String _birth_date;
        private String _continent;
        private String _country;
        private String _shirt_number;
        private String _preferred_foot;
        private String _height;
        private String _weight;

        public Player()
        {
        }

        public string TeamID { get => _teamID; set => _teamID = value; }
        public string Team { get => _team; set => _team = value; }
        public string PlayerID { get => _playerID; set => _playerID = value; }
        public string Name { get => _name; set => _name = value; }
        public string Position { get => _position; set => _position = value; }
        public string Position_abv { get => _position_abv; set => _position_abv = value; }
        public string Birth_date { get => _birth_date; set => _birth_date = value; }
        public string Continent { get => _continent; set => _continent = value; }
        public string Country { get => _country; set => _country = value; }
        public string Shirt_number { get => _shirt_number; set => _shirt_number = value; }
        public string Preferred_foot { get => _preferred_foot; set => _preferred_foot = value; }
        public string Height { get => _height; set => _height = value; }
        public string Weight { get => _weight; set => _weight = value; }

        public override string ToString()
        {
            return _name + " - " + _position;
        }
    }
}