using System;

class Program
{
    static void Main(string[] args)
    {
        Square cuadrado = new Square("rojo", 4.5);

        Console.WriteLine($"Square Area: {cuadrado.GetArea()}");
        Console.WriteLine($"Scuare Color: {cuadrado.GetColor()}");
        Console.WriteLine("**********************");


        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 4.2));
        shapes.Add(new Rectangle(2.6, 7.3, "orange"));
        shapes.Add(new Circle(5.8, "yellow"));

        foreach(Shape i in shapes)
        {
            Console.WriteLine($"Color: {i.GetColor()}");
            Console.WriteLine($"Area: {i.GetArea():f2}");
            Console.WriteLine("---------------------------");
        }
    }
}