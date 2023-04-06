using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}  Name:{Name}  Age:{Age}  Address:{Address}  Phonenumber:{PhoneNumber}";
        }
    }
}
