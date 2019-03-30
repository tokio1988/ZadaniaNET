using System;

namespace exercise_3
{
    public class Car
    {
        public string color;

        public void SetRedColor()
        {
            color = "red";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car polonez = new Car();
            polonez.SetRedColor();
            Console.WriteLine(polonez.color);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
