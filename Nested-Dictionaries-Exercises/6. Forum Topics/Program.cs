using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> topics = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input!= "filter")
            {
                string[] curentTopic = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!topics.ContainsKey(curentTopic[0]))
                {
                    topics[curentTopic[0]] = new List<string>();
                }
                string[] newTopic = curentTopic[1].Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < newTopic.Length; i++)
                {
                    if (!topics[curentTopic[0]].Contains(newTopic[i]))
                    {
                        topics[curentTopic[0]].Add(newTopic[i]);
                    }
                }
                input = Console.ReadLine();
            }
            string[] filter=Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in topics)
            {
                int token = 0;
                for (int i = 0; i < filter.Length; i++)
                {
                    if (item.Value.Contains(filter[i]))
                    {
                        token++;
                    }
                }
                if (token== filter.Length)
                {
                    Console.WriteLine("{0} | #{1}", item.Key, string.Join(", #", item.Value));
                }
            }
     }
    }
}
