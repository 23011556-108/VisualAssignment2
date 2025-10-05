
using System;

namespace VisualAssignment2
{
    // Question 7: Reverse a Number
    public class Question7
    {
        public static void Run()
        {
            Console.WriteLine("--- Question 7: Reverse a Number ---");

            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            int original = num;
            int reversed = 0;

            // Using loop to reverse digits
            while (num != 0)
            {
                int digit = num % 10;         // Get last digit
                reversed = reversed * 10 + digit; // Append to reversed number
                num /= 10;                    // Remove last digit
            }

            Console.WriteLine($"The reverse of {original} is: {reversed}");
        }
    }
}