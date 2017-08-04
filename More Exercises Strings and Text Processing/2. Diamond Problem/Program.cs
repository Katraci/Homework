using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Diamond_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> diamonds = new List<int>();
            FindDiamons(input, diamonds);
            if (diamonds.Count==0)
            {
                Console.WriteLine("Better luck next time");
            }
            else
            {
                foreach (var diamond in diamonds)
                {
                    Console.WriteLine($"Found {diamond} carat diamond");
                }
            }
        }

        private static void FindDiamons(string input, List<int> diamonds)
        {
            int diamondStart = -1;
            int diamondEnd = -1;
            do
            {
                diamondStart = input.IndexOf("<", diamondStart+1);
                if (diamondStart != -1)
                {
                    diamondEnd= input.IndexOf(">", diamondStart);
                    if (diamondEnd!=-1&&diamondEnd>diamondStart)
                    {
                        string diamond = input.Remove(diamondEnd, input.Length - diamondEnd).Remove(0, diamondStart + 1);
                        int newDiamond = CreatDiamond(diamond);
                        if (newDiamond>0)
                        {
                            diamonds.Add(newDiamond);
                        }
                        
                    }
                }
            } while (diamondStart!=-1);
        }

        private static int CreatDiamond(string diamond)
        {
            int result = 0;
            char[] numbers = diamond.ToCharArray().Where(c => char.IsDigit(c)).ToArray();
            foreach (var number in numbers)
            {
                result += int.Parse(number.ToString());
            }
            return result;
        }
    }
}
