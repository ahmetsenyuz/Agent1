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

                    // Counter variable to track iterations
                    int counter = 0;
                    
                    // Loop condition based on user input
                    while (counter < n)
                    {
                        // Incremental control mechanism
                        counter++;
                        
                        // Boundary checking for loop limits
                        if (counter > 10000)
                        {
                            Console.WriteLine("Maximum iteration limit exceeded.");
                            break;
                        }
                        
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