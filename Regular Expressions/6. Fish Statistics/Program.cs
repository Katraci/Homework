using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fish_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex filter = new Regex(@"(>*)(<)(\(+)([x\-'])(>)");
            Regex tailFilter = new Regex(@"(^>*)");
            Regex bodyFilter = new Regex(@"(\(+)");
            Regex statusesFilter = new Regex(@"([x\-'])");
            MatchCollection fish = filter.Matches(input);
            if (fish.Count==0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                List<Match> listFishes= fish.Cast<Match>().ToList();
                int counter = 1;
                foreach (Match match in listFishes)
                {
                    Console.WriteLine($"Fish {counter}: {match.Value}");
                    Match tail = tailFilter.Match(match.Value);
                    if (tail.Length==0)
                    {
                        Console.WriteLine("  Tail type: None");
                    }
                    else
                    {
                        if (tail.Length==1)
                        {
                            Console.WriteLine("  Tail type: Short (2 cm)");
                        }
                        else
                        {
                            if (tail.Length<=5)
                            {
                                Console.WriteLine($"  Tail type: Medium ({tail.Length*2} cm)");
                            }
                            else
                            {
                                Console.WriteLine($"  Tail type: Long ({tail.Length * 2} cm)");
                            }
                        }                       
                    }
                    Match body = bodyFilter.Match(match.Value);
                    if (body.Length<=5)
                    {
                        Console.WriteLine($"  Body type: Short ({body.Length*2} cm)");
                    }
                    else
                    {
                        if (body.Length<=10)
                        {
                            Console.WriteLine($"  Body type: Medium ({body.Length * 2} cm)");
                        }
                        else
                        {
                            Console.WriteLine($"  Body type: Long ({body.Length * 2} cm)");
                        }
                    }
                    Match statuses= statusesFilter.Match(match.Value);
                    switch (statuses.Value.ToString())
                    {
                        case "'":Console.WriteLine("  Status: Awake");break;
                        case "-": Console.WriteLine("  Status: Asleep"); break;
                        case "x": Console.WriteLine("  Status: Dead"); break;
                        default:
                            break;
                    }
                    counter++;
                }
            }
        }
    }
}
