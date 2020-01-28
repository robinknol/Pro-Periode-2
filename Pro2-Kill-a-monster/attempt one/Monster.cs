using System;

public class Monster
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
                Console.WriteLine(_name + " is dead you win");
                return;
            }
            _hitPoints = value;
        }
    }

    private string _name = "Gizzid";
    public string name
    {
        get
        {
            return _name;
        }
    }
}