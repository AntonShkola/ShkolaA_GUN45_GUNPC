using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {

        class Point
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 4;
            p.y = 2;

            p = null;

            Point p2 = new Point();
            p2.x = 2;
            p2.y = 6;

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);
          
;        }
    }
}