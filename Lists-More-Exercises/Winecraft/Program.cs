using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rounds = int.Parse(Console.ReadLine());
            while (grapes.Count>rounds)
            {
                for (int i = 1; i < rounds; i++)
                {
                    for (int j = 0; j < grapes.Count; j++)
                    {
                        
                    }
                }
            }
        }
    }
}
