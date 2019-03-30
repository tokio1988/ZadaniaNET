using System;

namespace exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj ile punktów otrzymałeś z testu");
                int point = int.Parse(Console.ReadLine());
                if (point >= 0 && point <= 39)
                {
                    Console.WriteLine("Ocena niedostateczna");
                }
                else if (point >= 40 && point <= 54)
                {
                    Console.WriteLine("Ocena dopuszczająca");
                }
                else if (point >= 55 && point <= 69)
                {
                    Console.WriteLine("Ocena dostateczna");
                }
                else if (point >= 70 && point <= 84)
                {
                    Console.WriteLine("Ocena dobra");
                }
                else if (point >= 85 && point <= 98)
                {
                    Console.WriteLine("Ocena bardzo dobra");
                }
                else if (point >= 99 && point <= 100)
                {
                    Console.WriteLine("Ocena celująca");
                }
                else
                {
                    Console.WriteLine("Wartość poza zakresu");
                }
            }
        }
    }
}
