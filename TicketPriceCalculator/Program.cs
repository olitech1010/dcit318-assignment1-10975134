using System;
namespace TicketPriceCalculator
{
    public class TicketPriceCalculator
    {
        private const decimal RegularPrice = 10.00m;
        private const decimal DiscountedPrice = 7.00m;

        public static void Run()
        {
            Console.WriteLine("Ticket Price Calculator");
            Console.Write("Enter your age: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                decimal ticketPrice = CalculateTicketPrice(age);
                Console.WriteLine($"Ticket Price: GHC {ticketPrice:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        private static decimal CalculateTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
            {
                return DiscountedPrice;
            }
            return RegularPrice;
        }
    }
}