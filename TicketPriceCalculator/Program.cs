namespace dcit318_assignment1_10975134.TicketPriceCalculator
{
    public class TicketPriceCalculator
    {
        private const decimal RegularPrice = 10.00;
        private const decimal DiscountedPrice = 7.00;

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