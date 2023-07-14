using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class Remainder
    {
        public void qr()
        {
            Console.WriteLine("Enter the Divident :");
            int Divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor :");
            int Divisor = Convert.ToInt32(Console.ReadLine());
            int Remainder;
            int Quotient = Math.DivRem(Divisor, Divident, out  Remainder);
            Console.WriteLine("Quotient = " + Quotient);
            Console.WriteLine("Remainder = " + Remainder);
            Console.ReadLine();


        }
    }
}
