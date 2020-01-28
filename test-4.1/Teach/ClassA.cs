using System;

namespace classic
{
    public class ClassA
    {
        public string stukTekst = " Hallo";

        protected int getalBeschermt = 55;
        private byte getalPrive = 123;

        public void LaatWatZien()
        {
            Console.WriteLine("getalPrive: " + getalPrive);
            string tijdelijk = "Niet lang meer";
            Console.WriteLine(tijdelijk);

            {
                int bodypart = 5;
                Console.WriteLine(bodypart);
            }
        }
    }
}