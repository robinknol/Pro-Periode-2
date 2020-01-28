using System;

public class Mario : Character
{
    public bool isRunning = false;
    public string item = "";

    public Mario()
    {
        Console.WriteLine("Mario constructor");

        id = "Mario";
        Console.WriteLine("Id is nu: " + id);
    }

    public void Shoot()
    {
        Console.WriteLine("Mario Shoots");
    }
    
    // overloading function:
    public void Shoot(int amount)
    {
        Console.WriteLine("Mario shoots " + amount + " times");
    }

    public void Shoot(string tekst)
    {
        Console.WriteLine("Mario says " + tekst);
    }

    public void jump()
    {
        Console.WriteLine("Mario jumps");
    }

    // Overwriting function
    public override void Walk()
    {
        // Dit voert de oorspronkelijke walk functie uit voordat deze wordt uitgevoerd
        base.Walk();
        
        Console.WriteLine("Mario's weird walk");
    }
}