using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("blue", 5, 6));
        shapes.Add(new Circle("green", 2));

        foreach (Shape s in shapes){
            Console.WriteLine($"{s} Area: {s.GetArea()} Color: {s.GetColor()}");
        }


    }
}