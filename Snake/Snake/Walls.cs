using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        // Конструктор стен
        public Walls(int mapWidht, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine topLine = new HorizontalLine(0, mapWidht - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidht - 2, mapHeight - 1, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine leftLine = new VerticalLine(mapWidht - 2, mapHeight - 1, 0, '+');

            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(rightLine);
            wallList.Add(leftLine);
        }

        // Было ли столкновение змейки со стеной
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure)) { return true; }
            }
            return false;
        }

        // Отрисовка стен
        public void Draw()
        {
            foreach (var wall in wallList) { wall.DrawFigure(); }
        }
    }
}
