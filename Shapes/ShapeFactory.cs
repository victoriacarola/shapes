/*
  File: ShapeFactory.cs
  Description: This class generates a random shape with random paraeters.
  Author: Victoria
  Date: 2024-12-21
  Version: 1.0
 */
using System;


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