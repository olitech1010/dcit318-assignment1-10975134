using GradeCalculator;
using TicketPriceCalculator;
using TriangleTypeIdentifier;
using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nDCIT 318 Assignment 1");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            GradeCalculator.GradeCalculator.Run();
                            break;
                        case 2:
                            TicketPriceCalculator.TicketPriceCalculator.Run();
                            break;
                        case 3:
                            TriangleTypeIdentifier.TriangleTypeIdentifier.Run();
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using the application. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
