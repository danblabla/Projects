using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndTrains
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float birdspeed;
            float trainspeed;
            float distance;
            float birddistance;

            Console.WriteLine("Enter trains speed=");
            trainspeed = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter bird speed=");
            birdspeed = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter inistial distance=");
            distance = float.Parse(Console.ReadLine());

            if(trainspeed<=0|| birdspeed<=0|| distance<=0)
            {
                Console.WriteLine("Please enter valid values");
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                birddistance = (float)(0.5 * distance * (trainspeed + birdspeed) / 2 * trainspeed)/100;
                Console.WriteLine("Total distance for bird " + birddistance);
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
