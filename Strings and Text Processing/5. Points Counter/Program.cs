using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Points_Counter
{
    class Program
    {
        class Player
        {
            public string UserName{ get; set; }
            public int Score { get; set; }
        }

        static void Main(string[] args)
        {
            Dictionary<string, List<Player>> scoreBoard = new Dictionary<string, List<Player>>();
            string input = Console.ReadLine();
            while (input!= "Result")
            {
                input = input.Replace("@", "").Replace("%", "").Replace("$", "").Replace("*", "");
                string[] curentInput = input.Split('|');
                string team = "";
                string name = "";
                if (CheckForTeam(curentInput[0]))
                {
                    team = curentInput[0];
                    name =curentInput[1];
                }
                else
                {
                    team = curentInput[1];
                    name = curentInput[0];
                }
                int points = int.Parse(curentInput[2]);
                if (!scoreBoard.ContainsKey(team))
                {
                    scoreBoard[team] = new List<Player>();
                }
                if (CheckName(scoreBoard[team],name))
                {
                    scoreBoard[team] = scoreBoard[team].Where(n => n.UserName != name).ToList();
                }
                scoreBoard[team].Add(CreatPlayer(name, points));
                input = Console.ReadLine();
            }
            var sorted = scoreBoard.OrderByDescending(n => n.Value.Sum(v => v.Score));
            foreach (var item in sorted)
            {
                string teamName = item.Key;
                List<Player> gamers = item.Value;
                int sum = gamers.Sum(n => n.Score);
                Player topPlayer = gamers.OrderByDescending(n => n.Score).First();
                Console.WriteLine($"{teamName} => {sum}");
                Console.WriteLine($"Most points scored by {topPlayer.UserName}");
            }

        }

        private static bool CheckForTeam(string v)
        {
            foreach (char symbol in v)
            {
                if (char.IsLower(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        private static Player CreatPlayer(string name, int points)
        {
            Player result = new Player
            {
                UserName = name,
                Score = points
            };
            return result;
        }

        static bool CheckName(List<Player> list, string name)
        {
            bool result = false;
            foreach (var item in list)
            {
                if (item.UserName==name)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
