using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine leftLine = new VerticalLine(78, 24, 0, '+');

            topLine.DrawFigure();
            bottomLine.DrawFigure();
            rightLine.DrawFigure();
            leftLine.DrawFigure();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawFigure();

            Console.Read();

        }
    }
}
