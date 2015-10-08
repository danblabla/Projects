using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaeologicalSite
{
    public class ArchaeologicalSite
    {
        public static void Main(string[] args)
        {
            float x1, y1, x2, y2, x3, y3;
            float area;


            Console.WriteLine("point coordinates 1 x1=");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("point coordinates 1 y1=");
            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("point coordinates 2 x2=");
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("point coordinates 2 y2=");
            y2 = float.Parse(Console.ReadLine());

            Console.WriteLine("point coordinates 3 x3=");
            x3 = float.Parse(Console.ReadLine());
            Console.WriteLine("point coordinates 3 y3=");
            y3 = float.Parse(Console.ReadLine());

            // aria unui triungi cand se cunosc coordonatele punctelor
            // determinantul de ordin 3 format din pct de coordonate

            area = Math.Abs(x1 * (y2 - y3) - y1 * (x2 - x3) + (x2 * y3 - x3 * y2));
            Console.WriteLine("Area {0}", (decimal)area / 2);
            Console.WriteLine();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
