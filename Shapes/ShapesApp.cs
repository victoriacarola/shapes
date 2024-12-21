/*
  File: ShapesApp.cs
  Description: This application defines a set of geometric shapes 
    (Triangle, Quad and Circle) with methods for calculating areas and perimeters.
    It includes a ShapeFactory for creating random shapes and a console-based demo.
  Author: Victoria
  Date: 2024-12-21
  Version: 1.0
  Notes: The focus is supposed to be in SOLID principles in shape design.
 */

using System;

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