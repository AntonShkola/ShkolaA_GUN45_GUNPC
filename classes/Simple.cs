using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Orange
        }

        class Point
        {
            public int x;
            public int y;
            public Color color;
        }

        class Stident
        {
            public Guid id;
            public string firstName;
            public string lastName;
            public string middleName;
            public int age;
            public string group;
        }

        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 4;
            p.y = 2;
            p.color = Color.Red;

            Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.color}");          
        }
    }
}