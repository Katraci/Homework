using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> siteList = new List<Website>();
            string input = Console.ReadLine();
            while (input!= "end")
            {
                string[] curentInput = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                siteList.Add(AddNewSite(curentInput));
                input = Console.ReadLine();
            }
            PrintWeb(siteList);
        }

        private static void PrintWeb(List<Website> siteList)
        {
            foreach (var item in siteList)
            {
                Console.Write($"https://www.{item.Host}.{item.Domain}");
                if (item.Query.Count==0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("/query?="+String.Join("&",item.Query));
                }
            }
        }

        private static Website AddNewSite(string[] curentInput)
        {
            Website result = new Website();
            result.Host = curentInput[0];
            result.Domain = curentInput[1];
                if (curentInput.Length==2)
                {
                    result.Query = new List<string>();
                }
            else
            {
                result.Query = curentInput[2].Split(',').Select(q => "[" + q + "]").ToList();
            }
            return result;
        }

        class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Query { get; set; }
        }
    }
}
