using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    class StudentDataManagement
    {
        public static void FindTeenageStudents(List<Student> students)
        {
            Console.WriteLine("\n Teenage Age Students");
            List<Student> teenagestudents = students.Where(s =>s.Age >=12 && s.Age <=18).ToList();
            Program.DisplayStudentDetails(teenagestudents);
        }

        public static void SortDataInDescendingOrder(List<Student> students)
        {
            Console.WriteLine("\n Sorting the Data in Age");
            List<Student> SortedData = students.OrderByDescending(s => s.Age).ToList();
            Program.DisplayStudentDetails(SortedData);
        }
    }
}
