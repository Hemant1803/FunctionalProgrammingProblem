using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class HarmonicNumber
    {
        public void NthHarmonicNumber()
        {
            Console.WriteLine("Enter the Value Of N");
            double n = Convert.ToInt32(Console.ReadLine());
            double harmonicsum = 1;
            for (double i = 2; i <= n; i++)
            {
                Console.WriteLine("test" + 1/i);
                harmonicsum += (1/i);
            }
            Console.WriteLine("harmonicsum" + harmonicsum);
        }
    }

    
}
