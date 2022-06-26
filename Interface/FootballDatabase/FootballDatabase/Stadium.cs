using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Stadium
    {
        private int _id;
        private int _attendance;
        private string _name;
        private string _country;

        public Stadium()
        {
            _id = -1;
            _attendance = -1;
            _name = String.Empty;
            _country = String.Empty;
        }

        public int Id { get => _id; set => _id = value; }
        public int Attendance { get => _attendance; set => _attendance = value; }
        public string Name { get => _name; set => _name = value; }
        public string Country { get => _country; set => _country = value; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
