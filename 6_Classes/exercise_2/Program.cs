using System;

namespace exercise_2
{
    public class Human
    {
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            Human h2 = new Human();

            h1.age = 20;
            h2.age = 20;

            if (h1 == h2)
            {
                Console.WriteLine("H1 jest równe H2");
            }
            else
            {
                Console.WriteLine("H1 i H2 nie są równe"); 
                //tutaj == porównuje referencje obiektów, innymi słowy instancje klasy mają różne "adresy" na stercie

                Console.Read();
            }
        }
    }
}
