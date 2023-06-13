using System;

class Program
{
    static void Main(string[] args)
    {

        Square sArea = new Square();
        sArea.SetColor("Blue");
        sArea.SetSide(5);
        // sArea.GetSides();
        // sArea.DisplayShape();

        Rectangle rArea = new Rectangle();
        rArea.SetColor("Brown");
        rArea.SetLenght(5);
        rArea.SetWidth(10);
        // rArea.DisplayShape();

        Circle cArea = new Circle();
        cArea.SetColor("White");
        cArea.SetRadius(5);
        // sArea.GetSides();
        // cArea.DisplayShape();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sArea);
        shapes.Add(rArea);
        shapes.Add(cArea);
        foreach (Shape shape in shapes)
        {
            shape.DisplayShape();
        }
    }
}