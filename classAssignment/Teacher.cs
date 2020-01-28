using System;

namespace classAssignment
{
    public class Teacher:Person
    {
        private string course = "no course";
        public Teacher(string name, string course) : base(name)
        {
            // constructor
            this.course = course;

            Console.WriteLine(" you teach " + course);
            Console.WriteLine();
        }
    }
}