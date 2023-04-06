using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Lamda Expression....");

            //Collection initializer
            List<Student> list = new List<Student>()
            {
                //object initializer
                new Student(){Id=1,Name="Raji",Age=17,Address="Hyderabad",PhoneNumber=9988776655},
                new Student(){Id=2,Name="Ammu",Age=14,Address="chennai",PhoneNumber=9988776657},
                new Student(){Id=3,Name="Neetha",Age=16,Address="Bangalore",PhoneNumber=9988775655},
                new Student(){Id=4,Name="Nithya",Age=20,Address="vizag",PhoneNumber=9988775655},
                new Student(){Id=5,Name="Teja",Age=18,Address="mumbai",PhoneNumber=9988776345},
            };
            DisplayStudentDetails(list);
            StudentDataManagement.FindTeenageStudents(list);
            StudentDataManagement.SortDataInDescendingOrder(list);
            StudentDataManagement.DisplayEachAddressOfStudent(list);
            StudentDataManagement.FetchFirstThreeStudents(list);
            StudentDataManagement.FetchLastThreeStudents (list);
            Console.ReadLine();
        }
        public static void DisplayStudentDetails(List<Student> list)
        {
            Console.WriteLine("Displaying All Students");
            foreach(Student student in list)
            {
                Console.WriteLine(student);
            }
        }
    }
}
