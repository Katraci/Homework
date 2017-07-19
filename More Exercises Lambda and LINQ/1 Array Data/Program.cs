using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nummbers = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();
            string input = Console.ReadLine();
            nummbers = nummbers.Where(n => n >= nummbers.Average()).OrderBy(n=>n).ToArray();
            switch (input)
            {
                case "Min":Console.WriteLine(nummbers.Min());break;
                case "Max": Console.WriteLine(nummbers.Max()); break;
                case "All":Console.WriteLine(string.Join(" ", nummbers));break;
                default:
                    break;
            }
        }
    }
}
