using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Cntrl_System.OBJECTS.Person
{
    internal abstract class APerson
    {
        protected string Name;
        protected int Age;

        public APerson(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string GetName()
        {
            return this.Name;
        }
        public int GetAge()
        {
            return this.Age;
        }
    }
}
