using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Continente
    {
        private String _name;
        public string Name { get => _name; set => _name = value; }

        public override string ToString()
        {
            return _name;
        }

    }

}
