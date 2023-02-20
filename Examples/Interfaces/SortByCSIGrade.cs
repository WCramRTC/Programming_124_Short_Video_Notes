using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Short_Video_Notes.Examples.Interfaces
{
    internal class SortByCSIGrade : IComparer<Student>
    {
        public int Compare(Student? s1, Student? s2)
        {
            if (s1.CsiGrade > s2.CsiGrade) return 1;
            else if (s1.CsiGrade < s2.CsiGrade) return -1;
            else return 0;
        }
    }
}
