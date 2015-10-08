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
            int N;
            int x;

            Console.WriteLine("Enter the numeber of reps rounds N=");
            N = int.Parse(Console.ReadLine());
           
          
                x = (int)Math.Pow(N, 2);
                Console.WriteLine("Total number of reps is" + x);
          
                //Console.WriteLine("The number is not integer");
           
           
          
               
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
