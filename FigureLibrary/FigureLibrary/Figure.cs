using System;

namespace FigureLibrary
{
    // хотел Figure объявить интерфейсом, но потом решил сделать abstract class
    // чтобы показать работу с protected
    public abstract class Figure
    {
        public abstract double Area();
        
        protected double Sin(double degree) =>
            Math.Sin(degree * Math.PI / 180);
    }
}
