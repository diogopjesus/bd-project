using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Team
    {
        private int _id;
        private string _abbreviation;
        private string _name;
        private string _continent;
        private string _country;
        private string _stadium;
        private int _attendance;
        private string _coach;
        public Team()
        {
            _id = -1;
            _abbreviation = String.Empty;
            _name = String.Empty;
            _continent = String.Empty;
            _country = String.Empty;
            _stadium = String.Empty;
            _attendance = -1;
            _coach = String.Empty;
        }
        public int Id { get => _id; set => _id = value; }
        public string Abbreviation { get => _abbreviation; set => _abbreviation = value; }
        public string Name { get => _name; set => _name = value; }
        public string Continent { get => _continent; set => _continent = value; }
        public string Country { get => _country; set => _country = value; }
        public string Stadium { get => _stadium; set => _stadium = value; }
        public int Attendance { get => _attendance; set => _attendance = value; }
        public string Coach { get => _coach; set => _coach = value; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
