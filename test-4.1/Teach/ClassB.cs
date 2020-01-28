using System;
using classic;

public class ClassB : ClassA
{
    public static int statischeintOpenbaar = 0;
    private static int statischeintprive = 55;
    public string nogwattekst = "Hello";


    public ClassB()
    {
        // CONSTRUCTOR
        Console.WriteLine(this.getalBeschermt);
        DoeIets();
    }

    protected void BeschermdeFunctie()
    {
        Console.WriteLine("Leuk");
        Console.WriteLine("prive statisch " + ClassB.statischeintprive);
    }

    private void DoeIets()
    {
        Console.WriteLine("Prive, alleen hier innen! :D");
    }
}