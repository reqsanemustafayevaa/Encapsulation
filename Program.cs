using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Raghsana","Mustafayeva",23);
            Console.WriteLine(student.Name+" "+student.SurName+" "+student.Age);
        }
    }
}
