using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lecture_12_ICompareable.Notes
{
    internal class Student_SortFirstNameDsc : IComparer<Student>
    {
        int IComparer<Student>.Compare(Student x, Student y)
        {
            return x.FirstName.CompareTo(y.FirstName) * -1;
        }
    }
}
