using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Cntrl_System.ValidateInput
{
    public static class ValidateOption
    {
        public static bool Validate(string opt1, string opt2, string opt3, string opt4, string opt5, string input)
        {
            if (opt1 == input || opt2 == input || opt3 == input || opt4 == input || opt5 ==input)
            {
                return true;
            }
            Console.WriteLine("wrong option. please enter the number of the option");
            return false;
        }

        public static bool Validate(string opt1, string opt2, string opt3, string opt4, string input)
        {
            if (opt1 == input || opt2==input || opt3 == input || opt4 == input)
            {
                return true;
            }
            Console.WriteLine("wrong option. please enter the number of the option");
            return false;
        }

        public static bool Validate(string opt1, string opt2, string opt3, string input)
        {
            if (opt1 == input || opt2 == input || opt3 == input)
            {
                return true;
            }
            Console.WriteLine("wrong option. please enter the number of the option");
            return false;
        }
    }
}
