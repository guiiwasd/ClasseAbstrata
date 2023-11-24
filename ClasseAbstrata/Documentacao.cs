﻿abstract class BaseClass
{
    protected int _x = 100;
    protected int _y = 150;

    public abstract void AbstractMethod();

    public abstract int X { get; }
    public abstract int Y { get; }
}

class DerivedClass : BaseClass
{
    public override void AbstractMethod()
    {
        _x++;
        _y++;
    }

    public override int X 
    {
        get
        {
            return _x + 10;
        }
    }

    public override int Y   
    {
        get
        {
            return _y + 10;
        }
    }

    static void Main()
    {
        var o = new DerivedClass();
        o.AbstractMethod();
        Console.WriteLine($"x = {o.X}, y = {o.Y}");
    }
}
