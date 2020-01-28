using System;

namespace classAssignment
{
    public class Student : Person
    {
        private string education = "no education";
        public Student(string name, string education) : base(name)
        {
            //constructor
            this.education = education;

            Console.WriteLine(" You're studying " + education);
            Console.WriteLine();
        }
    }
}