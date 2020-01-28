using System;
using classic;

namespace Teach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ClassA instantieX = new ClassA();

            instantieX.stukTekst += " Nog iets";
            instantieX.LaatWatZien();

            Console.WriteLine("Variabele in class" + instantieX.stukTekst);

            ClassB instantieY = new ClassB();

            instantieY.nogwattekst += "Leuk zeg";
            instantieY.LaatWatZien();

            ScoreSheet.Score += 1;

        }
    }
}
