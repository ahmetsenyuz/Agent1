using System;

namespace Agent1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main program flow control
            Console.WriteLine("Welcome to the Agent1 Program Flow Control");
            
            // Input reading phase
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            
            try
            {
                int n = int.Parse(input);
                
                if (n <= 0)
                {
                    Console.WriteLine("Please enter a positive integer.");
                    return;
                }

                // Validation phase
                Console.WriteLine($"Validating input: {n}");
                
                // Counter variable to track iterations
                int counter = 0;
                
                // Loop condition based on user input
                while (counter < n)
                {
                    // Incremental control mechanism
                    counter++;
                    
                    // Boundary checking for loop limits
                    if (counter > 100000)
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