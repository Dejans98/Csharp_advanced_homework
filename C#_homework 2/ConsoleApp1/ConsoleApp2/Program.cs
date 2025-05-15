

using System.Drawing;
using ConsoleApp2.Interfaces;
using ConsoleApp2.Models;
//using Rectangle = System.Drawing.Rectangle;

IShape circle = new Circle(3);
Console.WriteLine("Circle: " +circle.GetArea());
IShape triangle = new Triangle(6, 2);
Console.WriteLine($"Triangle: {triangle.GetArea()}");
//IShape rectangle = new Rectangle(3,2);
//Rectangle rect = new Rectangle(4, 3); Mi dava eror ne znam od sto 
