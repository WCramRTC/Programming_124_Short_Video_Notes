using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Short_Video_Notes.Examples.Interfaces
{
    internal class SortByCSIGrade : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;

            if (s1.CsiGrade > s2.CsiGrade) return 1;
            else if (s1.CsiGrade < s2.CsiGrade) return -1;
            else return 0;
        }
    }
}
