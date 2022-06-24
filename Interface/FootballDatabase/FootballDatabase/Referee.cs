using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Referee
    {
        private String _fname;
        private String _minit;
        private String _lname;
        private DateTime _birth_date;
        private String _country;

        public string Fname { get => _fname; set => _fname = value; }
        public string Minit { get => _minit; set => _minit = value; }
        public string Lname { get => _lname; set => _lname = value; }
        public DateTime Birth_date { get => _birth_date; set => _birth_date = value; }
        public string Country { get => _country; set => _country = value; }


        public override string ToString()
        {
            return _fname + " " + _lname;
        }
    }
}
