using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paving
{
    public class Paving
    {
        public static void Main(string[] args)
        {
            //declaring Size: L, L - size market; a, b, tile size
            float L, l, a, b;
            float L1, l1, a1, b1;
            float N, m;

            //size market L*l
            Console.WriteLine("Enter length market L= ");
            L = float.Parse(Console.ReadLine());
            L1 = Math.Abs(L);
            Console.WriteLine("Enter breadth market l= ");
            l = float.Parse(Console.ReadLine());
            l1 = Math.Abs(l);

            //tile size a*b
            Console.WriteLine("Tile size a= ");
            a = float.Parse(Console.ReadLine());
            a1 = Math.Abs(a);
            Console.WriteLine("Tile size b= ");
            b = float.Parse(Console.ReadLine());
            b1 = Math.Abs(b);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Enter other values, some of them are 0"); 
            }
            else
            {
                //N number of tiles you can break
                N = (L1 * l1) / (a1 * b1);
                int n = (int)Math.Ceiling(N);
                Console.WriteLine("The number of tiles required when they can be break it " + n);
                Console.WriteLine();

                int n1 = (int)Math.Ceiling(L1 / a1);
                int n2 = (int)Math.Ceiling(l1 / b1);
                m = n1 * n2;
                Console.WriteLine("The number of tiles required when they can't be break it " + m);
                Console.WriteLine();
            }
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }
    }
}