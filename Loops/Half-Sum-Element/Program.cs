using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = -1000000000;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            if((sum - max)==max)
            {
                Console.WriteLine("Yes Sum = {0}", max);
            }
            else
            {
                sum -= max;
                Console.WriteLine("No Diff = {0}", Math.Abs(sum - max));
            }
        }
    }
}
