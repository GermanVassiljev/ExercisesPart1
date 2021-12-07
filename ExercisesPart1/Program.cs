using System;

namespace ExercisesPart1
{
    class Program
    {
        private const int V = 2021;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string First_name = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string Last_name = Console.ReadLine();
            Console.WriteLine("Greetings " + First_name + " " + Last_name + "!");
            Console.WriteLine("Print your year birth, please: ");
            int Year_birth = Convert.ToInt32(Console.ReadLine());
            int currentDate = DateTime.Now.Year;
            int age = 2021 - Year_birth;
            if (age >= 13)
            {
                Console.WriteLine("Welcome to Instagram!");
            } 
            else
            {
                Console.WriteLine("You are too young to have Instagram account.");
            }
        }
    }
}
