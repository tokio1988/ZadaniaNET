using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Jabłko", "Banan", "Malina" };
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + "," + " ");
            }

            Console.ReadKey();
        }
    }
}
