using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Hiromichi", 24);
            //Console.WriteLine($"{person.Name} is {Person.scientificName}.");

            //Console.WriteLine($"{person.Name} is {person.Age} years old.");

            //person = new Person("Hiromichi");
            //Console.WriteLine($"{person.Name} is {person.Age} years old.");

            //person = new Person(24);
            //Console.WriteLine($"{person.Name} is {person.Age} years old.");

            //person = new Person();
            //Console.WriteLine($"{person.Name} is {person.Age} years old.");

            //Student student = new Student("Hiromichi", 24, 340350);
            //Console.WriteLine($"{student.Name}(:{student.Id}) is {student.Age} years old.");


            //Person person = new Student("Hiromichi", 24, 340350);
            //if (person is Student)
            //{
            //    Console.WriteLine($"{person.Name} is {person.Age} years old.");
            //}
            //else
            //{
            //    Console.WriteLine("Cast impossible");
            //}

            //if (person as Student != null)
            //{
            //    Console.WriteLine($"{person.Name} is {person.Age} years old.");
            //}
            //else
            //{
            //    Console.WriteLine("Cast impossible");
            //}

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