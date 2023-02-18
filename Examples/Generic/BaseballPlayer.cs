using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Short_Video_Notes.Examples.Generic
{
    internal class BaseballPlayer : Player
    {
        int _runs;
        int _hits;
        int _atBat;

        public BaseballPlayer(string name, string number, int runs, int hits, int atBat) : base(name, number)
        {
            _runs = runs;
            _hits = hits;
            _atBat = atBat;
        }

        public int Runs { get => _runs; set => _runs = value; }
        public int Hits { get => _hits; set => _hits = value; }
        public int AtBat { get => _atBat; set => _atBat = value; }
    }
}
