using System;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10;

            int resultA = ++a; // najpier zwiększa o 1 i dopiero przypisuje do resultA
            int resultB = b++; // najpierw przypisuje, a później zwiększa o 1

            Console.WriteLine(resultA);
            Console.WriteLine(resultB);

            Console.ReadKey();
        }
    }
}
