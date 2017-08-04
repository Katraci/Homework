using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string delimiter = Console.ReadLine();
            string[] cuted = input.Split(new string[] { delimiter }, StringSplitOptions.None).ToArray();
            Console.WriteLine("[" + String.Join(", ", cuted)+"]");
        }
    }
}
