using System;

namespace exercise_1
{
    public class Point
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point punkt = new Point();
            punkt.X = 10;
            punkt.Y = 15;
            Console.WriteLine(punkt.X);
            Console.WriteLine(punkt.Y);


            Console.ReadKey();
        }

        
    }
}
