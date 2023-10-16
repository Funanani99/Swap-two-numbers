using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int a = -13;
                int b = 2;

                SwapTwoNumbers(ref a, ref b);

                Console.WriteLine($"Before: a = -13, b = 2; After: a = {a}, b = {b}");
            Console.ReadLine();
        }

            static void SwapTwoNumbers(ref int a, ref int b)
            {
                int tempNumber = a;
                a = b;
                b = tempNumber;
            }
    }

}

