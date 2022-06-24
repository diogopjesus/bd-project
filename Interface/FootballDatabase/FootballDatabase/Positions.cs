using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Positions
    {
        private String position;
        private String abbreviation;

        public string Position { get => position; set => position = value; }
        public string Abbreviation { get => abbreviation; set => abbreviation = value; }

        public override string ToString()
        {
            return abbreviation + "-" + position;
        }
    }
}
