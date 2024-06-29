namespace dcit318_assignment1_10975134.TriangleTypeIdentifier
{
    public class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.WriteLine("Triangle Type Identifier");
            
            double side1 = GetSideLength("Enter the length of side 1: ");
            double side2 = GetSideLength("Enter the length of side 2: ");
            double side3 = GetSideLength("Enter the length of side 3: ");

            string triangleType = IdentifyTriangleType(side1, side2, side3);
            Console.WriteLine($"The triangle is: {triangleType}");
        }

        private static double GetSideLength(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double length) && length > 0)
                {
                    return length;
                }
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        private static string IdentifyTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}