using System;

namespace exercise_6
{
    public class Counter
    {
        public int number;

        public int IncreaseNumber(int a)
        {
            return this.number = +a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            int a = 10;
            counter.IncreaseNumber(a);
            Console.WriteLine(counter.number);

            Console.ReadKey();
        }
    }
}
