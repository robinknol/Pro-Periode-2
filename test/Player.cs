using System;

public class Player
{
    
    public int health = 100;
    private string _name = "Mario";

    private int _id = 100;

    public Player(string newName = "Mario")
    {
        // Is the constructor function!
        _name = newName;
    }

    public void jump()
    {
        Console.WriteLine(_name + " Jump");
    }

    public void shoot(int amount)
    {
        Console.WriteLine(_name + " Fire's " + amount + " Times");
    }
}