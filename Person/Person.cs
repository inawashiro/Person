using System;

namespace Person
{
    public class Person
    {
        //public static string scientificName;
        private string name;
        private int age;

        ////constructor
        //static Person() { Person.scientificName = "Homo sapiens"; }

        //constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        ////constructor
        //public Person(string name) : this(name, -1) { }

        ////constructor
        //public Person(int age) : this("None", age) { }

        ////constructor
        //public Person() : this("None", -1) { }

        //property
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        //property
        public int Age
        {
            set { this.age = value; }
            get
            {
                this.age = this.age > 0 ? this.age : 0;
                return this.age;
            }
        }
    }

    class Student : Person
    {
        private int id;

        public Student(string name, int age, int id) : base(name, age)
        {
            this.id = id;
        }

        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
    }
}
