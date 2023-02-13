using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Programming_124_Short_Video_Notes.Examples.Interfaces
{
    internal class Student : IComparable<Student>
    {
        string _firstName;
        string _lastName;
        int _csiGrade;
        int _genEdGrade;

        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public int GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        public double Average()
        {
            return (_csiGrade + _genEdGrade) / 2.0;
        } // Average()

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {CsiGrade} - {GenEdGrade} - Average - {Average()}";
        }

        public int CompareTo(Student? other)
        {
            MessageBox.Show(_firstName.CompareTo(other.FirstName).ToString());
            return _firstName.CompareTo(other.FirstName);
        }

        public static IComparer SortByFirstName()
        {
            return new SortByFirstNameHelper() as IComparer;
        }

        public static IComparer SortByGradeDescending()
        {
            return new SortByAverageDescendingHelper() as IComparer;
        }

   

        // Helper Classes

        private class SortByFirstNameHelper : IComparer<Student>
        {

            public int Compare(Student? x, Student? y)
            {
                return x.FirstName.CompareTo(y.FirstName);
            }
        }

        private class SortByAverageDescendingHelper : IComparer<Student>
        {
            public int Compare(Student? student1, Student? student2)
            {
                if (student1.Average() > student2.Average()) return 1;
                if (student1.Average() < student2.Average()) return -1;
                else return 0;
            }
        }
    }
}
