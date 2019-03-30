using System;

namespace exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
