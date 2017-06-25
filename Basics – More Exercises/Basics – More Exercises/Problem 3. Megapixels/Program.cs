using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double megapixels = (width * height) / 1000000.0;
            Console.WriteLine($"{width}x{height} => {Math.Round(megapixels, 1)}MP");
        }
    }
}
