using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice
{
    public class Persons
    {
        public string Name { get; set; }
        public Persons(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
        ~Persons()
        {
            Name = string.Empty;
        }

    }
}
