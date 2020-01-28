using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Teacher t1 = new Teacher("Erwin", "PRO2");
            Teacher t2 = new Teacher("Erik", "PRO2");
            Teacher t3 = new Teacher("Theo", "PRO1");
            Teacher t4 = new Teacher("Jesse", "Dip");

            Student s1 = new Student("Harry", "Mediadeveloper");
            Student s2 = new Student("Donny", "Gamedeveloper");
            Student s3 = new Student("Robin", "Gamedevoloper");

            parents p1 = new parents("Mieke", "Robin");
            parents p2 = new parents("Edwin", "Robin");
        }
    }
}
