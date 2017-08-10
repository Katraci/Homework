using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Booming_Cannon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> targets = new List<string>();
            int[] seekAndDestroy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string bathleField = Console.ReadLine();
            int seek = seekAndDestroy[0];
            int destroy = seekAndDestroy[1];
            string cannon = @"((?<=\\<<<)(?<field>.+?))(?=\\<<<|$)";
            if (Regex.IsMatch(bathleField,cannon))
            {
                MatchCollection fields = Regex.Matches(bathleField, cannon);
                if (fields.Count>0)
                {
                    foreach (Match match in fields)
                    {
                        if (match.Value.Length > 0)
                        {
                            string field = match.Value.ToString().Replace(@"\<<<", "");
                            if (field.Length > seek + destroy)
                            {
                                field = field.Substring(seek, destroy);
                                targets.Add(field);
                            }
                            else
                            {
                                if (field.Length>=seek)
                                {
                                    field = field.Substring(seek);
                                    if (field != string.Empty)
                                    {
                                        targets.Add(field);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(@"/\", targets));
        }
    }
}
