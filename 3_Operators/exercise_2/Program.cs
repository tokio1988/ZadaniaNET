using System;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5, c = 8;
            int result = a + 5 * b * c; // mnożenie ma wyższy priorytet niż dodawanie

            int changeOrderResult = (a + 5) * b * c; //działanie w nawiasie ma wyższy priorytet

            Console.WriteLine(result);
            Console.WriteLine(changeOrderResult);

            Console.ReadKey();

           
            
        }
    }
}
