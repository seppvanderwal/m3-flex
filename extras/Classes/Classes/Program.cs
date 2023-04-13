using System;
using System.Drawing;
class Rectangle
{
    public float x;
    public float y;
    public float width;
    public float height;
}
class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.x = 100f;
        rect.y = 200f;
        rect.width = 50f;
        rect.height = 50f;

        Console.WriteLine("Rectangle properties:");
        Console.WriteLine("x: " + rect.x);
        Console.WriteLine("y: " + rect.y);
        Console.WriteLine("width: " + rect.width);
        Console.WriteLine("height: " + rect.height);
    }
}




