using System;

namespace FigureLibrary
{
    public abstract class Figure
    {
        public const double PI = 3.14;
        public abstract double Area();
        protected double Exponentiation(double sourse, double degree) =>
            Math.Pow(sourse, degree);
        protected double Sin(double degree) =>
            Math.Sin(degree * Math.PI / 180);
    }
}
