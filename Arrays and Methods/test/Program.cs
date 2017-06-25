using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 0; i<=3*n; i++)
            {
                for (int j = 0; j <= 2 * n; j++)
                {
                    if ((i <= n || i > 2 * n)&&(j<=n))
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        if ((i <= n || i > 2 * n) && (j>n))
                        {
                            Console.Write("*");
                        }
                        Console.Write(new string('*', 2 * n));
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
