using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushrooms
{
    public class Mushrooms
    {
        public static void Main(string[] args)
        {
            int red;
            int white;
            int total;
            int x;

            //Console.WriteLine("Nomber of red mushrooms, red= ");
            //red = int.Parse(Console.ReadLine());

            Console.WriteLine("How many mushrooms are = ");
            total = int.Parse(Console.ReadLine());

            Console.WriteLine("How many red mushrooms are more than white= ");
            x = int.Parse(Console.ReadLine());

            if (total % (x + 1) == 0)
            {

                white = total / (x + 1);
                Console.WriteLine("White mushrooms= " + white);

                red = total - white;
                Console.WriteLine("Red mushrooms= " + red);
            }
            else
            {
                Console.WriteLine("Numebers of white and red mushrooms are decimal");
            }
            Console.WriteLine("");
            Console.ReadKey();

        }
    }
}