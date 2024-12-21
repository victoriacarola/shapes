/*
  File: Vector2D.cs
  Description: A simple class to represent a point in 2D space.
  Author: Victoria
  Date: 2024-12-21
  Version: 1.0
 */

using System;


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

    // Beispielmethoden für IShape und IHasPoints
    public double CalculateArea()
    {
        // Beispielhafter Code für die Berechnung der Fläche, falls zutreffend
        return 0; // Da Vector2D keine Fläche hat
    }

    public (double, double) GetPoints()
    {
        return (X, Y); // Gibt die Koordinaten des Punktes zurück
    }
}
