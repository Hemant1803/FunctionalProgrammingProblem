using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class OddEven
    {
        public void oddeven() 
        {
            Console.WriteLine("Enter a Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            if(Num % 2 ==0)
            {
                Console.WriteLine(Num + ":- is even");              
            }
            else 
            {
                Console.WriteLine(Num + ":- is Odd");
                    }
        }
    }
}
