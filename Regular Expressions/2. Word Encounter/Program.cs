using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            string filter = Console.ReadLine();
            string input = Console.ReadLine();
            string chek = @"^[A-Z].+[.!?]$";
            Regex regex = new Regex(chek);
            while (input!="end")
            {
                if (regex.IsMatch(input))
                {
                    char[] filtered = filter.ToCharArray();
                    char leter = filtered[0];
                    int number = int.Parse(filtered[1].ToString());
                    string secondCheck = @"\w+";
                    Regex secondRegex = new Regex(@secondCheck);
                    MatchCollection listResult = secondRegex.Matches(input);
                    foreach (Match match in listResult)
                    {
                        if (match.Value.Count(f=>f==leter)>=number)
                        {
                            result.Add(match.Value);
                        }
                    }
                
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
