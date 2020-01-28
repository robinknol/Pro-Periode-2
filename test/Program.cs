using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Player myplayer = new Player();
            Player secondPlayer = new Player("Luigi");
            Player thirdPlayer = new Player("Toad blue");

            myplayer.jump();

            secondPlayer.shoot(123456789);

            thirdPlayer.shoot(1);
        }
    }
}
