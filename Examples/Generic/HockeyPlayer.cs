using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Short_Video_Notes.Examples.Generic
{
    internal class HockeyPlayer : Player
    {
        int _points;
        int _goals;
        int _shotsTaken;

        public HockeyPlayer(string name, string number) : base(name, number)
        {
        }
    }
}
