using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Lecture_12_ICompareable.Notes
{
    internal class Notes
    {
        /*
         Questions to Answer:

What are IComparable and IComparer interfaces used for?
Answer:
The IComparable<T> and IComparer<T> interfaces work the the .Sort() method that collections have,
like Lists and Arrays. IComparable and IComparer implement methods, Compare and CompareTo,
that work with .Sort() to tell it what properties you want something organized by. 
        
IComparable is used when you want to Sort your list/array by comparing to data it has stored like firstName.
        
IComparer is used when you want to Sort your list/array by comparing to external data like a user
inputed value entered or a radio button selected (ifelse statements are indicators that we use IComparer).



What 3 numbers do your CompareTo method return?
Answer:
The CompareTo() method, built into your field, return 1 of 3 values: 1, 0, and -1.


What method do you call on your list to use sort your list?
Answer: 
You call the CompareTo() method that contains the .Sort() default sorting method.



What does the <T> signify in IComparable<T> and IComparer<T>?
Answer:
The <T> inside the IComparable<T> and IComparer<T> refer to the Generic List/Array that you want sorted.
          
       
        */
    }
}
