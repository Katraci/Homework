﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Debugging_Exercise_Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            bool triangleValidityCondition1 = a + b > c;
            bool triangleValidityCondition2 = b + c > a;
            bool triangleValidityCondition3 = a + c > b;
            bool isValidTriangle = triangleValidityCondition1 && triangleValidityCondition2 && triangleValidityCondition3;
            bool rightTriangleCondition1 = a * a + b * b == c * c;
            bool rightTriangleCondition2 = b * b + c * c == a * a;
            bool rightTriangleCondition3 = a * a + c * c == b * b;
            if (!isValidTriangle)
            {
                Console.WriteLine("Invalid Triangle.");
            }
            else
            {
                Console.WriteLine("Triangle is valid.");
                if (rightTriangleCondition1)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else
                {
                    if (rightTriangleCondition2)
                    {
                        Console.WriteLine("Triangle has a right angle between sides b and c");
                    }
                    else
                    {
                        if (rightTriangleCondition3)
                        {
                            Console.WriteLine("Triangle has a right angle between sides a and c");
                        }
                        else
                        {
                            Console.WriteLine("Triangle has no right angles");
                        }
                    }
                }
            }
        }
    }
    
}
