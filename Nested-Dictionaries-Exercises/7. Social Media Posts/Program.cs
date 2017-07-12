    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Social_Media_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> likesDislikes = new Dictionary<string, List<int>>();
            Dictionary<string, Dictionary<string, string>> coments = new Dictionary<string, Dictionary<string, string>>();
            string input = Console.ReadLine();
            while (input!= "drop the media")
            {
                string[] curentOperacion = input.Split(' ').ToArray();
                string operacion = curentOperacion[0];
                string postName= curentOperacion[1];
                if (operacion== "post")
                {
                    likesDislikes[postName] = new List<int> { 0, 0 };
                }
                if (operacion== "like")
                {
                    likesDislikes[postName][0]++;
                }
                if (operacion== "dislike")
                {
                    likesDislikes[postName][1]++;
                }
                if (operacion== "comment")
                {
                    if (!coments.ContainsKey(postName))
                    {
                        coments[postName] = new Dictionary<string, string>();
                    }
                    string comentAuthor= curentOperacion[2];
                    string coment = curentOperacion[3];
                    if (curentOperacion.Length>4)
                    {
                        for (int i = 4; i < curentOperacion.Length; i++)
                        {
                            coment += " "+curentOperacion[i];
                        }
                    }
                    coments[postName][comentAuthor] = coment;
                }
                input = Console.ReadLine();
            }
            foreach (var item in likesDislikes)
            {
                Console.WriteLine($"Post: {item.Key} | Likes: {item.Value[0]} | Dislikes: {item.Value[1]}");
                Console.WriteLine("Comments:");
                if (!coments.ContainsKey(item.Key))
                {
                    Console.WriteLine("None");
                }
                else
                {
                        foreach (var coment in coments[item.Key])
                        {
                            Console.WriteLine($"*  {coment.Key}: {coment.Value}");
                        }
                }
            }
        }
    }
}
