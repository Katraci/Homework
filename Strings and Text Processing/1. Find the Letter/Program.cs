using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Find_the_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string[] info = Console.ReadLine().Split(' ');
            string serch = info[0];
            int number = int.Parse(info[1]);
            int index = -1;
            do
            {
                number--; ;
                index = words.IndexOf(serch, index + 1);
            }
            while (number>0&&index!=-1);

            if (index!=-1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
