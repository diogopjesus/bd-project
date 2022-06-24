using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    internal class Foot
    {
        private String _Foot;

        public string Foots { get => _Foot; set => _Foot = value; }
        public override string ToString()
        {
            return _Foot;
        }
    }
}
