using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class PowerOf2
    {
        public void PowerOfTwo()
        {
            int N = 0;
            Console.WriteLine("enter the value of n");
            N = Convert.ToInt32(Console.ReadLine());

            if (N > 0)
            {

                double con = Math.Pow(2, N);
                for (int i = 1; i <= N; i++)
                {
                    double pow = Math.Pow(2, i);
                    if (pow < con)
                    {
                        Console.WriteLine($"2^{i} = {pow}");
                    }
                    else
                    {
                        break;
                    }
                }
                
            }


        }
    }
}
