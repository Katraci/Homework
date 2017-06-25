using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var oddMin = 0.0;
            var oddMax = 0.0;
            var evenSum = 0.0;
            var evenMin = 0.0;
            var evenMax = 0.0;
            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i==0)
                {
                    oddMin = num;
                    oddMax = num;
                }
                if(i==1)
                {
                    evenMax = num;
                    evenMin = num;
                }
                if (i % 2 != 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    else
                    {
                        if (num < evenMin)
                        {
                            evenMin = num;
                        }
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    else
                    {
                        if (num < oddMin)
                        {
                            oddMin = num;
                        }
                    }
                }
            }
            if (n > 1)
            {
                Console.WriteLine("OddSum={0}", oddSum);
                Console.WriteLine("OddMin={0}", oddMin);
                Console.WriteLine("OddMax={0}", oddMax);
                Console.WriteLine("EvenSum={0}", evenSum);
                Console.WriteLine("EvenMin={0}", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }
            else
            {
                if(n==1)
                {
                    Console.WriteLine("OddSum={0}", oddSum);
                    Console.WriteLine("OddMin={0}", oddMin);
                    Console.WriteLine("OddMax={0}", oddMax);
                    Console.WriteLine("EvenSum=0");
                    Console.WriteLine("EvenMin=no");
                    Console.WriteLine("EvenMax=no");
                }
                else
                {
                    Console.WriteLine("OddSum=0");
                    Console.WriteLine("OddMin=no");
                    Console.WriteLine("OddMax=no");
                    Console.WriteLine("EvenSum=0");
                    Console.WriteLine("EvenMin=no");
                    Console.WriteLine("EvenMax=no");
                }
            }
        }
    }
}
