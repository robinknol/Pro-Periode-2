using System;

namespace test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Character myBaseClass = new Character();
            Mario myMario = new Mario();
            
            myBaseClass.Walk();

            myMario.Shoot();

            myMario.Walk();

            myMario.Shoot(5); // Caal overloaded shoot function

            myMario.Shoot("Noice");
            
        }
    }
}
