using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_SoftUni_Beer_Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            var scoreBord = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "stop the game")
            {
                string[] arr = input.Split('|').ToArray();
                string name = arr[0];
                string team = arr[1];
                int score = int.Parse(arr[2]);
                if (!scoreBord.ContainsKey(team))
                {
                    scoreBord[team] = new Dictionary<string, int>();
                }
                if (!scoreBord[team].ContainsKey(name)&& scoreBord[team].Count < 3)
                {
                    scoreBord[team][name] = score;
                }

                    

                input = Console.ReadLine();
            }
            var sorted = scoreBord
                .Where(kvp => kvp.Value.Count == 3)
                .OrderByDescending(kvp => kvp.Value.Sum(n => n.Value));
            int place = 0;
            foreach (var item in sorted)
            {
                string team = item.Key;
                var players = item.Value.OrderByDescending(kvp=>kvp.Value);
                place++;
                Console.WriteLine($"{place}. {team}; Players:");
                foreach (var player in players)
                {
                    Console.WriteLine($"###{player.Key}: {player.Value}");
                }
            }
        }
    }
}
