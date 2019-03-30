using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 5, 15, 20, 25, 30, 35, 40, 45, 50 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            int x = 0;
            while (x < numbers.Length)
            {
                Console.WriteLine(numbers[x]);
                x++;
            }

            Console.WriteLine();

            foreach (int y in numbers)
            {
                Console.WriteLine(y);
            }

            Console.ReadKey();
        }
    }
}
