﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
            do
            {
                Console.WriteLine(b);
                b++;
            } while (a>=b);
        }
    }
}
