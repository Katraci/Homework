using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace _8_Commits
{
    class Program
    {
        class Commit {
            public string Hash { get; set; }
            public string Message { get; set; }
            public int Additions { get; set; }
            public int Deletions { get; set; }

            public Commit(string h,string m ,int a, int d)
            {
                this.Hash = h;
                this.Message = m;
                this.Additions = a;
                this.Deletions = d;
            }
            public override string ToString()
            {
                string format = String.Format($"    commit {this.Hash}: {this.Message} ({this.Additions} additions, {this.Deletions} deletions)");
                return format;
            }

        }
        static void Main(string[] args)
        {
            string filter = @"(^https:\/\/github\.com\/)(?<username>[a-zA-Z0-9-]+)\/(?<repo>[a-zA-Z-_]+)(\/commit\/)(?<commitHash>[a-f0-9]{40}),(?<message>[^\n]+),(?<additions>\d+),(?<deletions>\d+)$";
            Regex toFilter = new Regex(filter);
            var listOfUsers = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();
            string input = Console.ReadLine();
            while (input!= "git push")
            {
                if (toFilter.IsMatch(input))
                {
                    Match chekedInput = toFilter.Match(input);
                    string name = chekedInput.Groups["username"].Value;
                    string repo= chekedInput.Groups["repo"].Value;
                    string hash= chekedInput.Groups["commitHash"].Value;
                    string message= chekedInput.Groups["message"].Value;
                    int additions= int.Parse(chekedInput.Groups["additions"].Value);
                    int deletions = int.Parse(chekedInput.Groups["deletions"].Value);
                    Commit curent = new Commit(hash, message, additions, deletions);
                    if (!listOfUsers.ContainsKey(name))
                    {
                        listOfUsers[name] = new SortedDictionary<string, List<Commit>>();
                    }
                    if (!listOfUsers[name].ContainsKey(repo))
                    {
                        listOfUsers[name][repo] = new List<Commit>();
                    }
                    listOfUsers[name][repo].Add(curent);
                }
                input = Console.ReadLine();
            }
            foreach (var item in listOfUsers)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var part in item.Value)
                {
                    int totalAdditions = part.Value.Sum(c => c.Additions);
                    int totalDeletions = part.Value.Sum(c => c.Deletions);
                    Console.WriteLine($"  {part.Key}:");
                    foreach (var piece in part.Value)
                    {
                        Console.WriteLine(piece);
                    }
                    Console.WriteLine($"Total: {totalAdditions} additions, {totalDeletions} deletions");
                }
            }
        }
    }
}
