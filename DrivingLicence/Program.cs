using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //program asks date of birth 
            //program controlls users age
            //program teatab kasutajat, kas ta on piisavalt vana,
            //to have drivers licence (if 18 years old)

            Console.WriteLine("Whats your date of birth?");
            
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            
            int Age = 2021 - YearOfBirth;

            Console.WriteLine("You were born in " + YearOfBirth);

            if(Age > 18)
            {
                Console.WriteLine("Old enough for drivers licence, congrats");
            }
            else if(Age < 18)
            {
                Console.WriteLine("Too young bitch, grow up");
            }
            else
            {
                Console.WriteLine("Old enough for drivers licence, congrats");
            }
        }
    }
}
