using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Player myPlayer = new Player();
            
            Console.WriteLine("LIVES: " + myPlayer.lives);
            Console.WriteLine("points: " + myPlayer.points);
            Console.WriteLine("");

            myPlayer.points += 130;

            Console.WriteLine("LIVES: " + myPlayer.lives);
            Console.WriteLine("points: " + myPlayer.points);
            Console.WriteLine("");
        }
    }
}
