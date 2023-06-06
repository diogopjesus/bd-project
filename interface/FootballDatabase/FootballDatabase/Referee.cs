using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Referee
    {
        private int _id;
        private string _name;
        private string _birth_date;
        private string _country;

        public Referee()
        {
            _id = -1;
            _name = String.Empty;
            _birth_date = String.Empty;
            _country = String.Empty;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Birth_date { get => _birth_date; set => _birth_date = value; }
        public string Country { get => _country; set => _country = value; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
