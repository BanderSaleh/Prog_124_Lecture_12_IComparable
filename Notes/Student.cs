using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lecture_12_ICompareable.Notes
{
    internal class Student : IComparable<Student>
    {
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        public Student(string firstName, string lastName)
        {
            Random rand = new Random();
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = rand.Next(0, 101);
            _genEdGrade = rand.Next(0, 101);
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        public int CompareTo(Student other)
        {
            if (_csiGrade < other._csiGrade) return 1;
            else if (_csiGrade > other._csiGrade) return -1;
            else return 0;
        }

        public override string? ToString()
        {
            return $"{_firstName} {_lastName} - CSI Grade {_csiGrade} -  Gen Ed Grade - {GenEdGrade}";
        }

    }
}
