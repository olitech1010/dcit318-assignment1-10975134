using System;
namespace GradeCalculator
{
    public class GradeCalculator
    {
        public static void Run()
        {
            Console.WriteLine("Grade Calculator");
            Console.Write("Enter a numerical grade between 0 and 100: ");
            
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                string letterGrade = CalculateLetterGrade(grade);
                Console.WriteLine($"Letter Grade: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }

        private static string CalculateLetterGrade(int grade)
        {
            if (grade >= 90) return "A";
            if (grade >= 80) return "B";
            if (grade >= 70) return "C";
            if (grade >= 60) return "D";
            return "F";
        }
    }
}