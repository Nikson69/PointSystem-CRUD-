using System;

namespace FigureLibrary.Models
{
    public class Triangle : Figure
    {
        private const double half =  0.5;
        private const double degree = 2;
        private const double rightAngle = 90;

        private readonly double firstSides;
        private readonly double secondSides;
        private readonly double? height;
        private readonly double? corner;

        public Triangle(double firstSides, double secondSides, double degree)
        {
            this.firstSides = firstSides;
            this.secondSides = secondSides;
            corner = degree;
        }

        public Triangle(double side, double height)
        {
            this.firstSides = side;
            this.height = height;
        }

        public Triangle(double side)
        {
            firstSides = side;
        }

        public override double Area()
        {
            if (corner.HasValue)
                return AreaForSineAngle();

            if (height.HasValue)
                return AreaForSideAndHeight();            
                
            return AreaOfEquilateralTriangle();
        }

        private double AreaForSideAndHeight() => 
            half * firstSides * height.Value;
            
        private double AreaRectangle() =>
            half * firstSides * secondSides;

        private double AreaForSineAngle()
        {
            if (corner.Value == rightAngle)
                return AreaRectangle();
            else
                return half * firstSides * secondSides * Sin(corner.Value);
        }
            
        private double AreaOfEquilateralTriangle() => 
            (Math.Pow(firstSides, degree) * Math.Sqrt(3)) / 4;
    }
}
