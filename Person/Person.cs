using System;
namespace Person
{
    public class Person
    {
        private string Name;
        private int Age;

        //constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //constructor
        public Person(string name) : this(name, -1) { }

        //constructor
        public Person(int age) : this("None", age) { }

        //constructor
        public Person() : this("None", -1) { }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public void SetAge(int age)
        {
            this.Age = age > 0 ? age : 0;
        }
    }
}
