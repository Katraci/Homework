using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double km = mile * 1.60934;
            Console.WriteLine("{0:0.00}",Math.Round(km,2));
        }
    }
}
