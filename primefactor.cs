using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class primefactor
    {
        public void primefactorization()
        {
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;

            for (i = 2; n > 1; i++)
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        n /= i;
                    }
                    Console.WriteLine($"{i} is a prime factor!");
                }


        }
    }
}
