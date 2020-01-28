using System;

namespace attempt_one
{
    class Program
    {
        private static int x;
        private static int y;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("How long do you want the number line to be?");
            Console.WriteLine("Type in the length");
            x = Convert.ToInt32(Console.ReadLine() );

            Console.Clear();
            Console.WriteLine("between zero(0) and how much do you want your line to be (btw it is between 1 and 9)");
            Console.WriteLine("If you don't understand then type '0'.");
            Console.WriteLine("Type in a number");

            inBetween();
        }

        static private void inBetween()
        {
            y = Convert.ToInt32(Console.ReadLine() );

            if (y == 0) {
                Console.WriteLine("You said you want your line to be" + x + " So the number you type in here will limet the number generated");
                Console.WriteLine("In this example you want the line to be 4 numbers long");
                Console.WriteLine("so if you type here 6 the generator will make every number on the line between 1 and 6");
                inBetween();
            } else if (y >= 1 && y <= 9){
                Console.Clear();
                finish();
            } else {
                Console.WriteLine("retry");
                inBetween();
            }
        }

        static private void finish() 
        {
            Random randomNum = new Random();
            for (var i = 0; i < x; i++)
            {
                int result = randomNum.Next(0, y);
                Console.Write(result);
            }
        }
    }
}
