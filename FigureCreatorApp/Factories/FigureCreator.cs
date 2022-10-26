using FigureCreatorApp.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCreatorApp.Factories
{
    public abstract class FigureCreator
    {
        public abstract Figure CreateFigure();

        public abstract Figure CreateFigure(List<Point> points);
    }
}
