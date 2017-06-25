using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            List<string> newNames = new List<string>(names.Capacity);
            for (int i = 1; i < names.Capacity; i+=2)
            {
                newNames.Add(names[i]);
            }
            Console.WriteLine(String.Join("",newNames));
        }
    }
}
