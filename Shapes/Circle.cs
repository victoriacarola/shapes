/*
  File: Circle.cs
  Description: This class represents a Circle.
  Author: Victoria
  Date: 2024-12-21
  Version: 1.0
 */
using System;

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