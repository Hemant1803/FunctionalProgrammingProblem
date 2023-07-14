using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class Swap2Numbers
    {
        public void Swap2Number() 
        {
            Console.WriteLine("Write 1st Number ");
            int num1 = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Write 2nd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

           
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("Value After swaping");
            Console.WriteLine("Number1 :" + num1);
            Console.WriteLine("Number2 :" + num2);


            
        }
    }
}
