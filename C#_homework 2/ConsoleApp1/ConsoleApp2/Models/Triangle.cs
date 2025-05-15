using System.Security.Principal;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Models
{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLenght ,double height)
        {
            Base = baseLenght;
            Height = height;
        }

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }




    }
}
