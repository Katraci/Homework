﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            bool token = true;
            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i]!=arr[arr.Length-1-i])
                {
                    token = false;
                }
            }
            if (token)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
