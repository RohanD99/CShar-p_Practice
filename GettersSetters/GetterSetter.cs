using System;

public class Rectangle
{
    private double width;    
    public double Width
    {
        get { return width; }
        set { width = value; }
    }
}

public class Rectangles
{
    public double Width;

    public double GetWidth()
    {
        return Width;
    }

    public void SetWidth(double value)
    {
        Width = value;
    }
}

Rectangle rect = new Rectangle();
rect.Width = 1;
Console.WriteLine(rect);

Rectangles rects = new Rectangles();
rects.GetWidth;

Rectangles rects2 = new Rectangles();
rects2.SetWidth;




