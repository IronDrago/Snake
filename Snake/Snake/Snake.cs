﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        // Конструктор змейки
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, this.direction);
                pList.Add(p);
            }
        }

        // Движение змейки
        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        // Положения головы змейки после шага
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        // Было ли столкновение головы змейки с её хвостом
        public bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i])) { return true; }
            }
            return false;
        }

        // Поворот змейки
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) { direction = Direction.LEFT; }
            else if (key == ConsoleKey.RightArrow) { direction = Direction.RIGHT; }
            else if (key == ConsoleKey.UpArrow) { direction = Direction.UP; }
            else if (key == ConsoleKey.DownArrow) { direction = Direction.DOWN; }
        }

        // Съела ли змейка еду
        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else { return false; }
        }
    }
}
