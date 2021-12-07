using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite color: ");
            string Color = Console.ReadLine().ToLower();
            if (Color == "red")
            {
                Console.WriteLine($"{Color}. You are a romantic!");
            }
            else if (Color == "blue")
            {
                Console.WriteLine($"{Color}. You are a relible!");
            }
            else if (Color == "yellow")
            {
                Console.WriteLine($"{Color}. You are a cheerful!");
            }
            else
            {
                Console.WriteLine($"You are a {Color} unicorn!!!");
            }

        }
    }
}
