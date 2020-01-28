using System;

namespace Youdon_tOwnMe_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GreenShell green = new GreenShell();
            RedShell red = new RedShell();
            BlueShell blue = new BlueShell();

            Console.Clear();
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                green.abc();
            }
            else if (input == 2)
            {
                red.abc();
            }
            else if (input == 3)
            {
                blue.abc();
            }
        }
    }
}
