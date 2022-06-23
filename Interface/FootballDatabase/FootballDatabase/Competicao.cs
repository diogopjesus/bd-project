using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Competicao
    {
        private String _name;
        private String _type;
        private String _continent;
        private String _country;

        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public string Continent { get => _continent; set => _continent = value; }
        public string Country { get => _country; set => _country = value; }

        public override string ToString()
        {
            return Name + " " + Type + " "+ Continent + " " + Country ;
        }
    }
}
