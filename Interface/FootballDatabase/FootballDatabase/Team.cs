using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    public class Team
    {
        private String _id;
        private String _abbreviation;
        private String _name;
        private String _continent;
        private String _country;
        private String _stadium;
        private String _attendance;
        private String _coach;

        public string Id { get => _id; set => _id = value; }
        public string Abbreviation { get => _abbreviation; set => _abbreviation = value; }
        public string Name { get => _name; set => _name = value; }
        public string Continent { get => _continent; set => _continent = value; }
        public string Country { get => _country; set => _country = value; }
        public string Stadium { get => _stadium; set => _stadium = value; }
        public string Attendance { get => _attendance; set => _attendance = value; }
        public string Coach { get => _coach; set => _coach = value; }

        public override string ToString()
        {
            return _name;
        }
    }
}
