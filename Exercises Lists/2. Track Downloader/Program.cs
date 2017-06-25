using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blackList = Console.ReadLine().Split(' ').ToList();
            List<string> tracs = new List<string>();
            string curentTrack = "";
            while (curentTrack != "end")
            {
                bool token = true;
                curentTrack = Console.ReadLine();
                foreach (string item in blackList)
                {
                    if (curentTrack.Contains(item))
                    {
                        token = false;
                    }
                }
                if (token&& curentTrack!="end")
                {
                    tracs.Add(curentTrack);
                }
            }
            tracs.Sort();
            foreach (string item in tracs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
