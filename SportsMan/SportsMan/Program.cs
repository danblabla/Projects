using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsMan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double N = 0;
            double x;

            Console.WriteLine("Enter the numeber of reps rounds N=");
            if (double.TryParse(Console.ReadLine(), out N))
            {
                if (N == (int)N)
                {
                    x = Math.Pow(N, 2);
                    Console.WriteLine("Total number of reps is" + x);
                }
                else
                {
                    Console.WriteLine("The number is not integer");
                }
            }
            else
            {
                Console.WriteLine("Is not a numeber");
            }
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
