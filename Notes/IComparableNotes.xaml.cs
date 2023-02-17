using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog_124_Lecture_12_ICompareable.Notes
{
    /// <summary>
    /// Interaction logic for IComparableNotes.xaml
    /// </summary>
    public partial class IComparableNotes : Window
    {

        List<Student> studentList = new List<Student>();

        public IComparableNotes()
        {
            InitializeComponent();
            Preload();

            //Student_SortGenEdGrade grade = new Student_SortGenEdGrade(Student_SortGenEdGrade.Order.Descending);
            //students.Sort(grade);

            Student_SortGenEdGrade grade = new Student_SortGenEdGrade(Student_SortGenEdGrade.Order.Descending);

            studentList.Sort(grade);

            DisplayStudent();
        }


        void Preload()
        {
            studentList.Add(new Student("Will", "Cram"));
            studentList.Add(new Student("Anne", "Nguyen"));
            studentList.Add(new Student("Hannah", "Angel"));
            studentList.Add(new Student("Kristyn", "Taniguchi"));

        }

        void DisplayStudent()
        {
            lbStudents.Items.Clear();

            foreach (Student student in studentList)
            {
                lbStudents.Items.Add(student);
            }
        }


    }
}
