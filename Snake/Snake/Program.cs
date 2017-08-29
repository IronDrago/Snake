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
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(2, 6, '$');
            Point p4 = new Point(3, 7, '^');

            List<char> list = new List<char>();
            list.Add('*');
            list.Add('#');
            list.Add('$');
            list.Add('^');
            list.RemoveAt(0);

            foreach (char c in list)
            {
                Console.WriteLine(c);
            }

            List<Point> points = new List<Point>();
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);

            foreach (Point p in points)
            {
                p.Draw();
            }
            
            Console.ReadLine();

        }
    }
}
