using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;        // возможность использования копий для наследников

        // Отрисовка фигуры
        public virtual void DrawFigure()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        // Было ли столкновение фигур
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p)) { return true; }
            }
            return false;
        }

        // Было ли столкновение точек фигур
        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point)) { return true; }
            }
            return false;
        }
    }
}
