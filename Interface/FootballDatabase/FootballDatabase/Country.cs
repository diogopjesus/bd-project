using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Country
    {
        private String _name;
        private String _continent;

        public string Name { get => _name; set => _name = value; }
        public string Continent { get => _continent; set => _continent = value; }

        public override string ToString()
        {
            return _name;
        }

    }
}
