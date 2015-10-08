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
            double birdspeed;
            double trainspeed;
            double distance;
            double birddistance;

            Console.WriteLine("Enter trains speed=");
            trainspeed = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter bird speed=");
            birdspeed = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter inistial distance=");
            distance = double.Parse(Console.ReadLine());

            if(trainspeed==0|| trainspeed<0|| birdspeed==0|| birdspeed<0|| distance==0|| distance<0)
            {
                Console.WriteLine("Please enter valid values");
            }
            else
            {

            }
        }
    }
}
