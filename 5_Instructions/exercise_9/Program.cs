using System;

namespace exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            int n1 = 3;
            for (int i = 0; i <= n1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
