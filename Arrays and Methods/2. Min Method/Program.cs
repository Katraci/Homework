using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            GetMin(number1, number2, number3);
        }

         static void GetMin(int n , int m ,int k)
        {
            int min = Math.Min(Math.Min(n, m),k);
            Console.WriteLine(min);
        }
    }
}
