# Shape Visualizer

## Overview

This project demonstrates the implementation of geometric shapes (Triangle, Quad, Circle) in C#, adhering to the SOLID principles. It calculates and displays the area and perimeter of these shapes and includes a random shape generator. The application can serve as the backend for visualizing and analyzing shapes in a graphical interface.

## Features
- **Shape Classes**: Triangle, Quad, Circle
- **Shape Calculations**: Computes area and perimeter for each shape
- **Random Shape Factory**: Generates random shapes with random parameters
- **Adherence to SOLID Principles**: 
  - Single Responsibility Principle (SRP): Each class (e.g., `Vector2D`, `Triangle`) focuses on a single task, such as representing a 2D point or encapsulating triangle-specific calculations.
  - Open-Closed Principle (OCP): The `IShape` interface allows the addition of new shapes (e.g., polygons) without modifying existing code.
  - Liskov Substitution Principle (LSP): All shape classes (`Triangle`, `Quad`, `Circle`) can be used interchangeably wherever `IShape` is expected.
  - Interface Segregation Principle (ISP): The `IShape` interface is simple and provides only the necessary methods for area and perimeter calculations.
  - Dependency Inversion Principle (DIP): The code relies on the abstraction `IShape` rather than concrete shape classes, decoupling the logic from specific implementations.

## Code Structure

### Key Classes
- **`Vector2D`**: Represents a 2D point and provides methods for calculating distances.
- **`IShape`**: Interface for shape calculations.
- **`Triangle`, `Quad`, `Circle`**: Implementations of the `IShape` interface.
- **`ShapeFactory`**: Generates random shapes using polymorphism.

### Example Usage
```csharp
var randomShape = ShapeFactory.CreateRandomShape();
Console.WriteLine($"Random Shape ({randomShape.GetType().Name}) - Area: {randomShape.CalculateArea():F2}, Perimeter: {randomShape.CalculatePerimeter():F2}");

var triangle = new Triangle(new Vector2D(0, 0), new Vector2D(3, 0), new Vector2D(0, 4));
Console.WriteLine($"Triangle - Area: {triangle.CalculateArea():F2}, Perimeter: {triangle.CalculatePerimeter():F2}");
```

## Requirements
- **.NET SDK**: Version 6.0 or higher

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/shape-visualizer.git
   cd shape-visualizer
   ```
2. Build the project:
   ```bash
   dotnet build
   ```
3. Run the project:
   ```bash
   dotnet run
   ```

## Future Enhancements
- **Front-End Visualization**: Integrate a graphical front-end to plot and label shapes.
- **Shape Customization**: Allow users to input their own shape parameters.

## Contributing
Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License
This project is licensed under the MIT License.
