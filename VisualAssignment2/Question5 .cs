
using System;

namespace VisualAssignment2
{
    // Question 5: Multiplication Table
    public class Question5
    {
        public static void Run()
        {
            Console.WriteLine("--- Question 5: Multiplication Table ---");

            Console.Write("Enter a number to display its multiplication table: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMultiplication Table of {num}:");

            // Using for loop to print table up to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} × {i} = {num * i}");
            }
        }
    }
}