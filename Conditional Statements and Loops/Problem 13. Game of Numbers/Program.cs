using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int counter = 0;
            for (int i = number1; i <=number2; i++)
            {
                for (int j = number1; j <=number2; j++)
                {
                    counter++;
                    if (i+j==number3)
                    {
                        a = i;
                        b = j;
                    }
                }
            }
            if (a!=0&&b!=0)
            {
                Console.WriteLine($"Number found! {a} + {b} = {number3}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {number3}");
            }
        }
    }
}
