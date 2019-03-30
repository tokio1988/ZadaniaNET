using System;

namespace exercise_4
{
    public class Rectangle
    {
        public int Width = 50;
        public int Height = 25;

        public int GetArea()
        {
            return this.Height * this.Width;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle prostokat = new Rectangle();
            int result = prostokat.GetArea();
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}
