using FigureLibrary;

namespace FigureServices
{
    public class AreaСalculations
    { 
        private Figure figure;
        public AreaСalculations(Figure figure)
        {
            this.figure = figure;
        }

        public double GetArea()
        {
            return figure.Area();
        }
    }
}
