using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!= "end")
            {
                Box curentBox=CreatBox(input);
                int perimeter = 2 * curentBox.Width + 2 * curentBox.Height;
                int area = curentBox.Width * curentBox.Height;
                Console.WriteLine($"Box: {curentBox.Width}, {curentBox.Height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
                input = Console.ReadLine();
            }
        }

        private static double CalclateDistanse(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return result;
        }

        private static Box CreatBox(string input)
        {
            int[] numbers = input.Split(new char[] { ' ', '|', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Point p1= new Point(numbers[0] , numbers[1]);
            Point p2 = new Point (numbers[2], numbers[3]);
            Point p3 = new Point(numbers[4], numbers[5]);
            Point p4 = new Point(numbers[6], numbers[7]);

            Box result = new Box
            {
                UpperLeft=p1,
                UpperRight=p2,
                BottomLeft=p3,
                BottomRight=p4
            };
            return result;
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x,int y)
            {
                X = x;
                Y = y;
            }

        }
        class Box
        {
            public Point UpperLeft { get; set; }
            public Point UpperRight { get; set; }
            public Point BottomLeft { get; set; }
            public Point BottomRight { get; set; }
            public int Width
            {
                get
                {
                    return  (int) CalclateDistanse(UpperLeft, UpperRight);
                }
            }
            public int Height
            {
                get
                {
                    return (int) CalclateDistanse(UpperLeft, BottomLeft);
                }
            }
        }
    }
}
