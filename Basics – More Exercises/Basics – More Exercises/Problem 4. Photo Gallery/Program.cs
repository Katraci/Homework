using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int monght = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{number:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{monght:D2}/{year:D4} {hour:D2}:{minute:D2}");
            if (size<1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            if (size > 1000&&size<1000000)
            {
                Console.WriteLine($"Size: {size/1000}KB");
            }
            if (size > 1000000)
            {
                Console.WriteLine($"Size: {size/1000000}MB");
            }
            Console.Write($"Resolution: {width}x{height} ");
            if (width>height)
            {
                Console.WriteLine("(landscape)");
            }
            if (width < height)
            {
                Console.WriteLine("(portrait)");
            }
            if (width == height)
            {
                Console.WriteLine("(square)");
            }
        }
    }
}
