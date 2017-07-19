using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] filter= Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            char[] word = numbers.Where(n => n >= 65 && n <= 90).Skip(filter[0]).Take(filter[1]).Select(n=>(char)n).ToArray();
            Console.WriteLine(string.Join("", word));
        }
    }
}
