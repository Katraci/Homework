using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string, long> > cityVehicle = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input!= "ready")
            {
                string[] inputCityVehicle= input.Split(':').ToArray();
                string city = inputCityVehicle[0];
                if (!cityVehicle.ContainsKey(city))
                {
                    cityVehicle[city] = new Dictionary<string, long>();
                }
                string[] vehicleCapacity = inputCityVehicle[1].Split(',').ToArray();
                foreach (string item in vehicleCapacity)
                {
                    string[] token = item.Split('-').ToArray();
                    string vehicle = token[0];
                    long capacity = long.Parse(token[1]);
                    cityVehicle[city][vehicle] = capacity;
                }
                 input = Console.ReadLine();
            }
            input = Console.ReadLine();
            Dictionary<string, long> cityCapacity = new Dictionary<string, long>();
            foreach (var item in cityVehicle)
            {
                cityCapacity[item.Key] = SumCapacity(item.Value);
            }
            while (input!= "travel time!")
            {
                string[] cityComers = input.Split(' ').ToArray();
                string city = cityComers[0];
                long group = long.Parse(cityComers[1]);
                if (cityCapacity[city] >= group)
                {
                    Console.WriteLine($"{city} -> all {group} accommodated");
                }
                else
                {
                    Console.WriteLine($"{city} -> all except {group - cityCapacity[city]} accommodated");
                }
                input = Console.ReadLine();
            }
        }

        static long SumCapacity(Dictionary<string, long> n)
        {
            long sum = 0;
            foreach (var item in n)
            {
                sum += item.Value;
            }
            return sum;
        }
    }
}
