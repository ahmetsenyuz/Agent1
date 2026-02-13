using System;

namespace Agent1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Hello World");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}