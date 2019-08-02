using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Truepenny truepenny = new Truepenny("Hiromichi", 24);
            Introduce(truepenny);

            Equivocator equivocator = new Equivocator("Hiromichi", 24);
            Introduce(equivocator);
        }

        static void Introduce(Person person)
        {
            Console.WriteLine($"My name is {person.Name}.");
            Console.WriteLine($"I am {person.Age} years old.");
        }
    }
}