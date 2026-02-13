using System;

namespace Agent1
{
    /// <summary>
    /// Main program class for the Agent1 application.
    /// This console application prints "Hello World" n times based on user input.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main entry point of the application.
        /// </summary>
        /// <param name="args">Command line arguments (not used in this application)</param>
        static void Main(string[] args)
        {
            // Main program flow
            Console.WriteLine("Welcome to the Agent1 Program Flow");

            // Input reading phase
            Console.WriteLine("Please enter the number of times 'Hello World' should be printed:");
            Console.WriteLine("Number of iterations: ");
            string input = Console.ReadLine();

            try
            {
                int n = int.Parse(input);

                // Validation phase
                if (n <= 0)
                {
                    if (n == 0)
                    {
                        Console.WriteLine("Zero input detected. No output will be produced.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Negative input detected. Please enter a positive integer.");
                        return;
                    }
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