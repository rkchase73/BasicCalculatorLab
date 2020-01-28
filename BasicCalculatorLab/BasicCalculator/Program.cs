using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Weather Calculator***");

            Console.WriteLine("Finding the Dew Point,");
            
            Console.WriteLine("Enter the Temperature");
            int TempNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Humidity");
            int HumidNumber = int.Parse(Console.ReadLine());

            int DewPoint = (TempNumber - 9 * (100 - HumidNumber) / 25);
            Console.WriteLine("The Dew Point is: " + DewPoint);

            Console.WriteLine("Finding the Wind Chill,");
            
            Console.WriteLine("Enter the Wind Velocity(mph)");
            int WindVel = int.Parse(Console.ReadLine());
            double pow_ab = Math.Pow(WindVel, 0.16);

            double WindChill = 35.74 + 0.6215 * TempNumber - 35.75 * pow_ab + 0.4275 * TempNumber * pow_ab;
            Console.WriteLine("The Wind Chill is: " + WindChill);


        }
    }
}
