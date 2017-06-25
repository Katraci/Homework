using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            if (n < 1 && n > 12) Console.WriteLine("error");
            else
            {
                do
                {
                    num = n * num;
                    n--;
                } while (n>1);
                Console.WriteLine(num);
            }
        }
    }
}
