using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            List<string> sortedWords = new List<string>();
            List<int> count = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                SortWords(words[i], sortedWords, count);
            }
            while (true)
            {
                bool counter = true;
                for (int i = 0; i < count.Count-1; i++)
                {
                    if (count[i]<count[i+1])
                    {
                        int temp = count[i];
                        count[i] = count[i + 1];
                        count[i + 1] = temp;
                        string temp2 = sortedWords[i];
                        sortedWords[i] = sortedWords[i + 1];
                        sortedWords[i + 1] = temp2;
                        counter = false;
                    }
                }
                if (counter)
                {
                    break;
                }
            }
            for (int i = 0; i < sortedWords.Count; i++)
            {
                Console.WriteLine($"{sortedWords[i]} -> {count[i]} times ({100*((double)count[i]/ (double)words.Length):F2}%)");
            }
        }

        static void SortWords(string v, List<string> sortedWords, List<int> count)
        {
            bool counter = true;
            for (int i = 0; i < sortedWords.Count; i++)
            {
                if (sortedWords[i]==v)
                {
                    count[i]++;
                    counter = false;
                    break;
                }
            }
            if (counter)
            {
                sortedWords.Add(v);
                count.Add(1);
            }
        }
    }
}
