using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number2 - number1 < 5)
            {
                Console.WriteLine("No");
            }
            else
            {

                for (int i = number1; i <= number2; i++)
                {
                    for (int j = number1; j <= number2; j++)
                    {
                        for (int k = number1; k <= number2; k++)
                        {
                            for (int z = number1; z <= number2; z++)
                            {
                                for (int g = number1; g <= number2; g++)
                                {
                                    if (i >= number1 && i < j && j < k && k < z && z < g && g <= number2)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {z} {g}");
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
