using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Short_Video_Notes.Examples.Generic
{
    internal class TeamRoster<T> : IEnumerable where T : Player
    {
        List<T> _roster;

        public TeamRoster()
        {
            _roster = new List<T>();
        }

        public void AddPlayer(T player)
        {
            _roster.Add(player);
        }

        public IEnumerator GetEnumerator()
        {
            return new TeamRosterEnum<T>(ref _roster);
        }

        private class TeamRosterEnum<T> : IEnumerator where T: Player
        {
            List<T> _roster;
            int index = -1;

            public TeamRosterEnum(ref List<T> roster)
            {
                _roster = roster;
            }

            public object Current => _roster[index];

            public bool MoveNext()
            {
                index++;
                return (index >= _roster.Count) ? false : true;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
