using System;

namespace exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 5, 15, 20, 25, 30, 35, 40, 45, 50 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Liczba: " + numbers[i]);
            }

            Console.WriteLine();

            int x = 0;
            while (x < numbers.Length)
            {
                Console.WriteLine("Liczba: " + numbers[x]);
                x++;
            }

            Console.WriteLine();

            foreach (int y in numbers)
            {
                Console.WriteLine("Liczba: " + y);
            }


            Console.ReadKey();
        }
    }
}
