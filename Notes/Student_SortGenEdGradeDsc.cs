using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lecture_12_ICompareable.Notes
{
    internal class Student_SortGenEdGrade : IComparer<Student>
    {
        public enum Order { Ascending, Descending }
        public Order SortingOrder = Order.Ascending;

        public Student_SortGenEdGrade()
        {
            SortingOrder = Order.Ascending;
        }

        public Student_SortGenEdGrade(Order sortingOrder)
        {
            SortingOrder = sortingOrder;
        }

        public int Compare(Student x, Student y)
        {
            if(SortingOrder == Order.Descending)
            {
                if (x.GenEdGrade < y.GenEdGrade) return 1;
                else if (x.GenEdGrade > y.GenEdGrade) return -1;
                else return 0;
            }
            else
            {
                if (x.GenEdGrade > y.GenEdGrade) return 1;
                else if (x.GenEdGrade < y.GenEdGrade) return -1;
                else return 0;
            }
        }
    }
}
