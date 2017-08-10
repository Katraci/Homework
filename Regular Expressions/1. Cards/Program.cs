using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            Regex filter = new Regex(@"((?<=[SHDC]|^)[2-9]|10|[JQKA])([SHDC])");
            MatchCollection cards= filter.Matches(input);
            List<Match> cardCollection= cards.Cast<Match>().ToList();
            Console.WriteLine(string.Join(", ", cardCollection));
        }
    }
}
