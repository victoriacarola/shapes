/*
  File: ShapesApp.cs
  Description: This application defines a set of geometric shapes (Triangle, Quad and Circle) with methods 
    for calculating areas and perimeters.
    It includes a ShapeFactory for creating random shapes and a console-based demo.
  Author: Victoria
  Date: 2024-12-21
  Version: 1.0
  Notes: The focus is supposed to be in SOLID principles in shape design.
 */

using System;


public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}


public class Vector2D
{
    public double X { get; }
    public double Y { get; }

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double CalculateDistance(Vector2D other)
    {
        return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
    }
}


public class Triangle : IShape
{
    private readonly Vector2D _p0;
    private readonly Vector2D _p1;
    private readonly Vector2D _p2;

    public Triangle(Vector2D p0, Vector2D p1, Vector2D p2)
    {
        _p0 = p0;
        _p1 = p1;
        _p2 = p2;
    }

    public double CalculatePerimeter()
    {
        double side1 = _p0.CalculateDistance(_p1);
        double side2 = _p1.CalculateDistance(_p2);
        double side3 = _p2.CalculateDistance(_p0);
        return side1 + side2 + side3;
    }

    public double CalculateArea()
    {
        double side1 = _p0.CalculateDistance(_p1);
        double side2 = _p1.CalculateDistance(_p2);
        double side3 = _p2.CalculateDistance(_p0);
        double semiPerimeter = CalculatePerimeter() / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
    }
}


public class Quad : IShape
{
    private readonly Vector2D _p0;
    private readonly Vector2D _p1;
    private readonly Vector2D _p2;
    private readonly Vector2D _p3;

    public Quad(Vector2D p0, Vector2D p1, Vector2D p2, Vector2D p3)
    {
        _p0 = p0;
        _p1 = p1;
        _p2 = p2;
        _p3 = p3;
    }

    public double CalculatePerimeter()
    {
        double side1 = _p0.CalculateDistance(_p1);
        double side2 = _p1.CalculateDistance(_p2);
        double side3 = _p2.CalculateDistance(_p3);
        double side4 = _p3.CalculateDistance(_p0);
        return side1 + side2 + side3 + side4;
    }

    public double CalculateArea()
    {
        
        double side1 = _p0.CalculateDistance(_p1);
        double side2 = _p1.CalculateDistance(_p2);
        return side1 * side2; 
    }
}


public class Circle : IShape
{
    private readonly Vector2D _p0;
    private readonly double _r;

    public Circle(Vector2D p0, double r)
    {
        _p0 = p0;
        _r = r;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * _r;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_r, 2);
    }
}

public static class ShapeFactory
{
    private static readonly Random Random = new Random();

    public static IShape CreateRandomShape()
    {
        int shapeType = Random.Next(3); 

        switch (shapeType)
        {
            case 0:
                return new Triangle(
                    new Vector2D(Random.NextDouble() * 10, Random.NextDouble() * 10),
                    new Vector2D(Random.NextDouble() * 10, Random.NextDouble() * 10),
                    new Vector2D(Random.NextDouble() * 10, Random.NextDouble() * 10));
            case 1:
                return new Quad(
                    new Vector2D(Random.NextDouble() * 10, Random.NextDouble() * 10),
                    new Vector2D(Random.NextDouble() * 10, Random.NextDouble() * 10),
                    new Vector2D(Random.NextDouble() * 10, Random.NextDouble() * 10),
                    new Vector2D(Random.NextDouble() * 10, Random.NextDouble() * 10));
            case 2:
                return new Circle(
                    new Vector2D(Random.NextDouble() * 10, Random.NextDouble() * 10),
                    Random.NextDouble() * 10);
            default:
                throw new InvalidOperationException("Unknown shape type");
        }
    }
}


public class ShapesApp
{
    public static void Main(string[] args)
    {
        var randomShape = ShapeFactory.CreateRandomShape();
        Console.WriteLine($"Random Shape ({randomShape.GetType().Name}) Area: {randomShape.CalculateArea():F2}, Perimeter: {randomShape.CalculatePerimeter():F2}");

        var triangle = new Triangle(new Vector2D(0, 0), new Vector2D(3, 0), new Vector2D(0, 4));
        var quad = new Quad(new Vector2D(0, 0), new Vector2D(4, 0), new Vector2D(4, 3), new Vector2D(0, 3));
        var circle = new Circle(new Vector2D(0, 0), 1);

        Console.WriteLine($"Triangle Area: {triangle.CalculateArea():F2}, Perimeter: {triangle.CalculatePerimeter():F2}");
        Console.WriteLine($"Quad Area: {quad.CalculateArea():F2}, Perimeter: {quad.CalculatePerimeter():F2}");
        Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}, Circumference: {circle.CalculatePerimeter():F2}");
    }
}
