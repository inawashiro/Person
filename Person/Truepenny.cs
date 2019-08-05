using System;
namespace Person
{
    class Truepenny : IPerson
    {
        private string name;
        private int age;

        //constructor
        public Truepenny(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //property
        public string Name
        {
            get { return this.name; }
        }

        //property
        public int Age
        {
            get { return this.age; }
        }
    }
}
