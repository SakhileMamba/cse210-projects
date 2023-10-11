using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(color: "red", side: 15.0);
        Console.WriteLine($"Square color: {square.GetColor()}");
        Console.WriteLine($"Square area: {square.GetArea()}");
        Console.WriteLine();

        Rectangle rectangle = new Rectangle(color: "blue", length: 10.0, width: 5);
        Console.WriteLine($"Rectangle color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        Console.WriteLine();

        Circle circle = new Circle(color: "pink", radius: 50.0);
        Console.WriteLine($"Circle color: {circle.GetColor()}");
        Console.WriteLine($"Circle area: {circle.GetArea()}");
        Console.WriteLine();


        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape shape in shapes)
        {   
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }

    }
}