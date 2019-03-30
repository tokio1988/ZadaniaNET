using System;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} - parzysta", i);
                }
                else
                {
                    Console.WriteLine("{0} - nieparzysta", i);
                }



            }

            Console.Read();
        }
    }
}
