using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pętla for wyświetli liczby w zakresie 0-50");
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("Pętla while wyświetli liczby w zakresie 0-50");

            int x = 0;
            while (x <= 50)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.ReadKey();
        }
    }
}
