using System;

namespace attempt_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("How long do you want the number line to be?");
            Console.WriteLine("Type in the length");
            Console.WriteLine("Afterwards type in how big the number should be");
            
            randomizer(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine() ));
        }

        static void randomizer(int x, int y) {
            Random randomNum = new Random();
            for (var i = 0; i < x; i++)
            {
                int result = randomNum.Next(0, y);
                Console.Write(result + " ");
            }
        }
    }
}
