using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="end")
            {
                string firstHalf = input.Substring(0, input.Length / 2);
                string secondHalf= input.Substring(input.Length-firstHalf.Length, firstHalf.Length);

                    while (firstHalf != secondHalf)
                    {
                        firstHalf = firstHalf.Remove(firstHalf.Length - 1, 1);
                        secondHalf = secondHalf.Remove(0, 1);
                    }

                    if (firstHalf.Length!=0)
                    {
                        input = input.Remove(input.Length - firstHalf.Length, firstHalf.Length).Remove(0, firstHalf.Length);
                        Console.WriteLine(input+firstHalf+input);
                    }
                input = Console.ReadLine();
            }
        }
    }
}
