using System;

namespace Agent1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main program flow
            Console.WriteLine("Welcome to the Agent1 Program Flow");

            // Input reading phase
            Console.WriteLine("Please enter the number of times 'Hello World' should be printed:");
            Console.Write("Number of iterations: ");
            string input = Console.ReadLine();

            try
            {
                int n = int.Parse(input);

                // Validation phase
                if (n <= 0)
                {
                    Console.WriteLine("Please enter a positive integer.");
                    return;
                }

                // Counter variable to track iterations
                int counter = 0;

                // Loop condition based on user input
                while (counter < n)
                {
                    // Incremental control mechanism
                    counter++;

                    // Boundary checking for loop limit
                    if (counter > 1000000)
                    {
                        Console.WriteLine("Maximum iteration limit exceeded.");
                        break;
                    }

                    // Output generation phase
                    Console.WriteLine($"Iteration {counter}: Hello World");
                }

                // Exit conditions
                Console.WriteLine("Program execution completed successfully.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too large. Please enter a smaller integer.");
            }
        }
    }
}