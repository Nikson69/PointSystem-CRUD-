using System;

namespace FigureLibrary.Models
{
    public class Circle : Figure
    {
        private readonly double radius;
        private const double degree = 2;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        public override double Area() =>
            PI * Exponentiation(radius, degree);
    }
}
