using System;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultFor = 0;
            for (int i = 0; i <= 10; i++)
            {
                resultFor += i;
            }

            int resultWhile = 0;
            int x = 0;
            while (x <= 10)
            {
                resultWhile += x;
                x++;
            }

            Console.Read();
        }
    }
}
