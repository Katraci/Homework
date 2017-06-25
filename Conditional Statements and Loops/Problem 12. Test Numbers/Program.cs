using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = number1; i >=1; i--)
            {
                for (int j = 1; j <=number2; j++)
                {
                    sum += 3 * (i * j);
                    counter++;
                    if (sum>=number3)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {number3}");
                        break;
                    }
                }
                if (sum >= number3)
                {
                   
                    break;
                }
            }
            
            if (sum<number3)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
