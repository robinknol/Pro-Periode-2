using System;

namespace Pro2_simple_calculator
{
    class Program
    {

        private static int numberOne;
        private static int numberTwo;
        private static string calculation;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Give number one.");
            numberOne = Convert.ToInt32(Console.ReadLine() );
            Console.Clear();

            Console.WriteLine(numberOne + " " + "???" + " " + "???" + " " + "=" + "???");

            Console.WriteLine("What do you want do do with " + numberOne);
            calculation = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(numberOne + " " + calculation + " " + "???" + " " + "=" + "???");

            if (calculation == "+") {
                Console.WriteLine("How much do you want to add on " + numberOne);
            } else if (calculation == "-") {
                Console.WriteLine("How much do you want to subtrack from " + numberOne);
            } else if (calculation == "*" || calculation == "x" || calculation == "X") {
                Console.WriteLine("How many times do you want to multiply " + numberOne);
            } else if (calculation == "/" || calculation == ":") {
                Console.WriteLine("Through how much do you want to divide " + numberOne);
            } else if (calculation == "%") {
                Console.WriteLine("How many modulo's do you want to use on " + numberOne);
            }

            numberTwo = Convert.ToInt32(Console.ReadLine() );

            

            if (calculation == "+") {
                plus();
            } else if (calculation == "-") {
                minus();
            } else if (calculation == "*" || calculation == "x" || calculation == "X") {
                multiply();
            } else if (calculation == "/" || calculation == ":") {
                divide();
            } else if (calculation == "%") {
                modulo();
            }

        }

        static private void plus()
        {
            int result = numberOne + numberTwo;
            Console.Clear();
            Console.WriteLine(numberOne + " " + calculation + " " + numberTwo + " " + "=" + " " + result);
        }

        static private void minus()
        {
            int result = numberOne - numberTwo;
            Console.Clear();
            Console.WriteLine(numberOne + " " + calculation + " " + numberTwo + " " + "=" + " " + result);
        }

        static private void multiply()
        {
            int result = numberOne * numberTwo;
            Console.Clear();
            Console.WriteLine(numberOne + " " + calculation + " " + numberTwo + " " + "=" + " " + result);
        }

        static private void divide()
        {
            int result = numberOne / numberTwo;
            Console.Clear();
            Console.WriteLine(numberOne + " " + calculation + " " + numberTwo + " " + "=" + " " + result);
        }

        static private void modulo()
        {
            int result = numberOne % numberTwo;
            Console.Clear();
            Console.WriteLine(numberOne + " " + calculation + " " + numberTwo + " " + "=" + " " + result);
        }
    }
}
