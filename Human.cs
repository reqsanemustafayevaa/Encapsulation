using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Encapsulation
{
    public class Human
    {
        public string Name;
        public string SurName;
        public byte Age;
        public Human()
        {
            
        }
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name,string surname):this(name) 
        {
            SurName = surname;
        }
        public Human(string name, string surname,byte age) : this(name,surname)
        {
            Age = age;
        }
    }
}
