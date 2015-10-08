using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melon
{
    public class Melon
    {
        public static void Main(string[] args)
        {
            int x;
            // melon weight x

            Console.WriteLine("Enter melon weight in kg x=");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0 && x > 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
            return;
        }
    }
}
