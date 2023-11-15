

using Inheritance.Models;


List<Shape> shapes = new List<Shape>();

Shape shape = new Line(10);
shapes.Add(shape);
shape = new Square(15);
shapes.Add(shape);
shape = new Rectangle(12, 20);
shapes.Add(shape);
shape = new Triangle(12, 20, 90);
shapes.Add(shape);

foreach (Shape s in shapes)
{
    Console.WriteLine(s);
}