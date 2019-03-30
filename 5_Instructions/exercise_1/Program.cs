using System;

namespace exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;

            if (n1 > n2)
            {
                Console.WriteLine("N1 jest większe od N2");
            }
            else
            {
                Console.WriteLine("N1 nie jest większe od N2");
            }

            Console.ReadKey();
        }
    }
}
