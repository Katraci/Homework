using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var tiket = Console.ReadLine().ToLower();
            var column = double.Parse(Console.ReadLine());
            var row = double.Parse(Console.ReadLine());
            switch (tiket)
                {
                case "premiere":
                    Console.WriteLine("{0:f2} leva", column * row * 12.00);break;
                case "normal":
                    Console.WriteLine("{0:f2} leva", column * row * 7.5); break;
                case "discount":
                    Console.WriteLine("{0:f2} leva", column * row * 5.00); break;
            }
        }
    }
}
