using System;
using BaseGeometricShapeApp;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square
        {
            Width = 5,
        };
        Console.WriteLine($"Square Area (Width = 5, Height = 5): {square1.CalculateArea()}");
        Console.WriteLine();

        Rectangle rectangle1 = new Rectangle
        {
            Width = 5,
            Height = 10
        };
        Console.WriteLine($"Rectangle Area: (Width = 5, Height = 10): {rectangle1.CalculateArea()}");
        Console.WriteLine();

        RightTriangle rightTriangle = new RightTriangle
        {
            Width = 5,
            Height = 10
        };
        Console.WriteLine($"Right Triangle Area (Width = 5, Height = 10): {rightTriangle.CalculateArea()}");
    }
}