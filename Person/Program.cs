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

            Student student = new Student("Hiromichi", 24, 340350);
            Console.WriteLine($"{student.Name}(:{student.Id}) is {student.Age} years old.");

            Person person = student;
            Console.WriteLine($"{student.Name}(:{student.Id}) is {student.Age} years old.");

            //Student student1 = person;
            //Console.WriteLine($"{person.Name}(:{person.Id}) is {person.Age} years old.");
        }
    }
}