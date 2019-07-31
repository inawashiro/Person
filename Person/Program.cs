using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Hiromichi", 25);
            Console.WriteLine($"{person.Name} is {person.Age} years old.");

            person = new Person("Hiromichi");
            Console.WriteLine($"{person.Name} is {person.Age} years old.");

            person = new Person(25);
            Console.WriteLine($"{person.Name} is {person.Age} years old.");

            person = new Person();
            Console.WriteLine($"{person.Name} is {person.Age} years old.");
        }
    }
}