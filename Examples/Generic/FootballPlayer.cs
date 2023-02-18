using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Short_Video_Notes.Examples.Generic
{
    internal class FootballPlayer : Player
    {
        int _passYards;
        int _attempts;
        int _completions;

        public FootballPlayer(string name, string number, int passYards, int attempts, int completions) : base(name, number)
        {
            _passYards = passYards;
            _attempts = attempts;
            _completions = completions;
        }



        public int PassYards { get => _passYards; set => _passYards = value; }
        public int Attempts { get => _attempts; set => _attempts = value; }
        public int Completions { get => _completions; set => _completions = value; }

        public double AverageCompletion()
        {
            return _attempts / (double)_completions;
        }
    }
}
