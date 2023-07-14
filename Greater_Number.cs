using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class Greater_Number
    {
        public void greater_number()
        {
            Console.WriteLine("Enter The 1st Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The 2nd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The 3rd Number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                   Console.WriteLine("num1 is greater" + num1);
                else
                    Console.WriteLine("Number3 is greater" + num3);                
            }
            else if (num2 > num3)
                Console.WriteLine("Number2 is greater" + num2);
            else

                Console.WriteLine("Number3 is greater" + num3);
        }
    }
}
