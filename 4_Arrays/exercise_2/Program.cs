using System;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Niebieski", "Zielony", "Złoty", "Czerwony" };
            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i] == "Niebieski")
                {
                    Console.WriteLine("Mój pierwszy kolor to: " + colors[i]);
                }
                else if (colors[i] == "Czerwony")
                {
                    Console.WriteLine("Mój ostatni kolor to: " + colors[i]);
                }
                else
                {
                    Console.WriteLine("Pozostałe kolory to: " + colors[i]);
                }
            }

            Console.Read();
        }
    }
}
