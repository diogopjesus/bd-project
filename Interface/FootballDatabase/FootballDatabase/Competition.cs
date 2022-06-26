using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Competition
    {
        int _id;
        string _name;
        string _type;
        string _continent;
        string _country;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public string Continent { get => _continent; set => _continent = value; }
        public string Country { get => _country; set => _country = value; }

        public Competition()
        {
            this._id = -1;
            this._name = string.Empty;
            this._type = string.Empty;
            this._continent = string.Empty;
            this._country = string.Empty;
        }

        public override string? ToString()
        {
            return Country + " - " + Name;
        }
    }
}
