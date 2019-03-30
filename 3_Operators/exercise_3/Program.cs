using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 12;
            int add = a + b;
            int sub = a - b;
            int div1 = a / b; //wynik 0 bo brak rzutowania
            double div = (double)a / b; // wynik z rzutowaniem
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);

            Console.ReadKey();
        }
    }
}
