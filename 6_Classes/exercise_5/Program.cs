using System;

namespace exercise_5
{
    public class MyClass
    {
        public int number;
        public string name;
        public char znak;
        public bool prawda;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obiekt = new MyClass();
            Console.WriteLine(obiekt.number);
            Console.WriteLine(obiekt.name);
            Console.WriteLine(obiekt.znak);
            Console.WriteLine(obiekt.prawda);

            // wyświetlają się wartości domyślne typu 0 lub false ze względu, że obiektu nie zainicjowano wartościami


            Console.ReadKey(); 
        }
    }
}
