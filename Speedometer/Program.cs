using System;

namespace Speedometer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks for distance and time as input and displays the speed in kilometers per hour*/
            Console.WriteLine("Enter covered distance in kilometres: ");

            int speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hours spent: ");

            int time = Convert.ToInt32(Console.ReadLine());

            double kmh = speed / time;

            Console.WriteLine($" The speed is {kmh} km/h");


        }
    }
}
