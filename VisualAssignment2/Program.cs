using System;
using VisualAssignment2;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Assignment Menu =====");
                Console.WriteLine("1. Even or Odd Checker");
                Console.WriteLine("2. Simple Calculator");
                Console.WriteLine("3. Grade Evaluator");
                Console.WriteLine("4. Sum of Natural Numbers");
                Console.WriteLine("5. Multiplication Table");
                Console.WriteLine("6. Factorial Calculator");
                Console.WriteLine("7. Reverse a Number");
                Console.WriteLine("8. Array - Find Maximum and Minimum");
                Console.WriteLine("9. Array - Count Even and Odd Numbers");
                Console.WriteLine("10. Array - Search Element");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: Question1.Run(); break;
                    case 2: Question2.Run(); break;
                    case 3: Question3.Run(); break;
                    case 4: Question4.Run(); break;
                    case 5: Question5.Run(); break;
                    case 6: Question6.Run(); break;
                    case 7: Question7.Run(); break;
                    case 8: Question8.Run(); break;
                    case 9: Question9.Run(); break;
                    case 10: Question10.Run(); break;
                    case 0:
                        Console.WriteLine("\nExiting program...");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Try again!");
                        break;
                }
            }
        }
    }
}