using System;

public interface Drawable
{
    void draw();
}

public class Rectangles : Drawable
{
    public void draw()
    {
        Console.WriteLine("Drawing Rectangles...");
    }
}

public class circles : Drawable
{
    public void draw()
    {
        Console.WriteLine("Drawing Circless...");
    }
}

public class InterfaceExample : Drawable
{
    public void draw()
    {
        Console.WriteLine("Drawing nothing...");
    }
}


