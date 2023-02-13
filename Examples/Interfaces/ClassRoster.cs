using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Short_Video_Notes.Examples.Interfaces
{
    internal class ClassRoster : IEnumerable
    {
        List<Student> students = new List<Student>();

        public ClassRoster()
        {
            string[] firstNames = { "Will", "Anne", "Hannah", "Dylan", "Kris"};
            string[] lastNames = { "Cram", "Nguyen", "Angel", "Register", "Taniguchi"};

            Random rand = new Random();

            for (int i = 0; i < firstNames.Length; i++)
            {
                students.Add(new Student(firstNames[i], lastNames[i], rand.Next(0, 101), rand.Next(0, 101)));
            }
        }

        public void SortStudentsByAverage()
        {
            students.Sort();
        }

        public void SortByFirstName()
        {
            students.Sort((IComparer<Student>?)Student.SortByFirstName());
        }

        public void SortByAverageDescending()
        {
            students.Sort((IComparer<Student>?)Student.SortByGradeDescending());
        }

        public IEnumerator GetEnumerator()
        {
            return new ClassRosterEnum(ref students);
        }
    }

    internal class ClassRosterEnum : IEnumerator
    {
        int index = -1;
        List<Student> students = new List<Student>();

        public ClassRosterEnum(ref List<Student>students)
        {
            this.students = students;
        }

        public object Current => students[index];

        public bool MoveNext()
        {
            index++;
            return index >= students.Count ? false : true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
