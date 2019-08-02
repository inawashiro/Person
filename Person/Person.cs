using System;

namespace Person
{
    public abstract class Person
    {
        //public static string scientificName;
        private string name;
        protected int age;

        ////constructor
        //static Person() { Person.scientificName = "Homo sapiens"; }

        //constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //property
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        //property
        public abstract int Age
        {
            get;
        }
    }

    class Truepenny : Person
    {
        //constructor
        public Truepenny(string name, int age) : base(name, age) { }

        //property
        public override int Age
        {
            get { return this.age; }
        }
    }

    class Equivocator : Person
    {
        //constructor
        public Equivocator(string name, int age) : base(name, age) { }

        //property
        public override int Age
        {
            get
            {
                int remainder = this.age % 10;
                if (remainder < 5)
                {
                    return this.age - remainder;
                }
                else
                {
                    return this.age - remainder + 10;
                }
            }
        }
    }
}