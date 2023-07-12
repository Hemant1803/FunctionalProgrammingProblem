using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class Leapyear
    {
        public void leapyear()
        {
            Console.WriteLine("Enter a Four digit Year");
           int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("it is leap year" + year);
            }
            else
            {
                Console.WriteLine("it is not a leap year" + year);
            }
        }
    }
}
