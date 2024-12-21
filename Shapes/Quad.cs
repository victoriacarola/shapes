/*
  File: Quad.cs
  Description: This class represents a 2D Quad.
  Author: Victoria
  Date: 2024-12-21
  Version: 1.0
 */
using System;


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
