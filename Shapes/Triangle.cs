/*
  File: Triangle.cs
  Description: This class represents a 2D Triangle.
  Author: Victoria
  Date: 2024-12-21
  Version: 1.0
 */
using System;

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