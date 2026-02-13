using System;

namespace Agent1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();

                try
                {
                    int n = int.Parse(input);

                    if (n <= 0)
                    {
                        Console.WriteLine("Please enter a positive integer.");
                        continue;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Hello World");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too large. Please enter a smaller integer.");
                }

                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
            }
        }
    }
}