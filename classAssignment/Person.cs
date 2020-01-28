using System;

namespace classAssignment
{
    public class Person
    {
        private string name = "no name";
        public Person(string name)
        {
            //constructor
            this.name = name;

            Console.Write("Hi there " + name);
        }
    }
}