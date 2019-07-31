using System;
namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        //constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //constructor
        public Person(string name) : this(name, -1) { }

        //constructor
        public Person(int age) : this("None", age) { }

        //constructor
        public Person() : this("None", -1) { }

        //property
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        //property
        public int Age
        {
            set { this.age = value > 0 ? this.age : 0; }
            get { return this.age; }
        }
    }
}
