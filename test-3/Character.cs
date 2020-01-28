using System;

public class Character
{
    public string id = "characterBase";
    public int points = 0;
    public float speed = 10.0f;
    public int lives = 3;

    public Character()
    {
        Console.WriteLine("Character constructor");
    }

    public virtual void Walk()
    {
        Console.WriteLine("Walk");
    }

    public void Die()
    {
        Console.WriteLine("Die");
    }


}