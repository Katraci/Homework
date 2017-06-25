using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int l = 1; l < 10; l++)
                    {
                        for (int k = 1; k < 10; k++)
                        {
                            for (int z = 1; z < 10; z++)
                            {
                                for (int d = 1; d < 10; d++)
                                {
                                    if (n%i==0)
                                    {
                                        num = n / i;
                                        if (num%j==0)
                                        {
                                            num = num / j;
                                            if (num%l==0)
                                            {
                                                num = num / l;
                                                if (num%k==0)
                                                {
                                                    num = num / k;
                                                    if (num%z==0)
                                                    {
                                                        num = num / z;
                                                        if (num==d)
                                                        {
                                                            Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, l, k, z, d);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
