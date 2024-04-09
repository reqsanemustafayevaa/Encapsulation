using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Encapsulation
{
    public class Student:Human
    {
        public double Point;
        public double Grant;
        public Student():base()
        {
            
        }
        public Student(string name):base(name) 
        {
            
        }
        public Student(string name, string surname):base(name,surname) 
        {
           
        }
        public Student(string name, string surname,byte age):this(name, surname)
        {
            Age = age;  
        }
    }
}
