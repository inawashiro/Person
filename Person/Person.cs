﻿using System;

namespace Person
{
    interface IPerson
    {
        //property
        string Name { get; }

        //property
        int Age { get; }
    }

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

    class Equivocator : IPerson
    {
        private string name;
        private int age;

        //constructor
        public Equivocator(string name, int age)
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