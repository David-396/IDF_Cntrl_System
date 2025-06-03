using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Cntrl_System.OBJECTS.Person
{
    internal abstract class APerson
    {
        public string Name { get; }
        public int Age { get; }

        public APerson(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public virtual void Print()
        {
            Console.Write($"name: {this.Name}, age: {this.Age}");
        }
    }
}
