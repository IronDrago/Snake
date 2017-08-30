using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            // Отрисовка стенок
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawFigure();

            // Создание еды
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                // Проверка на проигрыш
                if (walls.IsHit(snake) || snake.IsHitTail()) { break; }

                // Отрисовка новой еды
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else { snake.Move(); }

                // Управление змейкой
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}



