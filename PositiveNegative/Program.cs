using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //program asks user to enter numbers from -10 to 10
            //program controlls these numbers
            //if number is positive, console writes (postivie)
            //if number is negative, console writes (negative)
            //if 0, console writes zero
            Console.WriteLine("Enter any number from -10 to 10");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (Number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
