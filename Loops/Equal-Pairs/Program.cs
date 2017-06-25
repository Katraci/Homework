using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var sumMax = -1000000000;
            var sumMin = 1000000000;
            for (int i = 0; i < 2*n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (i % 2 != 0)
                {
                    if (sum > sumMax)
                    {
                        sumMax = sum;
                    }
                    if (sum < sumMin)
                    {
                        sumMin = sum;
                    }
                    if(i!=(2*n-1))
                    {
                        sum = 0;
                    }
                }
            }
            if ((sumMax-sumMin)==0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {

                Console.WriteLine("No, maxdiff={0}", sumMax - sumMin);
            }
        }
    }
}
