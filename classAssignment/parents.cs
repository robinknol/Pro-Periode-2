using System;

namespace classAssignment
{
    public class parents : Person
    {
        private string Student = "No student";
        
        public parents(string name, string student) : base(name)
        {
            this.Student = student;

            Console.WriteLine(" You're the parant of " + student);
            Console.WriteLine();
        }
    }
}