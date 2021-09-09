using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib kasutaja vanust 
            //kui kasutaja on vanem, kui 18, siis konsolle kuvatakse "oled piisavalt vane"
            //kui kasutaja on noorem, kui 18, siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            Console.WriteLine("Enter your age");

            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("Old enough");
            }
            else if (Age < 18)
            {
                Console.WriteLine("You are too young");
            }
            else
            {
                Console.WriteLine("You are 18");
            }

            Console.WriteLine("Have a nice day bitch");


        }
    }
}