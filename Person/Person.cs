using System;

namespace Person
{
    public class Person
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
        public virtual int Age
        {
            set { this.age = value; }
            //get
            //{
            //    this.age = this.age > 0 ? this.age : 0;
            //    return this.age;
            //}
            get { return 0; }
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