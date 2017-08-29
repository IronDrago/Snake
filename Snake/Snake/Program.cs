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
            HorizontalLine HLine = new HorizontalLine(1, 10, 3, '-');
            HLine.DrawHLine();

            VerticalLine VLine = new VerticalLine(12, 1, 10, '+');
            VLine.DrawVLine();
            
            Console.ReadLine();

        }
    }
}
