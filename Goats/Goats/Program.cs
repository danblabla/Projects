
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goats
{
    public class Goats
    {
        public static void Main(string[] args)
        {
            int y, q;
            float x, z, w, n;

            //X days Y goats Z kg
            //W days Q goats nec Kg

            Console.WriteLine("Days x=");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Goats y=");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Kg z=");
            z = float.Parse(Console.ReadLine());

            Console.WriteLine("Days w=");
            w = float.Parse(Console.ReadLine());

            Console.WriteLine("Goats q=");
            q = int.Parse(Console.ReadLine());

            if (w == 0 || y == 0)
            {
                Console.WriteLine("invalid data");
            }
            else
            {
                n = Math.Abs((x * q * z) / (w * y));

                Console.WriteLine("Consumed " + n);
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
