
using System;

namespace VisualAssignment2
{
    public class Question10    {
        public static void Run()
        {
            int[] numbers = new int[10];

            Console.WriteLine("\nEnter 10 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter a number to search: ");
            int searchValue = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            foreach (int num in numbers)
            {
                if (num == searchValue)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"\n✅ {searchValue} exists in the array!\n");
            else
                Console.WriteLine($"\n❌ {searchValue} not found in the array.\n");
        }
    }
}