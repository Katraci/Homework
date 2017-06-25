using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if(number%2!=0&&number>=3)
            {
                for (int i = 1; i <=number; i++)
                {
                    for (int j = 1; j <= number; j++)
                    {
                        if (j==i||j==number+1-i)
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
