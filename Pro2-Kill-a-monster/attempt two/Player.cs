using System;

public class Player
{
    private int _hitPoints = 100;
    public int hitPoints
    {
        get
        {
            return _hitPoints;
        }
        set
        {
            if (value == 0)
            {
                Console.WriteLine(_name + " is dead you lose");
                return;
            }
            _hitPoints = value;
        }
    }

    private string _name = "rayan";
    public string name
    {
        get
        {
            return _name;
        }
    }
}