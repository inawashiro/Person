using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Truepenny("Hiromichi", 24);
            var person = new Equivocator("Hiromichi", 24);
            Introduce(person);
        }

        static void Introduce(IPerson person)
        {
            Console.WriteLine($"My name is {person.Name}.");
            Console.WriteLine($"I am {person.Age} years old.");
        }
    }
}