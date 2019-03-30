using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 15;

            bool resultA = a < b;
            bool resultB = a > b;

            Console.WriteLine(resultA);
            Console.WriteLine(resultB);

            Console.ReadKey();
        }
    }
}
