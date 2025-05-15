

using ConsoleApp3.BaseEntity;
using ConsoleApp3.Models;

Shape circle = new Circle(5);
Console.WriteLine($"Cicle:\nArea: {circle.CalculateArea()} \nPerimetar: {circle.CalculatePerimetar()}");

Shape triangle = new Triangle(5, 6, 3,4);

Console.WriteLine($"Area: {triangle.CalculateArea()}");
Console.WriteLine($"Perimetar: {triangle.CalculatePerimetar()}");