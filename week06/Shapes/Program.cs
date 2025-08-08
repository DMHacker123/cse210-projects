using System;
using System.Collections.Generic;
using ShapesProject;

namespace ShapesProject
{
    class Program
    {
        static void Main()
        {
            // Create a list of shapes
            List<Shape> shapes = new List<Shape>
            {
                new Square("Red", 4),
                new Rectangle("Blue", 5, 3),
                new Circle("Green", 2.5)
            };

            // Display each shape's color and area
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
            }
        }
    }
}
