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

        public static void DisplayEachAddressOfStudent(List<Student> list)
        {
            Console.WriteLine("\n Address of Each Student");
            var  address = list.OrderBy(s => s.Address).ToList();
            Program.DisplayStudentDetails(address);
        }
        public static void FetchFirstThreeStudents(List<Student> list)
        {
            Console.WriteLine("\n Fetching First Three Students Fom Records");
            var top = list.Take(3).ToList();
            Program.DisplayStudentDetails(top);
        }
        public static void FetchLastThreeStudents(List<Student> list)
        {
            Console.WriteLine("\n Fetching last Three Students Fom Records");
            list.Reverse();
            var last = list.Take(3).ToList();
            Program.DisplayStudentDetails(last);
        }
    }
}
