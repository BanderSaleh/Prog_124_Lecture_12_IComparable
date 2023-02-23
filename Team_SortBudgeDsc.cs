using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lecture_12_ICompareable
{
    internal class Team_SortBudgeDsc : IComparer<Team>
    {

        // IComparer is used to compare x2 different external Instances rather than comparing to itself
        public int Compare(Team x, Team y)
        {
            //if (x.Budget > y.Budget) return 1;
            //else if (x.Budget < y.Budget) return -1;
            //else return 0;
            return x.Budget.CompareTo(y.Budget) * -1;
        }
    }
}
