using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> chopTree = new Dictionary<string, List<decimal>>();
            string input = Console.ReadLine();
            while (input!= "chop chop")
            {
                string[] curentInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!chopTree.ContainsKey(curentInput[0]))
                {
                    chopTree[curentInput[0]] = new List<decimal>();
                }
                chopTree[curentInput[0]].Add(decimal.Parse(curentInput[1]));
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            decimal needMaterial = decimal.Parse(Console.ReadLine());
                decimal picePerMetar = Math.Round(chopTree.Sum(kvp => kvp.Value.Sum()) / (chopTree.Sum(kvp=> kvp.Value.Count)), 2);
                List<decimal> usedTree = chopTree[input].Where(d => d >= needMaterial).ToList();
                decimal usedPrice = Math.Round(usedTree.Sum() * picePerMetar, 2);
                decimal unusedPrice= Math.Round((chopTree.Sum(kvp=>kvp.Value.Sum())- usedTree.Sum())* picePerMetar*(decimal)0.25 ,2);
                Console.WriteLine($"Price per meter: ${picePerMetar:F2}");
                Console.WriteLine($"Used logs price: ${usedPrice:F2}");
                Console.WriteLine($"Unused logs price: ${unusedPrice:F2}");
                Console.WriteLine($"CottageScraper subtotal: ${Math.Round(unusedPrice +usedPrice,2):F2}");
        }
       
    }
}
