using System;

public abstract class Shape
{
    public abstract void draw();
}

public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing rectangle from Rectangle class...");
    }
}
public class AbstuctClassExample : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing rectangle from AbstuctClassExample class....");
    }
}


